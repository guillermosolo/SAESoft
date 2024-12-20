using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;

namespace SAESoft.Incentivo
{
    public partial class frmSuspensiones : Form
    {
        Boolean carga = false;
        Boolean esNuevo = true;
        private List<Suspension>? rs = [];
        private int CurrentIndex = 0;
        public frmSuspensiones()
        {
            InitializeComponent();
        }

        private void llenarDeptos()
        {
            carga = false;
            using SAESoftContext db = new();
            cboDepto.DataSource = db.DeptoIncentivo.ToList();
            cboDepto.DisplayMember = "Nombre";
            cboDepto.ValueMember = "IdDepto";
            carga = true;
        }

        private void llenarEmpleados()
        {
            if (carga)
            {
                using SAESoftContext db = new();
                cboEmpleado.DataSource = db.EmpIncentivos.Where(d => d.IdDepto == Convert.ToInt32(cboDepto.SelectedValue)).Select(d => new
                {
                    NombreCompleto = d.Apellidos + ", " + d.Nombres,
                    d.IdEmpIncentivo
                }).OrderBy(d => d.NombreCompleto).ToList();
                cboEmpleado.DisplayMember = "NombreCompleto";
                cboEmpleado.ValueMember = "IdEmpIncentivo";
            }
        }

        private void frmSuspensiones_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "SUSPENSION");
            llenarDeptos();
        }

        private void cboDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEmpleados();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            cboDepto.Focus();
        }

        private void frmSuspensiones_Shown(object sender, EventArgs e)
        {
            llenarEmpleados();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        Suspension suspension = new()
                        {
                            IdDepto = Convert.ToInt32(cboDepto.SelectedValue),
                            IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue),
                            FechaInicio = dtpInicio.Value.Date,
                            FechaFin = dtpFin.Value.Date,
                            Observaciones = txtObs.Text,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Suspensiones.Add(suspension);
                        db.SaveChanges();
                        rs.Add(suspension);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Empleado Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Suspension temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].FechaInicio = dtpInicio.Value.Date;
                        rs[CurrentIndex].FechaFin = dtpFin.Value.Date;
                        rs[CurrentIndex].Observaciones = txtObs.Text;
                        rs[CurrentIndex].Activo = tsActivo.Checked;
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Suspensiones.Update(rs[CurrentIndex]);
                        db.SaveChanges();
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "SUSPENSION");
                habilitarFormulario(this, false);
            }
        }

        private void despliegaDatos()
        {
            cboDepto.SelectedValue = rs[CurrentIndex].IdDepto;
            cboEmpleado.SelectedValue = rs[CurrentIndex].IdEmpleado;
            dtpInicio.Value = rs[CurrentIndex].FechaInicio;
            dtpFin.Value = rs[CurrentIndex].FechaFin;
            txtObs.Text = rs[CurrentIndex].Observaciones;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtObs.Text == "")
            {
                errorProvider1.SetError(txtObs, "No puede estar vacío.");
                txtObs.Focus();
                return false;
            }
            if (dtpFin.Value.Date <= dtpInicio.Value.Date)
            {
                errorProvider1.SetError(dtpFin, "La fecha de fin no puede ser anterior a la fecha de inicio.");
                dtpFin.Focus();
                return false;
            }
            return true;
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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using SAESoftContext db = new();
            var queryable = db.Suspensiones.Where(b => 1 == 1);
            //if (buscar.codigo != null)
            //    queryable = queryable.Where(b => b.Codigo == buscar.codigo);
            //buscar.Dispose();
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "SUSPENSION");
            }
            else
            {
                MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarFormulario(this);
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "SUSPENSION");
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            dtpInicio.Enabled = true;
            dtpFin.Enabled = true;
            txtObs.Enabled = true;
            tsActivo.Enabled = true;
            dtpInicio.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "SUSPENSION");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "SUSPENSION");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "SUSPENSION");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }
    }
}
