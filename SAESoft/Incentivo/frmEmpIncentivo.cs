using SAESoft.Models;
using SAESoft.Models.Incentivos;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Utilitarios;
using static SAESoft.Utilitarios.Validaciones;
using Microsoft.EntityFrameworkCore.Storage;

namespace SAESoft.Incentivo
{
    public partial class frmEmpIncentivo : Form
    {
        private Boolean esNuevo = true;
        private List<EmpIncentivos>? rs = [];
        private int CurrentIndex = 0;
        readonly DataTable dt = new();
        public frmEmpIncentivo()
        {
            InitializeComponent();
        }

        public void EstructuraGrid()
        {
            dt.Columns.Add("IdHistorial").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Departamento").DataType = Type.GetType("System.String");
            dt.Columns.Add("Desde").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Monto").DataType = Type.GetType("System.String");
            dt.Columns.Add("Autorización").DataType = Type.GetType("System.String");
            dgvHistorial.DataSource = dt;
            dgvHistorial.Columns["IdHistorial"].Visible = false;
            dgvHistorial.Columns["Departamento"].Width = 200;
            dgvHistorial.Columns["Autorización"].Width = 200;
            dgvHistorial.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void frmEmpIncentivo_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "EMPLEADOSINCENTIVO");
            llenarCombos();
            EstructuraGrid();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboDepto.DataSource = db.DeptoIncentivo.Where(a => a.Activo).ToList();
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
                var queryable = db.EmpIncentivos
                                  .Include(b => b.HistIncentivos)
                                  .ThenInclude(d => d.DeptoIncentivos)
                                  .Where(b => 1 == 1);
                if (buscar.codigo != null)
                    queryable = queryable.Where(b => b.Codigo == buscar.codigo);
                //if (buscar.grupo != -1)
                //    queryable = queryable.Where(b => b.IdGrupo == buscar.grupo);
                buscar.Dispose();
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "EMPLEADOSINCENTIVO");
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
            dtpIngreso.Value = rs[CurrentIndex].FechaIngreso;
            if (rs?[CurrentIndex].FechaBaja != null)
            {
                tsActivo.Checked = false;
                dtpBaja.Value = rs?[CurrentIndex].FechaBaja ?? DateTime.Now;
            }
            else
            {
                tsActivo.Checked = true;
            }
           
