﻿
using static SAESoft.Utilitarios.ControlFormularios;
using SAESoft.Utilitarios;
using SAESoft.Models.Administracion;
using Microsoft.EntityFrameworkCore;
using static SAESoft.Cache.UserData;
using SAESoft.Models;
using System.Data;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;




namespace SAESoft.Administracion
{
    public partial class frmPersonal : Form
    {
        private Boolean esNuevo = false;
        public int individual = 0;
        private List<Empleado>? rs = new();
        private int CurrentIndex = 0;
        readonly DataTable dtDoc = new();
        readonly DataTable dtMig = new();
        readonly DataTable dtMed = new();
        private bool isLoadingcboEmpresa = false;
        private Boolean? cuotaAnual;

        public frmPersonal()
        {
            InitializeComponent();
        }

        private void estructuraGrid()
        {
            dtDoc.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dtDoc.Columns.Add("Parentesco").DataType = Type.GetType("System.String");
            dtDoc.Columns.Add("Fecha Nacimiento").DataType = Type.GetType("System.DateTime");
            dtDoc.Columns.Add("Edad").DataType = Type.GetType("System.Int32");
            dtDoc.Columns.Add("Pasaporte").DataType = Type.GetType("System.String");
            dtDoc.Columns.Add("Vencimiento Pasaporte").DataType = Type.GetType("System.DateTime");
            dtDoc.Columns.Add("Días Vigencia Pasaporte").DataType = Type.GetType("System.Int32");
            dtDoc.Columns.Add("DPI").DataType = Type.GetType("System.String");
            dtDoc.Columns.Add("Vencimiento DPI").DataType = Type.GetType("System.DateTime");
            dtDoc.Columns.Add("Días Vigencia DPI").DataType = Type.GetType("System.Int32");
            dtDoc.Columns.Add("Licencia").DataType = Type.GetType("System.String");
            dtDoc.Columns.Add("Vencimiento Licencia").DataType = Type.GetType("System.DateTime");
            dtDoc.Columns.Add("Días Vigencia Licencia").DataType = Type.GetType("System.Int32");
            dtDoc.Columns.Add("Boleto de Ornato").DataType = Type.GetType("System.Boolean");

            dgvDocumentos.DataSource = dtDoc;
            dgvDocumentos.Columns[0].Width = 250;
            dgvDocumentos.Columns[1].Width = 160;
            dgvDocumentos.Columns[2].Width = 130;
            dgvDocumentos.ClearSelection();

            dtMig.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dtMig.Columns.Add("Parentesco").DataType = Type.GetType("System.String");
            dtMig.Columns.Add("Residencia").DataType = Type.GetType("System.String");
            dtMig.Columns.Add("Resolución").DataType = Type.GetType("System.String");
            dtMig.Columns.Add("Vencimiento Residencia").DataType = Type.GetType("System.DateTime");
            dtMig.Columns.Add("Dias Vigencia Residencia").DataType = Type.GetType("System.Int32");
            dtMig.Columns.Add("Estatus Migratorio").DataType = Type.GetType("System.String");
            dtMig.Columns.Add("Vencimiento Estatus").DataType = Type.GetType("System.DateTime");
            dtMig.Columns.Add("Dias Vigencia Estatus").DataType = Type.GetType("System.Int32");
            dtMig.Columns.Add("Años de Residencia").DataType = Type.GetType("System.Int32");
            dtMig.Columns.Add("Cuota de Extranjería").DataType = Type.GetType("System.Boolean");

            dgvMigracion.DataSource = dtMig;
            dgvMigracion.Columns[0].Width = 250;
            dgvMigracion.Columns[1].Width = 160;
            dgvMigracion.Columns[2].Width = 250;
            dgvMigracion.ClearSelection();

            dtMed.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dtMed.Columns.Add("Parentesco").DataType = Type.GetType("System.String");
            dtMed.Columns.Add("Certificado").DataType = Type.GetType("System.String");
            dtMed.Columns.Add("Carnet").DataType = Type.GetType("System.String");

            dgvMedico.DataSource = dtMed;
            dgvMedico.Columns[0].Width = 250;
            dgvMedico.Columns[1].Width = 160;
            dgvMedico.ClearSelection();

        }

        public void llenarCombos()
        {
            isLoadingcboEmpresa = true;
            llenarNombres(cboEmpresa, "PLANTA");
            llenarNombres(cboPuesto, "PUESTOS");
            isLoadingcboEmpresa = false;
            llenarDepto(Convert.ToInt32(cboEmpresa.SelectedValue));
        }

