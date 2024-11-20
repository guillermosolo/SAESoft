namespace SAESoft.AdministracionSistema.Importaciones
{
    public partial class frmBuscarAgente : Form
    {
        public string? nombre = null;
        public string? apellido = null;
        public frmBuscarAgente()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
                nombre = txtNombres.Text;
            if (txtApellidos.Text != "")
                apellido = txtApellidos.Text;
        }
    }
}
