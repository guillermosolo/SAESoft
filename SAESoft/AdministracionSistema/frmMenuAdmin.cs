using FontAwesome.Sharp;
using SAESoft.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.AdministracionSistema
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnUsuarios_Click(object sender, EventArgs e)
        {
            ControlFormularios.Abrir<frmUsuarios>(panelFormularios);
            ControlFormularios.menuActivo(ibtnUsuarios, panelMenu);
        }

        private void ibtnRoles_Click(object sender, EventArgs e)
        {
            ControlFormularios.Abrir<frmRoles>(panelFormularios);
            ControlFormularios.menuActivo(ibtnRoles, panelMenu);
        }

        private void ibtnRolPermiso_Click(object sender, EventArgs e)
        {
            ControlFormularios.Abrir<frmPermisosRoles>(panelFormularios);
            ControlFormularios.menuActivo(ibtnRolPermiso, panelMenu);
        }

        private void CloseForms(object sender, ControlEventArgs e) {
            if (Application.OpenForms["frmUsuario"]==null)
                ibtnUsuarios.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmPermisosRoles"] == null)
                ibtnRolPermiso.BackColor = Color.FromArgb(0, 122, 204);
            if (Application.OpenForms["frmRoles"] == null)
                ibtnRoles.BackColor = Color.FromArgb(0, 122, 204);

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            panelFormularios.ControlRemoved += new ControlEventHandler(CloseForms);
        }
    }
}
