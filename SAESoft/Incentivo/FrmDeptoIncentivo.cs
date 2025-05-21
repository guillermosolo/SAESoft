using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.Constantes;
using static SAESoft.Cache.UserData;
using SAESoft.Comunes;
using SAESoft.Utilitarios;
using SAESoft.Models.Administracion;
using SAESoft.Models.AdministracionSistema;

namespace SAESoft.Incentivo
{
    public partial class FrmDeptoIncentivo : Form
    {
        private Boolean esNuevo = true;
        private List<GrupoDeptoIncentivo>? rs = [];
        private readonly List<int> jefes = [IdSuperAdmin, JefeDeptoIncentivo];

        private int CurrentIndex = 0;
        readonly DataTable dt = new();

        public FrmDeptoIncentivo()
        {
            InitializeComponent();
        }

        private void EstructuraGrid()
        {
            dt.Columns.Add("IdDeptoIncentivo").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dt.Columns.Add("Activo").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Encargado").DataType = Type.GetType("System.String");
            dt.Columns.Add("Creación").DataType = Type.GetType("System.DateTime");

            dgvDeptos.DataSource = dt;

            dgvDeptos.Columns["IdDeptoIncentivo"].Visible = false;
            dgvDeptos.Columns["Nombre"].Width = 175;
            dgvDeptos.Columns["Activo"].Width = 75;
            dgvDeptos.Columns["Encargado"].Width = 150;
        }

        private void llenarCombo()
        {
            using SAESoftContext db = new();
            cboEncargado.DataSource = db.Usuarios.Where(a => a.Activo && jefes.Contains(a.IdRol)).ToList();
            cboEncargado.DisplayMember = "NombreCompleto";
            cboEncargado.ValueMember = "IdUsuario";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDeptoIncentivo_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "DEPARTAMENTOS");
            EstructuraGrid();
            llenarCombo();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using frmBuscarDepto buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.GrupoDeptoIncentivo
                                  .Include(b => b.Encargado)
                                  .Include(b => b.Departamentos)
                                  .ThenInclude(d => d.Encargado)
                                  .AsQueryable();
                if (!string.IsNullOrWhiteSpace(buscar.NombreDepto))
                    queryable = queryable.Where(b => b.Nombre.Contains(buscar.NombreDepto));
                if (buscar.IdEncargado != 0)
                    queryable = queryable.Where(b => b.IdUsuario == buscar.IdEncargado);
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], true, toolStrip1, "DEPARTAMENTOS");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], false, toolStrip1, "DEPARTAMENTOS");
                }
            }
        }

        private void despliegaDatos()
        {
            txtId.Text = rs[CurrentIndex].IdGrupo.ToString();
            txtNombres.Text = rs[CurrentIndex].Nombre;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            cboEncargado.SelectedValue = rs[CurrentIndex].IdUsuario;

            llenarDeptos();

            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void llenarDeptos()
        {
            dt.Clear();
            foreach (var depto in rs[CurrentIndex].Departamentos)
            {
                DataRow row = dt.NewRow();
                row["IdDeptoIncentivo"] = depto.IdDepto;
                row["Nombre"] = depto.Nombre;
                row["Activo"] = depto.Activo;
                row["Encargado"] = depto.IdUsuario == IdSuperAdmin ? rs[CurrentIndex].Encargado.NombreCompleto : depto.Encargado.NombreCompleto;
                row["Creación"] = depto.FechaCreacion.Date;
                dt.Rows.Add(row);
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            dt.Clear();
            limpiarFormulario(this);
            txtNombres.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], true, toolStrip1, "DEPARTAMENTOS");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], true, toolStrip1, "DEPARTAMENTOS");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], false, toolStrip1, "DEPARTAMENTOS");
                limpiarFormulario(this);
            }

            habilitarFormulario(this, false);
        }

        private void tsbAgregarDeptos_Click(object sender, EventArgs e)
        {
            using frmAgregaSubDepto sub = new()
            {
                grupo = rs[CurrentIndex]
            };

            var resp = sub.ShowDialog();
            if (resp == DialogResult.OK)
            {
                rs[CurrentIndex].Departamentos.Add(sub.depto);
                llenarDeptos();
            }
        }

        private void dgvDeptos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idDepto = Convert.ToInt32(dgvDeptos.Rows[e.RowIndex].Cells["IdDeptoIncentivo"].Value);
            DeptoIncentivo deptoOrigin = (DeptoIncentivo)rs[CurrentIndex].Departamentos.Where(d => d.IdDepto == idDepto).First();
            using frmAgregaSubDepto sub = new()
            {
                grupo = rs[CurrentIndex],
                depto = deptoOrigin
            };
            var resp = sub.ShowDialog();
            if (resp == DialogResult.OK)
            {
                if (deptoOrigin != sub.depto)
                {
                    deptoOrigin.Nombre = sub.depto.Nombre;
                    deptoOrigin.Activo = sub.depto.Activo;
                    deptoOrigin.IdUsuario = sub.depto.IdUsuario;
                    deptoOrigin.Encargado = sub.depto.Encargado;
                }
                llenarDeptos();
            }
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                using SAESoftContext db = new();
                if (esNuevo)
                {
                    try
                    {
                        GrupoDeptoIncentivo depto = new()
                        {
                            Nombre = txtNombres.Text,
                            Activo = tsActivo.Checked,
                            IdUsuario = Convert.ToInt32(cboEncargado.SelectedValue),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                            FechaCreacion = DatosServer.FechaServer(),
                            Departamentos = [],
                        };
                        db.GrupoDeptoIncentivo.Add(depto);
                        db.SaveChanges();
                        depto.Encargado = cboEncargado.SelectedItem as Usuario;
                        rs.Add(depto);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Departamento Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    GrupoDeptoIncentivo temp = rs[CurrentIndex];
                    try
                    {
                        rs[CurrentIndex].Nombre = txtNombres.Text;
                        rs[CurrentIndex].IdUsuario = Convert.ToInt32(cboEncargado.SelectedValue);
                        rs[CurrentIndex].Activo = tsActivo.Checked;
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        db.SaveChanges();
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar","tsbAgregarDeptos"], true, toolStrip1, "DEPARTAMENTOS");
                habilitarFormulario(this, false);
            }
        }

        private Boolean ValidaDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "Campo requerido");
                txtNombres.Focus();
                return false;
            }
            return true;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("¿Está seguro de eliminar el registro? \n Esto eliminará todos los subdepartamentos asociados.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using SAESoftContext db = new();
                try
                {
                    db.DeptoIncentivo.RemoveRange(rs[CurrentIndex].Departamentos);
                    db.GrupoDeptoIncentivo.Remove(rs[CurrentIndex]);
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
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar", "tsbAgregarDeptos"], false, toolStrip1, "DEPARTAMENTOS");
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

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombres.Focus();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            using frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.GrupoDeptoIncentivo.Include(p => p.Departamentos).Select(p => new { p.IdGrupo, p.Nombre, Departamentos = string.Join(", ", p.Departamentos.Select(d => d.Nombre)) }).OrderBy(p => p.Nombre ).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = [.. db.GrupoDeptoIncentivo.Include(b => b.Encargado)
                                               .Include(b => b.Departamentos)
                                               .ThenInclude(d => d.Encargado)
                                               .Where(p => p.IdGrupo == formListar.Id)];
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar","tsbAgregarDeptos"], true, toolStrip1, "DEPARTAMENTOS");
            }
        }
    }
}
