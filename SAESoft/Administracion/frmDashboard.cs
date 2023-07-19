using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;

namespace SAESoft.Administracion
{
    public partial class frmDashboard : Form
    {
        readonly DataSet ds = new();
        readonly DataTable dt = new("Maestro");
        readonly DataTable dtd = new("Detalle");
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarSet();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("IdDocumento").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dt.Columns.Add("Vigente").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Próximo a Vencer").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Vencido").DataType = Type.GetType("System.Int32");

            dtd.Columns.Add("IdDocumento").DataType = Type.GetType("System.Int32");
            dtd.Columns.Add("Idempleado").DataType = Type.GetType("System.Int32");
            dtd.Columns.Add("IdFamiliar").DataType = Type.GetType("System.Int32");
            dtd.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dtd.Columns.Add("Vencimiento").DataType = Type.GetType("System.DateTime");
            dtd.Columns.Add("Status").DataType = Type.GetType("System.String");
            dtd.Columns.Add("Observaciones").DataType = Type.GetType("System.String");

            ds.Tables.Add(dt);
            ds.Tables.Add(dtd);

            ds.Relations.Add(new DataRelation("Maestro_Detalle", dt.Columns["IdDocumento"], dtd.Columns["IdDocumento"]));

            dgvDashboardM.DataSource = new BindingSource() { DataSource = ds, DataMember = "Maestro" };
            dgvDashboardM.Columns["IdDocumento"].Visible = false;
            dgvDashboardM.Columns["Nombre"].Width = 390;
            dgvDashboardM.Columns["Vigente"].Width = 100;
            dgvDashboardM.Columns["Próximo a Vencer"].Width = 110;
            dgvDashboardM.Columns["Vencido"].Width = 100;

            dgvDetalle.DataSource = dgvDashboardM.DataSource;
            dgvDetalle.DataMember = "Maestro_Detalle";

            dgvDetalle.Columns["IdDocumento"].Visible = false;
            dgvDetalle.Columns["IdEmpleado"].Visible = false;
            dgvDetalle.Columns["IdFamiliar"].Visible = false;
            dgvDetalle.Columns["Nombre"].Width = 195;
            dgvDetalle.Columns["Vencimiento"].Width = 120;
            dgvDetalle.Columns["Vencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalle.Columns["Status"].Width = 150;
            dgvDetalle.Columns["Observaciones"].Width = 240;


            dgvDashboardM.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(198, 239, 206);
            dgvDashboardM.Columns[2].DefaultCellStyle.ForeColor = Color.FromArgb(0, 97, 0);

            dgvDashboardM.Columns[3].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 153);
            dgvDashboardM.Columns[3].DefaultCellStyle.ForeColor = Color.FromArgb(153, 102, 0);

