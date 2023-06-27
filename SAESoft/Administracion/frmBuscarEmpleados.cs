using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Administracion
{
    public partial class frmBuscarEmpleados : Form
    {
        public string codigo;
        public string nombreESP;
        public string nombreCOR;
        public frmBuscarEmpleados()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                codigo = txtCodigo.Text;
            }
            if (txtNombreESP.Text != "")
            {
                nombreESP = txtNombreESP.Text;
            }
            if (txtNombreCOR.Text != "")
            {
                nombreCOR = txtNombreCOR.Text;
            }
        }
    }
}
