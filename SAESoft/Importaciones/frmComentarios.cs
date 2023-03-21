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
    public partial class frmComentarios : Form
    {
        public string Obs;
        public frmComentarios()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            Obs = txtObs.Text;
        }
    }
}
