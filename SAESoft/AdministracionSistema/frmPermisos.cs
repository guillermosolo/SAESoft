using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;

namespace SAESoft.AdministracionSistema
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = true;
        private List<Permiso>? rs = new List<Permiso>();
        private int CurrentIndex = 0;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            txtNombre.Focus();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void llenarCombos()
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                cboModulos.DataSource = _Contexto.Modulos.ToList();
                cboModulos.DisplayMember = "Nombre";
                cboModulos.ValueMember = "IdModulo";
            }
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            Permiso permiso = new Permiso()
                            {
                                Nombre = txtNombre.Text,
                                IdModulo = Convert.ToInt32(cboModulos.SelectedValue),
                                FechaCreacion = DateTime.UtcNow,
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            _Contexto.Permisos.Add(permiso);
                            _Contexto.SaveChanges();
                            rs.Add(permiso);
                            CurrentIndex = rs.Count - 1;
                            despliegaDatos();
                            MessageBox.Show("Usuario Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
                else
                {
                    Permiso temp = rs[CurrentIndex];
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            _Contexto.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            rs[CurrentIndex].Nombre = txtNombre.Text;
                            rs[CurrentIndex].IdModulo = Convert.ToInt32(cboModulos.SelectedValue);
                            rs[CurrentIndex].FechaUltimaMod = DateTime.UtcNow;
                            rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                            _Contexto.Permisos.Update(rs[CurrentIndex]);
                            _Contexto.SaveChanges();
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
                }
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                }
                else
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
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
            return true;
        }

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdPermiso.ToString();
            txtNombre.Text = rs?[CurrentIndex].Nombre;
            cboModulos.SelectedValue = rs?[CurrentIndex].IdModulo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
                }
                else
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
                }
            }
            else
            {
                String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                CambiarVisibilidadBotones(botones, toolStrip1, true);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1);
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
                DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            _Contexto.Permisos.Remove(rs[CurrentIndex]);
                            _Contexto.SaveChanges();
                            rs.Remove(rs[CurrentIndex]);
                            if (rs.Count > 0)
                            {
                                if (rs.Count > 1)
                                {
                                    CurrentIndex--;
                                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbSalir" };
                                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                                }
                                else
                                {
                                    CurrentIndex = 0;
                                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                                }
                                despliegaDatos();
                            }
                            else
                            {
                                limpiarFormulario(this);
                                String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                                CambiarVisibilidadBotones(botones, toolStrip1, true);
                                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1);
                            }
                        }
                        catch (DbUpdateException ex)
                        {
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new frmListar();
            using (DB_Context _Contexto = new DB_Context())
            {
                var lista = _Contexto.Permisos.Include(p => p.Modulo).Select(p => new { p.IdPermiso, p.Nombre,Módulo = p.Modulo.Nombre }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    rs = _Contexto.Permisos.Where(p => p.IdPermiso == formListar.Id).ToList();
                    CurrentIndex = 0;
                    despliegaDatos();
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPermisos buscar = new frmBuscarPermisos();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    var queryable = _Contexto.Permisos.Where(b => 1 == 1);
                    if (buscar.nombre != null)
                        queryable = queryable.Where(b => b.Nombre.Contains(buscar.nombre));
                    if (buscar.modulo != -1)
                        queryable = queryable.Where(b => b.IdModulo == buscar.modulo);
                    rs = queryable.ToList();
                    if (rs.Count > 0)
                    {
                        despliegaDatos();
                        if (rs.Count > 1)
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                        }
                        else
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                        CambiarVisibilidadBotones(botones, toolStrip1, true);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1);
                    }

                }
            }
        }
    }
}
