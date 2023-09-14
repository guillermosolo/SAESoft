
using SAESoft.Models.Administracion;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmContrato : Form
    {
        public int empresa;
        public string numero;
        public frmContrato()
        {
            InitializeComponent();
        }

        private static int CalcularTamañoFuente(string texto)
        {
            int tamañoBase = 20; // Tamaño de fuente base
            int longitudTexto = texto.Length;
            int tamañoFuente = tamañoBase;

            if (longitudTexto > 15)
            {
                tamañoFuente = tamañoBase - ((longitudTexto - 15) * 2); // Reducir el tamaño de fuente en función de la longitud del texto
                if (tamañoFuente < 10) // Limitar el tamaño de fuente mínimo
                {
                    tamañoFuente = 10;
                }
            }

            return tamañoFuente;
        }
        private void frmContrato_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "CONTRATO DE TRABAJO";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarNombres(cboEmpresa, "PLANTA");
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                empresa = Convert.ToInt32(cboEmpresa.SelectedValue);
                numero = txtNumero.Text;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "No puede estar vacío.");
                txtNumero.Focus();
                return false;
            }
            return true;
        }
    }
}
