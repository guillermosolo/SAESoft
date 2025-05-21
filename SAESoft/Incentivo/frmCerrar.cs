using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Cache.UserData;

namespace SAESoft.Incentivo
{
    public partial class frmCerrar : Form
    {
        readonly DataTable dt = new();
        Evaluacion evaluacion = new();
        Boolean guardar = true;
        public frmCerrar()
        {
            InitializeComponent();
        }

        public void EstructuraGrid()
        {
            dt.Columns.Add("IdDepartamento").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Departamento").DataType = Type.GetType("System.String");
            dt.Columns.Add("Personal").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Monto Asignado").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Monto Pagado").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Porcentaje").DataType = Type.GetType("System.Decimal");
            dgvAsistencia.DataSource = dt;
            dgvAsistencia.Columns["IdDepartamento"].Visible = false;
            dgvAsistencia.Columns["Departamento"].Width = 200;
            dgvAsistencia.Columns["Monto Asignado"].DefaultCellStyle.Format = "C2";
            dgvAsistencia.Columns["Monto Asignado"].DefaultCellStyle.FormatProvider = culture;
            dgvAsistencia.Columns["Monto Pagado"].DefaultCellStyle.Format = "C2";
            dgvAsistencia.Columns["Monto Pagado"].DefaultCellStyle.FormatProvider = culture;
            dgvAsistencia.Columns["Porcentaje"].DefaultCellStyle.Format = "P2";
            for (int i = 2; i < dt.Columns.Count; i++)
            {
                dgvAsistencia.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void CargarDatos()
        {
            dt.Clear();
            using SAESoftContext db = new();
            evaluacion = db.Evaluaciones.Where(e => !e.finalizado).FirstOrDefault();
            if (evaluacion != null)
            {
                dtpInicio.Value = evaluacion.fechaInicio;
                dtpFin.Value = evaluacion.fechaFin;
                txtObservaciones.Text = evaluacion.Observaciones;
                var deptos = db.DeptoIncentivo
                    .Include(e => e.Empleados.Where(b => b.FechaBaja >= dtpFin.Value || b.FechaBaja == null))
                        .ThenInclude(e => e.Evaluaciones).Where(b => b.Activo == true).ToList();
                foreach (var depto in deptos)
                {
                    DataRow row = dt.NewRow();
                    row["IdDepartamento"] = depto.IdDepto;
                    row["Departamento"] = depto.Nombre;
                    row["Personal"] = depto.Empleados.Count(b => b.FechaBaja > dtpFin.Value || b.FechaBaja == null);
                    decimal asignado = depto.Empleados.Where(b => b.FechaBaja > dtpFin.Value || b.FechaBaja == null).Sum(e => e.BaseCalculo);
                    row["Monto Asignado"] = asignado;
                    decimal monto = 0m;
                    foreach (var pagado in depto.Empleados)
                    {
                        monto += pagado.Evaluaciones.Where(e => e.IdEvaluacion == evaluacion.IdEvaluacion).Sum(p => p.Total);
                    }
                    row["Monto Pagado"] = monto;
                    row["Porcentaje"] = asignado > 0 ? monto / asignado : 0;
                    dt.Rows.Add(row);
                }
                foreach (DataRow r in dt.Rows)
                {
                    if (Convert.ToDecimal(r["Monto Pagado"]) == 0m && Convert.ToDecimal(r["Monto Asignado"]) != 0m)
                    {
                        guardar = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe evaluación abierta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                icbGuardar.Enabled = false;
            }
        }

        private void frmCerrar_Load(object sender, EventArgs e)
        {
            EstructuraGrid();
            CargarDatos();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
            if (!guardar)
            {
                var resp = MessageBox.Show("Existen departamentos que no tienen monto pagado, ¿Desea continuar?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(evaluacion).State = EntityState.Modified;
                        evaluacion.finalizado = true;
                        evaluacion.FechaUltimaMod = DatosServer.FechaServer();
                        evaluacion.IdUsuarioMod = usuarioLogged.IdUsuario;
                        db.Evaluaciones.Update(evaluacion);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Período de Evaluaciones cerrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    icbGuardar.Enabled = false;
                }
            }
        }
    }
}
