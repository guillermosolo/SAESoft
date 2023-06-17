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
    public partial class frmResidencia : Form
    {
        public int tipo;
        public string resolucion;
        public Boolean existe = false;
        public DateTime vencimiento;
        public frmResidencia()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                var resp = MessageBox.Show("Ya existe una Residencia, ¿desea reemplazar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    tipo = Convert.ToInt32(cboTipo.SelectedValue);
                    resolucion = txtResolucion.Text;
                    vencimiento = dtpVencimiento.Value.Date;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                tipo = Convert.ToInt32(cboTipo.SelectedValue);
                resolucion = txtResolucion.Text;
                vencimiento = dtpVencimiento.Value.Date;
            }
        }

        private void frmResidencia_Load(object sender, EventArgs e)
        {
            llenarNombres(cboTipo, "RESIDENCIA");
        }
    }
}