            dgvDashboardM.Columns[4].DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 153);
            dgvDashboardM.Columns[4].DefaultCellStyle.ForeColor = Color.FromArgb(97, 0, 0);
        }

        private void llenarSet()
        {
            dt.Rows.Clear();
            List<int> normales = new() { 1, 2, 3, 5, 8, 11 };
            using SAESoftContext db = new();
            var queryable = db.TiposDocumento.Include(d => d.Documentos)
                                             .ThenInclude(e => e.Empleado)
                                             .Include(d => d.Documentos)
                                             .ThenInclude(f => f.Familiar)
                                             .ThenInclude(em => em.Empleado);
            foreach (var item in queryable)
            {
                DataRow row = dt.NewRow();
                row["IdDocumento"] = item.IdTipoDocumento;
                row["Nombre"] = item.Nombre;
                if (normales.Contains(item.IdTipoDocumento))
                {
                    row["Vigente"] = item.Documentos.Where(v => (v.NoVence || calculaVigencia(v.Vencimiento) > 50) && (v.Empleado?.Activo ?? v.Familiar.Empleado.Activo)).Count();
                    row["Próximo a Vencer"] = item.Documentos.Where(v => (!v.NoVence && calculaVigencia(v.Vencimiento) > 0 && calculaVigencia(v.Vencimiento) <= 50) && (v.Empleado?.Activo ?? v.Familiar.Empleado.Activo)).Count();
                    row["Vencido"] = item.Documentos.Where(v => (!v.NoVence && calculaVigencia(v.Vencimiento) <= 0) && (v.Empleado?.Activo ?? v.Familiar.Empleado.Activo)).Count();
                }
                else if (item.IdTipoDocumento == 4)
                {
                    using SAESoftContext aux = new();
                    var res = aux.Residencias.Include(e => e.Empleado)
                                             .Include(f => f.Familiar)
                                             .ThenInclude(em => em.Empleado)
                                             .Select(r => new
                                             {
                                                 r.Vencimiento,
                                                 Activo = r.Empleado != null ? r.Empleado.Activo : r.Familiar.Empleado.Activo
                                             }).ToList();
                    row["Vigente"] = res.Where(r => calculaVigencia(r.Vencimiento) > 50 && r.Activo).Count();
                    row["Próximo a Vencer"] = res.Where(r => calculaVigencia(r.Vencimiento) > 0 && calculaVigencia(r.Vencimiento) <= 50 && r.Activo).Count();
                    row["Vencido"] = res.Where(r => calculaVigencia(r.Vencimiento) <= 0 && r.Activo).Count();
                }
                else if (item.IdTipoDocumento == 6)
                {
                    using SAESoftContext aux = new();
                    var per = aux.PermisosTrabajo.Include(e => e.Empleado).Where(e => e.Empleado.Activo).ToList();
                    row["Vigente"] = per.Where(r => calculaVigencia(r.Vencimiento) > 50).Count();
                    row["Próximo a Vencer"] = per.Where(r => calculaVigencia(r.Vencimiento) > 0 && calculaVigencia(r.Vencimiento) <= 50).Count();
                    row["Vencido"] = per.Where(r => calculaVigencia(r.Vencimiento) <= 0).Count();
                }
                else if (item.IdTipoDocumento == 7)
                {
                    using SAESoftContext aux = new();
                    var con = aux.Contratos.Include(e => e.Empleado).Where(e => e.Empleado.Activo).ToList();
                    row["Vigente"] = con.Count;
                    row["Próximo a Vencer"] = 0;
                    row["Vencido"] = 0;
                }
                else if (item.IdTipoDocumento == 9)
                {
                    using SAESoftContext aux = new();
                    var rep = aux.Nombramientos.Include(e => e.Empleado).Where(e => e.Empleado.Activo).ToList();
                    row["Vigente"] = rep.Where(r => calculaVigencia(r.Vencimiento) > 50).Count();
                    row["Próximo a Vencer"] = rep.Where(r => calculaVigencia(r.Vencimiento) > 0 && calculaVigencia(r.Vencimiento) <= 50).Count();
                    row["Vencido"] = rep.Where(r => calculaVigencia(r.Vencimiento) <= 0).Count();
                }
                else if (item.IdTipoDocumento == 10)
                {
                    using SAESoftContext aux = new();
                    var segM = aux.SegurosMedicos.Include(e => e.Empleado)
                                             .Include(f => f.Familiar)
                                             .ThenInclude(em => em.Empleado)
                                             .Select(r => new
                                             {
                                                 r.Vencimiento,
                                                 Activo = (r.Empleado != null ? r.Empleado.Activo : (r.Familiar != null && r.Familiar.Empleado.Activo))
                                             }).ToList();
                    row["Vigente"] = segM.Where(r => calculaVigencia(r.Vencimiento) > 50 && r.Activo).Count();
                    row["Próximo a Vencer"] = segM.Where(r => calculaVigencia(r.Vencimiento) > 0 && calculaVigencia(r.Vencimiento) <= 50 && r.Activo).Count();
                    row["Vencido"] = segM.Where(r => calculaVigencia(r.Vencimiento) <= 0 && r.Activo).Count();
                }
                else if (item.IdTipoDocumento == 12)
                {
                    using SAESoftContext aux = new();
                    var segV = aux.SegurosVehiculos.Include(e => e.Empleado).Where(e => e.Empleado.Activo).ToList();
                    row["Vigente"] = segV.Where(r => calculaVigencia(r.Vencimiento) > 50).Count();
                    row["Próximo a Vencer"] = segV.Where(r => calculaVigencia(r.Vencimiento) > 0 && calculaVigencia(r.Vencimiento) <= 50).Count();
                    row["Vencido"] = segV.Where(r => calculaVigencia(r.Vencimiento) <= 0).Count();
                }
                dt.Rows.Add(row);
            }
            llenarDetalle();
            dgvDetalle.ClearSelection();
        }

        private void llenarDetalle()
        {
            dtd.Rows.Clear();
            using SAESoftContext db = new();
            DateTime FechaLimite = DateTime.Today.AddDays(50);
            var queryable = db.Empleados.Include(d => d.Departamento)
                                           .Include(co => co.Contrato)
                                           .ThenInclude(pl => pl.Empresa)
                                           .Include(n => n.Nombramientos)
                                           .ThenInclude(ne => ne.Empresa)
                                           .Include(n => n.Nombramientos)
                                           .ThenInclude(nt => nt.Tipo)
                                           .Include(r => r.Residencia)
                                           .ThenInclude(rt => rt.Tipo)
                                           .Include(p => p.Puesto)
                                           .Include(f => f.Familiares)
                                           .ThenInclude(p => p.Parentesco)
                                           .Include(f => f.Familiares)
                                           .ThenInclude(df => df.Documentos)
                                           .ThenInclude(dft => dft.Tipo)
                                           .Include(f => f.Familiares)
                                           .ThenInclude(rf => rf.Residencia)
                                           .ThenInclude(rft => rft.Tipo)
                                           .Include(f => f.Familiares)
                                           .ThenInclude(smf => smf.SeguroMedico)
                                           .Include(c => c.Documentos)
                                           .ThenInclude(t => t.Tipo)
                                           .Include(sv => sv.SeguroVehiculo)
                                           .ThenInclude(t => t.Aseguradora)
                                           .Include(p => p.PermisoTrabajo)
                                           .ThenInclude(t => t.Tipo)
                                           .Include(sm => sm.SeguroMedico)
                                           .Where(b => b.Activo);
            foreach (var e in queryable)
            {
                foreach (var d in e.Documentos)
                {
                    if (d.Vencimiento <= FechaLimite)
                    {
                        DataRow row = dtd.NewRow();
                        row["IdDocumento"] = d.IdTipo;
                        row["IdEmpleado"] = e.IdEmpleado;
                        row["IdFamiliar"] = 0;
                        row["Nombre"] = e.Alias;
                        row["Vencimiento"] = d.Vencimiento;
                        row["Status"] = calculaVigencia(d.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                        dtd.Rows.Add(row);
                    }
                }
                if (e.Residencia != null && e.Residencia.Vencimiento <= FechaLimite)
                {
                    DataRow row = dtd.NewRow();
                    row["IdDocumento"] = 4;
                    row["IdEmpleado"] = e.IdEmpleado;
                    row["IdFamiliar"] = 0;
                    row["Nombre"] = e.Alias;
                    row["Vencimiento"] = e.Residencia.Vencimiento;
                    row["Status"] = calculaVigencia(e.Residencia.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                    dtd.Rows.Add(row);
                }
                if (e.PermisoTrabajo != null && e.PermisoTrabajo.Vencimiento <= FechaLimite)
                {
                    DataRow row = dtd.NewRow();
                    row["IdDocumento"] = 6;
                    row["IdEmpleado"] = e.IdEmpleado;
                    row["IdFamiliar"] = 0;
                    row["Nombre"] = e.Alias;
                    row["Vencimiento"] = e.PermisoTrabajo.Vencimiento;
                    row["Status"] = calculaVigencia(e.PermisoTrabajo.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                    dtd.Rows.Add(row);
                }
                foreach (var n in e.Nombramientos)
                {
                    if (n.Vencimiento <= FechaLimite && !n.Cancelado)
                    {
                        DataRow row = dtd.NewRow();
                        row["IdDocumento"] = 9;
                        row["IdEmpleado"] = e.IdEmpleado;
                        row["IdFamiliar"] = 0;
                        row["Nombre"] = e.Alias;
                        row["Vencimiento"] = n.Vencimiento;
                        row["Status"] = calculaVigencia(n.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                        row["Observaciones"] = n.Empresa.Descripcion + " " + n.Tipo.Descripcion;
                        dtd.Rows.Add(row);
                    }
                }
                if (e.SeguroMedico != null && e.SeguroMedico.Vencimiento <= FechaLimite)
                {
                    DataRow row = dtd.NewRow();
                    row["IdDocumento"] = 10;
                    row["IdEmpleado"] = e.IdEmpleado;
                    row["IdFamiliar"] = 0;
                    row["Nombre"] = e.Alias;
                    row["Vencimiento"] = e.SeguroMedico.Vencimiento;
                    row["Status"] = calculaVigencia(e.SeguroMedico.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                    dtd.Rows.Add(row);
                }
                if (e.SeguroVehiculo != null && e.SeguroVehiculo.Vencimiento <= FechaLimite)
                {
                    DataRow row = dtd.NewRow();
                    row["IdDocumento"] = 12;
                    row["IdEmpleado"] = e.IdEmpleado;
                    row["IdFamiliar"] = 0;
                    row["Nombre"] = e.Alias;
                    row["Vencimiento"] = e.SeguroVehiculo.Vencimiento;
                    row["Status"] = calculaVigencia(e.SeguroVehiculo.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                    dtd.Rows.Add(row);
                }
                foreach (var f in e.Familiares)
                {
                    String nomb = f.Nombres.Split(' ')[0] + " " + f.Apellidos.Split(' ')[0];
                    foreach (var d in f.Documentos)
                    {
                        if (d.Vencimiento <= FechaLimite)
                        {
                            DataRow row = dtd.NewRow();
                            row["IdDocumento"] = d.IdTipo;
                            row["IdEmpleado"] = e.IdEmpleado;
                            row["IdFamiliar"] = f.IdFamiliar;
                            row["Nombre"] = nomb;
                            row["Vencimiento"] = d.Vencimiento;
                            row["Status"] = calculaVigencia(d.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                            row["Observaciones"] = f.Parentesco.Descripcion + " " + e.Alias;
                            dtd.Rows.Add(row);
                        }
                    }
                    if (f.Residencia != null && f.Residencia.Vencimiento <= FechaLimite)
                    {
                        DataRow row = dtd.NewRow();
                        row["IdDocumento"] = 4;
                        row["IdEmpleado"] = e.IdEmpleado;
                        row["IdFamiliar"] = f.IdFamiliar;
                        row["Nombre"] = nomb;
                        row["Vencimiento"] = f.Residencia.Vencimiento;
                        row["Status"] = calculaVigencia(f.Residencia.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                        row["Observaciones"] = f.Parentesco.Descripcion + " " + e.Alias;
                        dtd.Rows.Add(row);
                    }
                    if (f.SeguroMedico != null && f.SeguroMedico.Vencimiento <= FechaLimite)
                    {
                        DataRow row = dtd.NewRow();
                        row["IdDocumento"] = 10;
                        row["IdEmpleado"] = e.IdEmpleado;
                        row["IdFamiliar"] = f.IdFamiliar;
                        row["Nombre"] = nomb;
                        row["Vencimiento"] = f.SeguroMedico.Vencimiento;
                        row["Status"] = calculaVigencia(f.SeguroMedico.Vencimiento) > 0 ? "Próximo a Vencer" : "Vencido";
                        row["Observaciones"] = f.Parentesco.Descripcion + " " + e.Alias;
                        dtd.Rows.Add(row);
                    }
                }
            }
        }
        private static int calculaVigencia(DateTime? fecha)
        {
            TimeSpan diferencia = (fecha ?? DateTime.Today) - DateTime.Today;
            int dias = diferencia.Days;
            return dias;
        }

        private void dgvDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (e.RowIndex >= 0 && e.ColumnIndex == dg.Columns["Vencimiento"].Index)
            {
                DataGridViewRow fila = dg.Rows[e.RowIndex];
                DataGridViewCell celda = fila.Cells[e.ColumnIndex];
                DataGridViewCell celda2 = fila.Cells[e.ColumnIndex + 1];

                if (celda.Value != null && celda.Value != DBNull.Value)
                {
                    DateTime fechaVencimiento = (DateTime)dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (fechaVencimiento > DateTime.Today)
                    {
                        celda2.Style.BackColor = Color.FromArgb(255, 255, 153);
                        celda2.Style.ForeColor = Color.FromArgb(153, 102, 0);
                    }
                    else
                    {
                        celda2.Style.BackColor = Color.FromArgb(255, 153, 153);
                        celda2.Style.ForeColor = Color.FromArgb(97, 0, 0);
                    }
                }
            }
        }

        private void dgvDetalle_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                dgvDetalle.ClearSelection();
            }
        }
    }
}
