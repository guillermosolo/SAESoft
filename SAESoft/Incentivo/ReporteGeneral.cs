using SpreadsheetLight;
using static SAESoft.Utilitarios.ControlFormularios;
using DocumentFormat.OpenXml.Spreadsheet;
using SAESoft.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Incentivos;
using System.Diagnostics;
using Color = System.Drawing.Color;


namespace SAESoft.Incentivo
{
    public static class ReporteGeneral
    {
        static SLStyle headerStyle, lineaNegrita, lineaSubraya, moneda, porcentaje, normal, header2,
                       bordeNegrita, negrita, derecha, header3, header4, bordeNormal, bordePorcentaje, rojo,
                       fondoCeleste, fondoVerde, headerVerde, bordeNormalGris, fecha, bordePorcentajeGris,
                       negativosRojos, fondoNaranja, bordePorcentajeNegrita, bordeSuspendidoGris, bordeSuspPorcentajeGris,
                       bordeSuspendido, bordeSuspPorcentaje, fondoVerdeSuspendido, suspendido, empleadoNuevo, cambioBase;

        private static void crearEstilos(SLDocument excel)
        {
            headerStyle = excel.CreateStyle();
            headerStyle.Font.Bold = true;
            headerStyle.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(189, 215, 238), Color.Empty);
            headerStyle.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            headerStyle.Alignment.Vertical = VerticalAlignmentValues.Center;
            headerStyle.Font.FontSize = 10;
            headerStyle.SetWrapText(true);

            header2 = excel.CreateStyle();
            header2.Font.Bold = true;
            header2.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(155, 194, 230), Color.Empty);
            header2.Alignment.Vertical = VerticalAlignmentValues.Center;
            header2.Font.FontSize = 10;
            header2.SetWrapText(true);

