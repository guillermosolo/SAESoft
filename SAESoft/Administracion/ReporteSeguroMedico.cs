using SAESoft.Models.Administracion;
using SAESoft.Models.Importaciones;
using SAESoft.Models;
using SpreadsheetLight;
using System.Data;
using System.Diagnostics;
using static SAESoft.Utilitarios.ControlFormularios;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Administracion
{
    public partial class ReporteSeguroMedico : Form
    {
        public ReporteSeguroMedico()
        {
            InitializeComponent();
        }

        private void ReporteSeguroMedico_Load(object sender, EventArgs e)
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
                string pathFile = Path.Combine(Path.GetTempPath(), "ReporteSeguroMédico.xlsx");
                if (IsFileOpen(pathFile))
                {
                    throw new Exception("El archivo está abierto. Cierre el archivo y vuelva a intentarlo.");
                }

                SLDocument excel = new();
                SLStyle headerStyle = excel.CreateStyle();
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = HorizontalAlignmentValues.Center;

                DataTable dt = new();
                dt.Columns.Add("No.", typeof(int));
                dt.Columns.Add("Empresa", typeof(string));
                dt.Columns.Add("Departamento", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Parentesco", typeof(string));
                dt.Columns.Add("Certificado", typeof(string));
                dt.Columns.Add("Carnet", typeof(string));
                using (SAESoftContext db = new())
                {
                    List<int> idsSeleccionados = new();
                    foreach (var item in clbEmpresas.CheckedItems)
                    {
                        var castedItem = (Nombre)item;
                        idsSeleccionados.Add(castedItem.IdNombre);
                    }
                    var query = db.Empleados.Include(d => d.Departamento)
                        .ThenInclude(e => e.Empresa)
                        .Include(sm => sm.SeguroMedico)
                        .Include(f => f.Familiares)
                        .ThenInclude(p => p.Parentesco)
                        .Include(f => f.Familiares)
                        .ThenInclude(smf => smf.SeguroMedico)
                        .Where(e => idsSeleccionados.Contains(e.Departamento.IdEmpresa));
                    List<Empleado> rs;
                    if (checkBox1.Checked)
                        rs = query.ToList();
                    else
                        rs = query.Where(e => e.IdSeguroMedico != null).ToList();
                    int i = 0;
                    foreach (var item in rs)
                    {
                        i++;
                        DataRow row = dt.NewRow();
                        row[0] = i;
                        row[1] = item.Departamento.Empresa.Descripcion;
                        row[2] = item.Departamento.Nombre;
                        row[3] = item.Nombres + " " + item.Apellidos;
                        row[4] = "TITULAR";
                        if (item.IdSeguroMedico != null)
                        {
                            row[5] = item.SeguroMedico.Certificado;
                            row[6] = item.SeguroMedico.Carnet;
                        }
                        dt.Rows.Add(row);
                        if (checkBox2.Checked)
                        {
                            foreach (var familiar in item.Familiares)
                            {
                                if (!(calculaEdad(familiar.FechaNac) >= 23 && familiar.Parentesco.Descripcion == "HIJO / HIJA"))
                                {
                                    i++;
                                    DataRow row2 = dt.NewRow();
                                    row2[0] = i;
                                    row2[1] = item.Departamento.Empresa.Descripcion;
                                    row2[2] = item.Departamento.Nombre;
                                    row2[3] = familiar.Nombres + " " + familiar.Apellidos;
                                    row2[4] = familiar.Parentesco.Descripcion;
                                    if (familiar.IdSeguroMedico != null)
                                    {
                                        row2[5] = familiar.SeguroMedico.Certificado;
                                        row2[6] = familiar.SeguroMedico.Carnet;
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
                excel.SetColumnWidth(5, 15);
                excel.SetColumnWidth(6, 15);
                excel.SetColumnWidth(7, 20);

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

        private static int calculaEdad(DateTime fecha)
        {
            int edad = DateTime.Now.Year - fecha.Year; // Calcula la diferencia en años

            // Verifica si aún no se ha cumplido el aniversario de nacimiento este año
            if (fecha.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            return edad;
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
