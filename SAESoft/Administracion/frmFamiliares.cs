using SAESoft.Models.Administracion;
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
            lblTitulo.Text = "FAMILIARES";
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
            llenarCombos();
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
                this.DialogResult = DialogResult.Abort;
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
