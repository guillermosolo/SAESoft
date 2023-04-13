namespace SAESoft.AdministracionSistema.Importaciones
{
    public partial class frmBuscarShipper : Form
    {
        public string? nombre = null;
        public Boolean aereo = false;
        public Boolean maritimo = false;
        public Boolean terrestre = false;
        public frmBuscarShipper()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
                nombre = txtDescripcion.Text;
            aereo = chkAereo.Checked;
            maritimo = chkMaritimo.Checked;
            terrestre = chkTerrestre.Checked;
        }

        private void chkCheckedChange(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
                chk.Image = Properties.Resources.Nchecked;
            else
                chk.Image = Properties.Resources.Nunchecked;

        }
    }
}
