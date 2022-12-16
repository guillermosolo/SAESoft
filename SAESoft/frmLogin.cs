using SAESoft.Models;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.Password;
using static SAESoft.Utilitarios.ControlFormularios;

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
            lblError.Visible = false;
            using (DB_Context _Contexto = new DB_Context())
            {
                usuarioLogged = _Contexto.Usuarios.FirstOrDefault(c => c.UserName == txtUser.Text);
                if (usuarioLogged != null)
                {
                    if (!ConfirmHash(txtPass.Text, usuarioLogged.Password))
                    {
                       msgError(lblError,"La contraseña no es la correcta.");
                        txtPass.SelectAll();
                        txtPass.Focus();
                        return;
                    } else
                    {
                        if (!usuarioLogged.Activo)
                        {
                            msgError(lblError,"El usuario no se encuentra activo.");
;                           txtUser.SelectAll();
                            txtUser.Focus();
                            return;
                        }
                    }
                } else
                {
                    msgError(lblError, "El usuario no existe en la base de datos.");
                    txtUser.SelectAll();
                    txtUser.Focus();
                    return;
                }
            }
            frmPrincipal mainMenu = new frmPrincipal();
            mainMenu.Show();
            mainMenu.FormClosed += Logout;
            this.Hide();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                icbLogin_Click(sender, e);
            }
        }

        private void Logout(object? sender, FormClosedEventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            lblError.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}