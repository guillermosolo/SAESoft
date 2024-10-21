
namespace SAESoft.Incentivo
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmRepoGeneral repo = new();
            repo.ShowDialog();
        }
    }
}
