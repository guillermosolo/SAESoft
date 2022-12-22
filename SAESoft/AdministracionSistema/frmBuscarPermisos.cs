
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;

namespace SAESoft.AdministracionSistema
{
    public partial class frmBuscarPermisos : Form
    {
        public frmBuscarPermisos()
        {
            InitializeComponent();
        }
        public string? nombre = null;
        public int modulo = -1;

        private void frmBuscarPermisos_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }
        private void llenarCombos()
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                cboModulos.DataSource = _Contexto.Modulos.ToList();
                cboModulos.DisplayMember = "Nombre";
                cboModulos.ValueMember = "IdModulo";
                cboModulos.SelectedIndex = -1;
            }
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (cboModulos.SelectedIndex > -1)
                modulo = Convert.ToInt32(cboModulos.SelectedValue);
        }
    }
}
