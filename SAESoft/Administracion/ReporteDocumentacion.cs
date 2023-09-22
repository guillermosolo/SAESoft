using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Models.Comunes;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class ReporteDocumentacion : Form
    {
        public ReporteDocumentacion()
        {
            InitializeComponent();
        }

        private void ReporteDocumentacion_Load(object sender, EventArgs e)
        {
            llenarNombres(clbEmpresas, "PLANTA");
            for (int i = 0; i < clbEmpresas.Items.Count; i++)
            {
                clbEmpresas.SetItemChecked(i, true);
            }
            using SAESoftContext db = new();
            cboDocumento.DataSource = db.TiposDocumento.Where(d => d.activo).Where(t => !new List<int> { 10, 12 }.Contains(t.IdTipoDocumento)).ToList();
            cboDocumento.DisplayMember = "Nombre";
            cboDocumento.ValueMember = "IdTipoDocumento";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteDocumentación.xlsx");
                int doc = Convert.ToInt32(cboDocumento.SelectedValue);
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();

                SLStyle normal = new();
                normal.Font.Bold = false;
                normal.Font.Italic = false;
                normal.Fill.SetPattern(PatternValues.None, System.Drawing.Color.Black, System.Drawing.Color.White);

                SLStyle miles = excel.CreateStyle();
                miles.FormatCode = "#,##0";

                SLStyle fecha = excel.CreateStyle();
                fecha.FormatCode = "dd/mm/yyyy";

                SLStyle headerStyle = excel.CreateStyle();
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;

                SLStyle mergeStyle = excel.CreateStyle();
                mergeStyle.Alignment.Vertical = VerticalAlignmentValues.Center;

                SLStyle cancelado = new();
                cancelado.SetFontColor(System.Drawing.Color.Black);
                cancelado.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Black, System.Drawing.Color.LightGray);

                DataTable dt = new();
                dt.Columns.Add("No.", typeof(int));
                dt.Columns.Add("Empresa", typeof(string));
                dt.Columns.Add("Departamento", typeof(string));
                dt.Columns.Add("Puesto", typeof(string));
                dt.Columns.Add("Nombre Coreano", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Nombre Español", typeof(string));
                dt.Columns.Add("Fecha Ingreso", typeof(DateTime));
                if (radioButton2.Checked)
                {
                    dt.Columns.Add("Fecha Egreso", typeof(DateTime));
                }
                if (checkBox2.Checked)
                    dt.Columns.Add("Parentesco", typeof(string));
                if (new List<int> { 1, 2, 5, 8 }.Contains(doc))
                {
                    dt.Columns.Add("Numero", typeof(string));
                    dt.Columns.Add("Inicio", typeof(DateTime));
                    dt.Columns.Add("Vencimiento", typeof(DateTime));
                    dt.Columns.Add("Vigencia", typeof(int));
                    dt.Columns.Add("Estatus", typeof(string));
                }
                else if (new List<int> { 3, 11 }.Contains(doc))
                {
                    dt.Columns.Add("Numero", typeof(string));
                    dt.Columns.Add("Inicio", typeof(DateTime));
                }
                else if (doc == 4)
                {
                    dt.Columns.Add("Tipo", typeof(string));
                    dt.Columns.Add("Resolución", typeof(string));
                    dt.Columns.Add("Vencimiento", typeof(DateTime));
                    dt.Columns.Add("Vigencia", typeof(int));
                    dt.Columns.Add("Estatus", typeof(string));
                }
                else if (doc == 6)
                {
                    dt.Columns.Add("Tipo", typeof(string));
                    dt.Columns.Add("Resolución", typeof(string));
                    dt.Columns.Add("Inicio", typeof(DateTime));
                    dt.Columns.Add("Vencimiento", typeof(DateTime));
                    dt.Columns.Add("Vigencia", typeof(int));
                    dt.Columns.Add("Estatus", typeof(string));
                }
                else if (doc == 7)
                {
                    dt.Columns.Add("Numero", typeof(string));
                    dt.Columns.Add("Contratante", typeof(string));
                }
                else if (doc == 9)
                {
                    dt.Columns.Add("Tipo", typeof(string));
                    dt.Columns.Add("Expediente", typeof(string));
                    dt.Columns.Add("Vencimiento", typeof(DateTime));
                    dt.Columns.Add("Vigencia", typeof(int));
                    dt.Columns.Add("Estatus", typeof(string));
                }

                using (SAESoftContext db = new())
                {
                    List<int> idsSeleccionados = new();
                    foreach (var item in clbEmpresas.CheckedItems)
                    {
                        var castedItem = (Nombre)item;
                        idsSeleccionados.Add(castedItem.IdNombre);
                    }
                    var query = db.Empleados.Include(d => d.Departamento)
                                            .Include(co => co.Contrato)
                                            .ThenInclude(pl => pl.Empresa)
                                            .Include(r => r.Residencia)
                                            .ThenInclude(rt => rt.Tipo)
                                            .Include(p => p.Puesto)
                                            .Include(f => f.Familiares)
                                            .ThenInclude(p => p.Parentesco)
                                            .Include(f => f.Familiares)
                                            .ThenInclude(df => df.Documentos)
                                            .ThenInclude(dft => dft.Tipo)
                                            .Include(f => f.Familiares)
                                            .ThenInclude(rf => rf.Residencia)
                                            .ThenInclude(rft => rft.Tipo)
                                            .Include(f => f.Familiares)
                                            .ThenInclude(smf => smf.SeguroMedico)
                                            .Include(c => c.Documentos)
                                            .ThenInclude(t => t.Tipo)
                                            .Include(sv => sv.SeguroVehiculo)
                                            .ThenInclude(t => t.Aseguradora)
                                            .Include(p => p.PermisoTrabajo)
                                            .ThenInclude(t => t.Tipo)
                                            .Include(sm => sm.SeguroMedico)
                                            .Include(n => n.Nombramientos)
                                            .ThenInclude(t => t.Tipo)
                                            .Include(n => n.Nombramientos)
                                            .ThenInclude(e => e.Empresa)
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
                        rs = query.ToList();
                    else
                    {
                        if (new List<int> { 1, 2, 3, 5, 8, 11 }.Contains(doc))
                        {
                            rs = query.Where(d => d.Documentos.Any(d => d.IdTipo == doc)).ToList();
                        }
                        else if (doc == 4)
                        {
                            rs = query.Where(d => d.Residencia != null).ToList();
                        }
                        else if (doc == 6)
                        {
                            rs = query.Where(d => d.PermisoTrabajo != null).ToList();
                        }
                        else if (doc == 7)
                        {
                            rs = query.Where(d => d.Contrato != null).ToList();
                        }
                        else if (doc == 9)
                        {
                            rs = query.Where(d => d.Nombramientos.Any(d => !d.Cancelado)).ToList();
                        }
                        else
                        {
                            rs = query.ToList();
                        }
                    }
                    int i = 0;
                    foreach (var item in rs)
                    {
                        i++;
                        DataRow row = dt.NewRow();
                        row["No."] = i;
                        row["Empresa"] = item.Departamento.Empresa.Descripcion;
                        row["Departamento"] = item.Departamento.Nombre;
                        row["Puesto"] = item.Puesto.Descripcion;
                        row["Nombre"] = item.Nombres + " " + item.Apellidos;
                        row["Nombre Español"] = item.Alias;
                        row["Nombre Coreano"] = item.NombreCoreano;
                        row["Fecha Ingreso"] = item.FechaIngreso;
                        if (radioButton2.Checked)
                            row["Fecha Egreso"] = item.FechaBaja;
                        if (checkBox2.Checked)
                            row["Parentesco"] = "TITULAR";
                        if (new List<int> { 1, 2, 5, 8 }.Contains(doc))
                        {
                            DateTime? vencimiento = item.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Vencimiento;
                            DateTime? inicio = item.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Fecha;
                            row["Numero"] = item.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Numero ?? "";
                            row["Inicio"] = inicio.HasValue ? inicio.Value : DBNull.Value;
                            row["Vencimiento"] = vencimiento.HasValue ? vencimiento.Value : DBNull.Value;
                            row["Vigencia"] = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : DBNull.Value;
                            row["Estatus"] = vencimiento.HasValue ? (calculaVigencia(vencimiento.Value) > 0 ? "Vigente" : "Vencido") : DBNull.Value;
                        }
                        else if (new List<int> { 3, 11 }.Contains(doc))
                        {
                            DateTime? inicio = item.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Fecha;
                            row["Numero"] = item.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Numero ?? "";
                            row["Inicio"] = inicio.HasValue ? inicio.Value : DBNull.Value;
                        }
                        else if (doc == 4)
                        {
                            DateTime? vencimiento = item.Residencia?.Vencimiento;
                            row["Tipo"] = item.Residencia?.Tipo.Descripcion;
                            row["Resolución"] = item.Residencia?.Resolucion; 
                            if (item.Residencia.Tipo.Descripcion != "PERMANENTE")
                            {
                                row["Vencimiento"] = vencimiento.HasValue ? vencimiento.Value : DBNull.Value;
                                row["Vigencia"] = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : DBNull.Value;
                            } else
                            {
                                row["Vigencia"] = 0;
                            }
                            row["Estatus"] = vencimiento.HasValue ? (calculaVigencia(vencimiento.Value) > 0 ? "Vigente" : "Vencido") : DBNull.Value;
                        }
                        else if (doc == 6)
                        {
                            DateTime? inicio = item.PermisoTrabajo?.Inicio;
                            DateTime? vencimiento = item.PermisoTrabajo?.Vencimiento;
                            row["Tipo"] = item.PermisoTrabajo?.Tipo.Descripcion;
                            row["Resolución"] = item.PermisoTrabajo?.Resolucion;
                            row["Inicio"] = inicio.HasValue ? inicio.Value : DBNull.Value;
                            row["Vencimiento"] = vencimiento.HasValue ? vencimiento.Value : DBNull.Value;
                            row["Vigencia"] = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : DBNull.Value;
                            row["Estatus"] = vencimiento.HasValue ? (calculaVigencia(vencimiento.Value) > 0 ? "Vigente" : "Vencido") : DBNull.Value;
                        }
                        else if (doc == 7)
                        {
                            row["Numero"] = item.Contrato?.Numero;
                            row["Contratante"] = item.Contrato?.Empresa.Descripcion;
                        }
                        else if (doc == 9)
                        {
                            int x = 0;
                            foreach (var nom in item.Nombramientos)
                            {
                                DataRow row2 = dt.NewRow();
                                if (x == 0)
                                {
                                    x = 1;
                                    row2["No."] = i;
                                    row2["Departamento"] = item.Departamento.Nombre;
                                    row2["Puesto"] = item.Puesto.Descripcion;
                                    row2["Nombre"] = item.Nombres + " " + item.Apellidos;
                                    row2["Nombre Español"] = item.Alias;
                                    row2["Nombre Coreano"] = item.NombreCoreano;
                                    row2["Fecha Ingreso"] = item.FechaIngreso;
                                }
                                row2["Empresa"] = nom.Empresa.Descripcion;
                                row2["Tipo"] = nom.Tipo.Descripcion;
                                row2["Expediente"] = nom.Expediente;
                                row2["Vencimiento"] = nom.Vencimiento.Date;
                                row2["Vigencia"] = calculaVigencia(nom.Vencimiento);
                                if (nom.Cancelado)
                                {
                                    row2["Estatus"] = "Cancelado";
                                }
                                else
                                {
                                    row2["Estatus"] = calculaVigencia(nom.Vencimiento) > 0 ? "Vigente" : "Vencido";
                                }
                                dt.Rows.Add(row2);
                            }
                        }
                        if (doc != 9)
                        {
                            dt.Rows.Add(row);
                            if (checkBox2.Checked)
                            {
                                foreach (var familiar in item.Familiares)
                                {
                                    i++;
                                    DataRow row2 = dt.NewRow();
                                    row2["No."] = i;
                                    row2["Nombre"] = familiar.Nombres + " " + familiar.Apellidos;
                                    row2["Parentesco"] = familiar.Parentesco.Descripcion;
                                    if (new List<int> { 1, 2, 5 }.Contains(doc))
                                    {
                                        DateTime? vencimiento = familiar.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Vencimiento;
                                        DateTime? inicio = familiar.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Fecha;
                                        row2["Numero"] = familiar.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Numero ?? "";
                                        row2["Inicio"] = inicio.HasValue ? inicio.Value : DBNull.Value;
                                        row2["Vencimiento"] = vencimiento.HasValue ? vencimiento.Value : DBNull.Value;
                                        row2["Vigencia"] = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : DBNull.Value;
                                        row2["Estatus"] = vencimiento.HasValue ? (calculaVigencia(vencimiento.Value) > 0 ? "Vigente" : "Vencido") : DBNull.Value;
                                    }
                                    else if (new List<int> { 3, 11 }.Contains(doc))
                                    {
                                        DateTime? inicio = familiar.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Fecha;
                                        row["Numero"] = familiar.Documentos.Where(d => d.IdTipo == doc).FirstOrDefault()?.Numero ?? "";
                                        row["Inicio"] = inicio.HasValue ? inicio.Value : DBNull.Value;
                                    }
                                    else if (doc == 4)
                                    {
                                        DateTime? vencimiento = familiar.Residencia?.Vencimiento;
                                        row2["Tipo"] = familiar.Residencia?.Tipo.Descripcion;
                                        row2["Resolución"] = familiar.Residencia?.Resolucion;
                                        row2["Vencimiento"] = vencimiento.HasValue ? vencimiento.Value : DBNull.Value;
                                        row2["Vigencia"] = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : DBNull.Value;
                                        row2["Estatus"] = vencimiento.HasValue ? (calculaVigencia(vencimiento.Value) > 0 ? "Vigente" : "Vencido") : DBNull.Value;
                                    }
                                    dt.Rows.Add(row2);
                                }
                            }
                        }
                    }
                }
                excel.ImportDataTable(1, 1, dt, true);
                excel.SetColumnWidth(1, 5);
                excel.SetColumnWidth(2, 20);
                excel.SetColumnWidth(3, 25);
                excel.SetColumnWidth(4, 25);
                excel.SetColumnWidth(5, 20);
                excel.SetColumnWidth(6, 30);
                excel.SetColumnWidth(7, 20);
                excel.SetColumnWidth(8, 20);
                excel.SetColumnStyle(8, fecha);
                int p = 1;
                if (radioButton2.Checked)
                {
                    excel.SetColumnWidth(8 + p, 20);
                    excel.SetColumnStyle(8 + p, fecha);
                    p += 1;
                }
                if (checkBox2.Checked)
                {
                    excel.SetColumnWidth(8 + p, 15);
                    p += 1;
                }
                if (new List<int> { 1, 2, 5, 8 }.Contains(doc))
                {
                    excel.SetColumnWidth(8 + p, 15);
                    excel.SetColumnWidth(9 + p, 15);
                    excel.SetColumnWidth(10 + p, 18);
                    excel.SetColumnWidth(11 + p, 15);
                    excel.SetColumnWidth(12 + p, 15);

                    excel.SetColumnStyle(9 + p, fecha);
                    excel.SetColumnStyle(10 + p, fecha);
                    excel.SetColumnStyle(11 + p, miles);
                }
                else if (new List<int> { 3, 11 }.Contains(doc))
                {
                    excel.SetColumnWidth(8 + p, 15);
                    excel.SetColumnWidth(9 + p, 15);

                    excel.SetColumnStyle(9 + p, fecha);
                }
                else if (doc == 4)
                {
                    excel.SetColumnWidth(8 + p, 35);
                    excel.SetColumnWidth(9 + p, 15);
                    excel.SetColumnWidth(10 + p, 18);
                    excel.SetColumnWidth(11 + p, 15);
                    excel.SetColumnWidth(12 + p, 15);

                    excel.SetColumnStyle(10 + p, fecha);
                    excel.SetColumnStyle(11 + p, miles);
                }
                else if (doc == 6)
                {
                    excel.SetColumnWidth(8 + p, 30);
                    excel.SetColumnWidth(9 + p, 25);
                    excel.SetColumnWidth(10 + p, 15);
                    excel.SetColumnWidth(11 + p, 15);
                    excel.SetColumnWidth(12 + p, 15);
                    excel.SetColumnWidth(13 + p, 15);

                    excel.SetColumnStyle(10 + p, fecha);
                    excel.SetColumnStyle(11 + p, fecha);
                    excel.SetColumnStyle(12 + p, miles);
                }
                else if (doc == 7)
                {
                    excel.SetColumnWidth(8 + p, 25);
                    excel.SetColumnWidth(9 + p, 15);
                }
                else if (doc == 9)
                {
                    excel.SetColumnWidth(2, 25);
                    excel.SetColumnWidth(8 + p, 50);
                    excel.SetColumnWidth(9 + p, 15);
                    excel.SetColumnWidth(10 + p, 15);
                    excel.SetColumnWidth(11 + p, 15);
                    excel.SetColumnWidth(12 + p, 15);

                    excel.SetColumnStyle(10 + p, fecha);
                    excel.SetColumnStyle(11 + p, miles);
                }


                SLWorksheetStatistics stats = excel.GetWorksheetStatistics();
                int filaActual;
                int ultimaCol = stats.EndColumnIndex;
                int penultimaCol = ultimaCol - 1;
                int ultimaFila = stats.EndRowIndex;
                string ultimaColLetra = SLConvert.ToColumnName(ultimaCol);
                string penultimaColLetra = SLConvert.ToColumnName(penultimaCol);

                List<char> letras = new();

                if (doc == 9)
                {
                    letras = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                }
                else
                {
                    letras = new List<char> { 'A', 'B', 'C', 'D', 'E' };
                }
                foreach (char l in letras)
                {
                    filaActual = 2;
                    while (filaActual <= ultimaFila)
                    {
                        string celdaActual = l + filaActual.ToString();
                        if (string.IsNullOrEmpty(excel.GetCellValueAsString(celdaActual)))
                        {
                            int filaInicioVacias = filaActual;
                            int filaFinVacias = filaActual;
                            while (filaFinVacias <= ultimaFila && string.IsNullOrEmpty(excel.GetCellValueAsString(l.ToString() + filaFinVacias)))
                            {
                                filaFinVacias++;
                            }

                            string celdaSuperior = l + (filaInicioVacias - 1).ToString();
                            string celdaInferior = l + (filaFinVacias - 1).ToString();
                            excel.MergeWorksheetCells(celdaSuperior, celdaInferior);
                            excel.SetCellStyle(celdaSuperior, celdaInferior, mergeStyle);

                            filaActual = filaFinVacias;
                        }
                        else
                        {
                            filaActual++;
                        }

                    }
                }

                for (char i = 'A'; i <= ultimaColLetra[0]; i++)
                    excel.SetCellStyle(i + "1", headerStyle);

                if (new List<int> { 1, 2, 4, 5, 6, 8, 9 }.Contains(doc))
                {
                    SLConditionalFormatting cf = new(ultimaColLetra + "2", ultimaColLetra + ultimaFila);
                    SLConditionalFormatting cf2 = new(penultimaColLetra + "2", penultimaColLetra + ultimaFila);

                    String rangoP = $"{penultimaColLetra}2:{penultimaColLetra}{ultimaFila}";
                    String rangoU = $"{ultimaColLetra}2:{ultimaColLetra}{ultimaFila}";
                    String rangoI = $"I2:I{ultimaFila}"; //esto es para las residencias permanentes

                    cf2.HighlightCellsWithFormula(rangoP + "< 1", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                    excel.AddConditionalFormatting(cf2);
                    cf2.HighlightCellsWithFormula(rangoP + "> 0", SLHighlightCellsStyleValues.YellowFillWithDarkYellowText);
                    excel.AddConditionalFormatting(cf2);
                    cf2.HighlightCellsWithFormula(rangoP + "> 50", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                    excel.AddConditionalFormatting(cf2);
                    cf2.HighlightCellsWithFormula(rangoI + "=\"PERMANENTE\"", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                    excel.AddConditionalFormatting(cf2);
                    cf2.HighlightCellsWithFormula(rangoU + "= \"Cancelado\"", cancelado);
                    excel.AddConditionalFormatting(cf2);
                    cf2.HighlightCellsContainingBlanks(true, normal);
                    excel.AddConditionalFormatting(cf2);

                    cf.HighlightCellsWithFormula(rangoP + "< 1", SLHighlightCellsStyleValues.LightRedFillWithDarkRedText);
                    excel.AddConditionalFormatting(cf);
                    cf.HighlightCellsWithFormula(rangoP + "> 0", SLHighlightCellsStyleValues.YellowFillWithDarkYellowText);
                    excel.AddConditionalFormatting(cf);
                    cf.HighlightCellsWithFormula(rangoP + "> 50", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                    excel.AddConditionalFormatting(cf);
                    cf.HighlightCellsWithFormula(rangoI + "=\"PERMANENTE\"", SLHighlightCellsStyleValues.GreenFillWithDarkGreenText);
                    excel.AddConditionalFormatting(cf);
                    cf.HighlightCellsWithFormula(rangoU + "= \"Cancelado\"", cancelado);
                    excel.AddConditionalFormatting(cf);
                    cf.HighlightCellsContainingBlanks(true, normal);
                    excel.AddConditionalFormatting(cf);
                }

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
