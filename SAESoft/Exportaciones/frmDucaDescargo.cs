using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Models;
using SAESoft.Models.Comunes;
using SAESoft.Models.Exportaciones;
using SAESoft.Utilitarios;
using System.Data;
using System.Windows.Forms;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;

namespace SAESoft.Exportaciones
{
    public partial class frmDucaDescargo : Form
    {
        public int ducaAnterior = 0;
        public int licencia = 0;
        public frmDucaDescargo()
        {
            InitializeComponent();
        }

        private void frmDucaDescargo_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarDucas();
        }

        private void cargarCombo()
        {
            using SAESoftContext db = new();
            var tipos = db.Nombres.Where(n => n.IdGrupo == 19).ToList();
            List<Nombre> tiposFiltrados = [];
            if (ducaAnterior == 0)
            {
                tiposFiltrados = tipos.Where(n => n.Descripcion.Contains("10") || n.Descripcion.Contains("11")).ToList();
            }
            else if (ducaAnterior == 10 || ducaAnterior == 37)
            {
                tiposFiltrados = tipos.Where(n => n.Descripcion.Contains("DESCARGO") || n.Descripcion.Contains("36")).ToList();
            }
            else if (ducaAnterior == 11)
            {
                tiposFiltrados = tipos.Where(n => n.Descripcion.Contains("37")).ToList();
            }
            else
            {
                tiposFiltrados = tipos.Where(n => n.Descripcion == "DESCARGO").ToList();
            }
            cboTipoDoc.DataSource = tiposFiltrados;
            cboTipoDoc.DisplayMember = "Descripcion";
            cboTipoDoc.ValueMember = "IdNombre";
        }

        private void cargarDucas()
        {
            using SAESoftContext db = new();
            var lic = db.Licencias.Include(d => d.Ducas).FirstOrDefault(l => l.IdLicencia == licencia);
            var ducas = lic.Ducas.ToList();
            cboDucas.DataSource = ducas;
            cboDucas.DisplayMember = "NumDuca";
            cboDucas.ValueMember = "IdDuca";
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDoc.Text.Contains("36") || cboTipoDoc.Text.Contains("37"))
            {
                lblDUCA.Visible = true;
                cboDucas.Visible = true;
            }
            else
            {
                lblDUCA.Visible = false;
                cboDucas.Visible = false;
            }
        }

        private Boolean validarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "No puede estar vacío.");
                txtNumero.Focus();
                return false;
            }
            if (cboDucas.Items.Count == 0 && cboDucas.Visible)
            {
                errorProvider1.SetError(cboDucas, "No puede estar vacío.");
                cboDucas.Focus();
                return false;
            }
            return true;
        }
        private void ibtnFacturas_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                using SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                try
                {
                    var lic = db.Licencias.FirstOrDefault(l => l.IdLicencia == licencia);
                    string path = PATH_Export;
                    if (cboTipoDoc.Text.Contains("DUCA"))
                    {
                        var duca = new Duca()
                        {
                            IdTipoDuca = Convert.ToInt32(cboTipoDoc.SelectedValue),
                            NumDuca = txtNumero.Text,
                            Fecha = dtpFecha.Value.Date,
                            IdLicencia = lic.IdLicencia,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        };
                        if (cboTipoDoc.Text.Contains("36") || cboTipoDoc.Text.Contains("37"))
                        {
                            duca.IdDucaRef = Convert.ToInt32(cboDucas.SelectedValue);
                        }
                        db.Ducas.Add(duca);

                    }
                    else if (cboTipoDoc.Text.Contains("DESCARGO"))
                    {
                        Boolean final = true;
                        if (cboTipoDoc.Text.Contains("MANUAL"))
                        {
                            final = false;
                        }
                        var descargo = new Descargo()
                        {
                            NumDescargo = txtNumero.Text,
                            Fecha = dtpFecha.Value.Date,
                            IdLicencia = lic.IdLicencia,
                            final = final,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        };
                        db.Descargos.Add(descargo);
                    }

                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        return;
                    }
                    db.SaveChanges();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        path += @"\" + lic.Codigo.ToString();
                        string archivoDestino = Path.Combine(path, Path.GetFileName(openFileDialog1.FileName));
                        using FileStream sourceStream = new(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        using FileStream destinationStream = new(archivoDestino, FileMode.Create, FileAccess.Write);
                        sourceStream.CopyTo(destinationStream);
                    }
                    else
                    {
                        return;
                    }

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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
