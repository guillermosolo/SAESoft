using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Importaciones;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;

namespace SAESoft.Importaciones
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string pathFile = Path.Combine(Path.GetTempPath(), "BLyPolizaParaERP.xlsx");
            SLDocument excel = new();
            DataTable dt = new();
            dt.Columns.Add("BL", typeof(string));
            dt.Columns.Add("Poliza",typeof(string));

            using (SAESoftContext db = new())
            {
                DateTime Inicio = dtpInicio.Value.Date;
                DateTime fin = dtpFinal.Value.Date;
                var result = db.Importaciones
                .SelectMany(i => i.BL, (i, bl) => new { BL = bl, i })
                .SelectMany(t => t.BL.Polizas.DefaultIfEmpty(), (t, pol) => new { BLNumero = t.BL.Numero, Poliza = pol.Numero ?? "" })
                .ToList();
                foreach (var item in result)
                {
                    DataRow row = dt.NewRow();
                    row["BL"] = item.BLNumero;
                    row["Poliza"] = item.Poliza;
                    dt.Rows.Add(row);
                }
            }
            excel.ImportDataTable(1, 1, dt, true);
            excel.SetColumnWidth(1, 15);
            excel.SetColumnWidth(2, 15);
            excel.SaveAs(pathFile);
            new Process { StartInfo = new ProcessStartInfo(pathFile) { UseShellExecute = true } }.Start();
            this.Close();
        }
    }
}
