
using SAESoft.Models;
using SAESoft.Models.Administracion;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.Validaciones;
using static SAESoft.Cache.UserData;

namespace SAESoft.Administracion
{
    public partial class frmNombramientos : Form
    {
        public int IdEmpleado;
        public readonly DataTable dtNom = new();
        public ICollection<Nombramiento> nombramientos;
        public frmNombramientos()
        {
            InitializeComponent();
            estructuraGrid();
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            dtpEmision.MaxDate = DateTime.Today;
            dtpVencimiento.MinDate = DateTime.Today;
            dataGridView1.Columns[0].Visible = false;
            lblTitulo.Text = "REPRESENTACION LEGAL";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarNombres(cboTipo, "REPRESENTACION");
            llenarNombres(cboEmpresa, "PLANTA");
            llenarGrid();
        }

        private void llenarGrid()
        {
            DataRow row;
            dtNom.Clear();
            foreach (var nomb in nombramientos)
            {
                row = dtNom.NewRow();
                row[0] = nomb.IdNombramiento;
                row[1] = nomb.Cancelado;
                row[2] = nomb.Empresa.Descripcion;
                row[3] = nomb.Tipo.Descripcion;
                row[4] = nomb.Libro.ToString() + " / " + nomb.Folio.ToString() + " / " + nomb.Registro.ToString();
                row[5] = nomb.Expediente;
                row[6] = nomb.Vencimiento.Date;
                dtNom.Rows.Add(row);
            }
        }

        private void estructuraGrid()
        {
            dtNom.Columns.Add("IdNombramiento").DataType = Type.GetType("System.Int32");
            dtNom.Columns.Add("Cancelado").DataType = Type.GetType("System.Boolean");
            dtNom.Columns.Add("Empresa").DataType = Type.GetType("System.String");
            dtNom.Columns.Add("Tipo").DataType = Type.GetType("System.String");
            dtNom.Columns.Add("Libro / Folio / Registro").DataType = Type.GetType("System.String");
            dtNom.Columns.Add("Expediente").DataType = Type.GetType("System.String");
            dtNom.Columns.Add("Vencimiento").DataType = Type.GetType("System.DateTime");

            dataGridView1.DataSource = dtNom;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.ClearSelection();

            for (int i = 2; i <= 6; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private static int CalcularTamañoFuente(string texto)
        {
            int tamañoBase = 20; // Tamaño de fuente base
            int longitudTexto = texto.Length;
            int tamañoFuente = tamañoBase;

            if (longitudTexto > 15)
            {
                tamañoFuente = tamañoBase - ((longitudTexto - 15) * 2); // Reducir el tamaño de fuente en función de la longitud del texto
                if (tamañoFuente < 10) // Limitar el tamaño de fuente mínimo
                {
                    tamañoFuente = 10;
                }
            }

            return tamañoFuente;
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                using SAESoftContext db = new();
                Nombramiento nom = new()
                {
                    IdEmpleado = IdEmpleado,
                    IdEmpresa = Convert.ToInt32(cboEmpresa.SelectedValue),
                    IdTipo = Convert.ToInt32(cboTipo.SelectedValue),
                    Registro = txtRegistro.Text,
                    Folio = txtFolio.Text,
                    Libro = txtLibro.Text,
                    Expediente = txtExpediente.Text,
                    Inscripcion = dtpEmision.Value.Date,
                    Vencimiento = dtpVencimiento.Value.Date,
                    Cancelado = false,
                    FechaCreacion = DatosServer.FechaServer(),
                    IdUsuarioCreacion = usuarioLogged.IdUsuario,
                };
                db.Nombramientos.Add(nom);
                db.SaveChanges();
                nom.Tipo = db.Nombres.FirstOrDefault(t => t.IdNombre == nom.IdTipo);
                nom.Empresa = db.Nombres.FirstOrDefault(t => t.IdNombre == nom.IdEmpresa);
                nombramientos.Add(nom);
                llenarGrid();
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtRegistro.Text))
            {
                errorProvider1.SetError(txtRegistro, "No puede estar vacío.");
                txtRegistro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtFolio.Text))
            {
                errorProvider1.SetError(txtFolio, "No puede estar vacío.");
                txtFolio.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLibro.Text))
            {
                errorProvider1.SetError(txtLibro, "No puede estar vacío.");
                txtLibro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtExpediente.Text))
            {
                errorProvider1.SetError(txtExpediente, "No puede estar vacío.");
                txtExpediente.Focus();
                return false;
            }
            if (dtpEmision.Value.Date >= dtpVencimiento.Value.Date)
            {
                errorProvider1.SetError(dtpVencimiento, "No puede ser menor o igual a la fecha de inscripción.");
                dtpVencimiento.Focus();
                return false;
            }
            return true;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                bool currentValue = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (currentValue == true)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
            {
                try
                {
                    using SAESoftContext db = new();
                    var nomb = db.Nombramientos.Find(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    nomb.Cancelado = true;
                    nomb.Cancelacion = DatosServer.FechaServer();
                    db.Update(nomb);
                    db.SaveChanges();
                    nombramientos.FirstOrDefault(n => n.IdNombramiento == nomb.IdNombramiento).Cancelado = nomb.Cancelado;
                    nombramientos.FirstOrDefault(n => n.IdNombramiento == nomb.IdNombramiento).Cancelacion = nomb.Cancelacion;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enteros(e.KeyChar);
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enteros(e.KeyChar);
        }

        private void txtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = enteros(e.KeyChar);
        }

        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numerosGuion(e.KeyChar);
        }
    }
}
