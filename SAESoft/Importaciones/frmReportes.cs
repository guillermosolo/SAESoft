using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Importaciones
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void icbExcel_Click(object sender, EventArgs e)
        {
            frmExcel excel = new frmExcel();
            excel.ShowDialog();
        }
    }
}
