
using SAESoft.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Administracion;
using static SAESoft.Cache.UserData;

namespace SAESoft.Administracion
{
    public partial class frmDashboardTramit : Form
    {
        readonly DataTable dt = new();
        public frmDashboardTramit()
        {
            InitializeComponent();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdTramite").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Interesado").DataType = Type.GetType("System.String");
            dt.Columns.Add("Tipo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Inicio").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Status").DataType = Type.GetType("System.String");
            dgvDashboardTramit.DataSource = dt;
        }

        private void maquillarTabla()
        {
            dgvDashboardTramit.Columns[0].Visible = false;
            dgvDashboardTramit.Columns["Interesado"].Width = 200;
            dgvDashboardTramit.Columns["Tipo"].Width = 200;
            dgvDashboardTramit.Columns["Inicio"].Width = 150;
            dgvDashboardTramit.Columns["Status"].Width = 150;
        }

        private void llenarTabla()
        {
            dt.Clear();
            using SAESoftContext db = new();
            var queryable = db.Tramites.Include(r => r.Historial)
                                       .ThenInclude(s => s.Status)
                                       .Include(s => s.Status)
                                       .Include(t => t.Tipo)
                                       .Include(e => e.Empleado)
                                       .Include(f => f.Familiar)
                                       .Where(x => true);
            if (!chkFinalizado.Checked)
                queryable = queryable.Where(r => !r.Status.Ultimo);
            queryable = queryable.OrderByDescending(r => r.FechaCreacion);
            foreach (var item in queryable)
            {
                DataRow row = dt.NewRow();
                row["IdTramite"] = item.IdTramite;
                if (item.IdInteresado != null)
                    row["Interesado"] = item.Familiar.NombreCompleto;
                else
                    row["Interesado"] = item.Empleado.Alias;
                row["Tipo"] = item.Tipo.Nombre;
                row["Inicio"] = item.FechaCreacion;
                row["Status"] = item.Status.Nombre;
                dt.Rows.Add(row);
            }
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.Nchecked;
            else
                chk.Image = Properties.Resources.Nunchecked;

        }

        private void icbRefresh_Click(object sender, EventArgs e)
        {
            llenarTabla();
            maquillarTabla();
            dgvDashboardTramit.ClearSelection();
        }

        private void frmDashboardTramit_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarTabla();
            maquillarTabla();
            dgvDashboardTramit.ClearSelection();
        }

        private void dgvDashboardTramit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmTramites tramites = new();
            if (e.RowIndex != dgvDashboardTramit.Rows.Count - 1)
            {
                if (hasPermission("MODIFICAR.TRAMITES"))
                {
                    using SAESoftContext db = new();
                    DataGridViewRow fila = dgvDashboardTramit.SelectedRows[0];
                    int idTramite = Convert.ToInt32(fila.Cells["IdTramite"].Value.ToString());
                    Tramite tra = db.Tramites.Include(r => r.Historial)
                                           .ThenInclude(s => s.Status)
                                           .Include(s => s.Status)
                                           .Include(t => t.Tipo)
                                           .Include(e => e.Empleado)
                                           .Include(f => f.Familiar)
                                           .FirstOrDefault(x => x.IdTramite == idTramite);
                    tramites.tramite = tra;
                    var resp = tramites.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        icbRefresh_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("No posee permisos para modificar trámites.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (hasPermission("CREAR.TRAMITES"))
                {
                    var resp = tramites.ShowDialog();
                    if (resp == DialogResult.OK)
                    {
                        icbRefresh_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("No posee permisos para crear trámites.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
