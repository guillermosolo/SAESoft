using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Exportaciones;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;

namespace SAESoft.Exportaciones
{
    public partial class frmFacturas : Form
    {
        Boolean esNuevo = false;
        private List<FacturaExport>? rs = new();
        readonly List<string> listFiles = new();
        private int CurrentIndex = 0;
        public frmFacturas()
        {
            InitializeComponent();
        }

        public void llenarCombos()
        {
            llenarNombres(cboConsignatario, "CONSIGNATARIO");
            llenarNombres(cboModalidad, "MODALIDAD EXPORT", true);
            llenarNombres(cboExportador, "EXPORTADOR");
            using SAESoftContext db = new();
            var tipos = db.Nombres.Where(n => !new[] { 155, 158 }.Contains(n.IdNombre)).Where(g=>g.IdGrupo == 15).Select(n => new { n.IdNombre, n.Descripcion }).ToList();
            cboTipoFac.DataSource = tipos;
            cboTipoFac.DisplayMember = "Descripcion";
            cboTipoFac.ValueMember = "idNombre";
            var listado = db.Aduanas.Select(a => new { a.IdAduana, a.Nombre }).ToList();
            listado.Insert(0, new { IdAduana = 0, Nombre = "(NINGUNO)" });
            cboAduana.DataSource = listado;
            cboAduana.DisplayMember = "Nombre";
            cboAduana.ValueMember = "IdAduana";
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "FACTURAS");
            llenarCombos();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            tsActivo.Checked = true;
            ocultarCamposVariables();
            limpiarFormulario(this);
            //  tsActivo.Checked = true;
            txtReferencia.Focus();
        }

