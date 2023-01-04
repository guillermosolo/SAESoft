using System.Windows.Forms.DataVisualization.Charting;

namespace SAESoft.Importaciones
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }


        private void frmDashboard_Shown(object sender, EventArgs e)
        {
            string[] seriesArray = { "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };
            double[] pointsArray = { 2, 1, 3, 4, 5, 3, 7, 2, 9, 1, 2, 6 };
            chart1.Palette = ChartColorPalette.SemiTransparent;
            chart2.Palette = ChartColorPalette.SemiTransparent;
            for (int i = 0; i < 12; i++)
            {
                chart1.Series["Series1"].Points.AddXY(seriesArray[i], pointsArray[i]);
                chart2.Series["Series1"].Points.AddXY(seriesArray[i], pointsArray[i]);
            }
        }
    }
}
