﻿namespace SAESoft.Exportaciones
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ReporteNoFinalizado.Reporte();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmReporteLocales repo = new();
            repo.ShowDialog();
        }
    }
}
