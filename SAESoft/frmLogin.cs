using SAESoft.Models;
using System.Runtime.InteropServices;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.Password;
using static SAESoft.Utilitarios.ControlFormularios;
using Microsoft.EntityFrameworkCore;
using SAESoft.Utilitarios;
using System.Xml;

namespace SAESoft
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = new Icon("logo-blue.ico");
        }
        #region Funcionalidades del formulario
        // **********CODIGO PARA HACER QUE SE PUEDA ARRASTAR EL FORMULARIO************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //********* FIN CODIGO ARRASTRAR FORMULARIO***********************
        #endregion

        public Boolean logged = false;
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
            using (SAESoftContext db = new SAESoftContext())
            {
                try
                {
                    usuarioLogged = db.Usuarios.Include(r => r.Rol)
                                                      .Include(r => r.Rol.Permisos)
                                                      .FirstOrDefault(c => c.UserName == txtUser.Text);
                    if (usuarioLogged != null)
                    {
                        if (!ConfirmHash(txtPass.Text, usuarioLogged.Password))
                        {
                            msgError(lblError, "La contraseña no es la correcta.");
                            txtPass.SelectAll();
                            txtPass.Focus();
                            return;
                        }
                        else
                        {
                            if (!usuarioLogged.Activo)
                            {
                                msgError(lblError, "El usuario no se encuentra activo.");
                                ; txtUser.SelectAll();
                                txtUser.Focus();
                                return;
                            }
                        }
                    }
                    else
                    {
                        msgError(lblError, "El usuario no existe en la base de datos.");
                        txtUser.SelectAll();
                        txtUser.Focus();
                        return;
                    }
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
            var path = @"\\192.168.50.37\SAESoft";
            if (DatosServer.ConectarFileServer(path) || logged)
            {
                logged = true; 
            }
            else
            {
                MessageBox.Show("Error al conectarse al servidor de Archivos Compartidos,\r\n" +
                                "Intente de nuevo, si el problema persiste \r\n" +
                                "comuníquese con el Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string appManifestFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName + ".exe.manifest");
            if (System.IO.File.Exists(appManifestFilePath))
            {
                var xml = new XmlDocument();
                xml.Load(appManifestFilePath);
                XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
                nsManager.AddNamespace("asmv1", "urn:schemas-microsoft-com:asm.v1");
                AppVersion = xml.SelectSingleNode("//asmv1:assemblyIdentity", nsManager).Attributes["version"].Value.ToString();
                label2.Text = "Versión " + AppVersion;
            }
        }
    }
}