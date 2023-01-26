using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;

namespace SAESoft.Importaciones
{
    public partial class frmBuscarImport : Form
    {
        public List<int> ids = new List<int>();
        public Boolean todos = false;
        public frmBuscarImport()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            ids.Clear();
            if (txtNumero.Text == string.Empty)
            {
                todos = true;
            }
            else
            {
                todos = false;
                if (rbBL.Checked)
                {
                    ids = buscarBL();
                }
                else if (rbContendor.Checked)
                {
                    ids = buscarContenedor();
                }
                else
                {
                    ids = buscarPoliza();
                }
            }
        }

        private List<int> buscarBL()
        {
            using(SAESoftContext db = new SAESoftContext())
            {
                return db.BL.Where(b=>b.Numero == txtNumero.Text).Select(b=>b.IdImportacion).ToList();
            }
        }

        private List<int> buscarContenedor()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                return db.Contenedores.Where(c=>c.Numero == txtNumero.Text).Select(c=>c.IdImportacion).ToList();
            }
        }

        private List<int> buscarPoliza()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                return db.Polizas.Include(p => p.BL).Where(p => p.Numero == txtNumero.Text).Select(p => p.BL.IdImportacion).ToList();
            }
        }
    }
}