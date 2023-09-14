
using SAESoft.Models.Administracion;
using System.Windows.Forms;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmPermisoTrabajo : Form
    {
        public int tipo;
        public string resolucion;
        public DateTime inicio;
        public DateTime vencimiento;
        public frmPermisoTrabajo()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                tipo = Convert.ToInt32(cboTipo.SelectedValue);
                resolucion = txtResolucion.Text;
                vencimiento = dtpVencimiento.Value.Date;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtResolucion.Text))
            {
                errorProvider1.SetError(txtResolucion, "No puede estar vacío.");
                txtResolucion.Focus();
                return false;
            }
            if (dtpInicio.Value.Date >= dtpVencimiento.Value.Date)
            {
                errorProvider1.SetError(dtpVencimiento, "Fecha de vencimiento no válida.");
                dtpVencimiento.Focus();
                return false;
            }
            return true;
        }

        private void frmResidencia_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "PERMISO DE TRABAJO";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarNombres(cboTipo, "PERMISO TRABAJO");
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

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Value = dtpInicio.Value.AddYears(1);
        }
    }
}
