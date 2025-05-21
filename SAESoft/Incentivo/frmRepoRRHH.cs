using SAESoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SAESoft.Incentivo.ReporteRRHH;

namespace SAESoft.Incentivo
{
    public partial class frmRepoRRHH : Form
    {
        readonly DataTable dt = new();
        public frmRepoRRHH()
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
            var eval = db.Evaluaciones.Where(e => e.finalizado == true).OrderByDescending(b => b.fechaFin).ToList();
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

        private void icbPrint_Click(object sender, EventArgs e)
        {
            if (dgvEvaluaciones.SelectedRows.Count == 1)
            {
                DataGridViewRow selec = dgvEvaluaciones.SelectedRows[0];
                int idEvaluacion = Convert.ToInt32(selec.Cells["IdEvaluacion"].Value);
                ReporteRRHH.Reporte(idEvaluacion);
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una evaluación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmRepoRRHH_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            cargaDatos();
        }

        private void icbRefresh_Click(object sender, EventArgs e)
        {
            dt.Clear();
            cargaDatos();
        }
    }
}