        private void ocultarCamposVariables()
        {
            lblActivo.Visible = false;
            lblNotaCredito.Visible = false;
            tsActivo.Visible = false;
            txtNotaCredito.Visible = false;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso" }, true, toolStrip1, "FACTURAS");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso"}, true, toolStrip1, "FACTURAS");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso" }, false, toolStrip1, "FACTURAS");
                ocultarCamposVariables();
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void despliegaDatos()
        {
            dtpFecha.Value = rs[CurrentIndex].Fecha;
            txtReferencia.Text = rs[CurrentIndex].Referencia;
            txtNumero.Text = rs[CurrentIndex].NoFactura;
            cboTipoFac.SelectedValue = rs[CurrentIndex].IdTipoFactura;
            cboConsignatario.SelectedValue = rs[CurrentIndex].IdConsignatario;
            cboAduana.SelectedValue = rs[CurrentIndex].IdAduana != null ? rs[CurrentIndex].Aduana.IdAduana : 0;
            cboModalidad.SelectedValue = rs[CurrentIndex].IdModalidad != null ? rs[CurrentIndex].Modalidad.IdNombre : 0;
            cboExportador.SelectedValue = rs[CurrentIndex].IdExportador;
            tsActivo.Visible = true;
            lblActivo.Visible = true;
            if (rs[CurrentIndex].FechaAnulacion != null)
            {
                tsActivo.Checked = false;
                lblNotaCredito.Visible = true;
                txtNotaCredito.Visible = true;
                txtNotaCredito.Text = rs[CurrentIndex].NotaCredito;
            }
            else
            {
                tsActivo.Checked = true;
                lblNotaCredito.Visible = false;
                txtNotaCredito.Visible = false;
                txtNotaCredito.Text = string.Empty;
            }
            if (rs[CurrentIndex].Licencia != null)
            {
                cargarArchivos(@"\" + rs[CurrentIndex].Licencia.Codigo);
            }
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            cargarArchivos(@"\" + rs[CurrentIndex].Licencia.Codigo);
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            if (rs[CurrentIndex] != null)
            {
                cargarArchivos(@"\" + rs[CurrentIndex].Licencia.Codigo);
            }
        }

        private void cargarArchivos(string opcion)
        {
            listFiles.Clear();
            String path = PATH_Export + opcion;
            listView1.Items.Clear();
            imageList1.Images.Clear();
            if (Directory.Exists(path))
            {
                fileSystemWatcher1.Path = path;
                foreach (string file in Directory.GetFiles(path).Where(f => (new FileInfo(f).Attributes & FileAttributes.Hidden) == 0))
                {
                    Icon fileIcon = Icon.ExtractAssociatedIcon(file);
                    imageList1.Images.Add(fileIcon);
                    FileInfo fi = new(file);
                    listFiles.Add(fi.FullName);
                    listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                }
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtReferencia.Text))
            {
                errorProvider1.SetError(txtReferencia, "No puede estar vacío.");
                txtReferencia.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "No puede estar vacío.");
                txtNumero.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNotaCredito.Text) && !tsActivo.Checked)
            {
                errorProvider1.SetError(txtNotaCredito, "No puede estar vacío.");
                txtNotaCredito.Focus();
                return false;
            }
            return true;
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using SAESoftContext db = new();
                    try
                    {
                        var TipoFac = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboTipoFac.SelectedValue)).FirstOrDefault();
                        var Consignatario = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboConsignatario.SelectedValue)).FirstOrDefault();
                        var Modalidad = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboModalidad.SelectedValue)).FirstOrDefault();
                        var Aduana = db.Aduanas.Where(a => a.IdAduana == Convert.ToInt32(cboAduana.SelectedValue)).FirstOrDefault();
                        var Exportador = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboExportador.SelectedValue)).FirstOrDefault();
                        FacturaExport factura = new()
                        {
                            Fecha = dtpFecha.Value.Date,
                            Referencia = txtReferencia.Text,
                            NoFactura = txtNumero.Text,
                            IdTipoFactura = TipoFac.IdNombre,
                            IdConsignatario = Consignatario.IdNombre,
                            IdAduana = Aduana?.IdAduana,
                            IdModalidad = Modalidad?.IdNombre,
                            IdExportador = Exportador.IdNombre,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        };
                        db.FacturasExport.Add(factura);
                        db.SaveChanges();
                        rs.Add(factura);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Factura Grabada Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    FacturaExport temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        var TipoFac = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboTipoFac.SelectedValue)).FirstOrDefault();
                        var Consignatario = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboConsignatario.SelectedValue)).FirstOrDefault();
                        var Modalidad = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboModalidad.SelectedValue)).FirstOrDefault();
                        var Aduana = db.Aduanas.Where(a => a.IdAduana == Convert.ToInt32(cboAduana.SelectedValue)).FirstOrDefault();
                        var Exportador = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboExportador.SelectedValue)).FirstOrDefault();
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Fecha = dtpFecha.Value.Date;
                        rs[CurrentIndex].Referencia = txtReferencia.Text;
                        rs[CurrentIndex].NoFactura = txtNumero.Text;
                        rs[CurrentIndex].IdTipoFactura = TipoFac.IdNombre;
                        rs[CurrentIndex].IdConsignatario = Consignatario.IdNombre;
                        rs[CurrentIndex].IdAduana = Aduana?.IdAduana;
                        rs[CurrentIndex].IdModalidad = Modalidad?.IdNombre;
                        rs[CurrentIndex].IdExportador = Exportador.IdNombre;
                        if (!tsActivo.Checked)
                        {
                            rs[CurrentIndex].FechaAnulacion = DatosServer.FechaServer();
                            rs[CurrentIndex].NotaCredito = txtNotaCredito.Text;
                        }
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.FacturasExport.Update(rs[CurrentIndex]);
                        db.SaveChanges();
                        despliegaDatos();
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rs[CurrentIndex] = temp;
                        return;
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
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar"}, true, toolStrip1, "FACTURAS");
                habilitarFormulario(this, false);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using SAESoftContext db = new();
            var queryable = db.FacturasExport.Include(t => t.TipoFactura)
                                             .Include(c => c.Consignatario)
                                             .Include(a => a.Aduana)
                                             .Include(m => m.Modalidad)
                                             .Include(l => l.Licencia)
                                             .Where(b => 1 == 1);
            //if (buscar.codigo != null)
            //    queryable = queryable.Where(b => b.Codigo.Contains(buscar.codigo));
            //if (buscar.nombreESP != null)
            //    queryable = queryable.Where(b => b.Alias.Contains(buscar.nombreESP));
            //if (buscar.nombreCOR != null)
            //    queryable = queryable.Where(b => b.NombreCoreano.Contains(buscar.nombreCOR));
            rs = queryable.ToList();
            //buscar.Dispose();
            if (rs.Count > 0)
            {
                CurrentIndex = 0;
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "FACTURAS");
            }
            else
            {
                MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ocultarCamposVariables();
                limpiarFormulario(this);
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "FACTURAS");
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtReferencia.Focus();
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            txtNotaCredito.Visible = lblNotaCredito.Visible = !tsActivo.Checked;
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

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    db.FacturasExport.Remove(rs[CurrentIndex]);
                    db.SaveChanges();
                    rs.Remove(rs[CurrentIndex]);
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
                        ocultarCamposVariables();
                        limpiarFormulario(this);
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "FACTURAS");
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

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                string selectedFile = listFiles[listView1.SelectedIndices[0]];

                if (File.Exists(selectedFile))
                {
                    try
                    {
                        // Directorio temporal
                        string tempDirectory = Path.GetTempPath();

                        // Copiar el archivo a la carpeta temporal
                        string tempFilePath = Path.Combine(tempDirectory, Path.GetFileName(selectedFile));
                        File.Copy(selectedFile, tempFilePath, true);

                        // Abrir la copia desde la carpeta temporal
                        new Process { StartInfo = new ProcessStartInfo(tempFilePath) { UseShellExecute = true } }.Start();
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción según tus necesidades
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
