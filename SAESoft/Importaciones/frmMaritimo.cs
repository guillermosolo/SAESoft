
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Data;
using System.Diagnostics;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Importaciones
{
    public partial class frmMaritimo : Form
    {
        public frmMaritimo()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = true;
        private List<Importacion>? rs = new List<Importacion>();
        private int CurrentIndex = 0;

        List<string> listFiles = new List<string>();
        const string PATH = @"\\192.168.50.37\SAESoft\Import\Soporte";
        string path = PATH;




        private void cargarArchivos(string opcion)
        {
            listFiles.Clear();
            listView1.Items.Clear();
            imageList1.Images.Clear();
            path = PATH + opcion;
            foreach (string file in Directory.GetFiles(path).Where(f => (new FileInfo(f).Attributes & FileAttributes.Hidden) == 0))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(file));
                FileInfo fi = new FileInfo(file);
                listFiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
            }
            fileSystemWatcher1.Path = path;
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
            cargarArchivos("");
        }

        private void tsbUpload_Click(object sender, EventArgs e)
        {
            var resp = openFileDialog1.ShowDialog();
            if (resp == System.Windows.Forms.DialogResult.OK)
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
            using (DB_Context _Contexto = new DB_Context())
            {
                cboShipper.DataSource = _Contexto.Shippers.Where(s => s.Maritimo).OrderBy(s => s.Nombre).ToList();
                cboShipper.DisplayMember = "Nombre";
                cboShipper.ValueMember = "IdShipper";
                cboAduana.DataSource = _Contexto.Aduanas.Where(a => a.Via == 'M').OrderBy(a => a.Nombre).ToList();
                cboAduana.DisplayMember = "Nombre";
                cboAduana.ValueMember = "IdAduana";
                cboTerminal.DataSource = _Contexto.Terminales.Where(t => t.Via == 'M').OrderBy(t => t.Nombre).ToList();
                cboTerminal.DisplayMember = "Nombre";
                cboTerminal.ValueMember = "IdTerminal";
                clbRevisiones.DataSource = _Contexto.Revisiones.OrderBy(r => r.Descripcion).ToList();
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
            cargarArchivos("");
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        using (var transaction = _Contexto.Database.BeginTransaction())
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
                                    FechaCreacion = DatosServer.FechaServer(),
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                };
                                _Contexto.Importaciones.Add(im);
                                _Contexto.SaveChanges();
                                List<Revision> rev = new List<Revision>();
                                foreach (Revision item in clbRevisiones.CheckedItems)
                                {
                                    rev.Add(item);
                                }
                                rs[CurrentIndex].Revisiones = rev;
                                AgregarRevisiones(_Contexto, im.IdImport, rev);
                                List<BL> _bl = new List<BL>();
                                List<Contenedor> _con = new List<Contenedor>();
                                foreach (var item in lsbBL.Items)
                                {
                                   _bl.Add(new BL { Numero = item.ToString(), IdImportacion = im.IdImport, FechaCreacion = im.FechaCreacion, IdUsuarioCreacion = im.IdUsuarioCreacion });
                                };
                                foreach (var item in lsbEquipos.Items)
                                {
                                    _con.Add(new Contenedor {Numero = item.ToString(),IdImportacion = im.IdImport,FechaCreacion=im.FechaCreacion,IdUsuarioCreacion=im.IdUsuarioCreacion });
            
                                }
                                _Contexto.BL.AddRange(_bl);
                                _Contexto.Contenedores.AddRange(_con);
                                rs[CurrentIndex].Contenedores = _con;
                                rs[CurrentIndex].BL= _bl;
                                _Contexto.SaveChanges();
                                path = PATH + @"\" + im.Codigo.ToString();
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
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar","tsddbProceso","tsbUpload" }, true, toolStrip1, "MARITIMO");
                habilitarFormulario(this, false);
            }
        }

        private void AgregarRevisiones(DB_Context db,int id, List<Revision> rev)
        {
            var im = db.Importaciones.Include(i=>i.Revisiones).FirstOrDefault(i=>i.IdImport == id);
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


    }
}
