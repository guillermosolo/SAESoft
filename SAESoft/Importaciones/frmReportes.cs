namespace SAESoft.Importaciones
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void icbExcel_Click(object sender, EventArgs e)
        {
            frmExcel excel = new();
            excel.ShowDialog();
        }
    }
}
