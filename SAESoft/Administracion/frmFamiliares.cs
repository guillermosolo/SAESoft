using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmFamiliares : Form
    {
        public int parentesco;
        public string nombres;
        public string apellidos;
        public DateTime fecnac;
        public string genero;
        public frmFamiliares()
        {
            InitializeComponent();
        }

        private void frmFamiliares_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        public void llenarCombos()
        {
            llenarNombres(cboParentesco, "PARENTESCO");
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                parentesco = Convert.ToInt32(cboParentesco.SelectedValue);
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                fecnac = dtpFechaNac.Value.Date;
                if (rdbMasculino.Checked)
                    genero = "M";
                else
                    genero = "F";
            }
            else
            {
                return;
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "No puede estar vacío.");
                txtNombres.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "No puede estar vacío.");
                txtApellidos.Focus();
                return false;
            }
            return true;
        }
    }
}
