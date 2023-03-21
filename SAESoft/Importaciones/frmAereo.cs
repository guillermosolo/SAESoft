using SAESoft.Models.Importaciones;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.DatosServer;
using static SAESoft.Utilitarios.Validaciones;
using SAESoft.Models;
using Microsoft.EntityFrameworkCore;
using SAESoft.Utilitarios;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SAESoft.Importaciones
{
    public partial class frmAereo : Form
    {
        private Boolean esNuevo = false;
        public int individual = 0;
        private List<Importacion>? rs = new List<Importacion>();
        private int CurrentIndex = 0;
        private char Via = 'A';
        DataTable dt = new DataTable();
        DataTable dtc = new DataTable();

        List<string> listFiles = new List<string>();
        string path = PATH_Import;
        public frmAereo()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            if (individual != 0)
                this.Dispose();
            else
                this.Close();
        }


        private void llenarCombosVariables()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                if (Via == 'A')
                    cboShipper.DataSource = db.Shippers.Where(s => s.Aereo).OrderBy(s => s.Nombre).ToList();
                else
                    cboShipper.DataSource = db.Shippers.Where(s => s.Terrestre).OrderBy(s => s.Nombre).ToList();
                cboShipper.DisplayMember = "Nombre";
                cboShipper.ValueMember = "IdShipper";
                cboAduana.DataSource = db.Aduanas.Where(a => a.Via == Via).OrderBy(a => a.Nombre).ToList();
                cboAduana.DisplayMember = "Nombre";
                cboAduana.ValueMember = "IdAduana";
                cboTerminal.DataSource = db.Terminales.Where(t => t.Via == Via).OrderBy(t => t.Nombre).ToList();
                cboTerminal.DisplayMember = "Nombre";
                cboTerminal.ValueMember = "IdTerminal";
            }
        }

        private void llenarCombos()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                llenarCombosVariables();
                clbRevisiones.DataSource = db.Revisiones.OrderBy(r => r.Descripcion).ToList();
                clbRevisiones.DisplayMember = "Descripcion";
                clbRevisiones.ValueMember = "IdRevision";
                var agente = db.Agentes.Where(a => a.Activo).ToList();
                agente.Insert(0, new Agente { IdAgente = 0, Nombres = "(NINGUNO)", Apellidos = "" });
                cboAgente.DataSource = agente;
                cboAgente.DisplayMember = "NombreCompleto";
                cboAgente.ValueMember = "IdAgente";
            }
            llenarNombres(cboNaviera, "EMPRESA");
            llenarNombres(cboForwarder, "FORWARDER", true);
            llenarNombres(cboDestino, "DESTINO", true);
            llenarNombres(cboAlmacenadora, "ALMACENADORA", true);
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("Fase").DataType = Type.GetType("System.String");
            dt.Columns.Add("Responsable").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha").DataType = Type.GetType("System.DateTime");
            dtc.Columns.Add("Número").DataType = Type.GetType("System.String");
            dtc.Columns.Add("P. Cabezal").DataType = Type.GetType("System.String");
            dtc.Columns.Add("P. Furgón").DataType = Type.GetType("System.String");
            dgvHistorial.DataSource = dt;
            dgvHistorial.Columns[0].Width = 250;
            dgvHistorial.Columns[1].Width = 274;
            dgvHistorial.Columns[2].Width = 150;
            dgvHistorial.ClearSelection();
            dgvContenedores.DataSource = dtc;
            dgvContenedores.Columns[0].Width = 145;
            dgvContenedores.Columns[1].Width = 115;
            dgvContenedores.Columns[2].Width = 115;
        }

        private void ibtnAereo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAereo.Checked)
            {
                Via = 'A';
                label5.Visible = true;
                cboTerminal.Visible = true;
                label8.Visible = false;
                cboAlmacenadora.Visible = false;
                dgvContenedores.Visible = false;
            }
            else
            {
                Via = 'T';
                label5.Visible = false;
                cboTerminal.Visible = false;
                label8.Visible = true;
                cboAlmacenadora.Visible = true;
                dgvContenedores.Visible = true;
            }
            llenarCombos();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            frmBuscarImport buscar = new frmBuscarImport();
            DialogResult resp;
            if (individual == 0)
            {
                resp = buscar.ShowDialog();
            }
            else
            {
                buscar.todos = true;
                resp = DialogResult.OK;
            }
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    var queryable = db.Importaciones.Include(r => r.Revisiones)
                                                    .Include(r => r.BL)
                                                    .Include(r => r.Contenedores)
                                                    .Include(r => r.ImportStatus)
                                                    .Include(r => r.ImportHistorial)
                                                    .ThenInclude(rh => rh.ImportStatus)
                                                    .Where(b => b.Via == 'A' || b.Via == 'T');
                    if (hasRole(DigitadorImportaciones))
                        queryable = queryable.Where(r => r.IdUsuario == usuarioLogged.IdUsuario);
                    if (!buscar.todos)
                        queryable = queryable.Where(r => buscar.ids.Contains(r.IdImport));
                    if (individual != 0)
                        queryable = queryable.Where(r => r.IdImport == individual);
                    rs = queryable.ToList();
                    if (rs.Count > 0)
                    {
                        CurrentIndex = 0;
                        CambiarEstadoBotones(new[] { "tsddbProceso", "tsbUpload" }, true, toolStrip1, "AEREO");
                        if (rs.Count > 1)
                        {
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            BotonesIniciales(toolStrip1);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AEREO");
                        despliegaDatos();
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        dt.Rows.Clear();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AEREO");
                    }
                }
            }
        }

        private void frmAereo_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "AEREO");
            llenarMenu();
            llenarCombos();
            estructuraGrid();
        }

        private void llenarMenu()
        {
            tsddbProceso.DropDownItems.Clear();
            using (SAESoftContext db = new SAESoftContext())
            {
                var im = db.ImportStatus.Where(i => i.Via == Via).OrderBy(i => i.orden).ToList();
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
                            var status = db.ImportStatus.Where(s => s.Via == Via && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
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

        private void despliegaDatos()
        {
            dt.Clear();
            dtc.Clear();
            DataRow row;
            for (int i = 0; i < clbRevisiones.Items.Count; i++)
            {
                Revision item = (Revision)clbRevisiones.Items[i];
                var resp = rs[CurrentIndex].Revisiones.Where(r => r.IdRevision == item.IdRevision).Count() > 0;
                clbRevisiones.SetItemChecked(i, resp);
            }
            if (rs[CurrentIndex].Via == 'A')
            {
                Via = 'A';
                rbtnAereo.Checked = true;
                if (rs[CurrentIndex].IdTerminal != null)
                {
                    cboTerminal.SelectedValue = rs[CurrentIndex].IdTerminal;
                }
                else
                {
                    cboTerminal.SelectedIndex = -1;
                }
            }
            else
            {
                Via = 'T';
                rbtnTerrestre.Checked = true;
                if (rs[CurrentIndex].IdAlmacenadora != null)
                {
                    cboAlmacenadora.SelectedValue = rs[CurrentIndex].IdAlmacenadora;
                }
                else
                {
                    cboAlmacenadora.SelectedIndex = -1;
                }
                foreach (var c in rs[CurrentIndex].Contenedores)
                {
                    row = dtc.NewRow();
                    row[0] = c.Numero;
                    row[1] = c.Cabezal;
                    row[2] = c.Furgon;
                    dtc.Rows.Add(row);
                }
            }
            llenarMenu();
            llenarCombosVariables();
            txtId.Text = rs?[CurrentIndex].IdImport.ToString();
            cboShipper.SelectedValue = rs[CurrentIndex].IdShipper;
            cboNaviera.SelectedValue = rs[CurrentIndex].IdNaviera;
            if (rs[CurrentIndex].IdAgente != null)
                cboAgente.SelectedValue = rs[CurrentIndex].IdAgente;
            else
                cboAgente.SelectedIndex = 0;
            chkDocOriginales.Checked = rs[CurrentIndex].DocOriginales;
            if (rs[CurrentIndex].IdDestino != null)
                cboDestino.SelectedValue = rs[CurrentIndex].IdDestino;
            else
                cboDestino.SelectedIndex = 0;
            if (rs[CurrentIndex].IdForwarder != null)
                cboForwarder.SelectedValue = rs[CurrentIndex].IdForwarder;
            else
                cboForwarder.SelectedIndex = 0;
            dtpETA.Value = rs[CurrentIndex].ETA;
            if (rs[CurrentIndex].IdAduana != null)
            {
                cboAduana.SelectedValue = rs[CurrentIndex].IdAduana;
            } else
            {
                cboAduana.SelectedIndex = -1;
            }
            cargarArchivos(@"\" + rs[CurrentIndex].Codigo);
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
            checkProceso(rs[CurrentIndex].ImportStatus.orden);
            dt.Clear();
            foreach (var h in rs[CurrentIndex].ImportHistorial.OrderByDescending(h => h.FechaCreacion))
            {
                row = dt.NewRow();
                row[0] = h.Observaciones != null ? h.ImportStatus.Descripcion + ": " + h.Observaciones : h.ImportStatus.Descripcion;
                row[1] = NombreUsuario(h.IdUsuarioCreacion);
                row[2] = h.FechaCreacion;
                dt.Rows.Add(row);
            }
            if (rs[CurrentIndex].IdImportStatus == StatusFinalMaritimo)
                CambiarEstadoBotones(new[] { "tsbModificar" }, false, toolStrip1, "AEREO");
            else
                CambiarEstadoBotones(new[] { "tsbModificar" }, true, toolStrip1, "AEREO");

            if (rs[CurrentIndex].Via == 'A')
                CambiarEstadoBotones(new[] { "tsbPago" }, false, toolStrip1, "AEREO");
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

        private void checkProceso(uint ord)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                var im = db.ImportStatus.Where(i => i.Via == Via).OrderBy(i => i.orden).ToList();
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            dt.Rows.Clear();
            dtc.Rows.Clear();
            cboShipper.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AEREO");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AEREO");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AEREO");
                limpiarFormulario(this);
                dt.Rows.Clear();
            }
            habilitarFormulario(this, false);
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
                                Importacion im = new Importacion
                                {
                                    Codigo = Guid.NewGuid(),
                                    IdShipper = Convert.ToInt32(cboShipper.SelectedValue),
                                    Via = Via,
                                    IdNaviera = Convert.ToInt32(cboNaviera.SelectedValue),
                                    ETA = dtpETA.Value,
                                    IdAduana = Convert.ToInt32(cboAduana.SelectedValue),
                                    Consolidado = false,
                                    DocOriginales = chkDocOriginales.Checked,
                                    IdAgente = Convert.ToInt32(cboAgente.SelectedValue),
                                    IdImportStatus = db.ImportStatus.FirstOrDefault(i => i.Via == Via && i.orden == 1).IdImportStatus,
                                    FechaCreacion = DatosServer.FechaServer(),
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                };
                                if (cboDestino.SelectedIndex != 0)
                                    im.IdDestino = Convert.ToInt32(cboDestino.SelectedValue);
                                if (cboForwarder.SelectedIndex != 0)
                                    im.IdForwarder = Convert.ToInt32(cboForwarder.SelectedIndex);
                                if (Via == 'A')
                                    im.IdTerminal = Convert.ToInt32(cboTerminal.SelectedValue);
                                else
                                    im.IdAlmacenadora = Convert.ToInt32(cboAlmacenadora.SelectedValue);
                                db.Importaciones.Add(im);
                                db.SaveChanges();
                                rs.Add(im);
                                CurrentIndex = rs.Count - 1;
                                List<Revision> rev = new List<Revision>();
                                List<Contenedor> _con = new List<Contenedor>();
                                List<BL> _bl = new List<BL>();
                                foreach (Revision item in clbRevisiones.CheckedItems)
                                {
                                    rev.Add(item);
                                }
                                rs[CurrentIndex].Revisiones = rev;
                                AgregarRevisiones(db, im.IdImport, rev);
                                _bl.Add(new BL { Numero = txtBL.Text, IdImportacion = im.IdImport, FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion });
                                if (Via == 'T')
                                {
                                    foreach (DataRow r in dtc.Rows)
                                    {
                                        _con.Add(new Contenedor { Numero = r.ItemArray[0].ToString().ToUpper(), IdImportacion = im.IdImport, Cabezal = r.ItemArray[1].ToString().ToUpper(), Furgon = r.ItemArray[2].ToString().ToUpper(), FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion });
                                    }
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
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload" }, true, toolStrip1, "AEREO");
                habilitarFormulario(this, false);
            }
        }

        private void tsddbProceso_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Image == null)
            {
                if (Via == 'A')
                {
                    switch (rs[CurrentIndex].IdImportStatus)
                    {
                        case EntregaDigitadorAereo - 1:
                            {
                                break;
                            };
                        case ElaborarPolizaAereo - 1:
                            {
                                asignarPoliza();
                                break;
                            }
                        case StatusFinalAereo - 1:
                            {
                                llenarMontos();
                                break;
                            }
                        default:
                            {
                                cambiarFase();
                                break;
                            }
                    }
                }
                else
                {
                    switch (rs[CurrentIndex].IdImportStatus)
                    {
                        case EntregaDigitadorTerrestre - 1:
                            {
                                break;
                            };
                        case ElaborarPolizaTerrestre - 1:
                            {
                                asignarPoliza();
                                break;
                            }
                        default:
                            {
                                cambiarFase();
                                break;
                            }
                    }
                }

            }
        }

        private void asignarPoliza()
        {
            frmPoliza FrmPoliza = new frmPoliza(rs[CurrentIndex]);
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
                            var status = db.ImportStatus.Where(s => s.Via == Via && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
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

        private void llenarMontos()
        {
            frmMontos montos = new frmMontos();
            var resp = montos.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            var status = db.ImportStatus.Where(s => s.Via == Via && s.orden > rs[CurrentIndex].ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
                            rs[CurrentIndex].IdImportStatus = status.IdImportStatus;
                            db.SaveChanges();
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
                        finally
                        {
                            montos.Dispose();
                        }
                    }
                }
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
            Regex ValidarPlacas = plate_validation();
            errorProvider1.Clear();
            if (txtBL.Text == "")
            {
                errorProvider1.SetError(txtBL, "No puede estar vacío.");
                txtBL.Focus();
                return false;
            }
            if (Via == 'T')
            {
                if (dtc.Rows.Count == 0)
                {
                    errorProvider1.SetError(dgvContenedores, "No puede estar vacío.");
                    dgvContenedores.Focus();
                    return false;
                }
                foreach (DataRow r in dtc.Rows)
                {
                    if (r.ItemArray[0] == null)
                    {
                        errorProvider1.SetError(dgvContenedores, "No puede estar vacío.");
                        dgvContenedores.Focus();
                        return false;
                    }
                    if (!ValidarPlacas.IsMatch(r.ItemArray[1].ToString()))
                    {
                        errorProvider1.SetError(dgvContenedores, "La placa no parece una placa válida");
                        dgvContenedores.Focus();
                        return false;
                    }
                    if (!ValidarPlacas.IsMatch(r.ItemArray[2].ToString()))
                    {
                        errorProvider1.SetError(dgvContenedores, "La placa no parece una placa válida");
                        dgvContenedores.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.Nchecked;
            else
                chk.Image = Properties.Resources.Nunchecked;
        }
        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (CurrentIndex <= 0)
                return;
            CurrentIndex--;
            despliegaDatos();
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (CurrentIndex + 1 >= rs?.Count)
                return;
            CurrentIndex++;
            despliegaDatos();
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

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
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

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && hasPermission("ELIMINAR.AEREO"))
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

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            cboAlmacenadora.Enabled = true;
            cboAduana.Enabled = true;
            dtpETA.Enabled = true;
            cboDestino.Enabled = true;
            if (cboAgente.SelectedIndex == 0)
                cboAgente.Enabled = true;
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
                                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AEREO");
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

        public void mostrarIndividual(Panel panel)
        {
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            panel.Controls.Add(this);
            panel.Tag = this;
            this.Show();
            this.BringToFront();
            tsbBuscar_Click(null, null);
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
            if (c == 0 && rs[CurrentIndex].Via == 'T')
                llenarMontos();
            else
                MessageBox.Show("Ya se han ingresado los montos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbComentarios_Click(object sender, EventArgs e)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                try
                {
                    frmComentarios comm = new frmComentarios();
                    var res = comm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        var status = db.ImportStatus.Where(s => s.IdImportStatus == Comentario).OrderBy(s => s.orden).FirstOrDefault();
                        ImportHistorial ih = new ImportHistorial { IdImport = rs[CurrentIndex].IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario, Observaciones = comm.Obs };
                        db.ImportHistorial.Add(ih);
                        rs[CurrentIndex].ImportHistorial.Add(ih);
                        db.SaveChanges();
                        despliegaDatos();
                    }
                }
                catch (Exception ex)
                {
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
