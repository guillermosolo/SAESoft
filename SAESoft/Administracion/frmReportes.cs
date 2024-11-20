namespace SAESoft.Administracion
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void icbExcel_Click(object sender, EventArgs e)
        {
            ReporteSeguroVehiculos rep = new();
            rep.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ReporteSeguroMedico rep = new();
            rep.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ReporteDocumentacion rep = new();
            rep.ShowDialog();
        }
    }
}
