using static SAESoft.Utilitarios.ControlFormularios;

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
            Abrir<frmPermisosRoles>(panelFormularios);
            menuActivo(ibtnRolPermiso, panelMenu);
        }

        private void CloseForms(object? sender, ControlEventArgs e) {
            if (Application.OpenForms["frmUsuario"]==null)
                ibtnUsuarios.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmPermisosRoles"] == null)
                ibtnRolPermiso.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmRoles"] == null)
                ibtnRoles.BackColor = Color.FromArgb(0, 122, 204);

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms);
        }
    }
}
