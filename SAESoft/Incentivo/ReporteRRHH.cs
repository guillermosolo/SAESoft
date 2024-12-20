using SAESoft.Models.Incentivos;
using SAESoft.Models;
using SpreadsheetLight;
using System.Diagnostics;
using System.Data;
using Microsoft.EntityFrameworkCore;
using static SAESoft.Utilitarios.ControlFormularios;
using DocumentFormat.OpenXml.Spreadsheet;
using Color = System.Drawing.Color;

namespace SAESoft.Incentivo
{
    public static class ReporteRRHH
    {
        static SLStyle normal,numero, headerStyle;
        public static void Reporte(int eval)
        {
            try
            {
                SAESoftContext db = new();
                Evaluacion evaluacion = db.Evaluaciones.Include(e => e.Detalles)
                                                         .ThenInclude(d => d.Empleado)
                                               .Where(e => e.IdEvaluacion == eval)
                                               .FirstOrDefault();

                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteRRHHIncentivo.xlsx");
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();

                normal = excel.CreateStyle();
                normal.SetFont("Aptos Narrow", 11);
                normal.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                normal.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                normal.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                normal.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;

                numero = excel.CreateStyle();
                numero.SetFont("Aptos Narrow",11);
                numero.Font.FontSize = 11;
                numero.FormatCode = "#,##0;[Red]-#,##0";
                numero.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                numero.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                numero.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                numero.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;

                headerStyle = excel.CreateStyle();
                headerStyle.SetFont("Aptos Narrow", 11);
                headerStyle.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(201, 225, 245), Color.Empty);
                headerStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
                headerStyle.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
                headerStyle.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
                headerStyle.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                headerStyle.Alignment.Vertical = VerticalAlignmentValues.Center;

                excel.SetCellValue("A1", "No");
                excel.SetCellValue("B1", "Emp ID");
                excel.SetCellValue("C1", "Pay Item");
                excel.SetCellValue("D1", "Amount");
                excel.SetCellValue("E1", "Note");
                excel.SetCellValue("F1", "Emp Name");
                excel.SetCellValue("G1", "Emp. Status");
                excel.SetCellValue("H1", "Payroll Area");
                excel.SetCellStyle("A1","H1", headerStyle);

                excel.SetCellValue("C2","OTRO Incentivo");

                int i = 1;
                foreach (var item in evaluacion.Detalles)
                {
                    if (item.Total > 0)
                    {
                        i++;
                        excel.SetCellValue("A" + i, i - 1);
                        excel.SetCellValue("B" + i, item.Empleado.Codigo);
                        excel.SetCellStyle("A" + i, "C" + i, normal);
                        excel.SetCellValue("D" + i, item.Total);
                        excel.SetCellStyle("D" + i, numero);
                        excel.SetCellStyle("E" + i,"H" + i, normal);
                    }
                }

                excel.SetColumnWidth(1, 35 / 7);
                excel.SetColumnWidth(2, 66 / 7);
                excel.SetColumnWidth(3, 115 / 7);
                excel.SetColumnWidth(4, 63 / 7);
                excel.SetColumnWidth(5, 41 / 7);
                excel.SetColumnWidth(6, 85 / 7);
                excel.SetColumnWidth(7, 90 / 7);
                excel.SetColumnWidth(8, 93 / 7);

                excel.SaveAs(pathFile);
                new Process { StartInfo = new ProcessStartInfo(pathFile) { UseShellExecute = true } }.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
