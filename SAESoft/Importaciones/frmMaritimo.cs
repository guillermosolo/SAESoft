
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Data;
using System.Diagnostics;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Importaciones
{
    public partial class frmMaritimo : Form
    {
        public frmMaritimo()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = false;
        private List<Importacion>? rs = new List<Importacion>();
        private int CurrentIndex = 0;

        List<string> listFiles = new List<string>();
        string path = PATH_Import;

        private void cargarArchivos(string opcion)
        {
            listFiles.Clear();
            listView1.Items.Clear();
            imageList1.Images.Clear();
            path = PATH_Import + opcion;
            fileSystemWatcher1.Path = path;
            foreach (string file in Directory.GetFiles(path).Where(f => (new FileInfo(f).Attributes & FileAttributes.Hidden) == 0))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(file));
                FileInfo fi = new FileInfo(file);
                listFiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
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
                    File.Copy(openFileDialog1.FileName, path + '\\' + openFileDialog1.SafeFileName);
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
            }
            llenarNombres(cboNaviera, "EMPRESA");
            llenarNombres(cboForwarder, "FORWARDER");
            llenarNombres(cboDestino, "DESTINO");
        }



        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            tsSelectivo.Checked = true;
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
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MARITIMO");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MARITIMO");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "MARITIMO");
                limpiarFormulario(this);
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
            tsConsolidado.Checked = rs[CurrentIndex].Consolidado;
            cboShipper.SelectedValue = rs[CurrentIndex].IdShipper;
            cboNaviera.SelectedValue = rs[CurrentIndex].IdNaviera;
            cboForwarder.SelectedValue = rs[CurrentIndex].IdForwarder;
            cboDestino.SelectedValue = rs[CurrentIndex].IdDestino;
            dtpETA.Value = rs[CurrentIndex].ETA;
            tsSelectivo.Checked = !rs[CurrentIndex].SelectivoRojo;
            cboTerminal.SelectedValue = rs[CurrentIndex].IdTerminal;
            cboAduana.SelectedValue = rs[CurrentIndex].IdAduana;
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
        }

        private void checkProceso(uint ord)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                var im = db.ImportStatus.Where(i => i.Via == 'M').OrderBy(i => i.orden).ToList();
                int i = 0;
                foreach (var item in im)
                {
                    if (item.orden <= ord)
                    {
                        tsddbProceso.DropDownItems[i].Image = Properties.Resources.check2;
                        tsddbProceso.DropDownItems[i].Enabled = false;
                    }
                    else if (item.orden != ord + 1)
                    {
                        tsddbProceso.DropDownItems[i].Enabled = false;
                    } else
                    {
                        tsddbProceso.DropDownItems[i].Enabled = true;
                    }
                    i++;
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
                                    IdForwarder = Convert.ToInt32(cboForwarder.SelectedValue),
                                    IdDestino = Convert.ToInt32(cboDestino.SelectedValue),
                                    ETA = dtpETA.Value,
                                    IdTerminal = Convert.ToInt32(cboTerminal.SelectedValue),
                                    IdAduana = Convert.ToInt32(cboAduana.SelectedValue),
                                    SelectivoRojo = !tsSelectivo.Checked,
                                    Consolidado = tsConsolidado.Checked,
                                    IdImportStatus = db.ImportStatus.FirstOrDefault(i => i.Via == 'M' && i.orden == 1).IdImportStatus,
                                    FechaCreacion = DatosServer.FechaServer(),
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                };
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
                                ImportHistorial ih = new ImportHistorial {IdImport = im.IdImport, IdImportStatus = status.IdImportStatus,FechaCreacion=im.FechaCreacion,IdUsuarioCreacion=im.IdUsuarioCreacion};
                                db.ImportHistorial.Add(ih);
                                rs[CurrentIndex].ImportHistorial.Add(ih);
                                db.SaveChanges();
                                path = PATH_Import + @"\" + im.Codigo.ToString();
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);
                                transaction.Commit();
                                CurrentIndex = rs.Count - 1;
                                despliegaDatos();
                                MessageBox.Show("Documento Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload" }, true, toolStrip1, "MARITIMO");
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
            using (SAESoftContext db = new SAESoftContext())
            {
                var queryable = db.Importaciones.Include(r => r.Revisiones)
                                                .Include(r => r.BL)
                                                .Include(r => r.Contenedores)
                                                .Include(r => r.ImportStatus)
                                                .Include(r => r.ImportHistorial)
                                                .Where(b => 1 == 1);
                rs = queryable.ToList();
                if (rs.Count > 0)
                {
                    CambiarEstadoBotones(new[] { "tsddbProceso", "tsbUpload" }, true, toolStrip1, "MARITIMO");
                    despliegaDatos();
                    if (rs.Count > 1)
                    {
                        BotonesInicialesNavegacion(toolStrip1);
                    }
                    else
                    {
                        BotonesIniciales(toolStrip1);
                    }
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MARITIMO");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "MARITIMO");
                }
            }
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
                switch (rs[CurrentIndex].ImportStatus.IdImportStatus)
                {
                    case 1:
                        {
                            break;
                        };
                    default:
                        {
                            MessageBox.Show("Aquí solo cambia estatus");
                            break;
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
                            ((ToolStripMenuItem)tsddbProceso.DropDownItems[i - 1]).DropDownItems.Add(item2.Nombres + " " + item2.Apellidos, null, (s, e) => seleccionaDigitador(item2.IdUsuario));
                        }
                    }
                    i++;
                }
            }
        }
        private void seleccionaDigitador(int codigo)
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
                            var status = db.ImportStatus.Where(s => s.Via == 'M' && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
                            rs[CurrentIndex].IdImportStatus = status.IdImportStatus;
                            db.SaveChanges();
                            ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                            db.ImportHistorial.Add(ih);
                            rs[CurrentIndex].ImportHistorial.Add(ih);
                            db.SaveChanges();
                            transaction.Commit();
                            despliegaDatos();
                            MessageBox.Show("Documento correctamente asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
