namespace SAESoft.Comunes
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
        public BindingSource ds = [];
        public Boolean ajustar = false;
        public int Id = 0;

        private void frmListar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds;
            dataGridView1.Columns[0].Visible = false;
            if (ajustar)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}

