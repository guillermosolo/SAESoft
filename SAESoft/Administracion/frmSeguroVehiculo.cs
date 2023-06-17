using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SAESoft.Utilitarios.ControlFormularios;

namespace SAESoft.Administracion
{
    public partial class frmSeguroVehiculo : Form
    {
        public string marca;
        public string color;
        public string placas;
        public int idAseguradora;
        public string poliza;
        public DateTime inicio;
        public DateTime vencimiento;
        public decimal prima;
        public decimal deducible;
        public Boolean existe = false;
        public frmSeguroVehiculo()
        {
            InitializeComponent();
        }

        private void frmSeguroVehiculo_Load(object sender, EventArgs e)
        {
            llenarNombres(cboAseguradora, "ASEGURADORA");
        }

        private void icbFinalizar_Click(object sender, EventArgs e)
        {
            if (existe)
            {
                var resp = MessageBox.Show("Ya existe un Seguro, ¿desea reemplazar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    marca = txtMarca.Text;
                    color = txtColor.Text;
                    placas = txtPlacas.Text;
                    idAseguradora = Convert.ToInt32(cboAseguradora.SelectedValue);
                    poliza = txtPoliza.Text;
                    inicio = dtpInicio.Value.Date;
                    vencimiento = dtpVencimiento.Value.Date;
                    prima = Convert.ToDecimal(txtPrima.Text);
                    deducible = Convert.ToDecimal(txtDeducible.Text);
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                marca = txtMarca.Text;
                color = txtColor.Text;
                placas = txtPlacas.Text;
                idAseguradora = Convert.ToInt32(cboAseguradora.SelectedValue);
                poliza = txtPoliza.Text;
                inicio = dtpInicio.Value.Date;
                vencimiento = dtpVencimiento.Value.Date;
                prima = Convert.ToDecimal(txtPrima.Text);
                deducible = Convert.ToDecimal(txtDeducible.Text);
            }
        }
    }
}
