using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using SAESoft.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static SAESoft.Cache.UserData;

namespace SAESoft.Incentivo
{
    public partial class frmCalificacionDepto : Form
    {
        readonly DataTable dt = new();
        Boolean carga = false;
        int pasistencia, pactitud, pcoop;
        decimal Total, Extra;
        Evaluacion ev;
        public frmCalificacionDepto()
        {
            InitializeComponent();
        }

        public void llenarCombo()
        {
            using SAESoftContext db = new();
            if (usuarioLogged.Rol.IdRol == 1)
            {
                cboDepto.DataSource = db.DeptoIncentivo.ToList();

            }
            else
            {
                cboDepto.DataSource = db.DeptoIncentivo.Where(b => b.IdUsuario == usuarioLogged.IdUsuario).ToList();
            }
            cboDepto.DisplayMember = "Nombre";
            cboDepto.ValueMember = "IdDepto";
            carga = true;
        }

        public void EstructuraGrid()
        {
            dt.Columns.Add("IdEmpIncentivo").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Nombre Completo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Base de Cálculo").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Asistencia").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Actitud").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Cooperacion").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("SubTotal").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Extra").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Total").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Bolsa").DataType = Type.GetType("System.Decimal");


            dgvEvaluar.DataSource = dt;
            dgvEvaluar.Columns["IdEmpIncentivo"].Visible = false;
            dgvEvaluar.Columns["Bolsa"].Visible = false;
            dgvEvaluar.Columns["Nombre Completo"].Width = 200;
            dgvEvaluar.Columns["Nombre Completo"].ReadOnly = true;
            dgvEvaluar.Columns["Asistencia"].ReadOnly = true;
            dgvEvaluar.Columns["SubTotal"].ReadOnly = true;
            dgvEvaluar.Columns["Total"].ReadOnly = true;

            dgvEvaluar.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEvaluar.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void frmCalificacionDepto_Load(object sender, EventArgs e)
        {
            llenarCombo();
            EstructuraGrid();
            CargarDatos();
            using SAESoftContext db = new();
            pasistencia = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("ASISTENCIA")).Select(b => b.Porcentaje).FirstOrDefault();
            pactitud = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("ACTITUD")).Select(b => b.Porcentaje).FirstOrDefault();
            pcoop = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("COOPERACIÓN")).Select(b => b.Porcentaje).FirstOrDefault();
        }

        private void cboDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dt.Clear();
            Total = 0.00M;
            Extra = 0.00M;
            if (carga)
            {
                using SAESoftContext db = new();
                var emp = db.EmpIncentivos.Include(b => b.Asistencias).Where(b => b.IdDepto == Convert.ToInt32(cboDepto.SelectedValue));
                ev = db.Evaluaciones.Where(b => !b.finalizado).FirstOrDefault();
                if (ev != null)
                {
                    foreach (var item in emp)
                    {
                        DataRow row = dt.NewRow();
                        row["IdEmpIncentivo"] = item.IdEmpIncentivo;
                        row["Nombre Completo"] = item.Nombres + " " + item.Apellidos;
                        row["Asistencia"] = item.Asistencias.Where(b => b.IdEvaluacion == ev.IdEvaluacion).Select(b => b.Porcentaje).FirstOrDefault();
                        row["Base de Cálculo"] = item.BaseCalculo.ToString("N2");
                        Total += item.BaseCalculo;
                        dt.Rows.Add(row);
                    }
                    txtTotal.Text = Total.ToString("C");
                    txtExtra.Text = Extra.ToString("C");
                    EstablecerNumerosEncabezado(dgvEvaluar);
                }
                else
                {
                    MessageBox.Show("No existe ninguna evaluación pendiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private static void EstablecerNumerosEncabezado(DataGridView dataGridView)
        {
            // Recorre cada fila del DataGridView
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                // Establece el número de fila en el encabezado de fila
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void dgvEvaluar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Actitud"].Index || dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Cooperacion"].Index || dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Extra"].Index) // Reemplaza "NombreColumna" con el nombre de la columna
            {
                if (e.Control is TextBox textBox)
                {
                    textBox.KeyPress -= TextBox_KeyPress; // Elimina el controlador de eventos existente para evitar duplicados
                    textBox.KeyPress += TextBox_KeyPress; // Asocia el controlador de eventos KeyPress
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solamente números, el punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solamente un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dgvEvaluar_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Actitud"].Index || dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Cooperacion"].Index) // Reemplaza "NombreColumna" con el nombre de la columna
            {
                if (e.FormattedValue != "")
                {
                    string valor = e.FormattedValue.ToString();
                    if (!decimal.TryParse(valor, out decimal numero) || numero < 0 || numero > 100)
                    {
                        dgvEvaluar.Rows[e.RowIndex].ErrorText = "El valor debe ser un número entre 0 y 100.";
                        e.Cancel = true;
                    }
                }
            }
            if (dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Extra"].Index)
            {
                if (e.FormattedValue != "")
                {
                    string valor = e.FormattedValue.ToString();
                    object sumaTotal = dt.Compute("SUM(Extra)", "");
                    decimal consumido = sumaTotal != DBNull.Value ? Convert.ToDecimal(sumaTotal) : 0m;
                    decimal bcalculo = (decimal)dgvEvaluar.Rows[e.RowIndex].Cells["Base de Cálculo"].Value;
                    object oconseguido = dgvEvaluar.Rows[e.RowIndex].Cells["SubTotal"].Value;
                    decimal conseguido = oconseguido != DBNull.Value ? Convert.ToDecimal(oconseguido) : 0;
                    if (bcalculo == conseguido)
                    {
                        if (!decimal.TryParse(valor, out decimal numero) || numero + consumido > Extra)
                        {
                            dgvEvaluar.Rows[e.RowIndex].ErrorText = "El valor debe ser un número menor a la casilla extra.";
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        dgvEvaluar.Rows[e.RowIndex].ErrorText = "Para asignar extra debe de tener el 100% del incentivo.";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvEvaluar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvaluar.Rows[e.RowIndex].ErrorText = ""; // Limpiar el texto de error después de validar
            dt.AcceptChanges();
            object asistencia = dgvEvaluar.Rows[e.RowIndex].Cells["Asistencia"].Value;
            object actitud = dgvEvaluar.Rows[e.RowIndex].Cells["Actitud"].Value;
            object coop = dgvEvaluar.Rows[e.RowIndex].Cells["Cooperacion"].Value;
            object baseC = dgvEvaluar.Rows[e.RowIndex].Cells["Base de Cálculo"].Value;
            object valorCelda = dgvEvaluar.Rows[e.RowIndex].Cells["Extra"].Value;
            decimal valorExtra = valorCelda != DBNull.Value && valorCelda != null ? Convert.ToDecimal(valorCelda) : 0m;
            if (actitud != DBNull.Value && coop != DBNull.Value)
            {
                calcular(Convert.ToInt32(asistencia), Convert.ToInt32(actitud), Convert.ToInt32(coop), Convert.ToDecimal(baseC), valorExtra, e);
            }
        }

        private void calcular(int asistencia, int actitud, int coop, decimal baseC, decimal valorExtra, DataGridViewCellEventArgs e)
        {
            decimal result = baseC * (asistencia * pasistencia / 100 + actitud * pactitud / 100 + coop * pcoop / 100) / 100;
            dgvEvaluar.Rows[e.RowIndex].Cells["SubTotal"].Value = result;
            dgvEvaluar.Rows[e.RowIndex].Cells["Bolsa"].Value = baseC - result;
            dgvEvaluar.Rows[e.RowIndex].Cells["Total"].Value = result + valorExtra;
            dt.AcceptChanges();
            Extra = (decimal)dt.Compute("SUM(Bolsa)", "");
            txtExtra.Text = Extra.ToString("C");
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
            bool llenas = true;
            foreach (DataRow fila in dt.Rows)
            {
                object valorTotal = fila["Total"];
                if (valorTotal == null || valorTotal == DBNull.Value || string.IsNullOrWhiteSpace(valorTotal.ToString()))
                {
                    llenas = false;
                    break; // Salir del bucle si encuentra una línea con Total vacío
                }
            }
            if (llenas)
            {
                DialogResult resp = MessageBox.Show("¿Desea Guardar la información? ", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    using SAESoftContext db = new();
                    using IDbContextTransaction transaction = db.Database.BeginTransaction();
                    foreach(DataRow dr in dt.Rows)
                    {
                        object valorCelda =dr["Extra"];
                        decimal valorExtra = valorCelda != DBNull.Value && valorCelda != null ? Convert.ToDecimal(valorCelda) : 0m;
                        EvaluacionDetalle detalle = new()
                        {
                            IdEvaluacion = ev.IdEvaluacion,
                            IdEmpleado = Convert.ToInt32(dr["IdEmpIncentivo"]),
                            Asistencia = Convert.ToInt32(dr["Asistencia"]),
                            Actitud = Convert.ToInt32(dr["Actitud"]),
                            Cooperacion = Convert.ToInt32(dr["Cooperacion"]),
                            Extra = valorExtra,
                            Total = Convert.ToDecimal(dr["Total"]),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.EvaluacionesDetalle.Add(detalle);
                    }
                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Datos guardados exitosamente","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    CargarDatos();
                }
            } else
            {
                MessageBox.Show("Existen empleados sin evaluación","Información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
