using SAESoft.Models;
using SAESoft.Models.Incentivos;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.AdministracionSistema.Comunes;
using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Models.Comunes;
using SAESoft.Utilitarios;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Incentivo
{
    public partial class frmEmpIncentivo : Form
    {
        private Boolean esNuevo = true;
        private List<EmpIncentivos>? rs = new();
        private int CurrentIndex = 0;
        public frmEmpIncentivo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmpIncentivo_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
            llenarCombos();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboDepto.DataSource = db.DeptoIncentivo.ToList();
            cboDepto.DisplayMember = "Nombre";
            cboDepto.ValueMember = "IdDepto";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.EmpIncentivos.Where(b => 1 == 1);
                if (buscar.codigo != null)
                    queryable = queryable.Where(b => b.Codigo == buscar.codigo);
                //if (buscar.grupo != -1)
                //    queryable = queryable.Where(b => b.IdGrupo == buscar.grupo);
                buscar.Dispose();
                rs = queryable.ToList();
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
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "EMPLEADOSINCENTIVO");
                }
            }
        }

        private void despliegaDatos()
        {
            txtCodigo.Text = rs?[CurrentIndex].Codigo;
            txtNombres.Text = rs?[CurrentIndex].Nombres;
            txtApellidos.Text = rs?[CurrentIndex].Apellidos;
            txtBaseCalculo.Text = rs?[CurrentIndex].BaseCalculo.ToString("N2");
            cboDepto.SelectedValue = rs[CurrentIndex].IdDepto;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
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

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.EmpIncentivos.Include(p => p.DeptoIncentivos).Select(p => new { p.IdEmpIncentivo, p.Codigo, p.Nombres, p.Apellidos, Departamento = p.DeptoIncentivos.Nombre }).OrderBy(p => p.Departamento).ThenBy(p => p.Apellidos).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = db.EmpIncentivos.Where(p => p.IdEmpIncentivo == formListar.Id).ToList();
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
            }
            formListar.Dispose();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using SAESoftContext db = new();
                try
                {
                    db.EmpIncentivos.Remove(rs[CurrentIndex]);
                    db.SaveChanges();
                    rs.Remove(rs[CurrentIndex]);
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
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "EMPLEADOSINCENTIVO");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "EMPLEADOSINCENTIVO");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            txtCodigo.Focus();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtCodigo.Focus();
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
                        EmpIncentivos empleado = new()
                        {
                            Codigo = txtCodigo.Text,
                            Nombres = txtNombres.Text,
                            Apellidos = txtApellidos.Text,
                            BaseCalculo = Convert.ToDecimal(txtBaseCalculo.Text),
                            IdDepto = Convert.ToInt32(cboDepto.SelectedValue),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.EmpIncentivos.Add(empleado);
                        db.SaveChanges();
                        rs.Add(empleado);
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
                    EmpIncentivos temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Codigo = txtCodigo.Text;
                        rs[CurrentIndex].Nombres = txtNombres.Text;
                        rs[CurrentIndex].Apellidos = txtApellidos.Text;
                        rs[CurrentIndex].BaseCalculo = Convert.ToDecimal(txtBaseCalculo.Text);
                        rs[CurrentIndex].IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.EmpIncentivos.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "EMPLEADOSINCENTIVO");
                habilitarFormulario(this, false);
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo, "No puede estar vacío.");
                txtCodigo.Focus();
                return false;
            }
            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "No puede estar vacío.");
                txtApellidos.Focus();
                return false;
            }
            if (cboDepto.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboDepto, "No puede estar vacío.");
                cboDepto.Focus();
                return false;
            }
            return true;
        }

        private void txtBaseCalculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }
    }
}
