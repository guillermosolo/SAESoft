using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Utilitarios;
using System.Text.RegularExpressions;

namespace SAESoft.AdministracionSistema
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            String[] botones = { "tsbAceptar","tsbCancelar" };
            ControlFormularios.CambiarVisibilidadBotones(botones,toolStrip1, true);
            ControlFormularios.habilitarFormulario(this, true);
            ControlFormularios.limpiarFormulario(this);
            chkActivo.Checked = true;
            txtNombres.Focus();
            
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            String[] botones = { "tsbAceptar","tsbCancelar","tsbAnterior","tsbSiguiente"};
            ControlFormularios.CambiarVisibilidadBotones(botones, toolStrip1, false);
            ControlFormularios.habilitarFormulario(this,false);
            ControlFormularios.limpiarFormulario(this);
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    try
                    {
                        Usuario usuario = new Usuario();
                        usuario.Nombres = txtNombres.Text;
                        usuario.Apellidos = txtApellidos.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.UserName = txtUsuario.Text;
                        usuario.Password = Password.ComputeHash(txtPassword.Text);
                        usuario.IdRol = (int)cboRoles.SelectedValue;
                        usuario.Activo = chkActivo.Checked;
                        usuario.FechaCreacion = DateTime.UtcNow;
                        _Contexto.Usuarios.Add(usuario);
                        _Contexto.SaveChanges();
                        MessageBox.Show("Usuario Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String[] botones = { "tsbAceptar", "tsbCancelar", "tsbAnterior", "tsbSiguiente" };
                        ControlFormularios.CambiarVisibilidadBotones(botones, toolStrip1, false);
                        ControlFormularios.habilitarFormulario(this, false);
                        ControlFormularios.limpiarFormulario(this);
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Boolean ValidarDatos()
        {
            Regex validarEmail = Validaciones.email_validation();
            if (txtNombres.Text == "")
            {
                MessageBox.Show("El campo Nombres no puede estar vacío.","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
