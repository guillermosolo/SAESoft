using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.Password;
using static SAESoft.Utilitarios.Validaciones;
using static SAESoft.Cache.UserData;
using SAESoft.Comunes;
using System.Text.RegularExpressions;
using System.Windows.Data;
using System.Data;
using Microsoft.VisualBasic;

namespace SAESoft.AdministracionSistema
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = true;
        private List<Usuario>? rs = new List<Usuario>();
        private int CurrentIndex = 0;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            chkActivo.Checked = true;
            txtNombres.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tsbSiguiente", "tsbSalir" };
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
                            Usuario usuario = new Usuario()
                            {
                                Nombres = txtNombres.Text,
                                Apellidos = txtApellidos.Text,
                                Email = txtEmail.Text,
                                UserName = txtUsuario.Text,
                                Password = ComputeHash(txtPassword.Text),
                                IdRol = Convert.ToInt32(cboRoles.SelectedValue),
                                Activo = chkActivo.Checked,
                                FechaCreacion = DateTime.UtcNow,
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            _Contexto.Usuarios.Add(usuario);
                            _Contexto.SaveChanges();
                            rs.Add(usuario);
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
                        }
                    }
                }
                else
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            _Contexto.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            rs[CurrentIndex].Nombres = txtNombres.Text;
                            rs[CurrentIndex].Apellidos = txtApellidos.Text;
                            rs[CurrentIndex].Email = txtEmail.Text;
                            rs[CurrentIndex].UserName = txtUsuario.Text;
                            rs[CurrentIndex].Activo = chkActivo.Checked;
                            if (txtPassword.Text != "xxxxxxxxxxxxx")
                                rs[CurrentIndex].Password = ComputeHash(txtPassword.Text);
                            rs[CurrentIndex].IdRol = Convert.ToInt32(cboRoles.SelectedValue);
                            rs[CurrentIndex].FechaUltimaMod = DateTime.UtcNow;
                            rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                            _Contexto.Usuarios.Update(rs[CurrentIndex]);
                            _Contexto.SaveChanges();
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
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tsbSiguiente", "tsbSalir" };
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
            Regex validarEmail = email_validation();
            if (txtNombres.Text == "")
            {
                MessageBox.Show("El campo Nombres no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return false;
            }
            if (txtNombres.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return false;
            }
            if (!validarEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("El campo Email no es un correo válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("El campo Usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("El campo Password no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        private async void llenarCombos()
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                cboRoles.DataSource = await _Contexto.Roles.ToListAsync();
                cboRoles.DisplayMember = "Nombre";
                cboRoles.ValueMember = "IdRol";
            }
        }

        private void frmUsuarios_Shown(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombres.Focus();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda buscar = new frmBusqueda();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    var queryable = _Contexto.Usuarios.Where(b => 1 == 1);
                    if (buscar.nombre != null)
                        queryable = queryable.Where(b => b.Nombres.Contains(buscar.nombre));
                    if (buscar.apellido != null)
                        queryable = queryable.Where(b => b.Apellidos.Contains(buscar.apellido));
                    if (buscar.usuario != null)
                        queryable = queryable.Where(b => b.UserName.Contains(buscar.usuario));
                    if (buscar.rol != -1)
                        queryable = queryable.Where(b => b.IdRol == buscar.rol);
                    rs = queryable.ToList();
                    if (rs.Count > 0)
                    {
                        despliegaDatos();
                        if (rs.Count > 1)
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tsbSiguiente", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                            CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1);
                        }
                        else
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                        }
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

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdUsuario.ToString();
            txtNombres.Text = rs?[CurrentIndex].Nombres;
            txtApellidos.Text = rs?[CurrentIndex].Apellidos;
            txtEmail.Text = rs?[CurrentIndex].Email;
            txtUsuario.Text = rs?[CurrentIndex].UserName;
            txtPassword.Text = "xxxxxxxxxxxxx";
            cboRoles.SelectedItem = rs?[CurrentIndex].IdRol;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            chkActivo.Checked = rs[CurrentIndex].Activo;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
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

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioLogged?.IdUsuario == rs?[CurrentIndex].IdUsuario)
            {
                MessageBox.Show("No puede borrar el usuario activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                            _Contexto.Usuarios.Remove(rs[CurrentIndex]);
                            _Contexto.SaveChanges();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                            rs.Remove(rs[CurrentIndex]);
                            if (rs.Count > 0)
                            {
                                if (rs.Count > 1)
                                {
                                    CurrentIndex--;
                                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior", "tsbSiguiente", "tsbSalir" };
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
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new frmListar();
            using (DB_Context _Contexto = new DB_Context())
            {
                var lista = _Contexto.Usuarios.Include(p => p.Rol).Select(p => new { p.IdUsuario,p.Nombres, p.Apellidos,Usuario= p.UserName, p.Activo,Rol= p.Rol.Nombre }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    rs = _Contexto.Usuarios.Where(p => p.IdUsuario == formListar.Id).ToList();
                    CurrentIndex = 0;
                    despliegaDatos();
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                }
            }
        }
    }
}
