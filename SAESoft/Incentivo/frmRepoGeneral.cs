using SAESoft.Models;
using System.Data;

namespace SAESoft.Incentivo
{
    public partial class frmRepoGeneral : Form
    {
        readonly DataTable dt = new();
        public frmRepoGeneral()
        {
            InitializeComponent();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdEvaluacion").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Fecha Inicio").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Fecha Fin").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Observaciones").DataType = Type.GetType("System.String");
            dt.Columns.Add("Finalizado").DataType = Type.GetType("System.Boolean");

            dgvEvaluaciones.DataSource = dt;

            dgvEvaluaciones.Columns["IdEvaluacion"].Visible = false;
        }

        private void cargaDatos()
        {
            SAESoftContext db = new();
            var queryable = db.Evaluaciones.Where(e => 1 == 1);
            if (chkFinalizado.Checked)
            {
                queryable = queryable.Where(b => b.finalizado == true);
            }
            var eval = queryable.ToList();
            foreach (var e in eval)
            {
                DataRow row = dt.NewRow();
                row["IdEvaluacion"] = e.IdEvaluacion;
                row["Fecha Inicio"] = e.fechaInicio.Date;
                row["Fecha Fin"] = e.fechaFin.Date;
                row["Observaciones"] = e.Observaciones;
                row["Finalizado"] = e.finalizado;
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

        private void frmRepoGeneral_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            cargaDatos();
        }

        private void icbRefresh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            cargaDatos();
        }

        private void icbPrint_Click(object sender, EventArgs e)
        {
            if (dgvEvaluaciones.SelectedRows.Count == 1)
            {
                DataGridViewRow selec = dgvEvaluaciones.SelectedRows[0];
                int idEvaluacion = Convert.ToInt32(selec.Cells["IdEvaluacion"].Value);
                ReporteGeneral.Reporte(idEvaluacion);
            } else
            {
                MessageBox.Show ("Debe de seleccionar una evaluación.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
