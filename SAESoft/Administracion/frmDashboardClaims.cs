using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using System.Data;
using System.Linq;


namespace SAESoft.Administracion
{
    public partial class frmDashboardClaims : Form
    {
        readonly DataTable dt = new();
        public frmDashboardClaims()
        {
            InitializeComponent();
        }

        private void frmDashboardClaims_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarTabla();
            maquillarTabla();
            dgvDashboardClaim.ClearSelection();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdReclamo").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Paciente").DataType = Type.GetType("System.String");
            dt.Columns.Add("Tipo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Inicio").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Status").DataType = Type.GetType("System.String");
            dgvDashboardClaim.DataSource = dt;
        }

        private void llenarTabla()
        {
            dt.Clear();
            using SAESoftContext db = new();
            var queryable = db.Reclamos.Include(r => r.Historial)
                                       .ThenInclude(s => s.Status)
                                       .Include(s => s.Status)
                                       .Include(t => t.TipoReclamo)
                                       .Include(m => m.Moneda)
                                       .Include(e => e.Empleado)
                                       .Include(f => f.Familiar)
                                       .Where(x => true);
            if (!chkFinalizado.Checked)
                queryable = queryable.Where(r => !r.Status.Ultimo);
            queryable = queryable.OrderByDescending(r => r.FechaCreacion);
            foreach (var item in queryable)
            {
                DataRow row = dt.NewRow();
                row["IdReclamo"] = item.IdReclamo;
                if (item.IdPaciente != null)
                    row["Paciente"] = item.Familiar.NombreCompleto;
                else
                    row["Paciente"] = item.Empleado.Alias;
                row["Tipo"] = item.TipoReclamo.Descripcion;
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

        private void maquillarTabla()
        {
            dgvDashboardClaim.Columns[0].Visible = false;
            dgvDashboardClaim.Columns["Paciente"].Width = 200;
            dgvDashboardClaim.Columns["tipo"].Width = 200;
            dgvDashboardClaim.Columns["Inicio"].Width = 150;
            dgvDashboardClaim.Columns["Status"].Width = 150;
        }

        private void dgvDashboardClaim_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmReclamos reclamos = new();
            if (e.RowIndex != dgvDashboardClaim.Rows.Count - 1)
            {
                using SAESoftContext db = new();
                DataGridViewRow fila = dgvDashboardClaim.SelectedRows[0];
                int idReclamo = Convert.ToInt32(fila.Cells["IdReclamo"].Value.ToString());
                Reclamo rec = db.Reclamos.Include(r => r.Historial)
                                       .ThenInclude(s => s.Status)
                                       .Include(s => s.Status)
                                       .Include(t => t.TipoReclamo)
                                       .Include(m => m.Moneda)
                                       .Include(e => e.Empleado)
                                       .Include(f => f.Familiar)
                                       .FirstOrDefault(x => x.IdReclamo == idReclamo);
                reclamos.reclamo = rec;
            }
            var resp = reclamos.ShowDialog();
            if (resp == DialogResult.OK)
            {
                icbRefresh_Click(null, null);
            }
        }

        private void icbRefresh_Click(object sender, EventArgs e)
        {
            llenarTabla();
            maquillarTabla();
            dgvDashboardClaim.ClearSelection();
        }
    }
}
