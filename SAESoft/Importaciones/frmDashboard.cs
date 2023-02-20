using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
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
            dt.Columns.Add("ETA").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Destino").DataType = Type.GetType("System.String");
            dt.Columns.Add("Inicial").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Elaborar Póliza").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Póliza Puerto").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("ATC y Aduana").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Llegada Fábrica").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Salida Fábrica").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Finalizado").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("IdImportacion").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Originales").DataType = Type.GetType("System.Boolean");
            dgvDashboard.DataSource = dt;
            dgvDashboard.Columns["IdContenedor"].Visible = false;
            dgvDashboard.Columns["IdImportacion"].Visible = false;
            dgvDashboard.Columns["Originales"].Visible = false;
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
                                                .Where(r => 1 == 1);
                if (hasRole(DigitadorImportaciones))
                    queryable = queryable.Where(r => r.IdUsuario == usuarioLogged.IdUsuario);
                if (!chkFinalizado.Checked)
                    queryable = queryable.Where(r => ! r.ImportStatus.ultimo);
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
                            if (item.IdDestino != null)
                                row["Destino"] = item.Destino.Descripcion;
                            foreach (var hist in item.ImportHistorial)
                            {
                                if (hist.ImportStatus.Descripcion.Contains("Inicial"))
                                {
                                    row["Inicial"] = hist.FechaCreacion.Date;
                                }
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
                                if (hist.ImportStatus.Descripcion.Contains("Finalizado"))
                                {
                                    row["Finalizado"] = hist.FechaCreacion.Date;
                                }
                            }
                            row["IdImportacion"] = item.IdImport;
                            row["Originales"] = item.DocOriginales;
                            dt.Rows.Add(row);
                        }
                    }
                    else
                    {
                        DataRow row = dt.NewRow();
                        row["Contenedor"] = "N/A";
                        row["ETA"] = item.ETA.Date;
                        if (item.IdDestino != null)
                            row["Destino"] = item.Destino.Descripcion;
                        foreach (var hist in item.ImportHistorial)
                        {
                            if (hist.ImportStatus.Descripcion.Contains("Inicial"))
                            {
                                row["Inicial"] = hist.FechaCreacion.Date;
                            }
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
                            if (hist.ImportStatus.Descripcion.Contains("Finalizado"))
                            {
                                row["Finalizado"] = hist.FechaCreacion.Date;
                            }
                        }
                        row["IdImportacion"] = item.IdImport;
                        row["Originales"] = item.DocOriginales;
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
    }
}
