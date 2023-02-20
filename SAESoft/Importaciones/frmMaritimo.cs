
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Data;
using System.Diagnostics;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.DatosServer;
using static SAESoft.Utilitarios.Validaciones;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SAESoft.Importaciones
{
    public partial class frmMaritimo : Form
    {
        private Boolean esNuevo = false;
        private List<Importacion>? rs = new List<Importacion>();
        private int CurrentIndex = 0;
        DataTable dt = new DataTable();

        List<string> listFiles = new List<string>();
        string path = PATH_Import;
        public frmMaritimo()
        {
            InitializeComponent();
        }

        private void cargarArchivos(string opcion)
        {
            listFiles.Clear();
            listView1.Items.Clear();
            imageList1.Images.Clear();
            path = PATH_Import + opcion;
            if (Directory.Exists(path))
            {
                fileSystemWatcher1.Path = path;
                foreach (string file in Directory.GetFiles(path).Where(f => (new FileInfo(f).Attributes & FileAttributes.Hidden) == 0))
                {
                    imageList1.Images.Add(Icon.ExtractAssociatedIcon(file));
                    FileInfo fi = new FileInfo(file);
                    listFiles.Add(fi.FullName);
                    listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                }
            }
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("Fase").DataType = Type.GetType("System.String");
            dt.Columns.Add("Responsable").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha").DataType = Type.GetType("System.DateTime");
            dgvHistorial.DataSource = dt;
            dgvHistorial.Columns[0].Width = 250;
            dgvHistorial.Columns[1].Width = 274;
            dgvHistorial.Columns[2].Width = 150;
            dgvHistorial.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHistorial.ClearSelection();
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string selectedFile = listFiles[listView1.SelectedIndices[0]];
            if (File.Exists(selectedFile))
            {
                new Process { StartInfo = new ProcessStartInfo(selectedFile) { UseShellExecute = true } }.Start();
            }

        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            cargarArchivos(@"\" + rs[CurrentIndex].Codigo);
        }

        private void tsbUpload_Click(object sender, EventArgs e)
        {
            var resp = openFileDialog1.ShowDialog();
            if (resp == DialogResult.OK)
            {
                try
                {
                    path = PATH_Import + @"\" + rs[CurrentIndex].Codigo.ToString();
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    fileSystemWatcher1.Path = path;
                    File.Copy(openFileDialog1.FileName, path + @"\" + openFileDialog1.SafeFileName);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmMaritimo_Shown(object sender, EventArgs e)
        {
            llenarCombos();
            estructuraGrid();
        }

        private void llenarCombos()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                cboShipper.DataSource = db.Shippers.Where(s => s.Maritimo).OrderBy(s => s.Nombre).ToList();
                cboShipper.DisplayMember = "Nombre";
                cboShipper.ValueMember = "IdShipper";
                cboAduana.DataSource = db.Aduanas.Where(a => a.Via == 'M').OrderBy(a => a.Nombre).ToList();
                cboAduana.DisplayMember = "Nombre";
                cboAduana.ValueMember = "IdAduana";
                cboTerminal.DataSource = db.Terminales.Where(t => t.Via == 'M').OrderBy(t => t.Nombre).ToList();
                cboTerminal.DisplayMember = "Nombre";
                cboTerminal.ValueMember = "IdTerminal";
                clbRevisiones.DataSource = db.Revisiones.OrderBy(r => r.Descripcion).ToList();
                clbRevisiones.DisplayMember = "Descripcion";
                clbRevisiones.ValueMember = "IdRevision";
                cboAgente.DataSource = db.Agentes.Where(a => a.Activo).ToList();
                cboAgente.DisplayMember = "NombreCompleto";
                cboAgente.ValueMember = "IdAgente";
            }
            llenarNombres(cboNaviera, "EMPRESA");
            llenarNombres(cboForwarder, "FORWARDER", true);
            llenarNombres(cboDestino, "DESTINO", true);
        }



        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            dt.Rows.Clear();
            cboShipper.Focus();
        }

        private void frmMaritimo_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "MARITIMO");
            llenarMenu();
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago" }, true, toolStrip1, "MARITIMO");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago" }, true, toolStrip1, "MARITIMO");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago", }, false, toolStrip1, "MARITIMO");
                limpiarFormulario(this);
                dt.Rows.Clear();
            }
            habilitarFormulario(this, false);
        }

        private void despliegaDatos()
        {
            lsbBL.DataSource = null;
            lsbEquipos.DataSource = null;
            for (int i = 0; i < clbRevisiones.Items.Count; i++)
            {
                Revision item = (Revision)clbRevisiones.Items[i];
                var resp = rs[CurrentIndex].Revisiones.Where(r => r.IdRevision == item.IdRevision).Count() > 0;
                clbRevisiones.SetItemChecked(i, resp);
            }
            txtId.Text = rs?[CurrentIndex].IdImport.ToString();
            chkConsolidado.Checked = rs[CurrentIndex].Consolidado;
            cboShipper.SelectedValue = rs[CurrentIndex].IdShipper;
            cboNaviera.SelectedValue = rs[CurrentIndex].IdNaviera;
            if (rs[CurrentIndex].IdDestino != null)
                cboDestino.SelectedValue = rs[CurrentIndex].IdDestino;
            else
                cboDestino.SelectedIndex = 0;
            if (rs[CurrentIndex].IdForwarder != null)
                cboForwarder.SelectedValue = rs[CurrentIndex].IdForwarder;
            else
                cboForwarder.SelectedIndex = 0;
            dtpETA.Value = rs[CurrentIndex].ETA;
            cboTerminal.SelectedValue = rs[CurrentIndex].IdTerminal;
            cboAduana.SelectedValue = rs[CurrentIndex].IdAduana;
            cboAgente.SelectedValue = rs[CurrentIndex].IdAgente;
            txtTiempoLibre.Text = rs[CurrentIndex].TiempoLibre.ToString();
            txtValorExtra.Text = rs[CurrentIndex].ValorDiaExtraTL.ToString("F", CultureInfo.CreateSpecificCulture("es-GT"));
            txtDemora.Text = rs[CurrentIndex].Demora.ToString();
            txtValorExtra2.Text = rs[CurrentIndex].ValorDiaExtraD.ToString("F", CultureInfo.CreateSpecificCulture("es-GT"));
            chkDocOriginales.Checked = rs[CurrentIndex].DocOriginales;
            lsbBL.DataSource = rs[CurrentIndex].BL.ToList();
            lsbBL.ValueMember = "IdBL";
            lsbBL.DisplayMember = "Numero";
            lsbBL.SelectedIndex = -1;
            lsbEquipos.DataSource = rs[CurrentIndex].Contenedores.ToList();
            lsbEquipos.ValueMember = "IdContenedor";
            lsbEquipos.DisplayMember = "Numero";
            lsbEquipos.SelectedIndex = -1;
            cargarArchivos(@"\" + rs[CurrentIndex].Codigo);
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
            checkProceso(rs[CurrentIndex].ImportStatus.orden);
            dt.Clear();
            DataRow row;
            foreach (var h in rs[CurrentIndex].ImportHistorial.OrderByDescending(h => h.FechaCreacion))
            {
                row = dt.NewRow();
                row[0] = h.ImportStatus.Descripcion;
                row[1] = NombreUsuario(h.IdUsuarioCreacion);
                row[2] = h.FechaCreacion.Date;
                dt.Rows.Add(row);
            }

            if (rs[CurrentIndex].IdImportStatus == StatusFinalMaritimo)
                CambiarEstadoBotones(new[] { "tsbModificar" }, false, toolStrip1, "MARITIMO");
            else
                CambiarEstadoBotones(new[] { "tsbModificar" }, true, toolStrip1, "MARITIMO");

            if (rs[CurrentIndex].Contenedores.Any(c => c.IdPago != null))
                CambiarEstadoBotones(new[] { "tsbPago" }, false, toolStrip1, "MARITIMO");
            else
                CambiarEstadoBotones(new[] { "tsbPago" }, true, toolStrip1, "MARITIMO");

            if (rs[CurrentIndex].IdImportStatus < EntregaDigitadorMaritimo || hasRole(2))
                CambiarEstadoBotones(new[] { "tsddbSwitchUser" }, false, toolStrip1, "MARITIMO");
            else
                CambiarEstadoBotones(new[] { "tsddbSwitchUser" }, true, toolStrip1, "MARITIMO");
        }

        private void checkProceso(uint ord)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                var im = db.ImportStatus.Where(i => i.Via == 'M').OrderBy(i => i.orden).ToList();
                int i = 0, j = 0;
                foreach (var item in im)
                {
                    if (item.orden <= ord)
                    {
                        tsddbProceso.DropDownItems[i].Image = Properties.Resources.check2;
                        tsddbProceso.DropDownItems[i].Enabled = false;
                        j++;
                    }
                    else if (item.orden != ord + 1)
                    {
                        tsddbProceso.DropDownItems[i].Enabled = false;
                        tsddbProceso.DropDownItems[i].Image = null;
                    }
                    else
                    {
                        tsddbProceso.DropDownItems[i].Enabled = true;
                        tsddbProceso.DropDownItems[i].Image = null;
                    }
                    i++;
                }
                if (j == im.Count())
                {
                    tsddbProceso.Enabled = false;
                }
                else
                {
                    tsddbProceso.Enabled = true;
                }
            }
        }
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && hasPermission("ELIMINAR.MARITIMO"))
            {
                var resp = MessageBox.Show("¿Desea eliminar este archivo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    string selectedFile = listFiles[listView1.SelectedIndices[0]];
                    try
                    {
                        File.Delete(selectedFile);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No es posible borrar el archivo,\r\n" +
                            "asegurese que nadie lo tenga en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.Nchecked;
            else
                chk.Image = Properties.Resources.Nunchecked;
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            cargarArchivos(@"\" + rs[CurrentIndex].Codigo);
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                Importacion im = new Importacion()
                                {
                                    Codigo = Guid.NewGuid(),
                                    IdShipper = Convert.ToInt32(cboShipper.SelectedValue),
                                    Via = 'M',
                                    IdNaviera = Convert.ToInt32(cboNaviera.SelectedValue),
                                    ETA = dtpETA.Value,
                                    IdTerminal = Convert.ToInt32(cboTerminal.SelectedValue),
                                    IdAduana = Convert.ToInt32(cboAduana.SelectedValue),
                                    Consolidado = chkConsolidado.Checked,
                                    DocOriginales = chkDocOriginales.Checked,
                                    IdAgente = Convert.ToInt32(cboAgente.SelectedValue),
                                    TiempoLibre = Convert.ToInt32(txtTiempoLibre.Text),
                                    Demora = Convert.ToInt32(txtDemora.Text),
                                    ValorDiaExtraTL = Convert.ToDecimal(txtValorExtra.Text),
                                    ValorDiaExtraD = Convert.ToDecimal(txtValorExtra2.Text),
                                    IdImportStatus = db.ImportStatus.FirstOrDefault(i => i.Via == 'M' && i.orden == 1).IdImportStatus,
                                    FechaCreacion = DatosServer.FechaServer(),
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                };
                                if (cboDestino.SelectedIndex != 0)
                                    im.IdDestino = Convert.ToInt32(cboDestino.SelectedValue);
                                if (cboForwarder.SelectedIndex != 0)
                                    im.IdForwarder = Convert.ToInt32(cboForwarder.SelectedValue);
                                db.Importaciones.Add(im);
                                db.SaveChanges();
                                rs.Add(im);
                                CurrentIndex = rs.Count - 1;
                                List<Revision> rev = new List<Revision>();
                                foreach (Revision item in clbRevisiones.CheckedItems)
                                {
                                    rev.Add(item);
                                }
                                rs[CurrentIndex].Revisiones = rev;
                                AgregarRevisiones(db, im.IdImport, rev);
                                List<BL> _bl = new List<BL>();
                                List<Contenedor> _con = new List<Contenedor>();
                                foreach (var item in lsbBL.Items)
                                {
                                    _bl.Add(new BL { Numero = item.ToString(), IdImportacion = im.IdImport, FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion });
                                };
                                foreach (var item in lsbEquipos.Items)
                                {
                                    _con.Add(new Contenedor { Numero = item.ToString(), IdImportacion = im.IdImport, FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion });
                                }
                                db.BL.AddRange(_bl);
                                db.Contenedores.AddRange(_con);
                                rs[CurrentIndex].Contenedores = _con;
                                rs[CurrentIndex].BL = _bl;
                                db.SaveChanges();
                                var status = db.ImportStatus.Where(s => s.Via == 'M').OrderBy(s => s.orden).FirstOrDefault();
                                ImportHistorial ih = new ImportHistorial { IdImport = im.IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion };
                                db.ImportHistorial.Add(ih);
                                rs[CurrentIndex].ImportHistorial.Add(ih);
                                db.SaveChanges();
                                transaction.Commit();
                                CurrentIndex = rs.Count - 1;
                                despliegaDatos();
                                MessageBox.Show("Importación Grabada Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                if (ex.InnerException != null)
                                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else
                {
                    Importacion temp = rs[CurrentIndex];
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                                ImportHistorial ih = null;
                                if (rs[CurrentIndex].ETA != dtpETA.Value)
                                {
                                    var status = db.ImportStatus.Where(s => s.IdImportStatus == CambioETA).OrderBy(s => s.orden).FirstOrDefault();
                                    ih = new ImportHistorial { IdImport = temp.IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                                    db.ImportHistorial.Add(ih);
                                    db.SaveChanges();
                                }
                                if (rs[CurrentIndex].IdDestino != Convert.ToInt32(cboDestino.SelectedValue) && rs[CurrentIndex].IdDestino != null)
                                {
                                    var status = db.ImportStatus.Where(s => s.IdImportStatus == CambioDestino).OrderBy(s => s.orden).FirstOrDefault();
                                    ih = new ImportHistorial { IdImport = temp.IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                                    db.ImportHistorial.Add(ih);
                                    db.SaveChanges();
                                }
                                if (cboDestino.SelectedIndex != 0)
                                    rs[CurrentIndex].IdDestino = Convert.ToInt32(cboDestino.SelectedValue);
                                else if (rs[CurrentIndex].IdDestino != null)
                                    throw new Exception("No se puede cambiar el destino.");
                                rs[CurrentIndex].ETA = dtpETA.Value;
                                rs[CurrentIndex].DocOriginales = chkDocOriginales.Checked;
                                rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                                rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                                db.Importaciones.Update(rs[CurrentIndex]);
                                db.SaveChanges();
                                if (clbRevisiones.Enabled)
                                {
                                    foreach (Revision item in clbRevisiones.CheckedItems)
                                    {
                                        rs[CurrentIndex].Revisiones.Add(item);
                                    }
                                }
                                db.SaveChanges();
                                transaction.Commit();
                                if (ih != null)
                                    rs[CurrentIndex].ImportHistorial.Add(ih);
                                despliegaDatos();
                                MessageBox.Show("Importación Modificada Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                if (ex.InnerException != null)
                                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rs[CurrentIndex] = temp;
                                return;
                            }
                        }
                    }
                }
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago"}, true, toolStrip1, "MARITIMO");
                habilitarFormulario(this, false);
            }
        }

        private void AgregarRevisiones(SAESoftContext db, int id, List<Revision> rev)
        {
            var im = db.Importaciones.Include(i => i.Revisiones).FirstOrDefault(i => i.IdImport == id);
            im.Revisiones = rev;
            db.SaveChanges();
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (cboShipper.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboShipper, "No puede estar vacío.");
                cboShipper.Focus();
                return false;
            }
            if (cboNaviera.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboNaviera, "No puede estar vacío.");
                cboNaviera.Focus();
                return false;
            }
            if (cboTerminal.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboTerminal, "No puede estar vacío.");
                cboTerminal.Focus();
                return false;
            }
            if (cboAduana.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboAduana, "No puede estar vacío.");
                cboAduana.Focus();
                return false;
            }
            if (lsbBL.Items.Count == 0)
            {
                errorProvider1.SetError(grpBL, "No puede estar vacío.");
                txtBL.Focus();
                return false;
            }
            if (lsbEquipos.Items.Count == 0)
            {
                errorProvider1.SetError(grpEquipos, "No puede estar vacío.");
                txtEquipos.Focus();
                return false;
            }
            if (txtTiempoLibre.Text == "")
            {
                errorProvider1.SetError(txtTiempoLibre, "No puede estar vacío.");
                txtTiempoLibre.Focus();
                return false;
            }
            if (txtValorExtra.Text == "")
            {
                errorProvider1.SetError(txtValorExtra, "No puede estar vacío.");
                txtValorExtra.Focus();
                return false;
            }
            if (txtDemora.Text == "")
            {
                errorProvider1.SetError(txtDemora, "No puede estar vacío.");
                txtDemora.Focus();
                return false;
            }
            if (txtValorExtra2.Text == "")
            {
                errorProvider1.SetError(txtValorExtra2, "No puede estar vacío.");
                txtValorExtra2.Focus();
                return false;
            }
            return true;
        }

        private void lsbBL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && esNuevo)
            {
                lsbBL.Items.RemoveAt(lsbBL.SelectedIndex);
            }
        }


        private void txtBL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lsbBL.Items.Add(txtBL.Text);
                txtBL.Clear();
            }
        }

        private void lsbEquipos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && esNuevo)
            {
                lsbEquipos.Items.RemoveAt(lsbEquipos.SelectedIndex);
            }
        }

        private void txtEquipos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lsbEquipos.Items.Add(txtEquipos.Text);
                txtEquipos.Clear();
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            frmBuscarImport buscar = new frmBuscarImport();
            var resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    var queryable = db.Importaciones.Include(r => r.Revisiones)
                                                    .Include(r => r.BL)
                                                    .Include(r => r.Contenedores)
                                                    .ThenInclude(c => c.Pago)
                                                    .Include(r => r.ImportStatus)
                                                    .Include(r => r.ImportHistorial)
                                                    .ThenInclude(rh => rh.ImportStatus)
                                                    .Where(b => b.Via == 'M');
                    if (hasRole(DigitadorImportaciones))
                        queryable = queryable.Where(r => r.IdUsuario == usuarioLogged.IdUsuario);
                    if (!buscar.todos)
                        queryable = queryable.Where(r => buscar.ids.Contains(r.IdImport));
                    rs = queryable.ToList();
                    if (rs.Count > 0)
                    {
                        CurrentIndex = 0;
                        if (rs.Count > 1)
                        {
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            BotonesIniciales(toolStrip1);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago" }, true, toolStrip1, "MARITIMO");
                        despliegaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        dt.Rows.Clear();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago" }, false, toolStrip1, "MARITIMO");
                    }
                }
            }
            buscar.Dispose();
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (CurrentIndex + 1 >= rs?.Count)
                return;
            CurrentIndex++;
            despliegaDatos();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (CurrentIndex <= 0)
                return;
            CurrentIndex--;
            despliegaDatos();
        }

        private void tsddbProceso_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Image == null)
            {
                switch (rs[CurrentIndex].IdImportStatus)
                {
                    case EntregaDigitadorMaritimo - 1:
                        {
                            break;
                        };
                    case ElaborarPolizaMaritimo - 1:
                        {
                            asignarPoliza();
                            break;
                        };
                    case ElaborarPolizaMaritimo:
                        {
                            if (listFiles.Count > 0)
                                cambiarFase();
                            else
                                MessageBox.Show("No puede pasar a la siguiente fase\r\nsin antes haber subido documentos de respaldo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        };
                    case SalidaPuertoMaritimo - 1:
                        {
                            asignarFecha();
                            break;
                        };
                    case LlegadaFabricaMaritimo - 1:
                        {
                            asignarFecha();
                            break;
                        };
                    case SalidaFabricaMaritimo - 1:
                        {
                            asignarFecha();
                            break;
                        };
                    default:
                        {
                            cambiarFase();
                            break;
                        };
                }

            }
        }

        private void asignarFecha()
        {
            frmFecha FrmFecha = new frmFecha();
            FrmFecha.fechaMin = rs[CurrentIndex].ImportHistorial.LastOrDefault().FechaCreacion;
            var resp = FrmFecha.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            var status = db.ImportStatus.Where(s => s.Via == 'M' && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
                            rs[CurrentIndex].IdImportStatus = status.IdImportStatus;
                            db.SaveChanges();
                            ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = FrmFecha.fecha, Observaciones = FrmFecha.Obs, IdUsuarioCreacion = usuarioLogged.IdUsuario };
                            db.ImportHistorial.Add(ih);
                            rs[CurrentIndex].ImportHistorial.Add(ih);
                            db.SaveChanges();
                            transaction.Commit();
                            despliegaDatos();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            FrmFecha.Dispose();
        }

        private void llenarMontos()
        {
            frmMontos montos = new frmMontos();
            montos.contenedores = rs[CurrentIndex].Contenedores.ToList();
            var resp = montos.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            foreach (var cont in rs[CurrentIndex].Contenedores)
                            {
                                DataRow row = montos.dt.Rows.Find(cont.IdContenedor);
                                Pago p = new Pago
                                {
                                    IdContenedor = Convert.ToInt32(row[3]),
                                    MontoAlmacenaje = Convert.ToDecimal(row[1]),
                                    MontoDemora = Convert.ToDecimal(row[2]),
                                    FechaCreacion = DatosServer.FechaServer(),
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                                };
                                db.Pagos.Add(p);
                                cont.Pago = p;
                                db.SaveChanges();
                                db.Entry(cont).State = EntityState.Modified;
                                cont.IdPago = p.IdPago;
                                db.SaveChanges();
                            }
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            var status = db.ImportStatus.Where(s => s.IdImportStatus == IngresoMontos).OrderBy(s => s.orden).FirstOrDefault();
                            ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                            db.ImportHistorial.Add(ih);
                            rs[CurrentIndex].ImportHistorial.Add(ih);
                            db.SaveChanges();
                            transaction.Commit();
                            despliegaDatos();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            montos.Dispose();
        }
        private void asignarPoliza()
        {
            frmPoliza FrmPoliza = new frmPoliza(rs[CurrentIndex]);
            FrmPoliza.contenedores = rs[CurrentIndex].Contenedores.ToList();
            var resp = FrmPoliza.ShowDialog();
            if (resp == DialogResult.OK)
            {
                despliegaDatos();
            }
        }

        private void cambiarFase()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var resp = MessageBox.Show("Desea mover a la siguiente Fase?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            var status = db.ImportStatus.Where(s => s.Via == 'M' && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
                            rs[CurrentIndex].IdImportStatus = status.IdImportStatus;
                            db.SaveChanges();
                            ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                            db.ImportHistorial.Add(ih);
                            rs[CurrentIndex].ImportHistorial.Add(ih);
                            db.SaveChanges();
                            transaction.Commit();
                            despliegaDatos();
                            // MessageBox.Show("Importación movida a la siguiente Fase", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void llenarMenu()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                var im = db.ImportStatus.Where(i => i.Via == 'M').OrderBy(i => i.orden).ToList();
                int i = 0;
                foreach (var item in im)
                {
                    tsddbProceso.DropDownItems.Add(item.Descripcion);
                    tsddbProceso.DropDownItems[i].ImageScaling = ToolStripItemImageScaling.None;
                    if (i == 2)
                    {
                        var items = db.Usuarios.Include(u => u.Rol).Where(u => u.Rol.IdRol == DigitadorImportaciones);
                        foreach (var item2 in items)
                        {
                            ((ToolStripMenuItem)tsddbProceso.DropDownItems[i - 1]).DropDownItems.Add(item2.Nombres + " " + item2.Apellidos, null, (s, e) => seleccionaDigitador(item2.IdUsuario, true));
                            tsddbSwitchUser.DropDownItems.Add(item2.Nombres + " " + item2.Apellidos, null, (s, e) => seleccionaDigitador(item2.IdUsuario, false));
                        }
                    }
                    i++;
                }
            }
        }
        private void seleccionaDigitador(int codigo, Boolean PrimeraVez)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var digitador = db.Usuarios.FirstOrDefault(u => u.IdUsuario == codigo);
                        var resp = MessageBox.Show("Desea asignar el presente documento al digitador: \r\n" + digitador.Nombres + " " + digitador.Apellidos, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            rs[CurrentIndex].IdUsuario = codigo;
                            var status = db.ImportStatus.Where(s => s.IdImportStatus == EntregaDigitadorMaritimo).OrderBy(s => s.orden).FirstOrDefault();
                            if (PrimeraVez)
                            {
                                rs[CurrentIndex].IdImportStatus = status.IdImportStatus;
                                db.SaveChanges();
                            }
                            ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                            db.ImportHistorial.Add(ih);
                            rs[CurrentIndex].ImportHistorial.Add(ih);
                            db.SaveChanges();
                            transaction.Commit();
                            despliegaDatos();
                            MessageBox.Show("Importación asingada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            dtpETA.Enabled = true;
            cboDestino.Enabled = true;
            chkDocOriginales.Enabled = true;
            if (clbRevisiones.CheckedItems.Count == 0)
                clbRevisiones.Enabled = true;
            dtpETA.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.ImportHistorial.RemoveRange(rs[CurrentIndex].ImportHistorial);
                            db.SaveChanges();
                            db.BL.RemoveRange(rs[CurrentIndex].BL);
                            db.SaveChanges();
                            db.Contenedores.RemoveRange(rs[CurrentIndex].Contenedores);
                            db.SaveChanges();
                            foreach (var r in rs[CurrentIndex].Revisiones)
                            {
                                rs[CurrentIndex].Revisiones.Remove(r);
                            }
                            db.Importaciones.Remove(rs[CurrentIndex]);
                            db.SaveChanges();
                            rs.Remove(rs[CurrentIndex]);
                            if (Directory.Exists(path))
                                Directory.Delete(path, true);
                            transaction.Commit();
                            if (rs.Count > 0)
                            {
                                if (rs.Count > 1)
                                {
                                    if (CurrentIndex != 0)
                                        CurrentIndex--;
                                    BotonesInicialesNavegacion(toolStrip1);
                                }
                                else
                                {
                                    CurrentIndex = 0;
                                    BotonesIniciales(toolStrip1);
                                }
                                despliegaDatos();
                            }
                            else
                            {
                                limpiarFormulario(this);
                                dt.Rows.Clear();
                                cboDestino.SelectedIndex = -1;
                                BotonesIniciales(toolStrip1);
                                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbPago" }, false, toolStrip1, "MARITIMO");
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtValorExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(sender, e);
        }

        private void txtTiempoLibre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enteros(sender, e);
        }

        private void txtDemora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enteros(sender, e);
        }

        private void txtValorExtra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(sender, e);
        }

        private void tsbPago_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (var cont in rs[CurrentIndex].Contenedores)
            {
                if (cont.IdPago != null)
                {
                    c++;
                }
            }
            if (c == 0)
                llenarMontos();
            else
                MessageBox.Show("Ya se han ingresado los montos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
