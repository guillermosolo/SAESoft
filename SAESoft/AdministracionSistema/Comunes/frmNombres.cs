using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Utilitarios;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.Models.Comunes;

namespace SAESoft.AdministracionSistema.Comunes
{
    public partial class frmNombres : Form
    {
        private Boolean esNuevo = true;
        private List<Nombre>? rs = [];
        private int CurrentIndex = 0;
        public frmNombres()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNombres_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "NOMBRES");
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboGrupo.DataSource = db.Grupos.ToList();
            cboGrupo.DisplayMember = "Nombre";
            cboGrupo.ValueMember = "IdGrupo";
        }

        private void frmNombres_Shown(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdNombre.ToString();
            txtNombre.Text = rs?[CurrentIndex].Descripcion;
            cboGrupo.SelectedValue = rs[CurrentIndex].IdGrupo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarNombres buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.Nombres.Where(b => 1 == 1);
                if (buscar.descripcion != null)
                    queryable = queryable.Where(b => b.Descripcion.Contains(buscar.descripcion));
                if (buscar.grupo != -1)
                    queryable = queryable.Where(b => b.IdGrupo == buscar.grupo);
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "NOMBRES");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "NOMBRES");
                }
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
        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.Nombres.Include(p => p.Grupo).Select(p => new { p.IdNombre, p.Descripcion, Grupo = p.Grupo.Nombre }).OrderBy(p => p.Grupo).ThenBy(p => p.Descripcion).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = [.. db.Nombres.Where(p => p.IdNombre == formListar.Id)];
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "NOMBRES");
            }
            formListar.Dispose();
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

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "NOMBRES");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "NOMBRES");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "NOMBRES");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
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
                    db.Nombres.Remove(rs[CurrentIndex]);
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
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "NOMBRES");
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
                        Nombre nombre = new()
                        {
                            Descripcion = txtNombre.Text,
                            IdGrupo = Convert.ToInt32(cboGrupo.SelectedValue),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Nombres.Add(nombre);
                        db.SaveChanges();
                        rs.Add(nombre);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Nombre Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Nombre temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Descripcion = txtNombre.Text;
                        rs[CurrentIndex].IdGrupo = Convert.ToInt32(cboGrupo.SelectedValue);
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Nombres.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "NOMBRES");
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
            if (cboGrupo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboGrupo, "No puede estar vacío.");
                cboGrupo.Focus();
                return false;
            }
            return true;
        }
    }
}
