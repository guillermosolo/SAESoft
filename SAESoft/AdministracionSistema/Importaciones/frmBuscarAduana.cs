namespace SAESoft.AdministracionSistema.Importaciones
{
    public partial class frmBuscarAduana : Form
    {
        public string? nombre = null;
        public char? via = 'O';
        public frmBuscarAduana()
        {
            InitializeComponent();
        }

        private void llenarCombos()
        {
            List<object> options =
                [
                     new { Name = "Todos",Value='O'},
                     new { Name = "Aéreo", Value = 'A' },
                     new { Name = "Marítimo", Value = 'M' },
                     new { Name = "Terrestre", Value = 'T' }
                ];
            cboVia.DisplayMember = "Name";
            cboVia.ValueMember = "Value";
            cboVia.DataSource = options;
        }

        private void frmBuscarAduana_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
                nombre = txtDescripcion.Text;
            via = (char?)cboVia.SelectedValue;
        }
    }
}
