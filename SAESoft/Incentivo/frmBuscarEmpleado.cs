namespace SAESoft.Incentivo
{
    public partial class frmBuscarEmpleado : Form
    {
        public string? codigo = null;
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
                codigo = txtCodigo.Text;
        }
    }
}
