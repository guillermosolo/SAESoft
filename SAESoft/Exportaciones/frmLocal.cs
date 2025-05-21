using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.Models;
using SAESoft.Models.Exportaciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Utilitarios;

namespace SAESoft.Exportaciones
{
    public partial class frmLocal : Form
    {
        Boolean esNuevo = false;
        private List<FacturaLocal>? rs = [];
        private int CurrentIndex = 0;
        private static readonly int[] sourceArray = [155, 158];
        public frmLocal()
        {
            InitializeComponent();
        }

        private void frmLocal_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "LOCALES");
            llenarCombos();
        }

        public void llenarCombos()
        {
            llenarNombres(cboEmpresa, "EXPORTADOR");
            using SAESoftContext db = new();
            var tipos = db.Nombres.Where(n => sourceArray.Contains(n.IdNombre)).Select(n => new { n.IdNombre, n.Descripcion }).ToList();
            cboTipoFac.DataSource = tipos;
            cboTipoFac.DisplayMember = "Descripcion";
            cboTipoFac.ValueMember = "idNombre";
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "LOCALES");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "LOCALES");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "LOCALES");
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
            txtCliente.Text = rs[CurrentIndex].Cliente;
            cboEmpresa.SelectedValue = rs[CurrentIndex].IdEmpresa;
            txtComentarios.Text = rs[CurrentIndex].Comentarios;
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
            //if (rs[CurrentIndex].Licencia != null)
            //{
            //    cargarArchivos(@"\" + rs[CurrentIndex].Licencia.Codigo);
            //}
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using SAESoftContext db = new();
            var queryable = db.FacturasLocal.Include(t => t.TipoFactura)
                                             .Include(e => e.Empresa)
                                             .AsQueryable();
            //if (buscar.codigo != null)
            //    queryable = queryable.Where(b => b.Codigo.Contains(buscar.codigo));
            //if (buscar.nombreESP != null)
            //    queryable = queryable.Where(b => b.Alias.Contains(buscar.nombreESP));
            //if (buscar.nombreCOR != null)
            //    queryable = queryable.Where(b => b.NombreCoreano.Contains(buscar.nombreCOR));
            rs = [.. queryable];
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "LOCALES");
            }
            else
            {
                MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ocultarCamposVariables();
                limpiarFormulario(this);
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "LOCALES");
            }
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
                    db.FacturasLocal.Remove(rs[CurrentIndex]);
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
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "LOCALES");
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

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtReferencia.Focus();
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
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                errorProvider1.SetError(txtCliente, "No puede estar vacío.");
                txtCliente.Focus();
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
                        var Empresa = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboEmpresa.SelectedValue)).FirstOrDefault();
                        FacturaLocal factura = new()
                        {
                            Fecha = dtpFecha.Value.Date,
                            Referencia = txtReferencia.Text,
                            NoFactura = txtNumero.Text,
                            IdTipoFactura = TipoFac.IdNombre,
                            Cliente = txtCliente.Text,
                            IdEmpresa = Empresa.IdNombre,
                            Comentarios = txtComentarios.Text,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        };
                        db.FacturasLocal.Add(factura);
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
                    FacturaLocal temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        var TipoFac = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboTipoFac.SelectedValue)).FirstOrDefault();
                        var Empresa = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboEmpresa.SelectedValue)).FirstOrDefault();
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Fecha = dtpFecha.Value.Date;
                        rs[CurrentIndex].Referencia = txtReferencia.Text;
                        rs[CurrentIndex].NoFactura = txtNumero.Text;
                        rs[CurrentIndex].IdTipoFactura = TipoFac.IdNombre;
                        rs[CurrentIndex].Cliente = txtCliente.Text;
                        rs[CurrentIndex].IdEmpresa = Empresa.IdNombre;
                        rs[CurrentIndex].Comentarios = txtComentarios.Text;
                        if (!tsActivo.Checked)
                        {
                            rs[CurrentIndex].FechaAnulacion = DatosServer.FechaServer();
                            rs[CurrentIndex].NotaCredito = txtNotaCredito.Text;
                        }
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.FacturasLocal.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "LOCALES");
                habilitarFormulario(this, false);
            }
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            txtNotaCredito.Visible = lblNotaCredito.Visible = !tsActivo.Checked;
        }
    }
}
