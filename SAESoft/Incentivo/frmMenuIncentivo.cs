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
using static SAESoft.Cache.UserData;
using SAESoft.Exportaciones;

namespace SAESoft.Incentivo
{
    public partial class frmMenuIncentivo : Form
    {
        public frmMenuIncentivo()
        {
            InitializeComponent();
        }

        private void frmMenuIncentivo_Load(object sender, EventArgs e)
        {
            habilitarMenu();
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms);
        }

        private void CloseForms(object? sender, ControlEventArgs e)
        {
            if (Application.OpenForms["frmDashboardIn"] == null)
                ibtnDashboard.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmEmpIncentivo"] == null)
                ibtnPersonal.BackColor = Color.FromArgb(0, 122, 204);
        }
        private void habilitarMenu()
        {
            ibtnDashboard.Enabled = hasPermission("VER.DASHBOARDINCENTIVO");
            ibtnPersonal.Enabled = hasPermission("VER.EMPLEADOSINCENTIVO");
            ibtnAsistencia.Enabled = hasPermission("VER.ASISTENCIA");
            ibtnEvaluar.Enabled = hasPermission("VER.EVALUACION");
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnPersonal_Click(object sender, EventArgs e)
        {
            Abrir<frmEmpIncentivo>(panelFormularios);
            menuActivo(ibtnPersonal, panelMenu);
        }

        private void ibtnAsistencia_Click(object sender, EventArgs e)
        {
            Abrir<frmImportarAsistencia>(panelFormularios);
            menuActivo(ibtnAsistencia, panelMenu);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Abrir<frmCalificacionDepto>(panelFormularios);
            menuActivo(ibtnEvaluar, panelMenu);
        }
    }
}
