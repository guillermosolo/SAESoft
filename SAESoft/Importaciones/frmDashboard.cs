using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using System.Windows.Forms;
using SAESoft.Models.Importaciones;

namespace SAESoft.Importaciones
{
    public partial class frmDashboard : Form
    {
        DataTable dt = new DataTable();
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
            // dt.Columns.Add("Pólizas").DataType = Type.GetType("System.String");
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
        }

        private void llenarTabla()
        {
            dt.Rows.Clear();
            using (SAESoftContext db = new SAESoftContext())
            {
                var queryable = db.Importaciones.Include(r => r.Revisiones)
                                                .Include(r => r.BL)
                                                .Include(r => r.Destino)
                                                .Include(r => r.Contenedores)
                                                .ThenInclude(c => c.Pago)
                                                .Include(r => r.ImportStatus)
                                                .Include(r => r.ImportHistorial)
                                                .ThenInclude(rh => rh.ImportStatus)
                                                .Select(i => new
                                                {
                                                    IdImport = i.IdImport,
                                                    IdDestino = i.IdDestino,
                                                    ETA = i.ETA,
                                                    Destino = i.Destino,
                                                    ImportStatus = i.ImportStatus,
                                                    DocOriginales = i.DocOriginales,
                                                    IdUsuario = i.IdUsuario,
                                                    FechaCreacion = i.FechaCreacion,
                                                    Via = i.Via,
                                                    BL = i.BL,
                                                    Revisiones = i.Revisiones.Select(r => new
                                                    {
                                                        IdRevision = r.IdRevision,
                                                        Descripcion = r.Descripcion
                                                    }),
                                                    Contenedores = i.Contenedores.Select(c => new
                                                    {
                                                        IdContenedor = c.IdContenedor,
                                                        Numero = c.Numero,
                                                    }),
                                                    ImportHistorial = i.ImportHistorial.Select(ih => new
                                                    {
                                                        IdImportStatus = ih.IdImportStatus,
                                                        ImportStatus = ih.ImportStatus,
                                                        FechaCreacion = ih.FechaCreacion,
                                                        Observaciones = ih.Observaciones
                                                    })
                                                }).Where(r => 1 == 1);
                if (hasRole(DigitadorImportaciones))
                    queryable = queryable.Where(r => r.IdUsuario == usuarioLogged.IdUsuario);
                if (!chkFinalizado.Checked)
                    queryable = queryable.Where(r => !r.ImportStatus.ultimo);
                queryable = queryable.OrderByDescending(r => r.FechaCreacion);
                foreach (var item in queryable)
                {
                    if (item.Contenedores.Count() > 0)
                    {
                        foreach (var cont in item.Contenedores)
                        {
                            DataRow row = dt.NewRow();
                            row["IdContenedor"] = cont.IdContenedor;
                            row["Contenedor"] = cont.Numero;
                            row["ETA"] = item.ETA.Date;
                            row["Via"] = item.Via;
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
                            if (item.Revisiones.Where(r => r.IdRevision == SelectivoRojo).Count() > 0)
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
                        row["IdContenedor"] = item.BL.First().IdBL.ToString();
                        row["Contenedor"] = item.BL.First().Numero;
                        row["ETA"] = item.ETA.Date;
                        row["Via"] = item.Via;
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
                        if (item.Revisiones.Where(r => r.IdRevision == SelectivoRojo).Count() > 0)
                            row["Selectivo Rojo"] = true;
                        else
                            row["Selectivo Rojo"] = false;
                        var ultimo = item.ImportHistorial.LastOrDefault();
                        row["Comentarios"] = ultimo.IdImportStatus == Comentario ? ultimo.FechaCreacion.ToShortDateString() + ": " + ultimo.Observaciones : "";
                        dt.Rows.Add(row);
                    }
                }
            }

        }

        private void maquillarTabla()
        {
            foreach (DataGridViewRow row in dgvDashboard.Rows)
            {
                if (!(Boolean)row.Cells["Originales"].Value)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if ((Boolean)row.Cells["Selectivo Rojo"].Value)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
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
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvDashboard.RowHeadersWidth, e.RowBounds.Height);

            // Dibujar el número de fila en el encabezado de fila
            TextRenderer.DrawText(e.Graphics, rowNumber.ToString(), this.Font, headerBounds, this.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvDashboard_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string v = dgvDashboard.Rows[e.RowIndex].Cells["Via"].Value.ToString();
            int imp = (int)dgvDashboard.Rows[e.RowIndex].Cells["IdImportacion"].Value;
            if (v == "M")
            {
                frmMaritimo mar = new frmMaritimo();
                mar.individual = imp;
                mar.mostrarIndividual((Panel)this.Parent);
            }
            else
            {
                frmAereo aire = new frmAereo();
                aire.individual = imp;
                aire.mostrarIndividual((Panel)this.Parent);
            }
        }
    }
}
