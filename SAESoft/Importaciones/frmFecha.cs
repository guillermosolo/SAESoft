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
        public string Obs;
        public frmFecha()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            fecha = dtpFecha.Value;
            Obs = txtObs.Text;
        }

        private void frmFecha_Load(object sender, EventArgs e)
        {
            dtpFecha.MinDate = fechaMin;
            dtpFecha.MaxDate = fecha;
        }
    }
}
