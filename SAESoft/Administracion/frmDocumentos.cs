﻿using SAESoft.Models;
using static SAESoft.Utilitarios.Validaciones;

namespace SAESoft.Administracion
{
    public partial class frmDocumentos : Form
    {
        public string documento;
        public int id;
        public string numero;
        public DateTime emision;
        public Boolean novence;
        public DateTime vencimiento;
        public int familiar;
        public int idEmpleado;
        private static readonly int[] docs = [1, 2, 5, 11];

        public frmDocumentos()
        {
            InitializeComponent();
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = documento;
            if (docs.Contains(id))
            {
                llenarCombo();
                label3.Visible = true;
                cboFamiliar.Visible = true;
            }
            else
            {
                cboFamiliar.Items.Clear();
                cboFamiliar.Items.Add(new { IdFamiliar = 0, NombreCompleto = "(NINGUNO)" });
                cboFamiliar.DisplayMember = "NombreCompleto";
                cboFamiliar.ValueMember = "IdFamiliar";
                cboFamiliar.SelectedIndex = 0;
                label3.Visible = false;
                cboFamiliar.Visible = false;
            }
        }

        private void llenarCombo()
        {
            using SAESoftContext db = new();
            var listado = db.Familiares.Where(f => f.IdEmpleado == idEmpleado).OrderBy(f => f.Nombres).Select(f => new { f.IdFamiliar, f.NombreCompleto }).ToList();
            listado.Insert(0, new { IdFamiliar = 0, NombreCompleto = "(NINGUNO)" });
            cboFamiliar.DataSource = listado;
            cboFamiliar.DisplayMember = "NombreCompleto";
            cboFamiliar.ValueMember = "IdFamiliar";
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

        private void lblTitulo_TextChanged(object sender, EventArgs e)
        {
            int tamañoFuente = CalcularTamañoFuente(lblTitulo.Text);
            lblTitulo.Font = new Font(lblTitulo.Font.FontFamily, tamañoFuente);
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                familiar = Convert.ToInt32(cboFamiliar.SelectedValue);
                numero = txtNumero.Text;
                emision = dtpEmision.Value.Date;
                novence = !chkVence.Checked;
                vencimiento = dtpVencimiento.Value.Date;
                errorProvider1.Clear();
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private Boolean ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "No puede estar vacío.");
                txtNumero.Focus();
                return false;
            }
            if (documento == "NUMERO DE IDENTIFICACIÓN TRIBUTARIA" && !NIT_validation(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "El número de NIT no es válido.");
                txtNumero.Focus();
                return false;
            }
            if (documento == "DOCUMENTO PERSONAL DE IDENTIFICACIÓN" && !CUI_validation(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "El número de CUI no es válido.");
                txtNumero.Focus();
                return false;
            }
            return true;
        }

        private void chkVence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVence.Checked)
            {
                dtpVencimiento.Enabled = true;
            }
            else
            {
                dtpVencimiento.Enabled = false;
            }
        }

        private void frmDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }
    }
}
