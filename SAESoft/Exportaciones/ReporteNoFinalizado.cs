using SAESoft.Models.Administracion;
using SAESoft.Models.Comunes;
using SAESoft.Models;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;
using DocumentFormat.OpenXml.Spreadsheet;
using static SAESoft.Utilitarios.ControlFormularios;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Exportaciones;
using System.Linq;


namespace SAESoft.Exportaciones
{
    public static class ReporteNoFinalizado
    {
        public static void Reporte()
        {
            try
            {
                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteNoFinalizado.xlsx");
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
                dt.Columns.Add("Fecha Licencia", typeof(DateTime));
                dt.Columns.Add("Ultima Etapa", typeof(string));
                dt.Columns.Add("Dias Transcurridos", typeof(int));
                dt.Columns.Add("cod", typeof(int));
                using (SAESoftContext db = new())
                {
                    var queryable = db.Licencias.Include(f => f.Facturas)
                                        .ThenInclude(c => c.Consignatario)
                                        .Include(f => f.Facturas)
                                        .ThenInclude(a => a.Aduana)
                                        .Include(f => f.Facturas)
                                        .ThenInclude(t => t.TipoFactura)
                                        .Include(f => f.Facturas)
                                        .ThenInclude(e => e.Exportador)
                                        .Include(f => f.Facturas)
                                        .ThenInclude(m => m.Modalidad)
                                        .Include(d => d.Ducas)
                                        .ThenInclude(t => t.TipoDuca)
                                        .Include(b => b.Descargos)
                                        .Include(c => c.Comentarios)
                                        .Where(l => l.Facturas.Any(f => !new[] { 155, 158 }.Contains(f.IdTipoFactura)));
                    queryable = queryable.Where(r => r.Descargos.All(d => d.final == false));

                    queryable = queryable.OrderByDescending(r => r.FechaCreacion);
                    List<Licencia> rs = queryable.ToList();
                    foreach (var item in rs)
                    {
                        foreach (var fact in item.Facturas)
                        {
                            if (!fact.FechaAnulacion.HasValue)
                            {
                                DataRow row = dt.NewRow();
                                TimeSpan diferencia; 
                                row["No."] = fact.NoFactura;
                                row["Empresa"] = fact.Consignatario.Descripcion;
                                row["Fecha Factura"] = fact.Fecha.Date;
                                row["Fecha Licencia"] = item.Fecha.Date;
                                Boolean tieneDuca = item.Ducas.Any();
                                Boolean tieneDescargo = item.Descargos.Any();
                                if (tieneDescargo)
                                {
                                    diferencia = DateTime.Now - item.Descargos.Last().Fecha;
                                    row["Ultima Etapa"] = "DESCARGO MANUAL";
                                    row["cod"] = 4;
                                }
                                else if (tieneDuca)
                                {
                                    var duca = item.Ducas.OrderBy(d => d.FechaCreacion).Last();
                                    row["Ultima Etapa"] = duca.TipoDuca.Descripcion;
                                    diferencia = DateTime.Now - duca.Fecha;
                                    if (duca.TipoDuca.Descripcion.Contains("11"))
                                        row["cod"] = 2;
                                    else
                                        row["cod"] = 3;
                                }
                                else
                                {
                                    row["Ultima Etapa"] = "CREACIÓN DE LICENCIA";
                                    row["cod"] = 1;
                                    diferencia = DateTime.Now - item.Fecha;
                                }
                                row["Dias Transcurridos"] = diferencia.Days;
                                dt.Rows.Add(row);
                            }
                        }
                    }
                }
                excel.ImportDataTable(1, 1, dt, true);
                excel.SetColumnWidth(1, 10);
                excel.SetColumnWidth(2, 25);
                excel.SetColumnWidth(3, 15);
                excel.SetColumnWidth(4, 15);
                excel.SetColumnWidth(5, 25);
                excel.SetColumnWidth(6, 15);
                excel.HideColumn(7);
                excel.SetColumnStyle(3, fecha);
                excel.SetColumnStyle(4, fecha);

                for (char i = 'A'; i <= 'G'; i++)
                    excel.SetCellStyle(i + "1", headerStyle);

                SLWorksheetStatistics stats = excel.GetWorksheetStatistics();
                int ultimaFila = stats.EndRowIndex;

                SLConditionalFormatting cf = new("F2", "F" + ultimaFila);

                cf.HighlightCellsWithFormula($"AND(F2 = 0, G2 = 1)", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 > 0, G2 = 1)", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 < 3, G2 = 2)", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 > 2, G2 = 2)", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 < 30, G2 = 3)", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 > 29, F2 < 36, G2 = 3)", SLHighlightCellsStyleValues.YellowFillWithDarkYellowText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"AND(F2 > 35, G2 = 3)", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                excel.AddConditionalFormatting(cf);


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