            despliegaHistorial();
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void despliegaHistorial()
        {
            dt.Clear();
            if (rs[CurrentIndex]?.HistIncentivos != null)
            {
                foreach (HistIncentivos hist in rs[CurrentIndex].HistIncentivos.OrderByDescending(h => h.FechaInicio))
                {
                    DataRow row = dt.NewRow();
                    row["IdHistorial"] = hist.IdHistorial;
                    row["Departamento"] = hist.DeptoIncentivos != null ? hist.DeptoIncentivos.Nombre : string.Empty;
                    row["Desde"] = hist.FechaInicio;
                    row["Monto"] = hist.BaseCalculo.ToString("C2", culture);
                    row["Autorización"] = hist.Autorizacion;
                    dt.Rows.Add(row);
                }
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
                rs = [.. db.EmpIncentivos.Where(p => p.IdEmpIncentivo == formListar.Id)];
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "EMPLEADOSINCENTIVO");
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
                    db.HistorialIncentivos.RemoveRange(rs[CurrentIndex].HistIncentivos);
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
                        dt.Clear();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "EMPLEADOSINCENTIVO");
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "EMPLEADOSINCENTIVO");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "EMPLEADOSINCENTIVO");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            dt.Clear();
            limpiarFormulario(this);
            txtCodigo.Focus();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
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
                    using IDbContextTransaction transaction = db.Database.BeginTransaction();
                    try
                    {
                        EmpIncentivos empleado = new()
                        {
                            Codigo = txtCodigo.Text,
                            Nombres = txtNombres.Text,
                            Apellidos = txtApellidos.Text,
                            BaseCalculo = Convert.ToDecimal(txtBaseCalculo.Text),
                            IdDepto = Convert.ToInt32(cboDepto.SelectedValue),
                            FechaIngreso = dtpIngreso.Value.Date,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.EmpIncentivos.Add(empleado);
                        db.SaveChanges();
                        rs.Add(empleado);
                        string autorizacion = "";
                        var dialogResult = InputBox("Pregunta", "Ingrese el número de Autorización", ref autorizacion);
                        if (dialogResult == DialogResult.OK)
                        {
                            DeptoIncentivo dep = db.DeptoIncentivo.Where(b => b.IdDepto == empleado.IdDepto).FirstOrDefault();
                            HistIncentivos hist = new()
                            {
                                IdDepto = empleado.IdDepto,
                                DeptoIncentivos = dep,
                                IdEmpleado = empleado.IdEmpIncentivo,
                                FechaInicio = empleado.FechaIngreso,
                                BaseCalculo = empleado.BaseCalculo,
                                FechaCreacion = DatosServer.FechaServer(),
                                IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                Autorizacion = autorizacion,
                            };
                            db.HistorialIncentivos.Add(hist);
                            db.SaveChanges();
                        }
                        else
                        {
                            transaction.Rollback();
                            rs.Remove(empleado);
                            return;
                        }
                        transaction.Commit();
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Empleado Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    EmpIncentivos temp = (EmpIncentivos)rs[CurrentIndex].Clone();
                    using SAESoftContext db = new();
                    using IDbContextTransaction transaction = db.Database.BeginTransaction();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Codigo = txtCodigo.Text;
                        rs[CurrentIndex].Nombres = txtNombres.Text;
                        rs[CurrentIndex].Apellidos = txtApellidos.Text;
                        rs[CurrentIndex].BaseCalculo = Convert.ToDecimal(txtBaseCalculo.Text);
                        rs[CurrentIndex].IdDepto = Convert.ToInt32(cboDepto.SelectedValue);
                        rs[CurrentIndex].FechaIngreso = dtpIngreso.Value.Date;
                        if (!tsActivo.Checked)
                        {
                            rs[CurrentIndex].FechaBaja = dtpBaja.Value.Date;
                        } else
                        {
                            rs[CurrentIndex].FechaBaja = null;
                        }
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.EmpIncentivos.Update(rs[CurrentIndex]);
                        db.SaveChanges();
                        if (rs[CurrentIndex].BaseCalculo != temp.BaseCalculo)
                        {
                            string autorizacion = "";
                            var dialogResult = InputBox("Pregunta", "Ingrese el número de Autorización", ref autorizacion);
                            if (dialogResult == DialogResult.OK)
                            {
                                DeptoIncentivo dep = db.DeptoIncentivo.Where(b => b.IdDepto == rs[CurrentIndex].IdDepto).FirstOrDefault();
                                DateTime fechaT = DatosServer.FechaServer();
                                HistIncentivos hist = new()
                                {
                                    IdDepto = rs[CurrentIndex].IdDepto,
                                    DeptoIncentivos = dep,
                                    IdEmpleado = rs[CurrentIndex].IdEmpIncentivo,
                                    FechaInicio = fechaT,
                                    BaseCalculo = rs[CurrentIndex].BaseCalculo,
                                    FechaCreacion = fechaT,
                                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                    Autorizacion = autorizacion,
                                };
                                db.HistorialIncentivos.Add(hist);
                                db.SaveChanges();
                                rs[CurrentIndex].HistIncentivos.Add(hist);
                            }
                            else
                            {
                                transaction.Rollback();
                                rs[CurrentIndex] = temp;
                                return;
                            }
                        }
                        else if (rs[CurrentIndex].IdDepto != temp.IdDepto)
                        {
                            DeptoIncentivo dep = db.DeptoIncentivo.Where(b => b.IdDepto == rs[CurrentIndex].IdDepto).FirstOrDefault();
                            DateTime fechaT = DatosServer.FechaServer();
                            HistIncentivos hist = new()
                            {
                                IdDepto = rs[CurrentIndex].IdDepto,
                                DeptoIncentivos = dep,
                                IdEmpleado = rs[CurrentIndex].IdEmpIncentivo,
                                FechaInicio = fechaT,
                                BaseCalculo = rs[CurrentIndex].BaseCalculo,
                                FechaCreacion = fechaT,
                                IdUsuarioCreacion = usuarioLogged.IdUsuario,
                                Autorizacion = "",
                            };
                            db.HistorialIncentivos.Add(hist);
                            db.SaveChanges();
                            rs[CurrentIndex].HistIncentivos.Add(hist);
                        }
                        transaction.Commit();
                        despliegaDatos();
                    }
                    catch (Exception ex)
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "EMPLEADOSINCENTIVO");
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
            if (!tsActivo.Checked && dtpBaja.Value.Date <= dtpIngreso.Value.Date)
            {
                errorProvider1.SetError(dtpBaja, "La fecha de baja no puede ser anterior a la fecha de ingreso.");
                dtpBaja.Focus();
                return false;
            }
            return true;
        }

        private void txtBaseCalculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
            {
                label7.Visible = false;
                dtpBaja.Visible = false;
            }
            else
            {
                label7.Visible = true;
                dtpBaja.Visible = true;
            }
        }
    }
}
