using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Models;
using SAESoft.Utilitarios;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.Models.Comunes;

namespace SAESoft.AdministracionSistema.Comunes
{
    public partial class frmGrupos : Form
    {
        private Boolean esNuevo = true;
        private List<Grupo>? rs = [];
        private int CurrentIndex = 0;
        public frmGrupos()
        {
            InitializeComponent();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboModulo.DataSource = db.Modulos.ToList();
            cboModulo.DisplayMember = "Nombre";
            cboModulo.ValueMember = "IdModulo";
        }
        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdGrupo.ToString();
            txtNombre.Text = rs?[CurrentIndex].Nombre;
            cboModulo.SelectedValue = rs[CurrentIndex].IdModulo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using frmBuscarGrupos buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.Grupos.AsQueryable();
                if (buscar.nombre != null)
                    queryable = queryable.Where(b => b.Nombre.Contains(buscar.nombre));
                if (buscar.modulo != -1)
                    queryable = queryable.Where(b => b.IdModulo == buscar.modulo);
          
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "GRUPOS");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "GRUPOS");
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

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "GRUPOS");
        }

        private void frmGrupos_Shown(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            using frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.Grupos.Include(p => p.Modulo).Select(p => new { p.IdGrupo, p.Nombre, Modulo = p.Modulo.Nombre }).OrderBy(p => p.Modulo).ThenBy(p => p.Nombre).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = [.. db.Grupos.Where(p => p.IdGrupo == formListar.Id)];
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "GRUPOS");
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "GRUPOS");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "GRUPOS");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "GRUPOS");
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
            limpiarFormulario(this);
            txtNombre.Focus();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using SAESoftContext db = new();
                try
                {
                    db.Grupos.Remove(rs[CurrentIndex]);
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
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "GRUPOS");
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

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using SAESoftContext db = new();
                    try
                    {
                        Grupo grupo = new()
                        {
                            Nombre = txtNombre.Text,
                            IdModulo = Convert.ToInt32(cboModulo.SelectedValue),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Grupos.Add(grupo);
                        db.SaveChanges();
                        rs.Add(grupo);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Grupo Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Grupo temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Nombre = txtNombre.Text;
                        rs[CurrentIndex].IdModulo = Convert.ToInt32(cboModulo.SelectedValue);
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Grupos.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "GRUPOS");
                habilitarFormulario(this, false);
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No puede estar vacío.");
                txtNombre.Focus();
                return false;
            }
            if (cboModulo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboModulo, "No puede estar vacío.");
                cboModulo.Focus();
                return false;
            }
            return true;
        }
    }
}
