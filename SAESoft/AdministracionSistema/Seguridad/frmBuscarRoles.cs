
namespace SAESoft.AdministracionSistema.Seguridad
{
    public partial class frmBuscarRoles : Form
    {
        public frmBuscarRoles()
        {
            InitializeComponent();
        }
        public string? nombre = null;
        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
                nombre = txtNombres.Text;
        }
    }
}
