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
    public static class ReporteTardanzas
    {
        static SLStyle normal, numero, headerStyle;
        public static void Reporte()
        {
            try
            {
                SAESoftContext db = new(); 
                
                int maxEvaluacion = db.Evaluaciones.Max(e => e.IdEvaluacion);

                var asistencias = db.Asistencia.Where(a=> a.IdEvaluacion == maxEvaluacion && a.Tardanza>=5)
                                                .Include(a => a.Empleado)     
                                                .ThenInclude(e => e.DeptoIncentivos)
                                                .OrderByDescending(a=>a.Tardanza)
                                                .ToList();

                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteAusentes.xlsx");
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

                numero = normal.Clone();
                numero.FormatCode = "#,##0;[Red]-#,##0";

                headerStyle = normal.Clone();
                headerStyle.Font.Bold = true;
                headerStyle.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(201, 225, 245), Color.Empty);
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                headerStyle.Alignment.Vertical = VerticalAlignmentValues.Center;

                excel.SetCellValue("A1", "사번(Code)");
                excel.SetCellValue("B1", "이름(Nombre)");
                excel.SetCellValue("C1", "부서(Dept)");
                excel.SetCellValue("D1", "지각");
                excel.SetCellValue("D2", "Tardanza");

                excel.MergeWorksheetCells("A1", "A2");
                excel.MergeWorksheetCells("B1", "B2");
                excel.MergeWorksheetCells("C1", "C2");

                excel.SetCellStyle("A1", "D2", headerStyle);

                int i = 2;
                foreach (var item in asistencias)
                {
                    i++;
                    excel.SetCellValue("A" + i, item.Empleado.Codigo);
                    excel.SetCellValue("B" + i, item.Empleado.NombreCompleto);
                    excel.SetCellValue("C" + i, item.Empleado.DeptoIncentivos.Nombre);
                    excel.SetCellValue("D" + i, item.Tardanza);

                    excel.SetCellStyle("A" + i, "C" + i, normal);
                    excel.SetCellStyle("D" + i, numero);
                }
                
                excel.SetColumnWidth(1, 85 / 7);
                excel.SetColumnWidth(2, 400 / 7);
                excel.SetColumnWidth(3, 250 / 7);
                excel.SetColumnWidth(4, 75 / 7);

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
