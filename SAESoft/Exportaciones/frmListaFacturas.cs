using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Exportaciones
{
    public partial class frmListaFacturas : Form
    {
        readonly DataTable dt = new();
        public List<int> facturas = new();
        public frmListaFacturas()
        {
            InitializeComponent();
        }

        private void estructuraGrid()
        {
            dt.Columns.Add("Agregar").DataType = typeof(Boolean);
            dt.Columns.Add("IdFactura").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Numero").DataType = Type.GetType("System.String");
            dt.Columns.Add("Fecha").DataType = typeof(DateTime);
            dt.Columns.Add("Consignatario").DataType = typeof(String);
            dgvLista.DataSource = dt;
            for (int i = 1; i < dgvLista.Columns.Count; i++)
            {
                dgvLista.Columns[i].ReadOnly = true;
            }
            dgvLista.Columns["IdFactura"].Visible = false;
        }

        private void llenarGrid()
        {
            DataRow row;
            using SAESoftContext db = new();
            var facturas = db.FacturasExport.Include(c => c.Consignatario).Where(f => f.FechaAnulacion == null && f.IdLicencia == null).ToList();
            foreach (var fac in facturas)
            {
                row = dt.NewRow();
                row["Agregar"] = false;
                row["IdFactura"] = fac.IdFactura;
                row["Numero"] = fac.NoFactura;
                row["Fecha"] = fac.Fecha;
                row["Consignatario"] = fac.Consignatario.Descripcion;
                dt.Rows.Add(row);
            }
        }

        private void frmListaFacturas_Load(object sender, EventArgs e)
        {
            estructuraGrid();
            llenarGrid();
        }

        private void ibtnFacturas_Click(object sender, EventArgs e)
        {
            facturas.Clear();
            foreach (DataGridViewRow fila in dgvLista.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["Agregar"].Value))
                {
                    facturas.Add(Convert.ToInt32(fila.Cells["IdFactura"].Value));
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
