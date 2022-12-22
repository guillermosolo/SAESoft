using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAESoft.AdministracionSistema
{
    public partial class frmBuscarRoles : Form
    {
        public frmBuscarRoles()
        {
            InitializeComponent();
        }
        public string? nombre = null;
        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
                nombre = txtNombres.Text;
        }
    }
}
