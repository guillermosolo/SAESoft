using SAESoft.Models;

namespace SAESoft.Administracion
{
    public partial class frmSeguroMedico : Form
    {
        public int idEmpleado;
        public int familiar;
        public string carnet;
        public string certificado;
        public DateTime inicio;
        public DateTime fin;
        public frmSeguroMedico()
        {
            InitializeComponent();
        }

        private void frmSeguroMedico_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "SEGURO MÉDICO";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarCombo();
            establecerFechas();
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

        private void llenarCombo()
        {
            using SAESoftContext db = new();
            var listado = db.Familiares.Where(f => f.IdEmpleado == idEmpleado).OrderBy(f => f.Nombres).Select(f => new { f.IdFamiliar, f.NombreCompleto }).ToList();
            listado.Insert(0, new { IdFamiliar = 0, NombreCompleto = "(NINGUNO)" });
            cboFamiliar.DataSource = listado;
            cboFamiliar.DisplayMember = "NombreCompleto";
            cboFamiliar.ValueMember = "IdFamiliar";
        }

        private void establecerFechas()
        {
            DateTime fechaActual = DateTime.Now;
            if (fechaActual.Month != 12)
            {
                int añoAnterior = fechaActual.Year - 1;
                fechaActual = new DateTime(añoAnterior, 12, 1);
            }
            dtpEmision.Value = fechaActual;
            dtpVencimiento.Value = fechaActual.AddYears(1).AddDays(-1);
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                familiar = Convert.ToInt32(cboFamiliar.SelectedValue);
                carnet = txtCarnet.Text;
                certificado = txtCertificado.Text;
                inicio = dtpEmision.Value.Date;
                fin = dtpVencimiento.Value.Date;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtCertificado.Text))
            {
                errorProvider1.SetError(txtCertificado, "No puede estar vacío.");
                txtCertificado.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCarnet.Text))
            {
                errorProvider1.SetError(txtCarnet, "No puede estar vacío.");
                txtCarnet.Focus();
                return false;
            }
            if (dtpEmision.Value.Date >= dtpVencimiento.Value.Date)
            {
                errorProvider1.SetError(dtpVencimiento, "No puede ser igual o menor a fecha de emisión.");
                dtpVencimiento.Focus();
                return false;
            }
            return true;
        }
    }
}
