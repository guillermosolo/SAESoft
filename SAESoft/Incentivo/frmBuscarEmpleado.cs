using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Incentivo
{
    public partial class frmBuscarEmpleado : Form
    {
        public string? codigo = null;
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
                codigo = txtCodigo.Text;
        }
    }
}
