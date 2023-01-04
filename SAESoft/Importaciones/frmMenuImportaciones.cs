using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Importaciones
{
    public partial class frmMenuImportaciones : Form
    {
        public frmMenuImportaciones()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuImportaciones_Load(object sender, EventArgs e)
        {
            ibtnDashboard_Click(sender, e);
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            Abrir<frmDashboard>(panelFormularios);
            menuActivo(ibtnDashboard, panelMenu);
        }
    }
}
