using SAESoft.Models.Importaciones;
using System.Data;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Importaciones
{
    public partial class frmMontos : Form
    {
        public List<Contenedor> contenedores;
        public DataTable dt = new();
        public frmMontos()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                DataRow row = dt.NewRow();
                row[0] = cboContenedores.Text;
                row[1] = Convert.ToDecimal(textBox1.Text);
                row[2] = Convert.ToDecimal(textBox2.Text);
                row[3] = Convert.ToInt32(cboContenedores.SelectedValue);
                dt.Rows.Add(row);
                textBox1.ResetText();
                textBox2.ResetText();
            }
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("Contenedor").DataType = Type.GetType("System.String");
            dt.Columns.Add("Almacenaje (Q)").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Demora ($)").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("idContenedor").DataType = Type.GetType("System.Int32");
            dt.PrimaryKey = [dt.Columns[3]];
            dgvPagos.DataSource = dt;
            dgvPagos.Columns[0].Width = 150;
            dgvPagos.Columns[1].Width = 115;
            dgvPagos.Columns[2].Width = 115;
            dgvPagos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPagos.Columns[3].Visible = false;
            dgvPagos.ClearSelection();
        }

        private Boolean ValidarFormulario()
        {
            errorProvider1.Clear();
            bool contains = dt.AsEnumerable().Any(row => cboContenedores.Text == row.Field<String>("Contenedor"));
            if (contains)
            {
                errorProvider1.SetError(cboContenedores, "El contenedor ya ha sido ingresado");
                cboContenedores.Focus();
                return false;
            }
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
            cboContenedores.DisplayMember = "Numero";
            cboContenedores.ValueMember = "idContenedor";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ValidarGuardado())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarGuardado()
        {
            if (cboContenedores.Items.Count == dt.Rows.Count)
            {
                return true;
            }
            return false;
        }

        private void frmMontos_Shown(object sender, EventArgs e)
        {
            estructuraGrid();
        }
    }
}
