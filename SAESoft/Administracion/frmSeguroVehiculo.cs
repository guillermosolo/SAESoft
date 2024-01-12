
using SAESoft.Models.Administracion;
using SAESoft.Utilitarios;
using System.Text.RegularExpressions;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Administracion
{
    public partial class frmSeguroVehiculo : Form
    {
        public string marca;
        public string color;
        public string placas;
        public int idAseguradora;
        public string poliza;
        public DateTime inicio;
        public DateTime vencimiento;
        public decimal prima;
        public decimal deducible;
        public frmSeguroVehiculo()
        {
            InitializeComponent();
        }

        private void frmSeguroVehiculo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "SEGURO DE VEHÍCULOS";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarNombres(cboAseguradora, "ASEGURADORA");
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

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                marca = txtMarca.Text;
                color = txtColor.Text;
                placas = txtPlacas.Text;
                idAseguradora = Convert.ToInt32(cboAseguradora.SelectedValue);
                poliza = txtPoliza.Text;
                inicio = dtpInicio.Value.Date;
                vencimiento = dtpVencimiento.Value.Date;
                prima = Convert.ToDecimal(txtPrima.Text);
                deducible = Convert.ToDecimal(txtDeducible.Text);
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            Regex placa = Validaciones.plate_validation();
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, "No puede estar vacío.");
                txtMarca.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtColor.Text))
            {
                errorProvider1.SetError(txtColor, "No puede estar vacío.");
                txtColor.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPlacas.Text))
            {
                errorProvider1.SetError(txtPlacas, "No puede estar vacío.");
                txtPlacas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPoliza.Text))
            {
                errorProvider1.SetError(txtPoliza, "No puede estar vacío.");
                txtPoliza.Focus();
                return false;
            }
            if (!placa.IsMatch(txtPlacas.Text))
            {
                errorProvider1.SetError(txtPlacas, "Número de placa incorrecto.");
                txtPlacas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrima.Text))
            {
                errorProvider1.SetError(txtPrima, "No puede estar vacío.");
                txtPrima.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDeducible.Text))
            {
                errorProvider1.SetError(txtDeducible, "No puede estar vacío.");
                txtDeducible.Focus();
                return false;
            }
            return true;
        }

        private void txtPrima_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }

        private void txtDeducible_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }
    }
}
