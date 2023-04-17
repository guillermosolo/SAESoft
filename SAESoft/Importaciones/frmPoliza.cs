using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Importaciones
{
    public partial class frmPoliza : Form
    {
        public Importacion rs;
        public List<Contenedor> contenedores;
        readonly DataTable dt = new();

        public frmPoliza(Importacion item)
        {
            InitializeComponent();
            rs = item;
        }

        private void frmPoliza_Load(object sender, EventArgs e)
        {
            cboBL.DataSource = rs.BL.ToList();
            cboBL.ValueMember = "IdBL";
            cboBL.DisplayMember = "Numero";
            llenarNombres(cboModalidad, "MODALIDAD");
            txtContenedores.Text = string.Join(",",contenedores.Select(x=> x.Furgon ?? x.Numero));
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("BL").DataType = Type.GetType("System.String");
            dt.Columns.Add("Póliza").DataType = Type.GetType("System.String");
            dt.Columns.Add("Modalidad").DataType = Type.GetType("System.String");
            dt.Columns.Add("idBL").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("idModalidad").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Observaciones").DataType = Type.GetType("System.String");
            dgvPoliza.DataSource = dt;
            dgvPoliza.Columns[0].Width = 200;
            dgvPoliza.Columns[1].Width = 200;
            dgvPoliza.Columns[2].Width = 150;
            dgvPoliza.Columns[3].Visible = false;
            dgvPoliza.Columns[4].Visible = false;
            dgvPoliza.Columns[5].Width = 250;
            dgvPoliza.ClearSelection();
        }

        private void frmPoliza_Shown(object sender, EventArgs e)
        {
            estructuraGrid();
            txtPoliza.Focus();
        }

        private void icbAgregar_Click(object sender, EventArgs e)
        {
            if (txtPoliza.Text == "")
            {
                MessageBox.Show("El número de póliza no puede estar en blanco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPoliza.Focus();
                return;
            }
            if (!txtPoliza.Text.StartsWith(rs.IdAgente.ToString()))
            {
                MessageBox.Show("El número de póliza no coincide con el Agente Autorizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPoliza.Focus();
                return;
            }
            DataRow row = dt.NewRow();
            row[0] = cboBL.Text;
            row[1] = txtPoliza.Text;
            row[2] = cboModalidad.Text;
            row[3] = cboBL.SelectedValue;
            row[4] = cboModalidad.SelectedValue;
            row[5] = txtObservaciones.Text;
            dt.Rows.Add(row);
            txtPoliza.Text = "";
            txtObservaciones.Text = "";
            txtPoliza.Focus();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (BL item in cboBL.Items)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (item.IdBL == Convert.ToInt32(row[3]))
                    {
                        i++;
                        break;
                    }
                }
            }
            if (i >= cboBL.Items.Count)
            {
                using (SAESoftContext db = new())
                {
                    using var transaction = db.Database.BeginTransaction();
                    try
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            Poliza pol = new()
                            {
                                IdBL = Convert.ToInt32(row[3]),
                                Numero = Convert.ToString(row[1]),
                                IdModalidad = Convert.ToInt32(row[4]),
                                Observaciones = row[5].ToString(),
                                FechaCreacion = DatosServer.FechaServer(),
                                IdUsuarioCreacion = usuarioLogged.IdUsuario,
                            };
                            db.Add(pol);
                            db.SaveChanges();
                        }
                        db.Entry(rs).State = EntityState.Modified;
                        var status = db.ImportStatus.Where(s => s.Via == 'M' && s.orden > rs.ImportStatus.orden).OrderBy(s => s.orden).FirstOrDefault();
                        rs.IdImportStatus = status.IdImportStatus;
                        db.SaveChanges();
                        ImportHistorial ih = new() { IdImport = rs.IdImport, IdImportStatus = status.IdImportStatus, FechaCreacion = DatosServer.FechaServer(), IdUsuarioCreacion = usuarioLogged.IdUsuario };
                        db.ImportHistorial.Add(ih);
                        rs.ImportHistorial.Add(ih);
                        db.SaveChanges();
                        transaction.Commit();
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
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Existen BL que no tienen asignada Póliza de Importación,\r\npor favor verifíque", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
