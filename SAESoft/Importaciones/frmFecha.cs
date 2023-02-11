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
    public partial class frmFecha : Form
    {
        public DateTime fechaMin;
        public DateTime fecha = DateTime.Now;
        public frmFecha()
        {
            InitializeComponent();
            dtpFecha.MinDate = fecha;
            dtpFecha.MaxDate = fecha;
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            fecha = dtpFecha.Value;
        }
    }
}
