using SAESoft.Models;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.Password;

namespace SAESoft.CambioPassword
{
    public partial class WFCambioPwd : Form
    {
        public WFCambioPwd()
        {
            InitializeComponent();
        }
        private void WFCambioPwd_Load(object sender, EventArgs e)
        {
            textBox1.Text = usuarioLogged.UserName.ToString();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (validaPwd())
            {
                lblValida.ForeColor = System.Drawing.Color.Green;
                lblValida.Text = "OK";
            }
            else
            {
                lblValida.ForeColor = System.Drawing.Color.Red;
                lblValida.Text = "Inválido";
            }
            if (lblIguales.Text == "OK" && lblValida.Text == "OK")
            {
                iBtnCambio.Enabled = true;
            }
            else
            {
                iBtnCambio.Enabled = false;
            }
        }

        private Boolean validaPwd()
        {

            if (ConfirmHash(textBox2.Text, usuarioLogged.Password))
            {
                return true;
            }
            return false;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox3.Text == textBox4.Text)
            {
                lblIguales.ForeColor = System.Drawing.Color.Green;
                lblIguales.Text = "OK";
            }
            else
            {
                lblIguales.ForeColor = System.Drawing.Color.Red;
                lblIguales.Text = "No Coinciden";
            }
            if (lblIguales.Text == "OK" && lblValida.Text == "OK")
            {
                iBtnCambio.Enabled = true;
            }
            else
            {
                iBtnCambio.Enabled = false;
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (textBox3.Text == textBox4.Text)
                {
                    lblIguales.ForeColor = System.Drawing.Color.Green;
                    lblIguales.Text = "OK";
                }
                else
                {
                    lblIguales.ForeColor = System.Drawing.Color.Red;
                    lblIguales.Text = "No Coinciden";
                }
                if (lblIguales.Text == "OK" && lblValida.Text == "OK")
                {
                    iBtnCambio.Enabled = true;
                }
                else
                {
                    iBtnCambio.Enabled = false;
                }
            }
        }

        private void iBtnCambio_Click(object sender, EventArgs e)
        {
            using var _Contexto = new SAESoftContext();
            int idUsuario = usuarioLogged.IdUsuario;
            var usuarioEnviar = _Contexto.Usuarios.FirstOrDefault(a => a.IdUsuario == idUsuario);
            usuarioEnviar.Password = ComputeHash(textBox3.Text);
            _Contexto.SaveChanges();
            MessageBox.Show("Contraseña modifacada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lblIguales.Text = "";
            lblValida.Text = "";
            iBtnCambio.Enabled = false;
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
