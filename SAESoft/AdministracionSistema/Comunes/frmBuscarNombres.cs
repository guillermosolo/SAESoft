using SAESoft.Models;

namespace SAESoft.AdministracionSistema.Comunes
{
    public partial class frmBuscarNombres : Form
    {
        public string? descripcion = null;
        public int grupo = -1;
        public frmBuscarNombres()
        {
            InitializeComponent();
        }

        private void frmBuscarNombres_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboGrupos.DataSource = db.Grupos.ToList();
            cboGrupos.DisplayMember = "Nombre";
            cboGrupos.ValueMember = "IdGrupo";
            cboGrupos.SelectedIndex = -1;
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
                descripcion = txtDescripcion.Text;
            if (cboGrupos.SelectedIndex > -1)
                grupo = Convert.ToInt32(cboGrupos.SelectedValue);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
