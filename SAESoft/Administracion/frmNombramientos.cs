using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmNombramientos : Form
    {
        public string numero;
        public DateTime emision;
        public Boolean novence;
        public DateTime vencimiento;
        public frmNombramientos()
        {
            InitializeComponent();
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Representación Legal";
            llenarNombres(cboTipo, "REPRESENTACION");
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
            lblTitulo.Font = new Font(label1.Font.FontFamily, tamañoFuente);
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            numero = cboTipo.Text;
            emision = dtpEmision.Value.Date;
            novence = !chkVence.Checked;
            vencimiento = dtpVencimiento.Value.Date;
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
    }
}
