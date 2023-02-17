using SAESoft.Models.Importaciones;
using System.Windows.Forms.DataVisualization.Charting;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Importaciones
{
    public partial class frmMontos : Form
    {
        public List<Contenedor> contenedores;
        public frmMontos()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(sender, e); 
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(sender, e);
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private Boolean ValidarFormulario()
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "No puede estar vacío.");
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
                textBox2.Text = "0.00";
            return true;
        }

        private void frmMontos_Load(object sender, EventArgs e)
        {
            cboContenedores.DataSource = contenedores;
            cboContenedores.DisplayMember= "Numero";
            cboContenedores.ValueMember= "idContenedor";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
