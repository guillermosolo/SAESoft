using SAESoft.Models;
using SAESoft.Models.Administracion;
using System.Data;
using System.Windows.Forms;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmResidencia : Form
    {
        public int tipo;
        public int idEmpleado;
        public int familiar;
        public string resolucion;
        public DateTime vencimiento;
        public frmResidencia()
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
                familiar = Convert.ToInt32(cboFamiliar.SelectedValue);
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
            return true;
        }

        private void frmResidencia_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "RESIDENCIA";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarCombos();
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

        private void llenarCombos()
        {
            llenarNombres(cboTipo, "RESIDENCIA");
            using SAESoftContext db = new();
            var listado = db.Familiares.Where(f => f.IdEmpleado == idEmpleado).OrderBy(f => f.Nombres).Select(f => new { f.IdFamiliar, f.NombreCompleto }).ToList();
            listado.Insert(0, new { IdFamiliar = 0, NombreCompleto = "(NINGUNO)" });
            cboFamiliar.DataSource = listado;
            cboFamiliar.DisplayMember = "NombreCompleto";
            cboFamiliar.ValueMember = "IdFamiliar";
        }
    }
}
