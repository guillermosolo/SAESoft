namespace SAESoft.Importaciones
{
    public partial class frmComentarios : Form
    {
        public string Obs;
        public frmComentarios()
        {
            InitializeComponent();
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            Obs = txtObs.Text;
        }
    }
}
