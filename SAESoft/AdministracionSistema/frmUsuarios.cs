using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.Password;
using static SAESoft.Utilitarios.Validaciones;
using static SAESoft.Cache.UserData;
using SAESoft.Comunes;
using System.Text.RegularExpressions;
using System.Data;
using SAESoft.Utilitarios;

namespace SAESoft.AdministracionSistema
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = false;
        private List<Usuario>? rs = new List<Usuario>();
        private int CurrentIndex = 0;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            tsActivo.Checked = true;
            txtNombres.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"USUARIOS");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"USUARIOS");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1,"USUARIOS");
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
                    using (SAESoftContext db = new SAESoftContext())
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
                                Activo = tsActivo.Checked,
                                FechaCreacion = DatosServer.FechaServer(),
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            db.Usuarios.Add(usuario);
                            db.SaveChanges();
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
                            return;
                        }
                    }
                }
                else
                {
                    Usuario temp = rs[CurrentIndex];
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        try
                        {
                            db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            rs[CurrentIndex].Nombres = txtNombres.Text;
                            rs[CurrentIndex].Apellidos = txtApellidos.Text;
                            rs[CurrentIndex].Email = txtEmail.Text;
                            rs[CurrentIndex].UserName = txtUsuario.Text;
                            rs[CurrentIndex].Activo = tsActivo.Checked;
                            if (txtPassword.Text != "xxxxxxxxxxxxx")
                                rs[CurrentIndex].Password = ComputeHash(txtPassword.Text);
                            rs[CurrentIndex].IdRol = Convert.ToInt32(cboRoles.SelectedValue);
                            rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                            rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                            db.Usuarios.Update(rs[CurrentIndex]);
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
                }
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "USUARIOS");
                habilitarFormulario(this, false);
            }
        }

        private Boolean ValidarDatos()
        {
            Regex validarEmail = email_validation();
            errorProvider1.Clear();
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
            if (!validarEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "No es un correo válido.");
                txtEmail.Focus();
                return false;
            }
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "No puede estar vacío.");
                txtUsuario.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "No puede estar vacío.");
                txtPassword.Focus();
                return false;
            }
            if (cboRoles.SelectedIndex== -1)
            {
                errorProvider1.SetError(cboRoles, "No puede estar vacío.");
                cboRoles.Focus();
                return false;
            }
            return true;
        }
        private void llenarCombos()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                cboRoles.DataSource = db.Roles.ToList();
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
            frmBuscarUsuarios buscar = new frmBuscarUsuarios();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    var queryable = db.Usuarios.Where(b => 1 == 1);
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
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            BotonesIniciales(toolStrip1);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "USUARIOS");
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "USUARIOS");
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
            cboRoles.SelectedValue= rs?[CurrentIndex].IdRol;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
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
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        try
                        {
                            db.Usuarios.Remove(rs[CurrentIndex]);
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
                                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "USUARIOS");
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
            }
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new frmListar();
            using (SAESoftContext db = new SAESoftContext())
            {
                var lista = db.Usuarios.Include(p => p.Rol).Select(p => new {p.IdUsuario,p.Nombres, p.Apellidos,Usuario= p.UserName, p.Activo,Rol= p.Rol.Nombre }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    rs = db.Usuarios.Where(p => p.IdUsuario == formListar.Id).ToList();
                    CurrentIndex = 0;
                    despliegaDatos();
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "USUARIOS");
                }
            }
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
                lblActivo.Text = "Activo";
            else
                lblActivo.Text = "Inactivo";
        }

        private void cboRoles_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!((Rol)cboRoles.Items[e.Index]).Habilitado)
            {
                e.Graphics.DrawString(((Rol)cboRoles.Items[e.Index]).Nombre, cboRoles.Font, Brushes.LightSlateGray, e.Bounds);
            } else
            {
                e.DrawBackground();
                e.Graphics.DrawString(((Rol)cboRoles.Items[e.Index]).Nombre, cboRoles.Font,Brushes.Black,e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!((Rol)cboRoles.SelectedItem).Habilitado)
                cboRoles.SelectedIndex = -1;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "USUARIOS");
        }
    }
}
