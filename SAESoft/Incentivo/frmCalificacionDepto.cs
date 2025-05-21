using DocumentFormat.OpenXml.Bibliography;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using SAESoft.Utilitarios;
using System.Data;
using System.Windows.Input;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.ControlFormularios;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace SAESoft.Incentivo
{
    public partial class frmCalificacionDepto : Form
    {
        readonly DataTable dt = new();
        Boolean carga = false;
        int pasistencia, pactitud, pcoop, DiasMes;
        decimal Total, Extra, ExtraAnterior, TLogrado;
        Evaluacion ev;
        Boolean esNuevo = true;
        readonly List<int> evaluacionModificar = [];
        int firstDisplayedScrollingRowIndex;
        private DataGridViewCell _celWasEndEdit;
        readonly List<int> RolesPermitidos = [1, 6, 1006];
        const int QUINCENA = 15;
        public frmCalificacionDepto()
        {
            InitializeComponent();
        }

        public void llenarCombo()
        {
            carga = false;
            using SAESoftContext db = new();
            if (RolesPermitidos.Contains(usuarioLogged.Rol.IdRol))
            {
                cboDepto.DataSource = db.GrupoDeptoIncentivo.OrderBy(b => b.Nombre).Where(a => a.Activo).ToList();
                cboDepto.ValueMember = "IdGrupo";
            }
            else
            {
                if (hasGrupoDeptoIncentivo())
                {
                    cboDepto.DataSource = db.GrupoDeptoIncentivo.Include(d => d.Departamentos).Where(b => b.IdUsuario == usuarioLogged.IdUsuario && b.Activo).OrderBy(b => b.Nombre).ToList();
                    cboDepto.ValueMember = "IdGrupo";
                }
                else
                {
                    cboDepto.DataSource = db.DeptoIncentivo.Where(b => b.IdUsuario == usuarioLogged.IdUsuario && b.Activo).OrderBy(b => b.Nombre).ToList();
                    cboDepto.ValueMember = "IdDepto";
                }
            }
            cboDepto.DisplayMember = "Nombre";
            carga = true;
        }

        public void EstructuraGrid()
        {
            dt.Columns.Add("IdEmpIncentivo").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("IdDepto").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Codigo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Nombre Completo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Base").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Tardanza").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Permiso").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Ausencia").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Asistencia %").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Desempeño %").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Colaboración %").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Logro (1)").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Extra (2)").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Total Pago (1+2)").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Bolsa").DataType = Type.GetType("System.Decimal");
            dt.Columns.Add("Días Proporcional").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("IdEvaluacionDetalle").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("esNuevo").DataType = Type.GetType("System.Boolean");


            dgvEvaluar.DataSource = dt;
            dgvEvaluar.Columns["IdEmpIncentivo"].Visible = false;
            dgvEvaluar.Columns["IdDepto"].Visible = false;
            dgvEvaluar.Columns["Bolsa"].Visible = false;
            dgvEvaluar.Columns["IdEvaluacionDetalle"].Visible = false;
            dgvEvaluar.Columns["esNuevo"].Visible = false;
            //dgvEvaluar.Columns["Días Proporcional"].Visible = false;
            dgvEvaluar.Columns["Nombre Completo"].Width = 200;
            dgvEvaluar.Columns["IdEmpIncentivo"].ReadOnly = true;
            dgvEvaluar.Columns["IdDepto"].ReadOnly = true;
            dgvEvaluar.Columns["Codigo"].ReadOnly = true;
            dgvEvaluar.Columns["Bolsa"].ReadOnly = true;
            dgvEvaluar.Columns["Nombre Completo"].ReadOnly = true;
            dgvEvaluar.Columns["Base"].ReadOnly = true;
            dgvEvaluar.Columns["Tardanza"].ReadOnly = true;
            dgvEvaluar.Columns["Permiso"].ReadOnly = true;
            dgvEvaluar.Columns["Ausencia"].ReadOnly = true;
            dgvEvaluar.Columns["Asistencia %"].ReadOnly = true;
            dgvEvaluar.Columns["Logro (1)"].ReadOnly = true;
            dgvEvaluar.Columns["Total Pago (1+2)"].ReadOnly = true;
            dgvEvaluar.Columns["Días Proporcional"].ReadOnly = true;
            dgvEvaluar.Columns["IdEvaluacionDetalle"].ReadOnly = true;
            dgvEvaluar.Columns["esNuevo"].ReadOnly = true;

            if (usuarioLogged.IdRol == 2006)
            {
                dgvEvaluar.Columns["Extra (2)"].ReadOnly = true;
            }

            for (int c = 4; c <= 16; c++)
            {
                dgvEvaluar.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void frmCalificacionDepto_Load(object sender, EventArgs e)
        {
            llenarCombo();
            EstructuraGrid();
            using SAESoftContext db = new();
            pasistencia = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("ASISTENCIA")).Select(b => b.Porcentaje).FirstOrDefault();
            pactitud = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("ACTITUD")).Select(b => b.Porcentaje).FirstOrDefault();
            pcoop = db.PorcentajeEvaluacion.Where(b => b.fechaFin == null).Where(b => b.Descripcion.Equals("COOPERACIÓN")).Select(b => b.Porcentaje).FirstOrDefault();
        }

        private void cboDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carga)
                CargarDatos();
            BloqueaSuspendidos();
        }

        private void BloqueaSuspendidos()
        {
            foreach (DataGridViewRow row in dgvEvaluar.Rows)
            {
                if (row.Cells["Días Proporcional"].Value != null &&
                    int.TryParse(row.Cells["Días Proporcional"].Value.ToString(), out int diasProporcional) &&
                    diasProporcional == 0)
                {
                    row.Cells["Asistencia %"].Value = 0;
                    row.Cells["Desempeño %"].Value = 0;
                    row.Cells["Colaboración %"].Value = 0;
                    row.Cells["Logro (1)"].Value = 0;
                    row.Cells["Extra (2)"].Value = 0;
                    row.Cells["Total Pago (1+2)"].Value = 0;
                    row.ReadOnly = true;
                    row.DefaultCellStyle.BackColor = Color.MistyRose; // Cambia el color para indicar que está bloqueada
                    row.Tag = "Bloqueada";
                }
            }
        }

        private void CargarDatos()
        {
            if (hasPermission("MODIFICAR.EVALUACION"))
            {
                dgvEvaluar.Enabled = true;
            }
            else
            {
                dgvEvaluar.Enabled = false;
            }
            evaluacionModificar.Clear();
            dt.Clear();
            Total = 0.00M;
            Extra = 0.00M;
            TLogrado = 0.00M;
            using SAESoftContext db = new();
            ev = db.Evaluaciones.Include(d => d.Detalles).Where(b => !b.finalizado).FirstOrDefault();
            if (ev != null)
            {
                IQueryable<EmpIncentivos> emp = db.EmpIncentivos.Include(b => b.Asistencias);
                if (RolesPermitidos.Contains(usuarioLogged.Rol.IdRol) || hasGrupoDeptoIncentivo())
                {
                    emp = emp.Where(b => b.DeptoIncentivos.IdGrupo == Convert.ToInt32(cboDepto.SelectedValue)
                              && b.Asistencias.Any(a => a.IdEvaluacion == ev.IdEvaluacion));
                }
                else
                {
                    emp = emp.Where(b => b.IdDepto == Convert.ToInt32(cboDepto.SelectedValue)
                              && b.Asistencias.Any(a => a.IdEvaluacion == ev.IdEvaluacion));
                }
                emp = emp.OrderBy(b => b.IdDepto).ThenBy(b => b.Codigo);
                DiasMes = DateTime.DaysInMonth(ev.fechaFin.Year, ev.fechaFin.Month);
                foreach (var item in emp)
                {
                    DataRow row = dt.NewRow();
                    DiasLaborados(ref row, ev.fechaFin, item);
                    decimal diasLaborados = Convert.ToDecimal(row["Días Proporcional"]);
                    decimal proporcional = item.BaseCalculo * (diasLaborados / DiasMes);
                    row["IdEmpIncentivo"] = item.IdEmpIncentivo;
                    row["IdDepto"] = item.IdDepto;
                    row["Codigo"] = item.Codigo;
                    row["Nombre Completo"] = item.Nombres + " " + item.Apellidos;
                    row["Tardanza"] = item.Asistencias.Where(b => b.IdEvaluacion == ev.IdEvaluacion).Select(b => b.Tardanza).FirstOrDefault();
                    row["Permiso"] = item.Asistencias.Where(b => b.IdEvaluacion == ev.IdEvaluacion).Select(b => b.Permiso).FirstOrDefault();
                    row["Ausencia"] = item.Asistencias.Where(b => b.IdEvaluacion == ev.IdEvaluacion).Select(b => b.Ausente).FirstOrDefault();
                    row["Asistencia %"] = item.Asistencias.Where(b => b.IdEvaluacion == ev.IdEvaluacion).Select(b => b.Porcentaje).FirstOrDefault();
                    row["Base"] = proporcional.ToString("N2");
                    //row["Base"] = item.BaseCalculo;
                    Total += proporcional;
                    var evaluacion = ev.Detalles.FirstOrDefault(d => d.IdEmpleado == item.IdEmpIncentivo);
                    if (evaluacion != null)
                    {
                        icbGuardar.Enabled = false;
                        esNuevo = false;
                        despliegaCalificaciones(item, ref row);
                    }
                    else
                    {
                        icbGuardar.Enabled = true;
                        dgvEvaluar.Enabled = true;
                        esNuevo = true;
                    }
                    row["esNuevo"] = esNuevo;
                    dt.Rows.Add(row);
                }
                txtTotal.Text = Math.Round(Total, 2).ToString();
                Extra = Extra < 0 ? 0 : Extra;
                txtExtra.Text = (Math.Truncate(Extra * 100) / 100).ToString();
                txtLogrado.Text = Math.Round(TLogrado, 2).ToString();
                EstablecerNumerosEncabezado(dgvEvaluar);
            }
            else
            {
                MessageBox.Show("No existe ninguna evaluación pendiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void despliegaCalificaciones(EmpIncentivos emp, ref DataRow row)
        {
            decimal diasLaborados = Convert.ToDecimal(row["Días Proporcional"]);
            decimal proporcional = emp.BaseCalculo * (diasLaborados / DiasMes);
            var nota = ev.Detalles.FirstOrDefault(b => b.IdEmpleado == emp.IdEmpIncentivo);
            row["Asistencia %"] = nota.Asistencia;
            row["Desempeño %"] = nota.Actitud;
            row["Colaboración %"] = nota.Cooperacion;
            decimal Logro = nota.Total - nota.Extra;
            row["Logro (1)"] = Math.Round(Logro, 2);
            row["Extra (2)"] = Math.Round(nota.Extra, 2);
            row["Total Pago (1+2)"] = Math.Round(nota.Total, 2);
            decimal bolsa = proporcional - (nota.Total - nota.Extra);
            row["Bolsa"] = Math.Round(bolsa, 2);
            row["Días Proporcional"] = nota.DiasProporcional;
            row["IdEvaluacionDetalle"] = nota.IdEvaluacionDetalle;
            Extra += proporcional - nota.Total;
            TLogrado += nota.Total;
        }



        private void DiasLaborados(ref DataRow row, DateTime fecha, EmpIncentivos emp)
        {
            DateTime inicio = new(fecha.Year, fecha.Month, 1);
            DateTime fin = new(fecha.Year, fecha.Month, DiasMes);

            int DiasLaborados = DiasMes;
            // Calcula incentivo proporcional si ingreso en el mes de calculo.
            if (fin.Year == emp.FechaIngreso.Year && fin.Month == emp.FechaIngreso.Month)
            {
                DiasLaborados -= emp.FechaIngreso.Day - 1;
            }

            // calcula incentivo si se retiro en el mes del calculo.
            if (emp.FechaBaja != null)
            {
                if (((DateTime)emp.FechaBaja).Day > QUINCENA)
                {
                    DiasLaborados = ((DateTime)emp.FechaBaja).Day;
                }
                else
                {
                    DiasLaborados = 0;
                }
            }

            // toma suspensiones
            using SAESoftContext db = new();
            var suspensiones = db.Suspensiones.Where(b => b.IdEmpleado == emp.IdEmpIncentivo && b.Activo == true)
                                              .Where(b => b.FechaFin >= inicio && b.FechaInicio <= fin)
                                              .ToList();

            HashSet<int> diasSuspendido = [];

            foreach (var susp in suspensiones)
            {
                int startDay = (susp.FechaInicio.Month < inicio.Month) ? 1 : susp.FechaInicio.Day;
                int endDay = (susp.FechaFin.Month > inicio.Month) ? DiasMes : susp.FechaFin.Day;

                for (int day = startDay; day <= endDay; day++)
                {
                    diasSuspendido.Add(day);
                }
            }
            // Calcula los días laborados restando los días de suspensión
            DiasLaborados -= diasSuspendido.Count;

            if (DiasLaborados <= 0)
            {
                row["Días Proporcional"] = 0;
            }
            else
            {
                row["Días Proporcional"] = DiasLaborados;
            }
        }

        private void dgvEvaluar_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja el título "Asistencia %" encima de las tres columnas especificadas
            int colIndexStart = 5;
            int colIndexEnd = 7;

            // Calcula el rectángulo que abarca las tres columnas
            Rectangle headerRect = dgvEvaluar.GetCellDisplayRectangle(colIndexStart, -1, false);

            for (int i = colIndexStart + 1; i <= colIndexEnd; i++)
            {
                headerRect.Width += dgvEvaluar.GetCellDisplayRectangle(i, -1, false).Width;
            }

            // Ajusta el rectángulo para compensar el desplazamiento hacia la derecha
            headerRect.Width--;

            // Dibuja el fondo de la celda combinada
            e.Graphics.FillRectangle(new SolidBrush(Color.LightYellow), headerRect);

            // Dibuja el texto "Asistencia" en negrilla, centrado y arriba de la celda combinada
            StringFormat format = new()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Font boldFont = new(dgvEvaluar.DefaultCellStyle.Font, FontStyle.Bold);

            RectangleF textRect = new(headerRect.Left - 1, headerRect.Top, headerRect.Width, headerRect.Height / 2);
            e.Graphics.DrawString("Asistencia", boldFont, Brushes.Black, textRect, format);

            // Dibuja los títulos individuales de las columnas debajo de la celda combinada
            for (int i = colIndexStart; i <= colIndexEnd; i++)
            {
                Rectangle columnRect = dgvEvaluar.GetCellDisplayRectangle(i, -1, false);
                RectangleF textRectColumn = new(columnRect.Left, columnRect.Top + columnRect.Height / 2, columnRect.Width, columnRect.Height / 2);

                // Dibuja los bordes de los títulos individuales de las columnas en la mitad inferior
                using (Pen pen = new(Color.Black))
                {
                    // Ajusta el rectángulo para compensar el desplazamiento hacia la izquierda
                    columnRect.Width--;

                    e.Graphics.DrawRectangle(pen, columnRect.Left - 1, columnRect.Top - 1 + columnRect.Height / 2, columnRect.Width + 1, columnRect.Height / 2);
                }

                e.Graphics.DrawString(dgvEvaluar.Columns[i].HeaderText, dgvEvaluar.ColumnHeadersDefaultCellStyle.Font, Brushes.Black, textRectColumn, format);
            }

            // Dibuja la línea divisoria entre "Asistencia " y los títulos de las columnas
            int middleY = headerRect.Top + headerRect.Height / 2 - 1; // Ajuste para mover la línea hacia arriba
            e.Graphics.DrawLine(Pens.Black, headerRect.Left, middleY, headerRect.Right, middleY);
        }

        private void dgvEvaluar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dgvEvaluar.Rows[e.RowIndex];
            // Cambia el color de fondo de las columnas específicas
            if (row.Tag != null && row.Tag.ToString() == "Bloqueada")
            {
                e.CellStyle.BackColor = Color.MistyRose;
            }
            else
            {
                if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                {
                    // Cambia el color de fondo de las celdas
                    e.CellStyle.BackColor = Color.LightYellow;
                }
            }
        }

        private void dgvEvaluar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEvaluar.Rows[e.RowIndex];
                // Cambia el color de fondo de las columnas específicas
                if (row.Tag != null && row.Tag.ToString() == "Bloqueada")
                {
                    e.CellStyle.BackColor = Color.MistyRose;
                }
                else
                {
                    // Cambia el color de fondo de las celdas en las columnas específicas
                    if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7)
                    {
                        // Pinta el fondo de la celda de amarillo
                        e.CellStyle.BackColor = Color.LightYellow;

                        // Dibuja el fondo de la celda combinada
                        e.PaintBackground(e.CellBounds, true);

                        // Dibuja el contenido de la celda
                        e.PaintContent(e.CellBounds);

                        // Indica que el evento está manejado para evitar la pintura predeterminada
                        e.Handled = true;
                    }
                }
            }
        }

        private void dgvEvaluar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Desempeño %"].Index || dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Colaboración %"].Index || dgvEvaluar.CurrentCell.ColumnIndex == dgvEvaluar.Columns["Extra (2)"].Index) // Reemplaza "NombreColumna" con el nombre de la columna
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
            if (e.ColumnIndex == dgvEvaluar.Columns["Desempeño %"].Index || e.ColumnIndex == dgvEvaluar.Columns["Colaboración %"].Index) // Reemplaza "NombreColumna" con el nombre de la columna
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

            if (e.ColumnIndex == dgvEvaluar.Columns["Extra (2)"].Index)
            {
                if (e.FormattedValue != "")
                {
                    string valor = e.FormattedValue.ToString();
                    // object sumaTotal = dt.Compute("SUM([Extra (2)])", "");          
                    int tardanza = dgvEvaluar.Rows[e.RowIndex].Cells["Tardanza"].Value as int? ?? 0;

                    if (decimal.TryParse(valor, out decimal numero))
                    {
                        if (numero != 0)
                        {
                            if (tardanza <= 1)
                            {
                                if ((numero - ExtraAnterior) > (Extra + ExtraAnterior))
                                {
                                    dgvEvaluar.Rows[e.RowIndex].ErrorText = "El valor debe ser un número menor a la casilla \"Diferencia\".";
                                    e.Cancel = true;
                                }
                                else if (numero > 500)
                                {
                                    dgvEvaluar.Rows[e.RowIndex].ErrorText = "El valor debe ser un número menor a Q500.";
                                    e.Cancel = true;
                                }
                            }
                            else
                            {
                                dgvEvaluar.Rows[e.RowIndex].ErrorText = "Para asignar extra solamente puede tener como máximo una tardanza";
                                e.Cancel = true;
                            }
                        }
                    }
                    else
                    {
                        dgvEvaluar.Rows[e.RowIndex].ErrorText = "El valor debe de ser un número.";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dgvEvaluar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvaluar.Rows[e.RowIndex].ErrorText = ""; // Limpiar el texto de error después de validar
            dt.AcceptChanges();
            object asistencia = dgvEvaluar.Rows[e.RowIndex].Cells["Asistencia %"].Value;
            object actitud = dgvEvaluar.Rows[e.RowIndex].Cells["Desempeño %"].Value;
            object coop = dgvEvaluar.Rows[e.RowIndex].Cells["Colaboración %"].Value;
            object baseC = dgvEvaluar.Rows[e.RowIndex].Cells["Base"].Value;
            object valorCelda = dgvEvaluar.Rows[e.RowIndex].Cells["Extra (2)"].Value;
            object tardanza = dgvEvaluar.Rows[e.RowIndex].Cells["Tardanza"].Value;
            decimal valorExtra = valorCelda != DBNull.Value && valorCelda != null ? Convert.ToDecimal(valorCelda) : 0m;
            if (actitud != DBNull.Value && coop != DBNull.Value)
            {
                calcular(Convert.ToInt32(asistencia), Convert.ToInt32(actitud), Convert.ToInt32(coop), Convert.ToDecimal(baseC), valorExtra, Convert.ToInt32(tardanza), e);
            }
            BloqueaSuspendidos();
            object evDetalle = dgvEvaluar.Rows[e.RowIndex].Cells["IdEvaluacionDetalle"].Value;
            if (!esNuevo && int.TryParse(evDetalle.ToString(), out int celda))
            {
                if (!evaluacionModificar.Contains(celda))
                {
                    evaluacionModificar.Add(celda);
                    icbGuardar.Enabled = true;
                }
            }
            else if (esNuevo)
            {
                icbGuardar.Enabled = true;
            }
            EstablecerNumerosEncabezado(dgvEvaluar);
            dgvEvaluar.FirstDisplayedScrollingRowIndex = firstDisplayedScrollingRowIndex;
            _celWasEndEdit = dgvEvaluar[e.ColumnIndex, e.RowIndex];
        }

        private void calcular(int asistencia, int actitud, int coop, decimal baseC, decimal valorExtra, int tardanza, DataGridViewCellEventArgs e)
        {
            decimal result = baseC * ((asistencia / 100m) * (pasistencia / 100m) + (actitud / 100m) * (pactitud / 100m) + (coop / 100m) * (pcoop / 100m));
            if (tardanza > 1)
            {
                dgvEvaluar.Rows[e.RowIndex].Cells["Extra (2)"].Value = DBNull.Value;
                valorExtra = 0;
            }
            dt.AcceptChanges();
            result = Math.Round(result, 2);
            dgvEvaluar.Rows[e.RowIndex].Cells["Logro (1)"].Value = result;
            dgvEvaluar.Rows[e.RowIndex].Cells["Bolsa"].Value = baseC - result;
            dgvEvaluar.Rows[e.RowIndex].Cells["Total Pago (1+2)"].Value = result + valorExtra;
            dt.AcceptChanges();
            object sumaBolsa = dt.Compute("SUM(Bolsa)", "");
            object sumaExtra = dt.Compute("SUM([Extra (2)])", "");
            object sumaLogrado = dt.Compute("SUM([Total Pago (1+2)])", "");
            decimal sumaBolsaDecimal = sumaBolsa == DBNull.Value ? 0 : Convert.ToDecimal(sumaBolsa);
            decimal sumaExtraDecimal = sumaExtra == DBNull.Value ? 0 : Convert.ToDecimal(sumaExtra);
            decimal sumaLogradoDecimal = sumaLogrado == DBNull.Value ? 0 : Convert.ToDecimal(sumaLogrado);

            Extra = sumaBolsaDecimal - sumaExtraDecimal;
            Extra = Extra < 0 ? 0 : Extra;
            txtExtra.Text = (Math.Truncate(Extra * 100) / 100).ToString();
            TLogrado = sumaLogradoDecimal;
            txtLogrado.Text = Math.Round(TLogrado, 2).ToString();
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
            using SAESoftContext db = new();
            Evaluacion ev2 = db.Evaluaciones.Include(d => d.Detalles).Where(b => !b.finalizado).FirstOrDefault();
            if (ev2 != null)
            {
                bool llenas = true;
                foreach (DataRow fila in dt.Rows)
                {
                    object valorTotal = fila["Total Pago (1+2)"];
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
                        using IDbContextTransaction transaction = db.Database.BeginTransaction();
                        try
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                bool estatus = Convert.ToBoolean(dr["esNuevo"]);
                                if (estatus)
                                {
                                    object valorCelda = dr["Extra (2)"];
                                    decimal valorExtra = valorCelda != DBNull.Value && valorCelda != null ? Convert.ToDecimal(valorCelda) : 0m;
                                    EvaluacionDetalle detalle = new()
                                    {
                                        IdEvaluacion = ev.IdEvaluacion,
                                        IdEmpleado = Convert.ToInt32(dr["IdEmpIncentivo"]),
                                        IdDepto = Convert.ToInt32(dr["IdDepto"]),
                                        BaseCalculo = Convert.ToDecimal(dr["Base"]),
                                        Asistencia = Convert.ToInt32(dr["Asistencia %"]),
                                        Actitud = Convert.ToInt32(dr["Desempeño %"]),
                                        Cooperacion = Convert.ToInt32(dr["Colaboración %"]),
                                        Extra = valorExtra,
                                        Total = Convert.ToDecimal(dr["Total Pago (1+2)"]),
                                        DiasProporcional = Convert.ToDecimal(dr["Días Proporcional"]),
                                        FechaCreacion = DatosServer.FechaServer(),
                                        IdUsuarioCreacion = usuarioLogged.IdUsuario
                                    };
                                    db.EvaluacionesDetalle.Add(detalle);
                                }
                                else
                                {
                                    int celda = Convert.ToInt32(dr["idEvaluacionDetalle"]);
                                    if (evaluacionModificar.Contains(celda))
                                    {
                                        EvaluacionDetalle detalle = db.EvaluacionesDetalle.First(b => b.IdEvaluacionDetalle == celda);
                                        db.Entry(detalle).State = EntityState.Modified;
                                        detalle.Actitud = Convert.ToInt32(dr["Desempeño %"]);
                                        detalle.Cooperacion = Convert.ToInt32(dr["Colaboración %"]);
                                        detalle.Extra = decimal.TryParse(dr["Extra (2)"]?.ToString(), out decimal ext) ? ext : 0.00m;
                                        detalle.Total = Convert.ToDecimal(dr["Total Pago (1+2)"]);
                                        detalle.DiasProporcional = Convert.ToDecimal(dr["Días Proporcional"]);
                                        detalle.FechaUltimaMod = DatosServer.FechaServer();
                                        detalle.IdUsuarioMod = usuarioLogged.IdUsuario;
                                        db.EvaluacionesDetalle.Update(detalle);
                                    }
                                }
                            }
                            db.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("Datos guardados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatos();
                            BloqueaSuspendidos();
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
                }
                else
                {
                    MessageBox.Show("Existen empleados sin evaluación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La Evaluación ya está cerrada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCalificacionDepto_Shown(object sender, EventArgs e)
        {
            CargarDatos();
            BloqueaSuspendidos();
        }

        private void dgvEvaluar_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla Tab
            if (e.KeyCode == Keys.Tab)
            {
                // Obtener la celda actualmente enfocada
                DataGridViewCell currentCell = dgvEvaluar.CurrentCell;

                // Buscar la próxima celda editable en la misma fila o en la siguiente fila si estamos en la última columna
                DataGridViewCell nextEditableCell = GetNextEditableCell(currentCell);

                // Si se encontró una celda editable, establecerla como la celda actual
                if (nextEditableCell != null)
                {
                    dgvEvaluar.CurrentCell = nextEditableCell;
                    e.Handled = true; // Indicar que hemos manejado el evento de teclado
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        // Método para obtener la próxima celda editable en la misma fila o en la siguiente fila si estamos en la última columna
        private DataGridViewCell GetNextEditableCell(DataGridViewCell currentCell)
        {
            int currentRowIndex = currentCell.RowIndex;
            int currentColumnIndex = currentCell.ColumnIndex;

            // Buscar la próxima celda editable en la misma fila
            for (int i = currentColumnIndex + 1; i < dgvEvaluar.Columns.Count; i++)
            {
                DataGridViewCell cell = dgvEvaluar.Rows[currentRowIndex].Cells[i];
                if (!cell.ReadOnly)
                {
                    return cell;
                }
            }

            // Si no se encontró una celda editable en la misma fila, buscar en la siguiente fila
            for (int i = currentRowIndex + 1; i < dgvEvaluar.Rows.Count; i++)
            {
                for (int j = 0; j < dgvEvaluar.Columns.Count; j++)
                {
                    DataGridViewCell cell = dgvEvaluar.Rows[i].Cells[j];
                    if (!cell.ReadOnly)
                    {
                        return cell;
                    }
                }
            }
            return null;
        }

        private void dgvEvaluar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEvaluar.Columns["Extra (2)"].Index)
            {
                ExtraAnterior = dgvEvaluar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as decimal? ?? 0m;
            }
        }

        private void dgvEvaluar_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            firstDisplayedScrollingRowIndex = dgvEvaluar.FirstDisplayedScrollingRowIndex;
        }

        private void dgvEvaluar_SelectionChanged(object sender, EventArgs e)
        {
            if (MouseButtons != 0) return;
            if (Keyboard.IsKeyDown(Key.Enter) && _celWasEndEdit != null && dgvEvaluar.CurrentCell != null)
            {
                dgvEvaluar.CurrentCell = dgvEvaluar[_celWasEndEdit.ColumnIndex, _celWasEndEdit.RowIndex + 1];
            }
            _celWasEndEdit = null;
        }
    }
}
