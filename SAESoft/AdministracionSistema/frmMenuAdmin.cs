using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using FontAwesome.Sharp;
using SAESoft.AdministracionSistema.Comunes;
using SAESoft.AdministracionSistema.Seguridad;
using SAESoft.AdministracionSistema.Importaciones;

namespace SAESoft.AdministracionSistema
{
    public partial class frmMenuAdmin : Form
    {
        private Boolean showPanelSeguridad = false;
        private Boolean showPanelComunes = false;
        private Boolean showPanelImportaciones = false;
        public frmMenuAdmin()
        {
            InitializeComponent();
            togglePanels();
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

        private void CloseForms(object? sender, ControlEventArgs e)
        {
            if (Application.OpenForms["frmUsuario"] == null)
                ibtnUsuarios.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmPermisosRoles"] == null)
                ibtnPermisos.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmRoles"] == null)
                ibtnRoles.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmModulos"] == null)
                ibtnModulos.BackColor = Color.FromArgb(0, 122, 204);
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
            ibtnNombres.Enabled = hasPermission("VER.NOMBRES");
            ibtnGrupos.Enabled = hasPermission("VER.GRUPOS");
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

        private void ibtnNombres_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnGrupos_EnabledChanged(object sender, EventArgs e)
        {
            cambiarColorIcono(sender);
        }

        private void ibtnSeguridad_Click(object sender, EventArgs e)
        {
            showPanelSeguridad = !showPanelSeguridad;
            showPanelComunes = false;
            showPanelImportaciones = false;
            togglePanels();
        }

        private void togglePanels()
        {
            if (showPanelSeguridad)
            {
                panelSeguridad.Height = 133;
                ibtnSeguridad.IconChar = IconChar.ChevronUp;
            }
            else
            {
                panelSeguridad.Height = 0;
                ibtnSeguridad.IconChar = IconChar.ChevronDown;
            }
            if (showPanelComunes)
            {
                panelComunes.Height = 71;
                ibtnComunes.IconChar = IconChar.ChevronUp;
            }
            else
            {
                panelComunes.Height = 0;
                ibtnComunes.IconChar = IconChar.ChevronDown;
            }
            if (showPanelImportaciones)
            {
                panelImportaciones.Height = 154;
                ibtnImportaciones.IconChar = IconChar.ChevronUp;
            }
            else
            {
                panelImportaciones.Height = 0;
                ibtnImportaciones.IconChar = IconChar.ChevronDown;
            }
        }

        private void ibtnComunes_Click(object sender, EventArgs e)
        {
            showPanelComunes = !showPanelComunes;
            showPanelSeguridad = false;
            showPanelImportaciones = false;
            togglePanels();
        }

        private void ibtnNombres_Click(object sender, EventArgs e)
        {
            Abrir<frmNombres>(panelFormularios);
            menuActivo(ibtnNombres, panelMenu);
        }

        private void ibtnGrupos_Click(object sender, EventArgs e)
        {
            Abrir<frmGrupos>(panelFormularios);
            menuActivo(ibtnGrupos, panelMenu);
        }

        private void ibtnImportaciones_Click(object sender, EventArgs e)
        {
            showPanelImportaciones = !showPanelImportaciones;
            showPanelSeguridad = false;
            showPanelComunes = false;
            togglePanels();
        }

        private void ibtnRevisiones_Click(object sender, EventArgs e)
        {
            Abrir<frmRevisiones>(panelFormularios);
            menuActivo(ibtnRevisiones, panelMenu);
        }

        private void ibtnShippers_Click(object sender, EventArgs e)
        {
            Abrir<frmShippers>(panelFormularios);
            menuActivo(ibtnShippers, panelMenu);
        }

        private void ibtnAduanas_Click(object sender, EventArgs e)
        {
            Abrir<frmAduanas>(panelFormularios);
            menuActivo(ibtnAduanas, panelMenu);
        }

        private void ibtnTerminales_Click(object sender, EventArgs e)
        {
            Abrir<frmTerminales>(panelFormularios);
            menuActivo(ibtnTerminales, panelMenu);
        }

        private void ibtnAgentes_Click(object sender, EventArgs e)
        {
            Abrir<frmAgentes>(panelFormularios);
            menuActivo(ibtnAgentes, panelMenu);
        }
    }
}
