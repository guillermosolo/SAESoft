using SAESoft.Models;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.Constantes;

namespace SAESoft.Administracion
{
    public partial class frmSubirDocumento : Form
    {
        Boolean llenando = false;
        string path = PATH_Doc;
        public string codigo;
        public frmSubirDocumento()
        {
            InitializeComponent();
        }

        private void cargarCombos()
        {
            llenando = true;
            SAESoftContext db = new();
            cboDocumento.DataSource = db.TiposDocumento.Where(i => i.activo && i.mostrar).Select(d => new { d.IdTipoDocumento, d.Nombre }).OrderBy(i => i.Nombre).ToList();
            cboDocumento.DisplayMember = "Nombre";
            cboDocumento.ValueMember = "IdTipoDocumento";
            llenarNombres(cboTipo, "REPRESENTACION");
            llenarNombres(cboEmpresa, "PLANTA");
            llenando = false;
        }
        private void frmSubirDocumento_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label5.Text = FormatFileName(openFileDialog1.FileName);
            }
        }

        private void cboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!llenando)
            {
                if (Convert.ToInt32(cboDocumento.SelectedValue) == 9)
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    cboTipo.Visible = true;
                    cboEmpresa.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    cboTipo.Visible = false;
                    cboEmpresa.Visible = false;
                }
            }
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("Debe de seleccionar un Archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre;
            if (Convert.ToInt32(cboDocumento.SelectedValue) == 9)
            {
                nombre = cboTipo.Text + "-" + cboEmpresa.Text + ".pdf";
            }
            else
            {
                nombre = cboDocumento.Text + ".pdf";
            }
            try
            {
                path = PATH_Doc + @"\" + codigo;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string fileName = openFileDialog1.FileName;
                string fullPath = path + @"\" + nombre;
                if (File.Exists(fullPath))
                {
                    var result = MessageBox.Show("Ya existe un documento guardado,\n ¿Desea sobreescribir?","Pregunta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                } 
                File.Copy(fileName, fullPath,true);
                this.DialogResult = DialogResult.OK;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
