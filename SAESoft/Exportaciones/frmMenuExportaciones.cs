using SAESoft.Importaciones;
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
using static SAESoft.Cache.UserData;

namespace SAESoft.Exportaciones
{
    public partial class frmMenuExportaciones : Form
    {
        public frmMenuExportaciones()
        {
            InitializeComponent();
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnFacturas_Click(object sender, EventArgs e)
        {
            Abrir<frmFacturas>(panelFormularios);
            menuActivo(ibtnFacturas, panelMenu);
        }

        private void frmMenuExportaciones_Load(object sender, EventArgs e)
        {
            habilitarMenu();
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms);
        }

        private void habilitarMenu()
        {
            ibtnDashboard.Enabled = hasPermission("VER.DASHBOARDEXPORT");
            ibtnFacturas.Enabled = hasPermission("VER.FACTURAS");
            ibtnLocal.Enabled = hasPermission("VER.LOCALES");

        }

        private void CloseForms(object? sender, ControlEventArgs e)
        {
            if (Application.OpenForms["frmDashboard"] == null)
                ibtnDashboard.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmFacturas"] == null)
                ibtnFacturas.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmLocal"] == null)
                ibtnFacturas.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            Abrir<frmDashboard>(panelFormularios);
            menuActivo(ibtnDashboard, panelMenu);
        }

        private void ibtnLocal_Click(object sender, EventArgs e)
        {
            Abrir<frmLocal>(panelFormularios);
            menuActivo(ibtnLocal, panelMenu);
        }

        private void ibtnReporte_Click(object sender, EventArgs e)
        {
            Abrir<frmReportes>(panelFormularios);
            menuActivo(ibtnReporte, panelMenu);
        }
    }
}
