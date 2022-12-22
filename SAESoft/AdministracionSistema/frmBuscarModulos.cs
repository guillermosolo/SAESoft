
namespace SAESoft.AdministracionSistema
{
    public partial class frmBuscarModulos : Form
    {
        public frmBuscarModulos()
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
