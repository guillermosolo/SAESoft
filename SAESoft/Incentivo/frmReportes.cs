namespace SAESoft.Incentivo
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmRepoGeneral repo = new();
            repo.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmRepoRRHH repo2 = new();
            repo2.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ReporteTardanzas.Reporte();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ReporteGeneralDatos.Reporte();
        }
    }
}
