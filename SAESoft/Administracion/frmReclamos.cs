using Microsoft.Win32;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.Validaciones;
using static SAESoft.Cache.UserData;
using SAESoft.Models.Comunes;
using Microsoft.EntityFrameworkCore.Storage;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Administracion
{
    public partial class frmReclamos : Form
    {
        private bool isLoadingcbo = false;
        public Reclamo reclamo;
        public readonly DataTable dt = new();
        public frmReclamos()
        {
            InitializeComponent();
        }

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            estructuraTabla();
            maquillarTabla();
            llenarCombos();
            if (reclamo != null)
            {
                deshabilitaFormulario();
                despliegaDatos();
            }
        }

        private void deshabilitaFormulario()
        {
            cboEmpleados.Enabled = false;
            cboFamiliares.Enabled = false;
            cboTipoReclamo.Enabled = false;
            txtMonto.ReadOnly = true;
            cboMonedas.Enabled = false;
        }
        private void despliegaDatos()
        {
            txtId.Text = reclamo.IdReclamo.ToString();
            cboEmpleados.SelectedValue = reclamo.IdEmpleado;
            if (reclamo.IdPaciente != null)
                cboFamiliares.SelectedValue = reclamo.IdPaciente;
            cboTipoReclamo.SelectedValue = reclamo.IdTipo;
            cboStatus.SelectedValue = reclamo.IdStatus;
            if (reclamo.Status.Ultimo)
            {
                cboStatus.Enabled = false;
                iconButton1.Enabled = false;
            }
            txtMonto.Text = reclamo.Monto?.ToString("N2") ?? "";
            cboMonedas.SelectedValue = reclamo.IdMoneda;
            txtObservaciones.Text = reclamo.Observaciones;
            txtNoCheque.Text = reclamo.Cheque?.ToString() ?? "";
            dtpFechaRecepcion.Value = reclamo.FechaRecibir;
            txtDeducible.Text = reclamo.Deducible?.ToString("N2") ?? "";
            txtNoCubierto.Text = reclamo.MontosNoCubiertos?.ToString("N2") ?? "";
            txtCoaseguro.Text = reclamo.Coaseguro?.ToString("N2") ?? "";
            txtOtrosGastos.Text = reclamo.OtrosGastos?.ToString("N2") ?? "";
            txtTimbres.Text = reclamo.Timbres?.ToString("N2") ?? "";
            txtMontoCheque.Text = reclamo.MontoCheque?.ToString("N2") ?? "";
            foreach (var item in reclamo.Historial)
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

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = decimales(e.KeyChar, Text);
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
            dgvHistorial.Columns["Status"].Width = 200;
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
            var monedas = db.Monedas.ToList();
            cboMonedas.DataSource = monedas;
            cboMonedas.DisplayMember = "Nombre";
            cboMonedas.ValueMember = "IdMoneda";
            var status = db.AdminStatuses.Select(s => new { s.IdStatus, s.Nombre, s.Orden }).OrderBy(s => s.Orden).ToList();
            cboStatus.DataSource = status;
            cboStatus.DisplayMember = "Nombre";
            cboStatus.ValueMember = "IdStatus";
            if (reclamo == null)
            {
                cboStatus.Enabled = false;
            }
            llenarNombres(cboTipoReclamo, "RECLAMOS");
            isLoadingcbo = false;
        }

        private void llenarFamiliares(int selectedId)
        {
            using SAESoftContext db = new();
            DateTime limite = DateTime.Now.AddYears(-23);
            var familiares = db.Familiares.Where(f => f.IdEmpleado == selectedId).Where(f => f.FechaNac > limite).Select(f => new { f.IdFamiliar, f.Nombres, f.Apellidos, f.NombreCompleto }).OrderBy(f => f.Nombres).ToList();
            familiares.Insert(0, new { IdFamiliar = 0, Nombres = "", Apellidos = "", NombreCompleto = "NINGUNO" });
            cboFamiliares.DataSource = familiares;
            cboFamiliares.DisplayMember = "Nombrecompleto";
            cboFamiliares.ValueMember = "IdFamiliar";
        }

        private void cboEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcbo)
            {
                llenarFamiliares(Convert.ToInt32(cboEmpleados.SelectedValue));
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (reclamo == null)
                {
                    using SAESoftContext db = new();
                    using IDbContextTransaction transaction = db.Database.BeginTransaction();
                    try
                    {
                        reclamo = new()
                        {
                            IdEmpleado = Convert.ToInt32(cboEmpleados.SelectedValue),
                            IdTipo = Convert.ToInt32(cboTipoReclamo.SelectedValue),
                            IdStatus = Convert.ToInt32(cboStatus.SelectedValue),
                            Monto = Convert.ToDecimal(txtMonto.Text),
                            IdMoneda = Convert.ToInt32(cboMonedas.SelectedValue),
                            Observaciones = txtObservaciones.Text,
                            FechaRecibir = DatosServer.FechaServer().AddDays(20),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        int fam = Convert.ToInt32(cboFamiliares.SelectedValue);
                        if (fam != 0)
                            reclamo.IdPaciente = fam;
                        db.Add(reclamo);
                        db.SaveChanges();
                        HistorialReclamo hist = new()
                        {
                            IdReclamo = reclamo.IdReclamo,
                            IdStatus = reclamo.IdStatus,
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
                        db.Entry(reclamo).State = EntityState.Modified;
                        reclamo.Observaciones = txtObservaciones.Text;
                        reclamo.Cheque = txtNoCheque.Text;
                        reclamo.FechaRecibir = dtpFechaRecepcion.Value;
                        reclamo.IdStatus = Convert.ToInt32(cboStatus.SelectedValue);
                        reclamo.Deducible = string.IsNullOrEmpty(txtDeducible.Text) ? 0:Convert.ToDecimal(txtDeducible.Text);
                        reclamo.MontosNoCubiertos = string.IsNullOrEmpty(txtNoCubierto.Text) ? 0 : Convert.ToDecimal(txtNoCubierto.Text);
                        reclamo.Coaseguro = string.IsNullOrEmpty(txtCoaseguro.Text) ? 0 : Convert.ToDecimal(txtCoaseguro.Text);
                        reclamo.OtrosGastos = string.IsNullOrEmpty(txtOtrosGastos.Text) ? 0 : Convert.ToDecimal(txtOtrosGastos.Text);
                        reclamo.Timbres = string.IsNullOrEmpty(txtTimbres.Text) ? 0 : Convert.ToDecimal(txtTimbres.Text);
                        reclamo.MontoCheque = string.IsNullOrEmpty(txtMontoCheque.Text) ? 0 : Convert.ToDecimal(txtMontoCheque.Text);
                        db.Reclamos.Update(reclamo);
                        db.SaveChanges();
                        HistorialReclamo hist = new()
                        {
                            IdReclamo = reclamo.IdReclamo,
                            IdStatus = reclamo.IdStatus,
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

        private Boolean validarDatos()
        {
            errorProvider1.Clear();
            if (txtMonto.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMonto, "No puede estar vacío.");
                txtMonto.Focus();
                return false;
            }
            if (reclamo != null)
            {
                int estatusSeleccionado = Convert.ToInt32(cboStatus.SelectedValue);
                if (estatusSeleccionado == reclamo.IdStatus)
                {
                    errorProvider1.SetError(cboStatus, "Debe de ser un estatus diferente.");
                    cboStatus.Focus();
                    return false;
                }
            }
            return true;
        }
        private void cboMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcbo)
            {
                Moneda moneda = cboMonedas.SelectedItem as Moneda;
                label8.Text = "Monto (" + moneda.Simbolo + ")";
            }
        }

        private void txtNoCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo los dígitos del 0 al 9 y algunas teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
