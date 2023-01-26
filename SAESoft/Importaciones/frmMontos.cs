using System.Windows.Forms.DataVisualization.Charting;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Importaciones
{
    public partial class frmMontos : Form
    {
        public decimal monto=0.00m;
        public decimal mora=0.00m;
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
            if (ValidarFormulario())
            {
                monto = Convert.ToDecimal(textBox1.Text);
                mora = Convert.ToDecimal(textBox2.Text);
                this.DialogResult= DialogResult.OK;
            } 
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
    }
}
