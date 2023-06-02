
using static SAESoft.Utilitarios.ControlFormularios;
using SAESoft.Utilitarios;
using SAESoft.Models.Administracion;
using Microsoft.EntityFrameworkCore;
using static SAESoft.Cache.UserData;
using SAESoft.Models;
using System.Data;
using Microsoft.EntityFrameworkCore.Storage;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SAESoft.Administracion
{
    public partial class frmPersonal : Form
    {
        private Boolean esNuevo = false;
        public int individual = 0;
        private List<Empleado>? rs = new();
        private int CurrentIndex = 0;
        readonly DataTable dt = new();
        private bool isLoadingcboEmpresa = false;

        public frmPersonal()
        {
            InitializeComponent();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdFamiliar").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dt.Columns.Add("Parentesco").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Nacimiento").DataType = Type.GetType("System.DateTime");
            dgvFamiliares.DataSource = dt;
            dgvFamiliares.Columns["IdFamiliar"].Visible = false;
            dgvFamiliares.Columns[1].Width = 250;
            dgvFamiliares.Columns[2].Width = 160;
            dgvFamiliares.Columns[3].Width = 130;

            dgvFamiliares.ClearSelection();
        }

        public void llenarCombos()
        {
            isLoadingcboEmpresa = true;
            llenarNombres(cboEmpresa, "PLANTA");
            isLoadingcboEmpresa = false;
            llenarDepto(Convert.ToInt32(cboEmpresa.SelectedValue));
        }

        public void llenarDepto(int empresa)
        {
            using SAESoftContext db = new();
            cboDepartamento.DataSource = db.DepartamentosInternos.Where(d => d.IdEmpresa == empresa).Select(c => new { c.IdDepto, c.Nombre }).ToList();
            cboDepartamento.DisplayMember = "Nombre";
            cboDepartamento.ValueMember = "IdDepto";
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "PERSONAL");
            llenarCombos();
            estructuraGrid();
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
            limpiarFormulario(this);
            txtCodigo.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbComentarios", "tsbPago", "tsbRelatives" }, true, toolStrip1, "PERSONAL");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbComentarios", "tsbPago", "tsbRelatives" }, true, toolStrip1, "PERSONAL");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbComentarios", "tsbPago", "tsbRelatives" }, false, toolStrip1, "PERSONAL");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void despliegaDatos()
        {
            txtId.Text = rs[CurrentIndex].IdEmpleado.ToString();
            txtCodigo.Text = rs[CurrentIndex].Codigo;
            cboEmpresa.SelectedValue = rs[CurrentIndex].Departamento.IdEmpresa;
            cboDepartamento.SelectedValue = rs[CurrentIndex].IdDepto;
            txtNombres.Text = rs[CurrentIndex].Nombres;
            txtApellidos.Text = rs[CurrentIndex].Apellidos;
            txtNombreESP.Text = rs[CurrentIndex].Alias;
            txtNombreCOR.Text = rs[CurrentIndex].NombreCoreano;
            dtpFechaNac.Value = rs[CurrentIndex].FechaNac;
            tsCuotaAnual.Checked = rs[CurrentIndex].CuotaAnual;
            tsBoletoOrnato.Checked = rs[CurrentIndex].BoletoOrnato;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            if (rs[CurrentIndex].Familiares!=null)
                despliegaFamilia();
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void despliegaFamilia()
        {
            DataRow row;
            dt.Clear();
            foreach (var fam in rs[CurrentIndex].Familiares)
            {
                row = dt.NewRow();
                row[0] = fam.IdFamiliar;
                row[1] = fam.Nombres + " " + fam.Apellidos;
                row[2] = fam.Parentesco.Descripcion;
                row[3] = fam.FechaNac;
                dt.Rows.Add(row);
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtCodigo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCodigo, "No puede estar vacío.");
                txtCodigo.Focus();
                return false;
            }
            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombres, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidos, "No puede estar vacío.");
                txtApellidos.Focus();
                return false;
            }
            if (txtNombreESP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreESP, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (txtNombreCOR.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreCOR, "No puede estar vacío.");
                txtNombreCOR.Focus();
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
                        string genero;
                        if (rdbMasculino.Checked)
                        {
                            genero = "M";
                        }
                        else
                        {
                            genero = "F";
                        }
                        Empleado empleado = new()
                        {
                            Codigo = txtCodigo.Text,
                            IdDepto = Convert.ToInt32(cboDepartamento.SelectedValue),
                            Nombres = txtNombres.Text,
                            Apellidos = txtApellidos.Text,
                            Alias = txtNombreESP.Text,
                            NombreCoreano = txtNombreCOR.Text,
                            FechaNac = dtpFechaNac.Value.Date,
                            CuotaAnual = tsCuotaAnual.Checked,
                            BoletoOrnato = tsBoletoOrnato.Checked,
                            Activo = tsActivo.Checked,
                            Genero = genero,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Empleados.Add(empleado);
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
                    Empleado temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Codigo = txtCodigo.Text;
                        rs[CurrentIndex].Nombres = txtNombres.Text;
                        rs[CurrentIndex].Apellidos = txtApellidos.Text;
                        rs[CurrentIndex].Alias = txtNombreESP.Text;
                        rs[CurrentIndex].NombreCoreano = txtNombreCOR.Text;
                        rs[CurrentIndex].FechaNac = dtpFechaNac.Value.Date;
                        rs[CurrentIndex].CuotaAnual = tsCuotaAnual.Checked;
                        rs[CurrentIndex].BoletoOrnato = tsBoletoOrnato.Checked;
                        rs[CurrentIndex].Activo = tsActivo.Checked;
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Empleados.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives" }, true, toolStrip1, "PERSONAL");
                habilitarFormulario(this, false);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            // frmBuscarUsuarios buscar = new();
            // DialogResult resp = buscar.ShowDialog();
            var resp = DialogResult.OK;
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.Empleados.Include(d=>d.Departamento)
                                            .Include(f=>f.Familiares)
                                            .ThenInclude(p=>p.Parentesco)
                                            .Where(b => 1 == 1);
                /*    if (buscar.nombre != null)
                        queryable = queryable.Where(b => b.Nombres.Contains(buscar.nombre));
                    if (buscar.apellido != null)
                        queryable = queryable.Where(b => b.Apellidos.Contains(buscar.apellido));
                    if (buscar.usuario != null)
                        queryable = queryable.Where(b => b.UserName.Contains(buscar.usuario));
                    if (buscar.rol != -1)
                        queryable = queryable.Where(b => b.IdRol == buscar.rol);*/
                rs = queryable.ToList();
                //  buscar.Dispose();
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
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives" }, true, toolStrip1, "PERSONAL");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives" }, false, toolStrip1, "PERSONAL");
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

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtCodigo.Focus();
        }

        private void tsbRelatives_Click(object sender, EventArgs e)
        {
            frmFamiliares familia = new();
            var resp = familia.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var parentesco = db.Nombres.Where(p => p.IdNombre == familia.parentesco).FirstOrDefault();
                Familiar familiar = new()
                {
                    IdParentesco = parentesco.IdNombre,
                    IdEmpleado = rs[CurrentIndex].IdEmpleado,
                    Nombres = familia.nombres,
                    Apellidos = familia.apellidos,
                    FechaNac = familia.fecnac,
                    Genero = familia.genero,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                };
                db.Familiares.Add(familiar);
                db.SaveChanges();
                rs[CurrentIndex].Familiares.Add(familiar);
                despliegaDatos();
            }
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
                    db.Familiares.RemoveRange(rs[CurrentIndex].Familiares);
                    db.SaveChanges();
                    db.Empleados.Remove(rs[CurrentIndex]);
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
                        limpiarFormulario(this);
                        dt.Rows.Clear();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives" }, false, toolStrip1, "PERSONAL");
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

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcboEmpresa)
            {
                llenarDepto(Convert.ToInt32(cboEmpresa.SelectedValue));
            }
        }
    }
}
