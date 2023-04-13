using SAESoft.Models;

namespace SAESoft.AdministracionSistema.Comunes
{
    public partial class frmBuscarGrupos : Form
    {
        public string? nombre = null;
        public int modulo = -1;
        public frmBuscarGrupos()
        {
            InitializeComponent();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboModulo.DataSource = db.Modulos.ToList();
            cboModulo.DisplayMember = "Nombre";
            cboModulo.ValueMember = "IdModulo";
            cboModulo.SelectedIndex = -1;
        }

        private void frmBuscarGrupos_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
                nombre = txtNombre.Text;
            if (cboModulo.SelectedIndex > -1)
                modulo = Convert.ToInt32(cboModulo.SelectedValue);
        }
    }
}
