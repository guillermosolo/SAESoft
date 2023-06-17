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
    public partial class frmPermisoTrabajo : Form
    {
        public int tipo;
        public string resolucion;
        public Boolean existe = false;
        public DateTime inicio;
        public DateTime vencimiento;
        public frmPermisoTrabajo()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                var resp = MessageBox.Show("Ya existe un Permiso, ¿desea reemplazar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    tipo = Convert.ToInt32(cboTipo.SelectedValue);
                    resolucion = txtResolucion.Text;
                    inicio = dtpInicio.Value.Date;
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
            llenarNombres(cboTipo, "PERMISO TRABAJO");
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Value = dtpInicio.Value.AddYears(1);
        }
    }
}
