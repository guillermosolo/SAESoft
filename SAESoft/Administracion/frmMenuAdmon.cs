using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;

namespace SAESoft.Administracion
{
    public partial class frmMenuAdmon : Form
    {
        public frmMenuAdmon()
        {
            InitializeComponent();
        }

        private void ibtnPersonal_Click(object sender, EventArgs e)
        {
            Abrir<frmPersonal>(panelFormularios);
            menuActivo(ibtnPersonal, panelMenu);
        }

        private void habilitarMenu()
        {
            ibtnDashboard.Enabled = hasPermission("VER.DASHBOARDADMIN");
            ibtnPersonal.Enabled = hasPermission("VER.PERSONAL");
            ibtnReporte.Enabled = hasPermission("VER.REPORTESADMIN");
        }

        private void frmMenuAdmon_Load(object sender, EventArgs e)
        {
            habilitarMenu();
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnReporte_Click(object sender, EventArgs e)
        {
            Abrir<frmReportes>(panelFormularios);
            menuActivo(ibtnReporte, panelMenu);
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            Abrir<frmDashboard>(panelFormularios);
            menuActivo(ibtnDashboard, panelMenu);
        }

        private void icbReclamos_Click(object sender, EventArgs e)
        {
            Abrir<frmDashboardClaims>(panelFormularios);
            menuActivo(ibtnDashboard, panelMenu);
        }
    }
}