        public void llenarMenu()
        {
            tsddbDocumentos.DropDownItems.Clear();
            using SAESoftContext db = new();
            var im = db.TiposDocumento.Where(i => i.activo).OrderBy(i => i.Nombre).ToList();
            foreach (var item in im)
            {
                ToolStripMenuItem i = new(item.Nombre)
                {
                    Tag = item.IdTipoDocumento,
                };
                tsddbDocumentos.DropDownItems.Add(i);
            }
        }

        public void llenarDepto(int empresa)
        {
            using SAESoftContext db = new();
            cboDepartamento.DataSource = db.DepartamentosInternos.Where(d => d.IdEmpresa == empresa).Select(c => new { c.IdDepto, c.Nombre }).ToList();
            cboDepartamento.DisplayMember = "Nombre";
            cboDepartamento.ValueMember = "IdDepto";
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "PERSONAL");
            llenarCombos();
            llenarMenu();
            estructuraGrid();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            ocultarCamposVariables();
            limpiarDt();
            limpiarFormulario(this);
            //  tsActivo.Checked = true;
            txtCodigo.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, true, toolStrip1, "PERSONAL");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, true, toolStrip1, "PERSONAL");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, false, toolStrip1, "PERSONAL");
                ocultarCamposVariables();
                limpiarDt();
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void despliegaDatos()
        {
            txtId.Text = rs[CurrentIndex].IdEmpleado.ToString();
            txtCodigo.Text = rs[CurrentIndex].Codigo;
            cboEmpresa.SelectedValue = rs[CurrentIndex].Departamento.IdEmpresa;
            cboDepartamento.SelectedValue = rs[CurrentIndex].IdDepto;
            cboPuesto.SelectedValue = rs[CurrentIndex].IdPuesto;
            txtNombres.Text = rs[CurrentIndex].Nombres;
            txtApellidos.Text = rs[CurrentIndex].Apellidos;
            txtNombreESP.Text = rs[CurrentIndex].Alias;
            txtNombreCOR.Text = rs[CurrentIndex].NombreCoreano;
            dtpFechaNac.Value = rs[CurrentIndex].FechaNac;
            dtpIngreso.Value = rs[CurrentIndex].FechaIngreso;
            tsCuotaAnual.Checked = rs[CurrentIndex].CuotaAnual;
            tsBoletoOrnato.Checked = rs[CurrentIndex].BoletoOrnato;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            if (rs[CurrentIndex].Genero == "M")
            {
                rdbMasculino.Checked = true;
            }
            else
            {
                rdbFemenino.Checked = true;
            }
            if (rs[CurrentIndex].EstadoCivil == "C")
            {
                rdbCasado.Checked = true;
            }
            else
            {
                rdbSoltero.Checked = true;
            }
            if (!rs[CurrentIndex].Activo)
            {
                dtpBaja.Value = rs[CurrentIndex].FechaBaja ?? DateTime.Now;
            }
            var texto = rs[CurrentIndex].Residencia?.Tipo.Descripcion;
            if (texto == "PERMANENTE")
            {
                label11.Visible = true;
                tsCuotaAnual.Visible = true;
            }
            else
            {
                label11.Visible = false;
                tsCuotaAnual.Visible = false;
            }
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
            despliegaDocumentos();
        }

        private void despliegaDocumentos()
        {
            txtPasaporte.Text = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero ?? "";
            txtDPI.Text = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero ?? "";
            txtNIT.Text = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 11)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero ?? "";
            txtIGSS.Text = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 3)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero ?? "";
            limpiarDt();
            llenarDatosPersonales();
            llenarDatosMigracion();
            llenarDatosTrabajo();
            llenarDatosRepresentacion();
            llenarDatosSeguroMedico();
            llenarDatosSeguroVehiculo();
        }

        private void llenarDatosSeguroMedico()
        {
            DataRow row;
            row = dtMed.NewRow();
            row[0] = rs[CurrentIndex].Alias;
            row[1] = "TITULAR";
            row[2] = rs[CurrentIndex].SeguroMedico?.Certificado ?? "";
            row[3] = rs[CurrentIndex].SeguroMedico?.Carnet ?? "";
            dtMed.Rows.Add(row);
            foreach (var familiar in rs[CurrentIndex].Familiares)
            {
                row = dtMed.NewRow();
                row[0] = familiar.Nombres + " " + familiar.Apellidos;
                if (familiar.Parentesco.Descripcion == "HIJO / HIJA")
                    if (familiar.Genero == "M")
                        row[1] = "HIJO";
                    else
                        row[1] = "HIJA";
                else
                    row[1] = familiar.Parentesco.Descripcion;
                row[2] = familiar.SeguroMedico?.Certificado ?? "";
                row[3] = familiar.SeguroMedico?.Carnet ?? "";
                dtMed.Rows.Add(row);
            }
        }
        private void llenarDatosSeguroVehiculo()
        {
            DateTime? vencimiento = rs[CurrentIndex].SeguroVehiculo?.Vencimiento;
            int? vigencia = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : null;
            txtAseguradora.Text = rs[CurrentIndex].SeguroVehiculo?.Aseguradora.Descripcion;
            txtPolizaSV.Text = rs[CurrentIndex].SeguroVehiculo?.Poliza;
            txtInicioSV.Text = rs[CurrentIndex].SeguroVehiculo?.Inicio.Date.ToString();
            txtVencimientoSV.Text = vencimiento.HasValue ? vencimiento.Value.Date.ToString("dd/MM/yyyy") : "";
            txtVigenciaSV.Text = vigencia.HasValue ? vigencia.Value.ToString("N0") : "";
            if (vigencia.HasValue && vigencia.Value > 0)
                txtVigenciaSV.ForeColor = SystemColors.WindowText;
            else
            {
                txtVigenciaSV.BackColor = SystemColors.Control;
                txtVigenciaSV.ForeColor = System.Drawing.Color.Red;
            }
            txtPlacasSV.Text = rs[CurrentIndex].SeguroVehiculo?.Placa;
            txtDescSV.Text = rs[CurrentIndex].SeguroVehiculo?.Marca + " " + rs[CurrentIndex].SeguroVehiculo?.Color;
            txtPrima.Text = rs[CurrentIndex].SeguroVehiculo?.Prima.ToString("C");
            txtDeducibleSV.Text = rs[CurrentIndex].SeguroVehiculo?.Deducible.ToString("C");
        }

        private void llenarDatosRepresentacion()
        {
            Boolean? noVence;
            DateTime? vencimiento;
            noVence = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 9)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.NoVence;
            vencimiento = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 9)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            int? vigencia = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : null;
            txtCargoNomb.Text = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 9)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            if (noVence.HasValue && noVence.Value)
            {
                txtVenceNomb.Text = "NO VENCE";
                txtVigenciaNomb.Text = "Indefinida";
            }
            else
            {
                txtVenceNomb.Text = vencimiento.HasValue ? vencimiento.Value.ToString("dd/MM/yyyy") : "";
                txtVigenciaNomb.Text = vigencia.HasValue ? vigencia.Value.ToString("N0") : "";
            }
            if (vigencia.HasValue && vigencia.Value > 0)
                txtVigenciaNomb.ForeColor = SystemColors.WindowText;
            else
            {
                txtVigenciaNomb.BackColor = SystemColors.Control;
                txtVigenciaNomb.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void llenarDatosTrabajo()
        {
            txtTipoPermiso.Text = rs[CurrentIndex].PermisoTrabajo?.Tipo.Descripcion;
            txtResolucionPT.Text = rs[CurrentIndex].PermisoTrabajo?.Resolucion;
            DateTime? vencimiento = rs[CurrentIndex].PermisoTrabajo?.Vencimiento;
            txtVencimientoPT.Text = vencimiento.HasValue ? vencimiento.Value.ToString("dd/MM/yyyy") : "";
            int? vigencia = vencimiento.HasValue ? calculaVigencia(vencimiento.Value) : null;
            if (vigencia.HasValue && vigencia.Value > 0)
                txtVigenciaPT.ForeColor = SystemColors.WindowText;
            else
            {
                txtVigenciaPT.BackColor = SystemColors.Control;
                txtVigenciaPT.ForeColor = System.Drawing.Color.Red;
            }
            txtVigenciaPT.Text = vigencia.HasValue ? vigencia.Value.ToString("N0") : "";
            txtContrato.Text = rs[CurrentIndex].Contrato?.Numero ?? "";
            txtEmpresa.Text = rs[CurrentIndex].Contrato?.Empresa.Descripcion ?? "";
        }

        private void llenarDatosMigracion()
        {
            DataRow row;
            string? texto, texto2;
            DateTime? fecha;
            int? Años = null;
            row = dtMig.NewRow();
            row[0] = rs[CurrentIndex].Alias;
            row[1] = "TITULAR";
            texto = rs[CurrentIndex].Residencia?.Tipo.Descripcion;
            texto2 = rs[CurrentIndex].Residencia?.Resolucion;
            if (texto != "PERMANENTE")
            {
                fecha = rs[CurrentIndex].Residencia?.Vencimiento;
                cuotaAnual = null;
                Años = rs[CurrentIndex].AñosResidencia;
            }
            else
            {
                fecha = null;
                cuotaAnual = rs[CurrentIndex].CuotaAnual;
                Años = null;
            }
            row[2] = texto != null ? (Object)texto : DBNull.Value;
            row[3] = texto2 != null ? (Object)texto2 : DBNull.Value;
            row[4] = fecha.HasValue ? (Object)fecha : DBNull.Value;
            row[5] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
            texto = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            row[6] = texto != null ? (Object)texto : DBNull.Value;
            row[7] = fecha.HasValue ? (Object)fecha : DBNull.Value;
            row[8] = fecha != null ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
            if (Años != null)
                row[9] = Años;
            if (cuotaAnual != null)
                row[10] = cuotaAnual;
            dtMig.Rows.Add(row);
            foreach (var familiar in rs[CurrentIndex].Familiares)
            {
                row = dtMig.NewRow();
                row[0] = familiar.Nombres + " " + familiar.Apellidos;
                if (familiar.Parentesco.Descripcion == "HIJO / HIJA")
                    if (familiar.Genero == "M")
                        row[1] = "HIJO";
                    else
                        row[1] = "HIJA";
                else
                    row[1] = familiar.Parentesco.Descripcion;
                texto = familiar.Residencia?.Tipo.Descripcion;
                texto2 = familiar.Residencia?.Resolucion;
                if (texto != "PERMANENTE")
                {
                    fecha = familiar.Residencia?.Vencimiento;
                    cuotaAnual = null;
                    Años = familiar.AñosResidencia;
                }
                else
                {
                    fecha = null;
                    cuotaAnual = rs[CurrentIndex].CuotaAnual;
                    Años = null;
                }
                row[2] = texto != null ? (Object)texto : DBNull.Value;
                row[3] = texto2 != null ? (Object)texto2 : DBNull.Value;
                row[4] = fecha.HasValue ? (Object)fecha : DBNull.Value;
                row[5] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
                texto = familiar.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                fecha = familiar.Documentos?.Where(d => d.IdTipo == 5)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                row[6] = texto != null ? (Object)texto : DBNull.Value;
                row[7] = fecha.HasValue ? (Object)fecha : DBNull.Value;
                row[8] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
                if (Años != null)
                    row[9] = Años;
                if (cuotaAnual != null)
                    row[10] = cuotaAnual;
                dtMig.Rows.Add(row);
            }
        }
        private void llenarDatosPersonales()
        {
            DataRow row;
            string? texto;
            DateTime? fecha;
            row = dtDoc.NewRow();
            row[0] = rs[CurrentIndex].Alias;
            row[1] = "TITULAR";
            row[2] = rs[CurrentIndex].FechaNac.Date;
            row[3] = calculaEdad(rs[CurrentIndex].FechaNac.Date);
            texto = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            row[4] = texto != null ? (Object)texto : DBNull.Value;
            row[5] = fecha.HasValue ? (Object)fecha : DBNull.Value;
            row[6] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
            texto = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            row[7] = texto != null ? (Object)texto : DBNull.Value;
            row[8] = fecha.HasValue ? (Object)fecha : DBNull.Value;
            row[9] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
            texto = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 8)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
            fecha = rs[CurrentIndex].Documentos?.Where(d => d.IdTipo == 8)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
            row[10] = texto != null ? (Object)texto : DBNull.Value;
            row[11] = fecha.HasValue ? (Object)fecha : DBNull.Value;
            row[12] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
            row[13] = rs[CurrentIndex].BoletoOrnato;
            dtDoc.Rows.Add(row);
            foreach (var familiar in rs[CurrentIndex].Familiares)
            {
                row = dtDoc.NewRow();
                row[0] = familiar.Nombres + " " + familiar.Apellidos;
                if (familiar.Parentesco.Descripcion == "HIJO / HIJA")
                    if (familiar.Genero == "M")
                        row[1] = "HIJO";
                    else
                        row[1] = "HIJA";
                else
                    row[1] = familiar.Parentesco.Descripcion;
                row[2] = familiar.FechaNac.Date;
                row[3] = calculaEdad(familiar.FechaNac.Date);
                texto = familiar.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                fecha = familiar.Documentos?.Where(d => d.IdTipo == 2)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                row[4] = texto != null ? (Object)texto : DBNull.Value;
                row[5] = fecha.HasValue ? (Object)fecha : DBNull.Value;
                row[6] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
                texto = familiar.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                fecha = familiar.Documentos?.Where(d => d.IdTipo == 1)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                row[7] = texto != null ? (Object)texto : DBNull.Value;
                row[8] = fecha.HasValue ? (Object)fecha : DBNull.Value;
                row[9] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
                texto = familiar.Documentos?.Where(d => d.IdTipo == 8)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Numero;
                fecha = familiar.Documentos?.Where(d => d.IdTipo == 8)?.OrderByDescending(d => d.FechaCreacion)?.FirstOrDefault()?.Vencimiento;
                row[10] = texto != null ? (Object)texto : DBNull.Value;
                row[11] = fecha.HasValue ? (Object)fecha : DBNull.Value;
                row[12] = fecha.HasValue ? (Object)calculaVigencia(fecha.Value) : DBNull.Value;
                dtDoc.Rows.Add(row);
            }
        }

        private void ocultarCamposVariables()
        {
            tsCuotaAnual.Visible = false;
            label17.Visible = false;
            dtpBaja.Visible = false;
        }

        private void limpiarDt()
        {
            dtDoc.Clear();
            dtMig.Clear();
            dtMed.Clear();
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtCodigo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCodigo, "No puede estar vacío.");
                txtCodigo.Focus();
                return false;
            }
            if (txtNombres.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombres, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                errorProvider1.SetError(txtApellidos, "No puede estar vacío.");
                txtApellidos.Focus();
                return false;
            }
            if (txtNombreESP.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreESP, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (txtNombreCOR.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNombreCOR, "No puede estar vacío.");
                txtNombreCOR.Focus();
                return false;
            }
            return true;
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            string genero, estadoCivil;
            if (rdbMasculino.Checked)
            {
                genero = "M";
            }
            else
            {
                genero = "F";
            }
            if (rdbCasado.Checked)
            {
                estadoCivil = "C";
            }
            else
            {
                estadoCivil = "S";
            }
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using SAESoftContext db = new();
                    try
                    {
                        var depto = db.DepartamentosInternos.Where(e => e.IdDepto == Convert.ToInt32(cboDepartamento.SelectedValue)).FirstOrDefault();
                        var puesto = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboPuesto.SelectedValue)).FirstOrDefault();
                        Empleado empleado = new()
                        {
                            Codigo = txtCodigo.Text,
                            IdDepto = depto.IdDepto,
                            Nombres = txtNombres.Text,
                            Apellidos = txtApellidos.Text,
                            Alias = txtNombreESP.Text,
                            NombreCoreano = txtNombreCOR.Text,
                            FechaNac = dtpFechaNac.Value.Date,
                            FechaIngreso = dtpIngreso.Value.Date,
                            CuotaAnual = tsCuotaAnual.Checked,
                            BoletoOrnato = tsBoletoOrnato.Checked,
                            Activo = tsActivo.Checked,
                            Genero = genero,
                            EstadoCivil = estadoCivil,
                            IdPuesto = puesto.IdNombre,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        if (!tsActivo.Checked)
                        {
                            empleado.FechaBaja = dtpBaja.Value.Date;
                        }
                        db.Empleados.Add(empleado);
                        db.SaveChanges();
                        rs.Add(empleado);
                        CurrentIndex = rs.Count - 1;
                        List<Familiar> fam = new();
                        List<Documento> doc = new();
                        rs[CurrentIndex].Familiares = fam;
                        rs[CurrentIndex].Documentos = doc;
                        despliegaDatos();
                        MessageBox.Show("Empleado Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Empleado temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        var depto = db.DepartamentosInternos.Where(e => e.IdDepto == Convert.ToInt32(cboDepartamento.SelectedValue)).FirstOrDefault();
                        var puesto = db.Nombres.Where(e => e.IdNombre == Convert.ToInt32(cboPuesto.SelectedValue)).FirstOrDefault();
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Codigo = txtCodigo.Text;
                        rs[CurrentIndex].Nombres = txtNombres.Text;
                        rs[CurrentIndex].Apellidos = txtApellidos.Text;
                        rs[CurrentIndex].Alias = txtNombreESP.Text;
                        rs[CurrentIndex].NombreCoreano = txtNombreCOR.Text;
                        rs[CurrentIndex].FechaNac = dtpFechaNac.Value.Date;
                        rs[CurrentIndex].FechaIngreso = dtpIngreso.Value.Date;
                        rs[CurrentIndex].CuotaAnual = tsCuotaAnual.Checked;
                        rs[CurrentIndex].BoletoOrnato = tsBoletoOrnato.Checked;
                        rs[CurrentIndex].Activo = tsActivo.Checked;
                        rs[CurrentIndex].Genero = genero;
                        rs[CurrentIndex].EstadoCivil = estadoCivil;
                        rs[CurrentIndex].IdDepto = depto.IdDepto;
                        rs[CurrentIndex].IdPuesto = puesto.IdNombre;
                        if (!tsActivo.Checked)
                        {
                            rs[CurrentIndex].FechaBaja = dtpBaja.Value.Date;
                        }
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Empleados.Update(rs[CurrentIndex]);
                        db.SaveChanges();
                        despliegaDatos();
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rs[CurrentIndex] = temp;
                        return;
                    }
                }
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, true, toolStrip1, "PERSONAL");
                habilitarFormulario(this, false);
            }
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleados buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
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
                                            .Where(b => 1 == 1);
                if (buscar.codigo != null)
                    queryable = queryable.Where(b => b.Codigo.Contains(buscar.codigo));
                if (buscar.nombreESP != null)
                    queryable = queryable.Where(b => b.Alias.Contains(buscar.nombreESP));
                if (buscar.nombreCOR != null)
                    queryable = queryable.Where(b => b.NombreCoreano.Contains(buscar.nombreCOR));
                rs = queryable.ToList();
                buscar.Dispose();
                if (rs.Count > 0)
                {
                    CurrentIndex = 0;
                    despliegaDatos();
                    if (rs.Count > 1)
                    {
                        BotonesInicialesNavegacion(toolStrip1);
                    }
                    else
                    {
                        BotonesIniciales(toolStrip1);
                    }
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, true, toolStrip1, "PERSONAL");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ocultarCamposVariables();
                    limpiarDt();
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, false, toolStrip1, "PERSONAL");
                }
            }
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (CurrentIndex <= 0)
                return;
            CurrentIndex--;
            despliegaDatos();
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (CurrentIndex + 1 >= rs?.Count)
                return;
            CurrentIndex++;
            despliegaDatos();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtCodigo.Focus();
        }

        private void tsbRelatives_Click(object sender, EventArgs e)
        {
            frmFamiliares familia = new();
            var resp = familia.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var parentesco = db.Nombres.Where(p => p.IdNombre == familia.parentesco).FirstOrDefault();
                var empleado = db.Empleados.Where(e => e.IdEmpleado == rs[CurrentIndex].IdEmpleado).FirstOrDefault();
                Familiar familiar = new()
                {
                    IdParentesco = parentesco.IdNombre,
                    IdEmpleado = empleado.IdEmpleado,
                    Nombres = familia.nombres,
                    Apellidos = familia.apellidos,
                    FechaNac = familia.fecnac,
                    Genero = familia.genero,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                };
                db.Familiares.Add(familiar);
                db.SaveChanges();
                rs[CurrentIndex].Familiares.Add(familiar);
                despliegaDatos();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    db.Familiares.RemoveRange(rs[CurrentIndex].Familiares);
                    db.SaveChanges();
                    db.Empleados.Remove(rs[CurrentIndex]);
                    db.SaveChanges();
                    rs.Remove(rs[CurrentIndex]);
                    transaction.Commit();
                    if (rs.Count > 0)
                    {
                        if (rs.Count > 1)
                        {
                            if (CurrentIndex != 0)
                                CurrentIndex--;
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            CurrentIndex = 0;
                            BotonesIniciales(toolStrip1);
                        }
                        despliegaDatos();
                    }
                    else
                    {
                        ocultarCamposVariables();
                        limpiarFormulario(this);
                        limpiarDt();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar", "tsbRelatives", "tsddbDocumentos", "tsbFicha" }, false, toolStrip1, "PERSONAL");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingcboEmpresa)
            {
                llenarDepto(Convert.ToInt32(cboEmpresa.SelectedValue));
            }
        }

        private void tsddbDocumentos_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "RESIDENCIA":
                    {
                        llenarResidencia();
                        break;
                    }
                case "CONTRATO DE TRABAJO":
                    {
                        llenarContrato();
                        break;
                    }
                case "PERMISO DE TRABAJO":
                    {
                        llenarPermisoTrabajo();
                        break;
                    }
                case "REPRESENTACIÓN LEGAL":
                    {
                        llenarRepresentacion();
                        break;
                    }
                case "SEGURO VEHÍCULO":
                    {
                        llenarSeguroVehiculo();
                        break;
                    }
                default:
                    {
                        llenarDocumentos((int)e.ClickedItem.Tag);
                        break;
                    }
            }
        }

        private void llenarSeguroVehiculo()
        {
            frmSeguroVehiculo vehiculo = new();
            if (rs[CurrentIndex].SeguroVehiculo != null)
            {
                vehiculo.existe = true;
            }
            var resp = vehiculo.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                if (vehiculo.existe)
                {
                    rs[CurrentIndex].IdSeguroVehiculo = null;
                    db.Empleados.Update(rs[CurrentIndex]);
                    db.SaveChanges();
                    db.SegurosVehiculos.Remove(rs[CurrentIndex].SeguroVehiculo);
                    db.SaveChanges();
                    rs[CurrentIndex].SeguroVehiculo = null;
                }
                var aseg = db.Nombres.Where(t => t.IdNombre == vehiculo.idAseguradora).FirstOrDefault();
                SeguroVehiculo veh = new()
                {
                    Marca = vehiculo.marca,
                    Color = vehiculo.color,
                    Placa = vehiculo.placas,
                    IdAseguradora = aseg.IdNombre,
                    Poliza = vehiculo.poliza,
                    Inicio = vehiculo.inicio,
                    Vencimiento = vehiculo.vencimiento,
                    Prima = vehiculo.prima,
                    Deducible = vehiculo.deducible,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                };
                db.SegurosVehiculos.Add(veh);
                db.SaveChanges();
                db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                rs[CurrentIndex].IdSeguroVehiculo = veh.IdVehiculo;
                db.Empleados.Update(rs[CurrentIndex]);
                db.SaveChanges();
                rs[CurrentIndex].SeguroVehiculo = veh;
                despliegaDatos();
            }
        }
        private void llenarPermisoTrabajo()
        {
            frmPermisoTrabajo permiso = new();
            if (rs[CurrentIndex].PermisoTrabajo != null)
            {
                permiso.existe = true;
            }
            var resp = permiso.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                if (permiso.existe)
                {
                    rs[CurrentIndex].IdPermisoTrabajo = null;
                    db.Empleados.Update(rs[CurrentIndex]);
                    db.SaveChanges();
                    db.PermisosTrabajo.Remove(rs[CurrentIndex].PermisoTrabajo);
                    db.SaveChanges();
                    rs[CurrentIndex].PermisoTrabajo = null;
                }
                var tipo = db.Nombres.Where(t => t.IdNombre == permiso.tipo).FirstOrDefault();
                PermisoTrabajo per = new()
                {
                    IdTipo = tipo.IdNombre,
                    Resolucion = permiso.resolucion,
                    Inicio = permiso.inicio,
                    Vencimiento = permiso.vencimiento,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                };
                db.PermisosTrabajo.Add(per);
                db.SaveChanges();
                db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                rs[CurrentIndex].IdPermisoTrabajo = per.IdPermiso;
                db.Empleados.Update(rs[CurrentIndex]);
                db.SaveChanges();
                rs[CurrentIndex].PermisoTrabajo = per;
                despliegaDatos();
            }
        }

        private void llenarRepresentacion()
        {
            using SAESoftContext db = new();
            var tipo = db.TiposDocumento.Where(p => p.IdTipoDocumento == 9).FirstOrDefault();
            frmNombramientos nombramiento = new();
            var resp = nombramiento.ShowDialog();
            if (resp == DialogResult.OK)
            {
                Documento docto = new()
                {
                    IdEmpleado = rs[CurrentIndex].IdEmpleado,
                    IdTipo = tipo.IdTipoDocumento,
                    Numero = nombramiento.numero,
                    Fecha = nombramiento.emision,
                    NoVence = nombramiento.novence,
                    Vencimiento = nombramiento.novence ? null : nombramiento.vencimiento,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                };

                db.Documentos.Add(docto);
                db.SaveChanges();
                rs[CurrentIndex].Documentos.Add(docto);
                despliegaDatos();
            }
        }
        private void llenarDocumentos(int t)
        {
            using SAESoftContext db = new();
            var tipo = db.TiposDocumento.Where(p => p.IdTipoDocumento == t).FirstOrDefault();
            frmDocumentos documento = new() { documento = tipo.Nombre };
            var resp = documento.ShowDialog();
            if (resp == DialogResult.OK)
            {
                Documento docto = new()
                {
                    IdEmpleado = rs[CurrentIndex].IdEmpleado,
                    IdTipo = tipo.IdTipoDocumento,
                    Numero = documento.numero,
                    Fecha = documento.emision,
                    NoVence = documento.novence,
                    Vencimiento = documento.novence ? null : documento.vencimiento,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                };

                db.Documentos.Add(docto);
                db.SaveChanges();
                rs[CurrentIndex].Documentos.Add(docto);
                despliegaDatos();
            }
        }

        private void llenarResidencia()
        {
            frmResidencia residencia = new();
            if (rs[CurrentIndex].Residencia != null)
            {
                residencia.existe = true;
            }
            var resp = residencia.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                if (residencia.existe)
                {
                    rs[CurrentIndex].IdResidencia = null;
                    db.Empleados.Update(rs[CurrentIndex]);
                    db.SaveChanges();
                    db.Residencias.Remove(rs[CurrentIndex].Residencia);
                    db.SaveChanges();
                    rs[CurrentIndex].Residencia = null;
                }
                var tipo = db.Nombres.Where(t => t.IdNombre == residencia.tipo).FirstOrDefault();
                Residencia res = new()
                {
                    IdTipo = tipo.IdNombre,
                    Resolucion = residencia.resolucion,
                    Vencimiento = residencia.vencimiento,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                };
                db.Residencias.Add(res);
                db.SaveChanges();
                db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                rs[CurrentIndex].IdResidencia = res.IdResidencia;
                db.Empleados.Update(rs[CurrentIndex]);
                db.SaveChanges();
                rs[CurrentIndex].Residencia = res;
                despliegaDatos();
            }
        }

        private void llenarContrato()
        {
            frmContrato contrato = new();
            if (rs[CurrentIndex].Contrato != null)
            {
                contrato.existe = true;
            }
            var resp = contrato.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                if (contrato.existe)
                {
                    rs[CurrentIndex].IdContrato = null;
                    db.Empleados.Update(rs[CurrentIndex]);
                    db.SaveChanges();
                    db.Contratos.Remove(rs[CurrentIndex].Contrato);
                    db.SaveChanges();
                    rs[CurrentIndex].Contrato = null;
                }
                var empresa = db.Nombres.Where(e => e.IdNombre == contrato.empresa).FirstOrDefault();
                Contrato cont = new()
                {
                    Numero = contrato.numero,
                    IdEmpresa = empresa.IdNombre,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario
                };
                db.Contratos.Add(cont);
                db.SaveChanges();
                db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                rs[CurrentIndex].IdContrato = cont.IdContrato;
                db.Empleados.Update(rs[CurrentIndex]);
                db.SaveChanges();
                rs[CurrentIndex].Contrato = cont;
                despliegaDatos();
            }
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
            {
                label17.Visible = false;
                dtpBaja.Visible = false;
            }
            else
            {
                label17.Visible = true;
                dtpBaja.Visible = true;
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Convert.ToString(calculaEdad(dtpFechaNac.Value.Date));
        }

        private static int calculaEdad(DateTime fecha)
        {
            int edad = DateTime.Now.Year - fecha.Year; // Calcula la diferencia en años

            // Verifica si aún no se ha cumplido el aniversario de nacimiento este año
            if (fecha.Date > DateTime.Now.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        private static int calculaVigencia(DateTime fecha)
        {
            TimeSpan diferencia = fecha - DateTime.Today;
            int dias = diferencia.Days;
            return dias;
        }

        private void dgvDocumentos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // para que no salte error por defecto, no borrar.
        }

        private void dgvMigracion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // para que no salte error por defecto, no borrar.
        }

        private void dgvMigracion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (cuotaAnual == null)
            {
                DataGridViewRow lastRow = dgvMigracion.Rows[^1];
                lastRow.Cells[8] = new DataGridViewTextBoxCell
                {
                    Value = ""
                };
            }
        }

        private void dgvDocumentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvDocumentos.Rows.Count > 1)
            {
                DataGridViewRow lastRow = dgvDocumentos.Rows[^1];
                lastRow.Cells[10] = new DataGridViewTextBoxCell
                {
                    Value = ""
                };
            }
        }

        private void dgvDocumentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 9 || e.ColumnIndex == 12)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Obtener el valor numérico
                    int valor = Convert.ToInt32(e.Value);

                    // Aplicar formato con separador de miles
                    string valorFormateado = valor.ToString("#,##0");

                    // Configurar el color de la celda
                    if (valor < 0)
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    }

                    // Asignar el valor formateado a la celda
                    e.Value = valorFormateado;
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvMigracion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 8)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Obtener el valor numérico
                    int valor = Convert.ToInt32(e.Value);

                    // Aplicar formato con separador de miles
                    string valorFormateado = valor.ToString("#,##0");

                    // Configurar el color de la celda
                    if (valor < 0)
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    }

                    // Asignar el valor formateado a la celda
                    e.Value = valorFormateado;
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    e.FormattingApplied = true;
                }
            }
        }

        private void tsbFicha_Click(object sender, EventArgs e)
        {
            try
            {
                new Process { StartInfo = new ProcessStartInfo(FichaPersonal.Imprime(rs[CurrentIndex], rs[CurrentIndex].IdEmpleado)) { UseShellExecute = true } }.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
