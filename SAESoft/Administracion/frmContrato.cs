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
    public partial class frmContrato : Form
    {
        public int empresa;
        public string numero;
        public Boolean existe = false;
        public frmContrato()
        {
            InitializeComponent();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            llenarNombres(cboEmpresa, "PLANTA");
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                var resp = MessageBox.Show("Ya existe un Contrato, ¿desea reemplazar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    empresa = Convert.ToInt32(cboEmpresa.SelectedValue);
                    numero = txtNumero.Text;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                empresa = Convert.ToInt32(cboEmpresa.SelectedValue);
                numero = txtNumero.Text;
            }

        }
    }
}
