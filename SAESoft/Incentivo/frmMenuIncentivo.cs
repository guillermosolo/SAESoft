using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;

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
            if (Application.OpenForms["frmCalificacionDepto"] == null)
                ibtnPersonal.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmImportarAsistencia"] == null)
                ibtnPersonal.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmCerrar"] == null)
                ibtnCerrar.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmReportes"] == null)
                ibtnCerrar.BackColor = Color.FromArgb(0, 122, 204);
        }
        private void habilitarMenu()
        {
            ibtnDashboard.Enabled = hasPermission("VER.DASHBOARDINCENTIVO");
            ibtnPersonal.Enabled = hasPermission("VER.EMPLEADOSINCENTIVO");
            ibtnAsistencia.Enabled = hasPermission("VER.ASISTENCIA");
            ibtnEvaluar.Enabled = hasPermission("VER.EVALUACION");
            ibtnSuspension.Enabled = hasPermission("VER.SUSPENSION");
            ibtnCerrar.Enabled = hasPermission("VER.CERRAR");
            ibtnReporte.Enabled = hasPermission("VER.REPORTES");
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

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            Abrir<frmSuspensiones>(panelFormularios);
            menuActivo(ibtnSuspension, panelMenu);
        }

        private void iconButton2_Click_2(object sender, EventArgs e)
        {
            Abrir<frmCerrar>(panelFormularios);
            menuActivo(ibtnCerrar, panelMenu);
        }

        private void ibtnReporte_Click(object sender, EventArgs e)
        {
            Abrir<frmReportes>(panelFormularios);
            menuActivo(ibtnReporte, panelMenu);
        }

        private void ibtnDeptos_Click(object sender, EventArgs e)
        {
            Abrir<FrmDeptoIncentivo>(panelFormularios);
            menuActivo(ibtnDeptos, panelMenu);
        }
    }
}
