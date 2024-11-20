using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;

namespace SAESoft.Importaciones
{
    public partial class frmDashboard : Form
    {
        readonly DataTable dt = new();
        public frmDashboard()
        {
            InitializeComponent();

        }

        private void frmDashboard_Shown(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarTabla();
            maquillarTabla();
            dgvDashboard.ClearSelection();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdContenedor").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Contenedor").DataType = Type.GetType("System.String");
            dt.Columns.Add("Via").DataType = Type.GetType("System.String");
            dt.Columns.Add("Pólizas").DataType = Type.GetType("System.String");
            dt.Columns.Add("BUrgente").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Urgente").DataType = Type.GetType("System.String");
            dt.Columns.Add("ETA").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Destino").DataType = Type.GetType("System.String");
            dt.Columns.Add("Elaborar Póliza").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Póliza Puerto").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("ATC y Aduana").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Llegada Fábrica").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Salida Fábrica").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("IdImportacion").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Originales").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Revisiones").DataType = Type.GetType("System.String");
            dt.Columns.Add("Selectivo Rojo").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Comentarios").DataType = Type.GetType("System.String");
            dgvDashboard.DataSource = dt;
            dgvDashboard.Columns["Via"].Visible = false;
            dgvDashboard.Columns["IdContenedor"].Visible = false;
            dgvDashboard.Columns["IdImportacion"].Visible = false;
            dgvDashboard.Columns["Originales"].Visible = false;
            dgvDashboard.Columns["Selectivo Rojo"].Visible = false;
            dgvDashboard.Columns["BUrgente"].Visible = false;
        }

        private void llenarTabla()
        {
            dt.Rows.Clear();
            using SAESoftContext db = new();
            var queryable = db.Importaciones.Include(r => r.Revisiones)
                                            .Include(r => r.BL)
                                            .ThenInclude(p => p.Polizas)
                                            .Include(r => r.Destino)
                                            .Include(r => r.Contenedores)
                                            .ThenInclude(c => c.Pago)
                                            .Include(r => r.ImportStatus)
                                            .Include(r => r.ImportHistorial)
                                            .ThenInclude(rh => rh.ImportStatus)
                                            .Select(i => new
                                            {
                                                i.IdImport,
                                                i.IdDestino,
                                                i.ETA,
                                                i.Destino,
                                                i.ImportStatus,
                                                i.DocOriginales,
                                                i.IdUsuario,
                                                i.FechaCreacion,
                                                i.Via,
                                                i.urgente,
                                                i.personaUrgente,
                                                i.BL,
                                                Revisiones = i.Revisiones.Select(r => new
                                                {
                                                    r.IdRevision,
                                                    r.Descripcion
                                                }),
                                                Contenedores = i.Contenedores.Select(c => new
                                                {
                                                    c.IdContenedor,
                                                    c.Numero,
                                                    c.Furgon
                                                }),
                                                ImportHistorial = i.ImportHistorial.Select(ih => new
                                                {
                                                    ih.IdImportStatus,
                                                    ih.ImportStatus,
                                                    ih.FechaCreacion,
                                                    ih.Observaciones
                                                })
                                            }).Where(r => true);
            if (hasRole(DigitadorImportaciones))
                queryable = queryable.Where(r => r.IdUsuario == usuarioLogged.IdUsuario);
            if (!chkFinalizado.Checked)
                queryable = queryable.Where(r => !r.ImportStatus.ultimo);
            queryable = queryable.OrderByDescending(r => r.FechaCreacion);
            foreach (var item in queryable)
            {
                if (item.Contenedores.Any())
                {
                    foreach (var cont in item.Contenedores)
                    {
                        DataRow row = dt.NewRow();
                        row["IdContenedor"] = cont.IdContenedor;
                        row["Contenedor"] = cont.Furgon ?? cont.Numero;
                        row["ETA"] = item.ETA.Date;
                        row["Via"] = item.Via;
                        row["BUrgente"] = item.urgente;
                        row["Urgente"] = item.urgente ? item.personaUrgente : "";
                        foreach (var _bl in item.BL)
                        {
                            if (!string.IsNullOrEmpty(row["Pólizas"].ToString()))
                            {
                                row["Pólizas"] += ", ";
                            }

                            row["Pólizas"] += string.Join(",", _bl.Polizas.Select(p => p.Numero));
                        }
                        if (item.IdDestino != null)
                            row["Destino"] = item.Destino.Descripcion;
                        foreach (var hist in item.ImportHistorial)
                        {
                            if (hist.ImportStatus.Descripcion.Contains("Elaborar Póliza"))
                            {
                                row["Elaborar Póliza"] = hist.FechaCreacion.Date;
                            }
                            if (hist.ImportStatus.Descripcion.Contains("Enviar Póliza"))
                            {
                                row["Póliza Puerto"] = hist.FechaCreacion.Date;
                            }
                            if (hist.ImportStatus.Descripcion.Contains("ATC"))
                            {
                                row["ATC y Aduana"] = hist.FechaCreacion.Date;
                            }
                            if (hist.ImportStatus.Descripcion.Contains("Llegada"))
                            {
                                row["Llegada Fábrica"] = hist.FechaCreacion.Date;
                            }
                            if (hist.ImportStatus.Descripcion.Contains("Salida de Fábrica"))
                            {
                                row["Salida Fábrica"] = hist.FechaCreacion.Date;
                            }
                        }
                        row["IdImportacion"] = item.IdImport;
                        row["Originales"] = item.DocOriginales;
                        row["Revisiones"] = string.Join(",", item.Revisiones.Where(r => r.IdRevision != SelectivoRojo).Select(r => r.Descripcion));
                        if (item.Revisiones.Any(r => r.IdRevision == SelectivoRojo))
                            row["Selectivo Rojo"] = true;
                        else
                            row["Selectivo Rojo"] = false;
                        var ultimo = item.ImportHistorial.LastOrDefault();
                        row["Comentarios"] = ultimo.IdImportStatus == Comentario ? ultimo.FechaCreacion.ToShortDateString() + ": " + ultimo.Observaciones : "";
                        dt.Rows.Add(row);
                    }
                }
                // ESTA OPCION ES PARA AEREO Y ESTÁ ASÍ PORQUE AQUI NO EXISTEN CONTENEDORES... AUNQUE PAREZCAN LO MISMO SON DOS PROCESOS DISTINTOS.
                else
                {
                    DataRow row = dt.NewRow();
                    row["IdContenedor"] = item.BL.FirstOrDefault().IdBL.ToString();
                    row["Contenedor"] = item.BL.FirstOrDefault().Numero;
                    row["ETA"] = item.ETA.Date;
                    row["Via"] = item.Via;
                    row["BUrgente"] = item.urgente;
                    row["Urgente"] = item.urgente ? item.personaUrgente : "";
                    foreach (var _bl in item.BL)
                    {
                        if (!string.IsNullOrEmpty(row["Pólizas"].ToString()))
                        {
                            row["Pólizas"] += ", ";
                        }

                        row["Pólizas"] += string.Join(",", _bl.Polizas.Select(p => p.Numero));
                    }
                    if (item.IdDestino != null)
                        row["Destino"] = item.Destino.Descripcion;
                    foreach (var hist in item.ImportHistorial)
                    {
                        if (hist.ImportStatus.Descripcion.Contains("Elaborar Póliza"))
                        {
                            row["Elaborar Póliza"] = hist.FechaCreacion.Date;
                        }
                        if (hist.ImportStatus.Descripcion.Contains("Enviar Póliza"))
                        {
                            row["Póliza Puerto"] = hist.FechaCreacion.Date;
                        }
                        if (hist.ImportStatus.Descripcion.Contains("ATC"))
                        {
                            row["ATC y Aduana"] = hist.FechaCreacion.Date;
                        }
                        if (hist.ImportStatus.Descripcion.Contains("Llegada"))
                        {
                            row["Llegada Fábrica"] = hist.FechaCreacion.Date;
                        }
                        if (hist.ImportStatus.Descripcion.Contains("Salida"))
                        {
                            row["Salida Fábrica"] = hist.FechaCreacion.Date;
                        }
                    }
                    row["IdImportacion"] = item.IdImport;
                    row["Originales"] = item.DocOriginales;
                    row["Revisiones"] = string.Join(",", item.Revisiones.Where(r => r.IdRevision != SelectivoRojo).Select(r => r.Descripcion));
                    if (item.Revisiones.Any(r => r.IdRevision == SelectivoRojo))
                        row["Selectivo Rojo"] = true;
                    else
                        row["Selectivo Rojo"] = false;
                    var ultimo = item.ImportHistorial.LastOrDefault();
                    row["Comentarios"] = ultimo.IdImportStatus == Comentario ? ultimo.FechaCreacion.ToShortDateString() + ": " + ultimo.Observaciones : "";
                    dt.Rows.Add(row);
                }
            }

        }

        private void maquillarTabla()
        {
            foreach (DataGridViewRow row in dgvDashboard.Rows)
            {
                if (!(Boolean)row.Cells["Originales"].Value)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255,255,153);
                }
                if ((Boolean)row.Cells["Selectivo Rojo"].Value)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 51, 51);
                }
                if ((Boolean)row.Cells["BUrgente"].Value)
                {
                    row.Cells["Urgente"].Style.BackColor = Color.FromArgb(255,204,153);
                }
            }
            dgvDashboard.Columns["Revisiones"].Width = 250;
            dgvDashboard.Columns["Comentarios"].Width = 500;
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

        private void dgvDashboard_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Obtener el número de fila actual
            int rowNumber = (e.RowIndex + 1);

            // Crear un rectángulo para el encabezado de fila
            Rectangle headerBounds = new(e.RowBounds.Left, e.RowBounds.Top, dgvDashboard.RowHeadersWidth, e.RowBounds.Height);

            // Dibujar el número de fila en el encabezado de fila
            TextRenderer.DrawText(e.Graphics, rowNumber.ToString(), this.Font, headerBounds, this.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvDashboard_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgvDashboard.Rows[e.RowIndex].Cells["Via"].Value.ToString();
            int imp = (int)dgvDashboard.Rows[e.RowIndex].Cells["IdImportacion"].Value;
            if (v == "M")
            {
                if (hasPermission("VER.MARITIMO"))
                {
                    frmMaritimo mar = new()
                    {
                        individual = imp
                    };
                    mar.mostrarIndividual((Panel)this.Parent);
                }
                }
            else
            {
                if (hasPermission("VER.AEREO"))
                {
                    frmAereo aire = new()
                    {
                        individual = imp
                    };
                    aire.mostrarIndividual((Panel)this.Parent);
                }
            }
        }

        private void dgvDashboard_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                maquillarTabla();
            }
        }
    }
}