            header3 = excel.CreateStyle();
            header3.Font.Bold = true;
            header3.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(68, 114, 196), Color.Empty);
            header3.Alignment.Vertical = VerticalAlignmentValues.Center;
            header3.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            header3.Font.FontSize = 10;
            header3.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            header3.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            header3.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            header3.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            header3.SetWrapText(true);

            header4 = excel.CreateStyle();
            header4.Font.Bold = true;
            header4.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(155, 194, 230), Color.Empty);
            header4.Alignment.Vertical = VerticalAlignmentValues.Center;
            header4.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            header4.Font.FontSize = 10;
            header4.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            header4.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            header4.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            header4.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            header4.SetWrapText(true);

            fondoCeleste = excel.CreateStyle();
            fondoCeleste.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(155, 194, 230), Color.Empty);

            fondoVerde = excel.CreateStyle();
            fondoVerde.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(169, 208, 142), Color.Empty);

            headerVerde = fondoVerde.Clone();
            headerVerde.Font.Bold = true;
            headerVerde.Alignment.Vertical = VerticalAlignmentValues.Center;
            headerVerde.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            headerVerde.Font.FontSize = 10;
            headerVerde.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            headerVerde.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            headerVerde.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            headerVerde.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            headerVerde.SetWrapText(true);


            lineaNegrita = excel.CreateStyle();
            lineaNegrita.Font.Bold = true;
            lineaNegrita.Font.FontSize = 12;
            lineaNegrita.SetWrapText(false);

            lineaSubraya = excel.CreateStyle();
            lineaSubraya.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            lineaSubraya.Font.FontSize = 10;
            lineaSubraya.SetWrapText(false);

            bordeNegrita = excel.CreateStyle();
            bordeNegrita.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNegrita.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNegrita.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNegrita.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNegrita.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            bordeNegrita.Font.FontSize = 10;
            bordeNegrita.Font.Bold = true;

            negativosRojos = excel.CreateStyle();
            negativosRojos.FormatCode = "#,##0;[Red]-#,##0";
            negativosRojos.Font.FontSize = 10;

            fondoNaranja = negativosRojos.Clone();
            fondoNaranja.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(255, 217, 102), Color.Empty);
            fondoNaranja.Font.FontSize = 10;

            moneda = excel.CreateStyle();
            moneda.FormatCode = "_-Q* #,##0_-;-Q* #,##0_-;_-Q* \"-\"??_-;_-@_-";

            porcentaje = excel.CreateStyle();
            porcentaje.FormatCode = "0%";

            normal = excel.CreateStyle();
            normal.Font.FontSize = 10;

            rojo = normal.Clone();
            rojo.Font.FontColor = Color.Red;
            rojo.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            bordeNormal = normal.Clone();
            bordeNormal.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNormal.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNormal.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNormal.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            bordeNormal.FormatCode = "#,##0;[Red]-#,##0";

            bordeNormalGris = bordeNormal.Clone();
            bordeNormalGris.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(217, 217, 217), Color.Empty);
            bordeNormalGris.FormatCode = "#,##0;[Red]-#,##0";

            bordePorcentajeGris = bordeNormalGris.Clone();
            bordePorcentajeGris.FormatCode = "0%";

            bordePorcentaje = bordeNormal.Clone();
            bordePorcentaje.FormatCode = "0%";

            bordePorcentajeNegrita = bordePorcentaje.Clone();
            bordePorcentajeNegrita.Font.Bold = true;


            negrita = normal.Clone();
            negrita.Font.Bold = true;

            derecha = normal.Clone();
            derecha.Alignment.Horizontal = HorizontalAlignmentValues.Right;

            fecha = excel.CreateStyle();
            fecha.FormatCode = "dd/mm/yyyy";

            bordeSuspendidoGris = bordeNormalGris.Clone();
            bordeSuspendidoGris.Font.Bold = true;
            bordeSuspendidoGris.Font.FontColor = Color.Red;

            bordeSuspPorcentajeGris = bordePorcentajeGris.Clone();
            bordeSuspPorcentajeGris.Font.Bold = true;
            bordeSuspPorcentajeGris.Font.FontColor = Color.Red;

            bordeSuspendido = bordeNormal.Clone();
            bordeSuspendido.Font.Bold = true;
            bordeSuspendido.Font.FontColor = Color.Red;

            bordeSuspPorcentaje = bordePorcentaje.Clone();
            bordeSuspPorcentaje.Font.Bold = true;
            bordeSuspPorcentaje.Font.FontColor = Color.Red;

            fondoVerdeSuspendido = fondoVerde.Clone();
            fondoVerdeSuspendido.Font.Bold = true;
            fondoVerdeSuspendido.Font.FontColor = Color.Red;

            suspendido = normal.Clone();
            suspendido.Font.Bold = true;
            suspendido.Font.FontColor = Color.Red;

            empleadoNuevo = bordeNormal.Clone();
            empleadoNuevo.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(255, 217, 102), Color.Empty);

            cambioBase = bordeNormal.Clone();
            cambioBase.Fill.SetPattern(PatternValues.Solid, Color.FromArgb(255, 255, 0), Color.Empty);
        }

        public static void Reporte(int eval)
        {
            try
            {
                SAESoftContext db = new();
                Evaluacion evaluacion = db.Evaluaciones.Include(e => e.Detalles)
                                                         .ThenInclude(d => d.Empleado)
                                                         .ThenInclude(emp => emp.Asistencias)
                                                       .Include(e => e.Detalles)
                                                         .ThenInclude(d => d.Empleado)
                                                         .ThenInclude(emp => emp.DeptoIncentivos)
                                               .Where(e => e.IdEvaluacion == eval)
                                               .FirstOrDefault();

                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteGeneralIncentivo.xlsx");
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();
                SLPageSettings settings = excel.GetPageSettings();
                settings.ShowGridLines = false;
                settings.HeaderMargin = 0.8 / 2.2;
                settings.TopMargin = 1.1 / 2.2;
                settings.LeftMargin = 1.8 / 2.2;
                settings.RightMargin = 0.8 / 2.2;
                settings.BottomMargin = 0.4 / 2.2;
                settings.FooterMargin = 0.4 / 2.2;
                settings.Orientation = OrientationValues.Landscape;
                settings.ScalePage(1, 1);
                excel.SetPageSettings(settings);

                crearEstilos(excel);

                excel.RenameWorksheet(SLDocument.DefaultFirstSheetName, "SUMM");

                agregaResumen(excel, evaluacion);

                var deptosUnicos = evaluacion.Detalles.Select(d => new
                {
                    d.Departamento.IdDepto,
                    d.Departamento.Nombre
                }).Distinct().ToList();
                foreach (var d in deptosUnicos)
                {
                    excel.AddWorksheet(d.Nombre);
                    excel.SetPageSettings(settings);
                    agregaDeptos(excel, evaluacion, d.Nombre, d.IdDepto);
                }
                excel.SelectWorksheet("SUMM");
                excel.SaveAs(pathFile);
                new Process { StartInfo = new ProcessStartInfo(pathFile) { UseShellExecute = true } }.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void agregaDeptos(SLDocument hoja, Evaluacion eval, string depto, int idDepto)
        {
            SLPageSettings settingsColor = hoja.GetPageSettings();
            settingsColor.ShowGridLines = false;
            settingsColor.HeaderMargin = 0.8 / 2.2;
            settingsColor.TopMargin = 1.1 / 2.2;
            settingsColor.LeftMargin = 1.8 / 2.2;
            settingsColor.RightMargin = 0.8 / 2.2;
            settingsColor.BottomMargin = 0.4 / 2.2;
            settingsColor.FooterMargin = 0.4 / 2.2;
            settingsColor.Orientation = OrientationValues.Landscape;
            settingsColor.TabColor = Color.FromArgb(146, 208, 80);
            settingsColor.ScalePage(1, 1);

            hoja.SetPageSettings(settingsColor);
            hoja.SetCellValue("B2", "평가계산표 [인센티브]");
            hoja.SetCellStyle("B2", lineaNegrita);

            hoja.SetCellValue("H2", "부서");
            hoja.SetCellStyle("H2", normal);
            hoja.DrawBorder("H2", "H2", BorderStyleValues.Medium);

            hoja.SetCellValue("I2", depto);
            hoja.SetCellStyle("I2", negrita);
            hoja.SetCellValue("J2", "=CONCATENATE(I2,1)");
            hoja.SetCellStyle("J2", normal);
            hoja.SetCellValue("Q2", "주의사항 :  Total  100% 이어야 함");
            hoja.SetCellStyle("Q2", derecha);
            hoja.DrawBorder("I2", "I2", BorderStyleValues.Medium);


            hoja.SetCellValue("B3", "평가기간 : ");
            hoja.SetCellStyle("B3", negrita);
            hoja.SetCellValue("C3", $"{eval.fechaInicio:yyyy-MM-dd}  ~ {eval.fechaFin:yyyy-MM-dd}");
            hoja.SetCellStyle("C3", "E3", lineaSubraya);
            hoja.SetCellValue("I3", "근태\r\n[고정]");
            hoja.SetCellValue("J3", "업무태도");
            hoja.SetCellValue("K3", "협력도");
            hoja.SetCellValue("L3", "");
            hoja.SetCellValue("M3", "");
            hoja.SetCellValue("N3", "");
            hoja.SetCellValue("O3", "");
            hoja.SetCellValue("P3", "");
            hoja.SetCellValue("Q3", "Total");
            hoja.SetCellStyle("I3", header3);
            hoja.SetCellStyle("J3", "Q3", header4);

            hoja.SetCellValue("F4", "가용액");
            hoja.SetCellStyle("F4", header4);
            hoja.SetCellValue("I4", 0.6);
            hoja.SetCellValue("J4", 0.3);
            hoja.SetCellValue("K4", 0.1);
            hoja.SetCellValue("Q4", "=SUM(I4:P4)");
            hoja.SetCellStyle("I4", "P4", bordePorcentaje);
            hoja.SetCellStyle("Q4", bordePorcentajeNegrita);

            hoja.SetCellValue("F5", "=E6-H6");
            hoja.SetCellStyle("F5", bordeNormal);
            hoja.SetCellValue("Q5", "=IF(Q4=1,\"OK\",\"-재확인요함-\")");
            hoja.SetCellStyle("Q5", rojo);

            hoja.SetCellStyle("B7", "H8", fondoCeleste);
            hoja.SetCellStyle("G7", "G8", fondoVerde);
            hoja.DrawBorder("B7", "B8", BorderStyleValues.Thin);
            hoja.DrawBorder("C7", "C8", BorderStyleValues.Thin);
            hoja.DrawBorder("D7", "D8", BorderStyleValues.Thin);
            hoja.DrawBorder("E7", "E8", BorderStyleValues.Thin);
            hoja.DrawBorder("F7", "F8", BorderStyleValues.Thin);
            hoja.DrawBorder("G7", "G8", BorderStyleValues.Thin);
            hoja.DrawBorder("H7", "H8", BorderStyleValues.Thin);

            hoja.SetCellValue("I7", "성취도");
            hoja.SetCellStyle("I7", "P7", header4);
            hoja.MergeWorksheetCells("I7", "P7");

            hoja.SetCellValue("I8", "근태 [고정]");
            hoja.SetCellStyle("I8", header3);
            hoja.MergeWorksheetCells("I8", "L8");
            hoja.SetCellStyle("M8", "P8", header4);

            hoja.SetCellValue("B9", "사번(Code)");
            hoja.SetCellValue("C9", "이름(Nombre)");
            hoja.SetCellValue("D9", "부서(Dept)");
            hoja.SetCellValue("E9", "책정(Base)");
            hoja.SetCellValue("F9", "차액지정");
            hoja.SetCellValue("G9", "최종액\r\n(T. Pago)");
            hoja.SetCellValue("H9", "성취액\r\nLogro");
            hoja.SetCellValue("I9", "근태");
            hoja.SetCellValue("J9", "지각\r\nTardanza");
            hoja.SetCellValue("K9", "Permiso");
            hoja.SetCellValue("L9", "결근\r\nAusencia");
            hoja.SetCellValue("M9", "업무태도");
            hoja.SetCellValue("N9", "협력도");
            hoja.SetCellValue("O9", "-");
            hoja.SetCellValue("P9", "열2");
            hoja.SetCellStyle("B9", "P9", header4);
            hoja.SetCellStyle("G9", headerVerde);

            hoja.Filter("B9", "P9");
            hoja.FreezePanes(9, 1);

            int i = 10;
            foreach (var item in eval.Detalles.Where(b => b.IdDepto == idDepto).ToList())
            {
                int Tardanza = item.Empleado.Asistencias.Where(a => a.IdEvaluacion == eval.IdEvaluacion).FirstOrDefault().Tardanza;
                int Permiso = item.Empleado.Asistencias.Where(a => a.IdEvaluacion == eval.IdEvaluacion).FirstOrDefault().Permiso;
                int Ausencia = item.Empleado.Asistencias.Where(a => a.IdEvaluacion == eval.IdEvaluacion).FirstOrDefault().Ausente;

                DateTime inicioEval = eval.fechaInicio;
                DateTime finEval = eval.fechaFin;

                SAESoftContext db = new();
                var suspensiones = db.Suspensiones.Where(b => b.IdEmpleado == item.Empleado.IdEmpIncentivo && b.Activo == true)
                                                 .Where(b => b.FechaInicio >= inicioEval || b.FechaFin >= inicioEval)
                                                 .ToList();

                String mensaje = "";
                foreach (var susp in suspensiones)
                {
                    if (mensaje == "")
                    {
                        mensaje = $"DEL {susp.FechaInicio:dd/MM/yyyy} AL {susp.FechaFin:dd/MM/yyyy}";
                    }
                    else
                    {
                        mensaje += $", DEL {susp.FechaInicio:dd/MM/yyyy} AL {susp.FechaFin:dd/MM/yyyy}";
                    }
                }

                decimal subTotal = item.Total - item.Extra;

                hoja.SetCellValue("B" + i, item.Empleado.Codigo);
                hoja.SetCellValue("C" + i, item.Empleado.NombreCompleto);
                hoja.SetCellValue("D" + i, depto);
                hoja.SetCellValue("E" + i, item.BaseCalculo);
                hoja.SetCellValue("F" + i, item.Extra);
                hoja.SetCellValue("G" + i, item.Total);
                hoja.SetCellValue("H" + i, subTotal);
                hoja.SetCellValue("I" + i, item.Asistencia / 100m);
                hoja.SetCellValue("J" + i, Tardanza);
                hoja.SetCellValue("K" + i, Permiso);
                hoja.SetCellValue("L" + i, Ausencia);
                hoja.SetCellValue("M" + i, item.Actitud / 100m);
                hoja.SetCellValue("N" + i, item.Cooperacion / 100m);


                if (suspensiones.Count == 0)
                {
                    if (i % 2 == 0)
                    {
                        hoja.SetCellStyle("B" + i, "P" + i, bordeNormalGris);
                        hoja.SetCellStyle("I" + i, bordePorcentajeGris);
                        hoja.SetCellStyle("M" + i, "N" + i, bordePorcentajeGris);
                    }
                    else
                    {
                        hoja.SetCellStyle("B" + i, "P" + i, bordeNormal);
                        hoja.SetCellStyle("I" + i, bordePorcentaje);
                        hoja.SetCellStyle("M" + i, "N" + i, bordePorcentaje);
                    }
                    hoja.SetCellStyle("G" + i, fondoVerde);
                }
                else
                {
                    hoja.SetCellValue("Q" + i, $"SUSPENDIDO {mensaje}");

                    if (i % 2 == 0)
                    {
                        hoja.SetCellStyle("B" + i, "P" + i, bordeSuspendidoGris);
                        hoja.SetCellStyle("I" + i, bordeSuspPorcentajeGris);
                        hoja.SetCellStyle("M" + i, "N" + i, bordeSuspPorcentajeGris);
                        hoja.SetCellStyle("Q" + i, suspendido);
                    }
                    else
                    {
                        hoja.SetCellStyle("B" + i, "P" + i, bordeSuspendido);
                        hoja.SetCellStyle("I" + i, bordeSuspPorcentaje);
                        hoja.SetCellStyle("M" + i, "N" + i, bordeSuspPorcentaje);
                        hoja.SetCellStyle("Q" + i, suspendido);
                    }
                    hoja.SetCellStyle("G" + i, fondoVerdeSuspendido);
                }

                var historial = db.HistorialIncentivos.Where(e => e.IdEmpleado == item.Empleado.IdEmpIncentivo).Where(f => (f.FechaInicio >= inicioEval && f.idEvaluacion == null) || f.idEvaluacion == eval.IdEvaluacion).ToList();

                if (item.Empleado.FechaIngreso >= inicioEval)
                {
                    hoja.SetCellStyle("E" + i, empleadoNuevo);
                }
                else if (historial.Count > 0)
                {
                    foreach (var hist in historial)
                    {
                        hist.idEvaluacion ??= eval.IdEvaluacion;
                    }
                    db.SaveChanges();
                    hoja.SetCellStyle("E" + i, cambioBase);
                }
                i++;
            }
            i--;
            hoja.SetCellValue("C6", "=SUBTOTAL(3,C10:C" + i + ")");
            hoja.SetCellValue("E6", "=SUBTOTAL(9,E10:E" + i + ")");
            hoja.SetCellValue("F6", "=F5 - SUBTOTAL(9,F10:F" + i + ")");
            hoja.SetCellValue("G6", "=SUBTOTAL(9,G10:G" + i + ")");
            hoja.SetCellValue("H6", "=SUBTOTAL(9,H10:H" + i + ")");
            hoja.SetCellStyle("E6", fondoNaranja);
            hoja.SetCellStyle("F6", negativosRojos);
            hoja.SetCellStyle("G6", fondoNaranja);
            hoja.SetCellStyle("H6", negativosRojos);

            for (int row = 1; row <= i; row++)
            {
                for (int col = 1; col <= 16; col++)
                {
                    if (hoja.GetCellValueAsString(row, col) == "0")
                    {
                        hoja.SetCellValue(row, col, string.Empty);
                    }
                }
            }

            hoja.SetRowHeight(9, 30);
            hoja.SetRowHeight(3, 30);

            hoja.SetColumnWidth(1, 70 / 7);
            hoja.SetColumnWidth(2, 90 / 7);
            hoja.SetColumnWidth(3, 310 / 7);
            hoja.SetColumnWidth(4, 110 / 7);
            hoja.SetColumnWidth(5, 90 / 7);
            hoja.SetColumnWidth(6, 80 / 7);
            hoja.SetColumnWidth(7, 80 / 7);
            hoja.SetColumnWidth(8, 70 / 7);
            hoja.SetColumnWidth(9, 90 / 7);
            hoja.SetColumnWidth(10, 80 / 7);
            hoja.SetColumnWidth(11, 80 / 7);
            hoja.SetColumnWidth(12, 80 / 7);
            hoja.SetColumnWidth(13, 80 / 7);
            hoja.SetColumnWidth(14, 90 / 7);
            hoja.SetColumnWidth(15, 100 / 7);
            hoja.SetColumnWidth(16, 200 / 7);
            hoja.SetColumnWidth(17, 120 / 7);

            hoja.HideColumn(15, 16);
        }

        private static void agregaResumen(SLDocument resumen, Evaluacion eval)
        {
            resumen.SetCellValue("B2", "인센티브 평가표 및 상여금 내역 [S&G]");
            resumen.SetCellStyle("B2", lineaNegrita);

            DateTime fPago = new(eval.fechaFin.Year, eval.fechaFin.Month + 1, 6);
            resumen.SetCellValue("B4", "평가기간");
            resumen.SetCellValue("C4", $"{eval.fechaInicio:yyyy-MM-dd}  ~ {eval.fechaFin:yyyy-MM-dd}");

            resumen.SetCellValue("B5", "지급일");
            resumen.SetCellValue("C5", fPago.ToString("yyyy-MM-dd"));

            resumen.SetCellStyle("B4", "E5", lineaSubraya);

            resumen.SetCellValue("B7", "부서");
            resumen.SetCellValue("C7", "인원");
            resumen.SetCellValue("D7", "책정액");
            resumen.SetCellValue("E7", "실.지급액");
            resumen.SetCellValue("F7", "지급율");
            resumen.SetCellValue("G7", "비고");
            // resumen.SetCellValue("H7", "");

            resumen.SetCellStyle("B7", "H7", headerStyle);
            resumen.SetRowHeight(7, 40);

            int i = 8;

            var deptoProcesado = new HashSet<string>();
            SAESoftContext db = new();
            foreach (var ev in eval.Detalles.OrderBy(b => b.IdDepto))
            {
                var nombreDepto = ev.Departamento.Nombre;
                if (!deptoProcesado.Contains(nombreDepto))
                {
                    int cantidad = eval.Detalles.Count(b => b.IdDepto == ev.IdDepto);
                    List<int> listaEmpleados = eval.Detalles.Where(b => b.IdDepto == ev.IdDepto).Select(b => b.IdEmpleado).ToList();
                    var emps = db.EmpIncentivos.Include(e => e.HistIncentivos)
                                                       .Where(b => listaEmpleados.Contains(b.IdEmpIncentivo))
                                                       .ToList();
                    decimal asignado = 0;
                    foreach (var e in emps)
                    {
                        asignado += e.BaseCalculo;
                    }
                    decimal pagado = eval.Detalles.Where(b => b.IdDepto == ev.IdDepto).Sum(b => b.Total);

                    resumen.SetCellValue("B" + i, nombreDepto);
                    resumen.SetCellValue("C" + i, cantidad);
                    resumen.SetCellValue("D" + i, asignado);
                    resumen.SetCellValue("E" + i, pagado);
                    resumen.SetCellValue("F" + i, "=E" + i + "/D" + i);
                    i++;
                    deptoProcesado.Add(nombreDepto);
                }
            }
            resumen.SetCellStyle("B8", "H" + i, normal);
            resumen.SetColumnStyle(4, moneda);
            resumen.SetColumnStyle(5, moneda);
            resumen.SetColumnStyle(6, porcentaje);

            resumen.SetCellValue("B" + i, "Total");
            resumen.SetCellValue("C" + i, "=SUM(C8:C" + (i - 1) + ")");
            resumen.SetCellValue("D" + i, "=SUM(D8:D" + (i - 1) + ")");
            resumen.SetCellValue("E" + i, "=SUM(E8:E" + (i - 1) + ")");
            resumen.SetCellStyle("B" + i, "H" + i, header2);
            resumen.SetRowHeight(i, 40);

            var firmas = db.Firmas.Where(b => b.IdModulo == 6).ToList();
            string responsable = firmas.FirstOrDefault(b => b.puesto.Equals("RESPONSABLE"))?.firma ?? string.Empty;
            string gerente = firmas.FirstOrDefault(b => b.puesto.Equals("GERENTE"))?.firma ?? string.Empty;
            string director = firmas.FirstOrDefault(b => b.puesto.Equals("DIRECTOR"))?.firma ?? string.Empty;
            string presidente = firmas.FirstOrDefault(b => b.puesto.Equals("PRESIDENTE"))?.firma ?? string.Empty;
            i += 5;
            resumen.SetCellValue("E" + i, responsable);
            resumen.SetCellValue("F" + i, gerente);
            resumen.SetCellValue("G" + i, director);
            resumen.SetCellValue("H" + i, presidente);
            resumen.SetCellStyle("E" + i, bordeNegrita);
            resumen.SetCellStyle("F" + i, bordeNegrita);
            resumen.SetCellStyle("G" + i, bordeNegrita);
            resumen.SetCellStyle("H" + i, bordeNegrita);

            i++;
            int f = i + 3;
            resumen.DrawBorder("E" + i, "E" + f, BorderStyleValues.Thin);
            resumen.DrawBorder("F" + i, "F" + f, BorderStyleValues.Thin);
            resumen.DrawBorder("G" + i, "G" + f, BorderStyleValues.Thin);
            resumen.DrawBorder("H" + i, "H" + f, BorderStyleValues.Thin);

            resumen.SetColumnWidth(1, 64 / 7);
            resumen.SetColumnWidth(2, 106 / 7);
            resumen.SetColumnWidth(3, 81 / 7);
            resumen.SetColumnWidth(4, 100 / 7);
            resumen.SetColumnWidth(5, 100 / 7);
            resumen.SetColumnWidth(6, 100 / 7);
            resumen.SetColumnWidth(7, 100 / 7);
            resumen.SetColumnWidth(8, 100 / 7);
        }

    }
}
