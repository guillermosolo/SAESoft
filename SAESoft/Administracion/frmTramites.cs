using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Cache.UserData;

namespace SAESoft.Administracion
{
    public partial class frmTramites : Form
    {
        private bool isLoadingcbo = false;
        public Tramite tramite;
        public readonly DataTable dt = new();
        public frmTramites()
        {
            InitializeComponent();
        }

        private void frmTramites_Load(object sender, EventArgs e)
        {
            estructuraTabla();
            maquillarTabla();
            llenarCombos();
            if (tramite != null)
            {
                deshabilitaFormulario();
                despliegaDatos();
            }
        }

        private void despliegaDatos()
        {
            txtId.Text = tramite.IdTramite.ToString();
            cboEmpleados.SelectedValue = tramite.IdEmpleado;
            if (tramite.IdInteresado != null)
                cboFamiliares.SelectedValue = tramite.IdInteresado;
            cboTipoTramite.SelectedValue = tramite.IdTipo;
            cboStatus.SelectedValue = tramite.IdStatus;
            if (tramite.Status.Ultimo)
            {
                cboStatus.Enabled = false;
                iconButton1.Enabled = false;
            }
            txtObservaciones.Text = tramite.Observaciones;
            if (tramite.Cita != null)
            {
                chkCita.Checked = true;
                dtpFechaCita.Value = (DateTime)tramite.Cita;
                dtpHoraCita.Value = (DateTime)tramite.Cita;
            }
            else
            {
                chkCita.Checked = false;
            }
            txtNoSolicitud.Text = tramite.NumeroSolicitud;
            foreach (var item in tramite.Historial)
            {
                DataRow row = dt.NewRow();
                row[0] = item.IdHistorial;
                row[1] = item.Status.Nombre;
                row[2] = item.fecha;
                dt.Rows.Add(row);
            }
            dgvHistorial.ClearSelection();
            maquillarTabla();
        }

        private void deshabilitaFormulario()
        {
            cboEmpleados.Enabled = false;
            cboFamiliares.Enabled = false;
            cboTipoTramite.Enabled = false;
        }

        private void estructuraTabla()
        {
            dt.Columns.Add("IdHistorial").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Status").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha").DataType = Type.GetType("System.DateTime");
            dgvHistorial.DataSource = dt;
        }

        private void maquillarTabla()
        {
            dgvHistorial.Columns[0].Visible = false;
            dgvHistorial.Columns["Status"].Width = 300;
            dgvHistorial.Columns["Fecha"].Width = 150;
        }

        private void llenarCombos()
        {
            isLoadingcbo = true;
            using SAESoftContext db = new();
            var empleados = db.Empleados.Where(e => e.Activo).Select(e => new { e.IdEmpleado, e.Alias }).OrderBy(e => e.Alias).ToList();
            cboEmpleados.DataSource = empleados;
            cboEmpleados.DisplayMember = "Alias";
            cboEmpleados.ValueMember = "IdEmpleado";
            llenarFamiliares(Convert.ToInt32(cboEmpleados.SelectedValue));
            List<int> docs = [1, 4, 6, 8, 9, 11, 13, 14, 15];
            var tipos = db.TiposDocumento.Select(s => new { s.IdTipoDocumento, s.Nombre }).Where(s => docs.Contains(s.IdTipoDocumento)).ToList();
            cboTipoTramite.DataSource = tipos;
            cboTipoTramite.DisplayMember = "Nombre";
            cboTipoTramite.ValueMember = "IdTipoDocumento";
            llenarStatuses(Convert.ToInt32(cboTipoTramite.SelectedValue));
            if (tramite == null)
            {
                cboStatus.Enabled = false;
            }
            isLoadingcbo = false;
        }

        private void llenarFamiliares(int selectedId)
        {
            using SAESoftContext db = new();
            var familiares = db.Familiares.Where(f => f.IdEmpleado == selectedId).Select(f => new { f.IdFamiliar, f.Nombres, f.Apellidos, f.NombreCompleto }).OrderBy(f => f.Nombres).ToList();
            familiares.Insert(0, new { IdFamiliar = 0, Nombres = "", Apellidos = "", NombreCompleto = "NINGUNO" });
            cboFamiliares.DataSource = familiares;
            cboFamiliares.DisplayMember = "Nombrecompleto";
            cboFamiliares.ValueMember = "IdFamiliar";
        }

