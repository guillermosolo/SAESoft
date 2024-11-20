using SAESoft.Models.Exportaciones;
using SAESoft.Models;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;
using static SAESoft.Utilitarios.ControlFormularios;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Exportaciones
{
    public partial class frmReporteLocales : Form
    {
        public frmReporteLocales()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dtpFin.Value.Date >= dtpInicio.Value.Date)
            {
                reporteLocal();
            }
            else
            {
                MessageBox.Show("La fecha de inicio debe de ser menor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reporteLocal()
        {
            try
            {
                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteFactLocal.xlsx");
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();
                SLStyle headerStyle = excel.CreateStyle();
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                headerStyle.Alignment.Vertical = VerticalAlignmentValues.Center;
                headerStyle.SetWrapText(true);

                SLStyle fecha = excel.CreateStyle();
                fecha.FormatCode = "dd/mm/yyyy";

                DataTable dt = new();
                dt.Columns.Add("No.", typeof(int));
                dt.Columns.Add("Empresa", typeof(string));
                dt.Columns.Add("Fecha Factura", typeof(DateTime));
                dt.Columns.Add("Cliente", typeof(string));
                dt.Columns.Add("Fecha Anulación", typeof(DateTime));
                dt.Columns.Add("Nota Crédito", typeof(string));
                using (SAESoftContext db = new())
                {
                    var queryable = db.FacturasLocal.Include(t => t.TipoFactura)
                                        .Include(e => e.Empresa)
                                        .Where(b => b.Fecha >= dtpInicio.Value.Date && b.Fecha <= dtpFin.Value.Date);
                    queryable = queryable.OrderByDescending(r => r.FechaCreacion);
                    List<FacturaLocal> rs = [.. queryable];

                    foreach (var fact in rs)
                    {
                        DataRow row = dt.NewRow();
                        row["No."] = fact.NoFactura;
                        row["Empresa"] = fact.Empresa.Descripcion;
                        row["Fecha Factura"] = fact.Fecha.Date;
                        row["Cliente"] = fact.Cliente;
                        row["Fecha Anulación"] = fact.FechaAnulacion?.Date ?? (object)DBNull.Value;
                        row["Nota Crédito"] = fact.NotaCredito;
                        dt.Rows.Add(row);
                    }

                }
                excel.ImportDataTable(1, 1, dt, true);
                excel.SetColumnWidth(1, 10);
                excel.SetColumnWidth(2, 25);
                excel.SetColumnWidth(3, 15);
                excel.SetColumnWidth(4, 25);
                excel.SetColumnWidth(5, 15);
                excel.SetColumnWidth(6, 15);
                excel.SetColumnStyle(3, fecha);
                excel.SetColumnStyle(5, fecha);

                for (char i = 'A'; i <= 'G'; i++)
                    excel.SetCellStyle(i + "1", headerStyle);

                excel.SaveAs(pathFile);
                new Process { StartInfo = new ProcessStartInfo(pathFile) { UseShellExecute = true } }.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
