using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;
using Color = System.Drawing.Color;
using static SAESoft.Cache.UserData;
using System.Diagnostics;
using SpreadsheetLight;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Exportaciones
{
    public partial class frmDashboard : Form
    {
        readonly DataTable dt = new();
        public frmDashboard()
        {
            InitializeComponent();
        }

        public void estructuraGrid()
        {
            dt.Columns.Add("IdLicencia").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Fecha").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Ref.").DataType = Type.GetType("System.String");
            dt.Columns.Add("Numero").DataType = Type.GetType("System.String");
            dt.Columns.Add("Exportador").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Anulación").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Nota de Crédito").DataType = Type.GetType("System.String");
            dt.Columns.Add("Consignatario").DataType = Type.GetType("System.String");
            dt.Columns.Add("Aduana").DataType = Type.GetType("System.String");
            dt.Columns.Add("Tipo Factura").DataType = Type.GetType("System.String");
            dt.Columns.Add("Modalidad").DataType = Type.GetType("System.String");
            dt.Columns.Add("Clase 10").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Clase 10").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Simplificada").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Simplificada").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Complementaria").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Complementaria").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Descargo Manual").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Descargo Manual").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Descargo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha Descargo").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Comentarios").DataType = Type.GetType("System.String");

            dgvDashboard.DataSource = dt;
        }

        private void frmDashboard_Shown(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarTabla();
            maquillarTabla();
            dgvDashboard.ClearSelection();
        }

        private void maquillarTabla()
        {
            dgvDashboard.Columns["Comentarios"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDashboard.Columns["IdLicencia"].Visible = false;
            dgvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dgvDashboard.Rows)
            {
                if ((row.Cells["Fecha Clase 10"].Value != DBNull.Value || row.Cells["Fecha Simplificada"].Value != DBNull.Value) && row.Index != dgvDashboard.Rows.Count - 1)
                {
                    DateTime fecha = row.Cells["Fecha Clase 10"].Value != DBNull.Value ? (DateTime)row.Cells["Fecha Clase 10"].Value :
                                     row.Cells["Fecha Simplificada"].Value != DBNull.Value ? (DateTime)row.Cells["Fecha Simplificada"].Value :
                                     DateTime.MaxValue;
                    int diferencia = (int)((TimeSpan)(DateTime.Now - fecha)).TotalDays;
                    if (diferencia >= 40 && row.Cells["Fecha Descargo Manual"].Value == DBNull.Value && row.Cells["Fecha Descargo"].Value == DBNull.Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 153);
                    }
                    else if (diferencia >= 32 && row.Cells["Fecha Descargo Manual"].Value == DBNull.Value && row.Cells["Fecha Descargo"].Value == DBNull.Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 153);
                    }
                }
            }
        }

        private void icbRefresh_Click(object sender, EventArgs e)
        {
            llenarTabla();
            maquillarTabla();
            dgvDashboard.ClearSelection();
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.Nchecked;
            else
                chk.Image = Properties.Resources.Nunchecked;

        }

        private void llenarTabla()
        {
            dt.Rows.Clear();
            using SAESoftContext db = new();
            int[] tiposF = [155, 158];
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
                                        .Where(l => l.Facturas.Any(f => !tiposF.Contains(f.IdTipoFactura)));
            if (!chkFinalizado.Checked)
            {
                queryable = queryable.Where(r => r.Descargos.All(d => d.final == false));
            }
            queryable = queryable.OrderByDescending(r => r.FechaCreacion);
            foreach (var item in queryable)
            {
                foreach (var fac in item.Facturas)
                {
                    DataRow row = dt.NewRow();
                    row["IdLicencia"] = item.IdLicencia.ToString();
                    row["Fecha"] = item.Fecha;
                    row["Ref."] = fac.Referencia.ToString();
                    row["Numero"] = fac.NoFactura.ToString();
                    row["Exportador"] = fac.Exportador.Descripcion;
                    if (fac.FechaAnulacion != null)
                    {
                        row["Fecha Anulación"] = fac.FechaAnulacion;
                        row["Nota de Crédito"] = fac.NotaCredito;
                    }
                    row["Consignatario"] = fac.Consignatario.Descripcion;
                    row["Aduana"] = fac.Aduana?.Abreviatura;
                    row["Tipo Factura"] = fac.TipoFactura.Descripcion;
                    row["Modalidad"] = fac.Modalidad?.Descripcion;
                    row["Clase 10"] = item.Ducas?.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("10"))?.NumDuca ?? "";
                    row["Fecha Clase 10"] = item.Ducas.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("10")) != null ? item.Ducas.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("10"))?.Fecha : DBNull.Value;
                    row["Simplificada"] = item.Ducas?.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("11"))?.NumDuca ?? "";
                    row["Fecha Simplificada"] = item.Ducas.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("11")) != null ? item.Ducas.FirstOrDefault(d => d.TipoDuca.Descripcion.Contains("11"))?.Fecha : DBNull.Value;
                    row["Complementaria"] = item.Ducas.Where(d => d.TipoDuca.Descripcion.Contains("37") || d.TipoDuca.Descripcion.Contains("36")).OrderByDescending(d => d.Fecha).FirstOrDefault()?.NumDuca ?? "";
                    row["Fecha Complementaria"] = item.Ducas.Where(d => d.TipoDuca.Descripcion.Contains("37") || d.TipoDuca.Descripcion.Contains("36")).OrderByDescending(d => d.Fecha).FirstOrDefault() != null ? item.Ducas.Where(d => d.TipoDuca.Descripcion.Contains("37") || d.TipoDuca.Descripcion.Contains("36")).OrderByDescending(d => d.Fecha).FirstOrDefault()?.Fecha : DBNull.Value;
                    row["Descargo Manual"] = item.Descargos.FirstOrDefault(d => d.final == false)?.NumDescargo ?? "";
                    row["Fecha Descargo Manual"] = item.Descargos.FirstOrDefault(d => d.final == false) != null ? item.Descargos.FirstOrDefault(d => d.final == false)?.Fecha : DBNull.Value;
                    row["Descargo"] = item.Descargos.FirstOrDefault(d => d.final == true)?.NumDescargo ?? "";
                    row["Fecha Descargo"] = item.Descargos.FirstOrDefault(d => d.final == true) != null ? item.Descargos.FirstOrDefault(d => d.final == false)?.Fecha : DBNull.Value;
                    string comments = "";
                    foreach (var c in item.Comentarios)
                    {
                        comments += "• " + c.Comentario;
                        if (c != item.Comentarios.Last())
                        {
                            comments += "\n";
                        }
                    }
                    row["Comentarios"] = comments;
                    dt.Rows.Add(row);
                }
            }
        }

        private void dgvDashboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != dgvDashboard.Rows.Count - 1 && e.RowIndex >= 0)
            {
                if (hasPermission("MODIFICAR.LICENCIAS"))
                {
                    frmDucaDescargo ducaDescargo = new();
                    if (dgvDashboard.Rows[e.RowIndex].Cells["Descargo"].Value.ToString() != "")
                    {
                        return;
                    }
                    if (dgvDashboard.Rows[e.RowIndex].Cells["Clase 10"].Value.ToString() != "")
                    {
                        ducaDescargo.ducaAnterior = 10;
                    }
                    if (dgvDashboard.Rows[e.RowIndex].Cells["Simplificada"].Value.ToString() != "")
                    {
                        ducaDescargo.ducaAnterior = 11;
                    }
                    if (dgvDashboard.Rows[e.RowIndex].Cells["Complementaria"].Value.ToString() != "")
                    {
                        ducaDescargo.ducaAnterior = 37;
                    }
                    if (dgvDashboard.Rows[e.RowIndex].Cells["Descargo Manual"].Value.ToString() != "")
                    {
                        ducaDescargo.ducaAnterior = 99;
                    }
                    ducaDescargo.licencia = Convert.ToInt32(dgvDashboard.Rows[e.RowIndex].Cells["IdLicencia"].Value);
                    var resp = ducaDescargo.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        icbRefresh_Click(null, EventArgs.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("No posee permisos para agregar documentos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (hasPermission("CREAR.LICENCIAS"))
                {
                    frmLicencias licencias = new();
                    var resp = licencias.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        icbRefresh_Click(null, EventArgs.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("No posee permisos para crear licencias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvDashboard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != dgvDashboard.Rows.Count - 1 && e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    frmComentarios comment = new()
                    {
                        referencia = dgvDashboard.Rows[e.RowIndex].Cells["Ref."].Value.ToString(),
                        idLicencia = Convert.ToInt32(dgvDashboard.Rows[e.RowIndex].Cells["idLicencia"].Value),
                    };
                    var resp = comment.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        icbRefresh_Click(sender, EventArgs.Empty);
                    }
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            { 
                string fechaDash = "(" + DateTime.Now.ToString("ddMMMyyyy").ToUpper().Replace(".","") + ")";
                string pathFile = Path.Combine(Path.GetTempPath(), "Dashboard "+fechaDash+".xlsx");
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

                excel.ImportDataTable(1, 1, dt, true);

                for (char i = 'A'; i <= 'V'; i++)
                    excel.SetCellStyle(i + "1", headerStyle);

                excel.HideColumn(1);
                excel.SetColumnStyle(2, fecha);
                excel.SetColumnStyle(6, fecha);
                excel.SetColumnStyle(13, fecha);
                excel.SetColumnStyle(15, fecha);
                excel.SetColumnStyle(17, fecha);
                excel.SetColumnStyle(19, fecha);
                excel.SetColumnStyle(21, fecha);

                excel.SetColumnWidth(2, 15);
                excel.SetColumnWidth(3, 10);
                excel.SetColumnWidth(4, 25);
                excel.SetColumnWidth(5, 30);
                excel.SetColumnWidth(6, 15);
                excel.SetColumnWidth(7, 25);
                excel.SetColumnWidth(8, 25);
                excel.SetColumnWidth(9, 25);
                excel.SetColumnWidth(10, 20);
                excel.SetColumnWidth(11, 12);
                excel.SetColumnWidth(12, 25);
                excel.SetColumnWidth(13, 15);
                excel.SetColumnWidth(14, 25);
                excel.SetColumnWidth(15, 15);
                excel.SetColumnWidth(16, 25);
                excel.SetColumnWidth(17, 17);
                excel.SetColumnWidth(18, 25);
                excel.SetColumnWidth(19, 15);
                excel.SetColumnWidth(20, 25);
                excel.SetColumnWidth(21, 15);
                excel.SetColumnWidth(22, 35);

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
