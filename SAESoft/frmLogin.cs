using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Utilitarios;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace SAESoft
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Funcionalidades del formulario
        // **********CODIGO PARA HACER QUE SE PUEDA ARRASTAR EL FORMULARIO************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //********* FIN CODIGO ARRASTRAR FORMULARIO***********************
        #endregion
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icbLogin_Click(object sender, EventArgs e)
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                Usuario usuarioLogged = _Contexto.Usuarios.FirstOrDefault(c => c.UserName == txtUser.Text);
                if (usuarioLogged != null)
                {
                    if (!Password.ConfirmHash(txtPass.Text, usuarioLogged.Password))
                    {
                        MessageBox.Show("La contraseña no es la correcta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPass.Focus();
                        return;
                    }
                } else
                {
                    MessageBox.Show("El usuario no existe en la base de datos","Información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
            }
            new frmPrincipal().Show();
            this.Hide();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                icbLogin_Click(sender, e);
            }
        }
    }
}