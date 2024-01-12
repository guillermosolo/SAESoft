using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System.Data;

namespace SAESoft.Importaciones
{
    public partial class frmBuscarImport : Form
    {
        public List<int> ids = new();
        public Boolean todos = false;
        public frmBuscarImport()
        {
            InitializeComponent();
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            ids.Clear();
            if (string.IsNullOrEmpty(txtNumero.Text))
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
                else if (rbPoliza.Checked)
                {
                    ids = buscarPoliza();
                } else
                {
                    ids.Add(Convert.ToInt32(txtNumero.Text));
                }
            }
        }

        private List<int> buscarBL()
        {
            using SAESoftContext db = new();
            return db.BL.Where(b => b.Numero.Contains(txtNumero.Text)).Select(b => b.IdImportacion).ToList();
        }

        private List<int> buscarContenedor()
        {
            using SAESoftContext db = new();
            return db.Contenedores.Where(c => c.Numero.Contains(txtNumero.Text)).Select(c => c.IdImportacion).ToList();
        }

        private List<int> buscarPoliza()
        {
            using SAESoftContext db = new();
            return db.Polizas.Include(p => p.BL).Where(p => p.Numero.Contains(txtNumero.Text)).Select(p => p.BL.IdImportacion).ToList();
        }
    }
}