        private void llenarStatuses(int selectedId)
        {
            using SAESoftContext db = new();
            var statuses = db.AdminStatuses.Where(f => f.IdTipoDoc == selectedId).Select(f => new { f.IdStatus, f.Nombre, f.Orden }).OrderBy(f => f.Orden).ThenByDescending(f => f.Nombre).ToList();
            cboStatus.DataSource = statuses;
            cboStatus.DisplayMember = "Nombre";
            cboStatus.ValueMember = "IdStatus";
        }

        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcbo)
            {
                llenarFamiliares(Convert.ToInt32(cboEmpleados.SelectedValue));
            }
        }

        private void cboTipoTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcbo)
            {
                llenarStatuses(Convert.ToInt32(cboTipoTramite.SelectedValue));
            }
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            label7.Enabled = chk.Checked;
            label8.Enabled = chk.Checked;
            dtpFechaCita.Enabled = chk.Checked;
            dtpHoraCita.Enabled = chk.Checked;
            if (chk.Checked)
            {
                chk.Image = Properties.Resources.Nchecked;
            }
            else
            {
                chk.Image = Properties.Resources.Nunchecked;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (tramite == null)
            {
                using SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    tramite = new()
                    {
                        IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue),
                        IdTipo = Convert.ToInt32(cboTipoTramite.SelectedValue),
                        IdStatus = Convert.ToInt32(cboStatus.SelectedValue),
                        Observaciones = txtObservaciones.Text,
                        FechaCreacion = DatosServer.FechaServer(),
                        IdUsuarioCreacion = usuarioLogged.IdUsuario
                    };
                    int fam = Convert.ToInt32(cboFamiliares.SelectedValue);
                    if (fam != 0)
                        tramite.IdInteresado = fam;
                    if (chkCita.Checked)
                    {
                        DateTime fechaSeleccionada = dtpFechaCita.Value;
                        DateTime horaSeleccionada = dtpHoraCita.Value;

                        DateTime fechaCita = new(
                            fechaSeleccionada.Year,
                            fechaSeleccionada.Month,
                            fechaSeleccionada.Day,
                            horaSeleccionada.Hour,
                            horaSeleccionada.Minute,
                            horaSeleccionada.Second
                        );
                        tramite.Cita = fechaCita;
                    }
                    db.Add(tramite);
                    db.SaveChanges();
                    HistorialTramite hist = new()
                    {
                        IdTramite = tramite.IdTramite,
                        IdStatus = tramite.IdStatus,
                        fecha = DatosServer.FechaServer(),
                        FechaCreacion = DatosServer.FechaServer(),
                        IdUsuarioCreacion = usuarioLogged.IdUsuario
                    };
                    db.Add(hist);
                    db.SaveChanges();
                    transaction.Commit();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                using SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    db.Entry(tramite).State = EntityState.Modified;
                    tramite.Observaciones = txtObservaciones.Text;
                    tramite.IdStatus = Convert.ToInt32(cboStatus.SelectedValue);
                    if (chkCita.Checked)
                    {
                        DateTime fechaSeleccionada = dtpFechaCita.Value;
                        DateTime horaSeleccionada = dtpHoraCita.Value;

                        DateTime fechaCita = new(
                            fechaSeleccionada.Year,
                            fechaSeleccionada.Month,
                            fechaSeleccionada.Day,
                            horaSeleccionada.Hour,
                            horaSeleccionada.Minute,
                            horaSeleccionada.Second
                        );
                        tramite.Cita = fechaCita;
                    }
                    tramite.NumeroSolicitud = txtNoSolicitud.Text;
                    db.Tramites.Update(tramite);
                    db.SaveChanges();
                    HistorialTramite hist = new()
                    {
                        IdTramite = tramite.IdTramite,
                        IdStatus = tramite.IdStatus,
                        fecha = DatosServer.FechaServer(),
                        FechaCreacion = DatosServer.FechaServer(),
                        IdUsuarioCreacion = usuarioLogged.IdUsuario
                    };
                    db.Add(hist);
                    db.SaveChanges();
                    transaction.Commit();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
