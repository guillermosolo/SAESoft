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
    public static class ReporteGeneralDatos
    {
        static SLStyle normal, moneda, headerStyle;
        public static void Reporte()
        {
            try
            {
                SAESoftContext db = new();   

                var empleados = db.EmpIncentivos
                    .Include(d=>d.DeptoIncentivos)
                    .Where(e=>e.FechaBaja == null)
                    .OrderBy(d=>d.IdDepto)
                    .ThenBy(d => d.Codigo)
                    .ToList();

                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteGeneralDatos.xlsx");
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

                moneda = normal.Clone();
                moneda.FormatCode = "_-\"Q. \"* #,##0.00_-;[Red]-\"Q. \"* #,##0.00_-";

                headerStyle = normal.Clone();
                headerStyle.Font.Bold = true;
                headerStyle.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(201, 225, 245), Color.Empty);
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
                headerStyle.Alignment.Vertical = VerticalAlignmentValues.Center;

                excel.SetCellValue("A1", "DEPARTAMENTO");
                excel.SetCellValue("B1", "CODIGO");
                excel.SetCellValue("C1", "NOMBRE");
                excel.SetCellValue("D1", "BASE");

                excel.SetCellStyle("A1", "D1", headerStyle);

                int i = 1;
                foreach (var item in empleados)
                {
                    i++;
                    excel.SetCellValue("A" + i, item.DeptoIncentivos.Nombre);
                    excel.SetCellValue("B" + i, item.Codigo);
                    excel.SetCellValue("C" + i, item.NombreCompleto);
                    excel.SetCellValue("D" + i, item.BaseCalculo);

                    excel.SetCellStyle("A" + i, "C" + i, normal);
                    excel.SetCellStyle("D" + i, moneda);
                }

                excel.SetColumnWidth(1, 300 / 7);
                excel.SetColumnWidth(2, 75 / 7);
                excel.SetColumnWidth(3, 400 / 7);
                excel.SetColumnWidth(4, 100 / 7);

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
