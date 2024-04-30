﻿using System;
using System.IO;
using SpreadsheetLight;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Models.Incentivos;
using SAESoft.Models.AdministracionSistema;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Utilitarios;
using static SAESoft.Cache.UserData;

namespace SAESoft.Incentivo
{
    public partial class frmImportarAsistencia : Form
    {
        readonly DataTable dt = new();
        public frmImportarAsistencia()
        {
            InitializeComponent();
        }

        public void EstructuraGrid()
        {
            dt.Columns.Add("IdEmpIncentivo").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Codigo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Nombre Completo").DataType = Type.GetType("System.String");
            dt.Columns.Add("Tardanza").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Permiso").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Ausencia").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Porcentaje").DataType = Type.GetType("System.Int32");
            dgvAsistencia.DataSource = dt;
            dgvAsistencia.Columns["IdEmpIncentivo"].Visible = false;
            dgvAsistencia.Columns["Nombre Completo"].Width = 200;
        }

        private static bool VerifyExcel(string filePath)
        {
            // Crea un nuevo objeto SLDocument para cargar el archivo de Excel
            using SLDocument sl = new(filePath);
            // Verifica el contenido de las celdas en la fila 1
            if (sl.GetCellValueAsString(1, 1).Trim() != "CODIGO" ||
                sl.GetCellValueAsString(1, 2).Trim() != "TARDANZA" ||
                sl.GetCellValueAsString(1, 3).Trim() != "PERMISO" ||
                sl.GetCellValueAsString(1, 4).Trim() != "AUSENCIA")
            {
                // No se cumplen las condiciones, devuelve false
                return false;
            }

            // Se cumple la condición, devuelve true
            return true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Boolean errorImport = false;
            // Establece el filtro para que solo se muestren archivos de Excel
            openFileDialog1.Filter = "Archivos de Excel|*.xls;*.xlsx";
            try
            {

                // Muestra el cuadro de diálogo y espera a que el usuario seleccione un archivo
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado
                    string filePath = openFileDialog1.FileName;
                    if (VerifyExcel(filePath))
                    {
                        // Crea un nuevo objeto SLDocument para cargar el archivo de Excel
                        using SLDocument sl = new(filePath);
                        // Obtiene las filas y columnas del archivo de Excel
                        int rowCount = sl.GetWorksheetStatistics().EndRowIndex;
                        int colCount = sl.GetWorksheetStatistics().EndColumnIndex;
                        // Itera sobre las filas y columnas para leer los datos
                        using SAESoftContext db = new();
                        int tarde = db.EvaluacionAsistencia.Where(b => b.FechaFin == null).Where(b => b.Descripcion.Equals("TARDE")).Select(b => b.GradoPonderado).FirstOrDefault();
                        int permiso = db.EvaluacionAsistencia.Where(b => b.FechaFin == null).Where(b => b.Descripcion.Equals("PERMISO")).Select(b => b.GradoPonderado).FirstOrDefault();
                        int ausente = db.EvaluacionAsistencia.Where(b => b.FechaFin == null).Where(b => b.Descripcion.Equals("AUSENCIA")).Select(b => b.GradoPonderado).FirstOrDefault();
                        for (int row = 2; row <= rowCount; row++)
                        {

                            string codigo = sl.GetCellValueAsString(row, 1);
                            EmpIncentivos empleado = db.EmpIncentivos.FirstOrDefault(b => b.Codigo == codigo);
                            if (empleado != null)
                            {
                                int t = Convert.ToInt32(sl.GetCellValueAsString(row, 2));
                                int p = Convert.ToInt32(sl.GetCellValueAsString(row, 3));
                                int a = Convert.ToInt32(sl.GetCellValueAsString(row, 4));
                                DataRow dtrow = dt.NewRow();
                                dtrow["IdEmpIncentivo"] = empleado.IdEmpIncentivo;
                                dtrow["Codigo"] = empleado.Codigo;
                                dtrow["Nombre Completo"] = empleado.Nombres + " " + empleado.Apellidos;
                                dtrow["Tardanza"] = t;
                                dtrow["Permiso"] = p;
                                dtrow["Ausencia"] = a;
                                int suma = (t * tarde) + (p * permiso) + (a * ausente);
                                int puntaje = db.PuntajeAsistencia.Where(b => b.FechaFin == null).Where(b => suma >= b.Minimo && suma <= b.Maximo).Select(b => b.Porcentaje).FirstOrDefault();
                                dtrow["Porcentaje"] = puntaje;
                                dt.Rows.Add(dtrow);
                            }
                            else
                            {
                                MessageBox.Show($"El Código {codigo} no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                errorImport = true;
                                break;
                            }
                        }
                        if (!errorImport)
                        {
                            EstablecerNumerosEncabezado(dgvAsistencia);
                            icbGuardar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo de excel no cumple con el formato requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImportarAsistencia_Load(object sender, EventArgs e)
        {
            EstructuraGrid();
            dtpFin.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 15);
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 16);
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

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                errorProvider1.SetError(txtObservaciones, "No puede estar vacío.");
                txtObservaciones.Focus();
                return false;
            }
            return true;
        }

        private void icbGuardar_Click(object sender, EventArgs e)
        {
            using SAESoftContext db = new();
            Evaluacion abierto = db.Evaluaciones.Where(b => !b.finalizado).FirstOrDefault();
            if (abierto != null)
            {
                MessageBox.Show("Finalice la evaluación anterior, para crear una nueva", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    if (ValidarDatos())
                    {
                        Evaluacion evaluacion = new()
                        {
                            fechaInicio = dtpInicio.Value.Date,
                            fechaFin = dtpFin.Value.Date,
                            Observaciones = txtObservaciones.Text,
                            finalizado = false,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Evaluaciones.Add(evaluacion);
                        db.SaveChanges();
                        foreach (DataRow row in dt.Rows)
                        {
                            EmpIncentivos emp = db.EmpIncentivos.FirstOrDefault(b => b.IdEmpIncentivo == Convert.ToInt32(row["IdEmpIncentivo"]));
                            Asistencia asistencia = new()
                            {
                                IdEvaluacion = evaluacion.IdEvaluacion,
                                IdEmpleado = emp.IdEmpIncentivo,
                                Tardanza = Convert.ToInt32(row["Tardanza"]),
                                Permiso = Convert.ToInt32(row["Permiso"]),
                                Ausente = Convert.ToInt32(row["Ausencia"]),
                                Porcentaje = Convert.ToInt32(row["Porcentaje"]),
                                FechaCreacion = DatosServer.FechaServer(),
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            db.Asistencia.Add(asistencia);
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        icbGuardar.Enabled = false;
                        dt.Clear();
                        txtObservaciones.Text = "";
                        MessageBox.Show("Datos guardados correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
