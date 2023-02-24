using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
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
            SLDocument excel = new SLDocument();
            DataTable dt = new DataTable();
            dt.Columns.Add("BL", typeof(string));
            dt.Columns.Add("Poliza",typeof(string));

            using (SAESoftContext db = new SAESoftContext())
            {
                DateTime Inicio = dtpInicio.Value.Date;
                DateTime fin = dtpFinal.Value.Date;
                var rs = db.Importaciones.Include(i=>i.BL)
                                         .ThenInclude(p=>p.Polizas)
                                         .Where(i=>i.FechaCreacion>Inicio && i.FechaCreacion<= fin.AddDays(1).AddTicks(-1))
                                         .ToList();
                foreach (var item in rs)
                {
                    foreach (var item2 in item.BL)
                    {
                        foreach (var poliza in item2.Polizas)
                        {
                            DataRow row = dt.NewRow();
                            row["BL"] = item2.Numero;
                            row["Poliza"] = poliza.Numero;
                            dt.Rows.Add(row);
                        }
                    }
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
