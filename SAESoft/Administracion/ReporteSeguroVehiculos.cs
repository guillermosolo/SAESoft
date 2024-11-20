using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Models.Comunes;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;
using System.Windows.Controls;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class ReporteSeguroVehiculos : Form
    {
        public ReporteSeguroVehiculos()
        {
            InitializeComponent();
        }

        private void ReporteSeguroVehiculos_Load(object sender, EventArgs e)
        {
            llenarNombres(clbEmpresas, "PLANTA");
            for (int i = 0; i < clbEmpresas.Items.Count; i++)
            {
                clbEmpresas.SetItemChecked(i, true);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteSeguroVehículos.xlsx");
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();
                SLStyle fecha = excel.CreateStyle();
                fecha.FormatCode = "dd/mm/yyyy";
                SLStyle moneda = excel.CreateStyle();
                moneda.FormatCode = "Q#,##0.00";
                SLStyle headerStyle = excel.CreateStyle();
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;

                DataTable dt = new();
                dt.Columns.Add("No.", typeof(int));
                dt.Columns.Add("Departamento", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Nombre Coreano", typeof(string));
                dt.Columns.Add("Marca", typeof(string));
                dt.Columns.Add("Color", typeof(string));
                dt.Columns.Add("Placa", typeof(string));
                dt.Columns.Add("Aseguradora", typeof(string));
                dt.Columns.Add("Póliza", typeof(string));
                dt.Columns.Add("Inicio", typeof(DateTime));
                dt.Columns.Add("Fin", typeof(DateTime));
                dt.Columns.Add("Total Prima", typeof(decimal));
                dt.Columns.Add("Deducible", typeof(decimal));
                dt.Columns.Add("Vigencia", typeof(int));
                dt.Columns.Add("Status", typeof(string));
                using (SAESoftContext db = new())
                {
                    List<int> idsSeleccionados = [];
                    foreach (var item in clbEmpresas.CheckedItems)
                    {
                        var castedItem = (Nombre)item;
                        idsSeleccionados.Add(castedItem.IdNombre);
                    }
                    var query = db.Empleados.Include(d => d.Departamento)
                        .Include(sv => sv.SeguroVehiculo)
                        .ThenInclude(a => a.Aseguradora)
                        .Where(e => idsSeleccionados.Contains(e.Departamento.IdEmpresa));
                    if (radioButton1.Checked)
                    {
                        query = query.Where(f => f.Activo);
                    }
                    else
                    {
                        query = query.Where(f => !f.Activo);
                    }
                    List<Empleado> rs;
                    if (checkBox1.Checked)
                        rs = [.. query];
                    else
                        rs = [.. query.Where(e => e.IdSeguroVehiculo != null)];
                    int i = 0;
                    foreach (var item in rs)
                    {
                        i++;
                        DataRow row = dt.NewRow();
                        row[0] = i;
                        row[1] = item.Departamento.Nombre;
                        row[2] = item.Alias;
                        row[3] = item.Nombres + " " + item.Apellidos;
                        if (item.IdSeguroVehiculo != null)
                        {
                            row[4] = item.SeguroVehiculo.Marca;
                            row[5] = item.SeguroVehiculo.Color;
                            row[6] = item.SeguroVehiculo.Placa;
                            row[7] = item.SeguroVehiculo.Aseguradora.Descripcion;
                            row[8] = item.SeguroVehiculo.Poliza;
                            row[9] = item.SeguroVehiculo.Inicio;
                            row[10] = item.SeguroVehiculo.Vencimiento;
                            row[11] = item.SeguroVehiculo.Prima;
                            row[12] = item.SeguroVehiculo.Deducible;
                            row[13] = calculaVigencia(item.SeguroVehiculo.Vencimiento);
                            if (DateTime.Now < item.SeguroVehiculo.Vencimiento)
                                row[14] = "Vigente";
                            else
                                row[14] = "Vencido";
                        }
                        dt.Rows.Add(row);
                    }
                }
                excel.ImportDataTable(1, 1, dt, true);
                excel.SetColumnWidth(1, 5);
                excel.SetColumnWidth(2, 30);
                excel.SetColumnWidth(3, 25);
                excel.SetColumnWidth(4, 25);
                excel.SetColumnWidth(5, 25);
                excel.SetColumnWidth(6, 25);
                excel.SetColumnWidth(7, 15);
                excel.SetColumnWidth(8, 30);
                excel.SetColumnWidth(9, 25);
                excel.SetColumnWidth(10, 15);
                excel.SetColumnWidth(11, 15);
                excel.SetColumnWidth(12, 15);
                excel.SetColumnWidth(13, 15);
                excel.SetColumnWidth(14, 15);


                excel.SetColumnStyle(10, fecha);
                excel.SetColumnStyle(11, fecha);
                excel.SetColumnStyle(12, moneda);
                excel.SetColumnStyle(13, moneda);


                SLWorksheetStatistics stats = excel.GetWorksheetStatistics();
                int ultimaCol = stats.EndColumnIndex;
                int penultimaCol = ultimaCol - 1;
                int ultimaFila = stats.EndRowIndex;
                string ultimaColLetra = SLConvert.ToColumnName(ultimaCol);
                string penultimaColLetra = SLConvert.ToColumnName(penultimaCol);

                for (char i = 'A'; i <= ultimaColLetra[0]; i++)
                    excel.SetCellStyle(i + "1", headerStyle);

                SLStyle normal = excel.GetCellStyle("A2");

                SLConditionalFormatting cf = new(ultimaColLetra + "2", ultimaColLetra + ultimaFila);
                SLConditionalFormatting cf2 = new(penultimaColLetra + "2", penultimaColLetra + ultimaFila);


                cf.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} < 1", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} > 0", SLHighlightCellsStyleValues.YellowFillWithDarkYellowText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} > 50", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                excel.AddConditionalFormatting(cf);
                cf.HighlightCellsContainingBlanks(true, normal);
                excel.AddConditionalFormatting(cf);

                cf2.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} < 1", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                excel.AddConditionalFormatting(cf2);
                cf2.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} > 0", SLHighlightCellsStyleValues.YellowFillWithDarkYellowText);
                excel.AddConditionalFormatting(cf2);
                cf2.HighlightCellsWithFormula($"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila} > 50", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                excel.AddConditionalFormatting(cf2);
                cf2.HighlightCellsContainingBlanks(true, normal);
                excel.AddConditionalFormatting(cf2);


                excel.SaveAs(pathFile);
                new Process { StartInfo = new ProcessStartInfo(pathFile) { UseShellExecute = true } }.Start();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int calculaVigencia(DateTime fecha)
        {
            TimeSpan diferencia = fecha - DateTime.Today;
            int dias = diferencia.Days;
            return dias;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEmpresas.Items.Count; i++)
            {
                clbEmpresas.SetItemChecked(i, checkBox3.Checked);
            }
        }
    }
}
