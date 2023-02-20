using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;

namespace SAESoft.Importaciones
{
    public partial class frmMenuImportaciones : Form
    {
        public frmMenuImportaciones()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuImportaciones_Load(object sender, EventArgs e)
        {
            habilitarMenu();
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms); 
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            Abrir<frmDashboard>(panelFormularios);
            menuActivo(ibtnDashboard, panelMenu);
        }

        private void habilitarMenu()
        {
            ibtnDashboard.Enabled = hasPermission("VER.DASHBOARD");
            ibtnMaritimo.Enabled = hasPermission("VER.MARITIMO");
            ibtnAereo.Enabled = hasPermission("VER.AEREO");
        }

        private void CloseForms(object? sender, ControlEventArgs e)
        {
            if (Application.OpenForms["frmDashboard"] == null)
                ibtnDashboard.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmMaritimo"] == null)
                ibtnMaritimo.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmAereo"] == null)
                ibtnAereo.BackColor = Color.FromArgb(0, 122, 204);

        }
        private void ibtnDashboard_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnMaritimo_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnAereo_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnMaritimo_Click(object sender, EventArgs e)
        {
            Abrir<frmMaritimo>(panelFormularios);
            menuActivo(ibtnMaritimo, panelMenu);
        }

        private void ibtnAereo_Click(object sender, EventArgs e)
        {
            Abrir<frmAereo>(panelFormularios);
            menuActivo(ibtnAereo, panelMenu);
        }

        private void icbReporte_Click(object sender, EventArgs e)
        {
            Abrir<frmReportes>(panelFormularios);
            menuActivo(ibtnReporte, panelMenu);
        }
    }
}
