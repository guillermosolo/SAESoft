using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using FontAwesome.Sharp;

namespace SAESoft.AdministracionSistema
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnUsuarios_Click(object sender, EventArgs e)
        {
            Abrir<frmUsuarios>(panelFormularios);
            menuActivo(ibtnUsuarios, panelMenu);
        }

        private void ibtnRoles_Click(object sender, EventArgs e)
        {
            Abrir<frmRoles>(panelFormularios);
            menuActivo(ibtnRoles, panelMenu);
        }

        private void ibtnRolPermiso_Click(object sender, EventArgs e)
        {
            Abrir<frmPermisos>(panelFormularios);
            menuActivo(ibtnPermisos, panelMenu);
        }

        private void CloseForms(object? sender, ControlEventArgs e) {
            if (Application.OpenForms["frmUsuario"]==null)
                ibtnUsuarios.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmPermisosRoles"] == null)
                ibtnPermisos.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmRoles"] == null)
                ibtnRoles.BackColor = Color.FromArgb(0, 122, 204);

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            habilitarMenu();
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms);
        }

        private void ibtnModulos_Click(object sender, EventArgs e)
        {
            Abrir<frmModulos>(panelFormularios);
            menuActivo(ibtnModulos, panelMenu);
        }

        private void habilitarMenu()
        {
            ibtnUsuarios.Enabled = hasPermission("VER.USUARIOS");
            ibtnPermisos.Enabled = hasPermission("VER.PERMISOS");
            ibtnModulos.Enabled = hasPermission("VER.MODULOS");
            ibtnRoles.Enabled = hasPermission("VER.ROLES");
        }

        private void ibtnUsuarios_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnRoles_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnPermisos_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnModulos_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }
    }
}
