using SAESoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.AdministracionSistema
{
    public partial class frmBuscarUsuarios : Form
    {
        public frmBuscarUsuarios()
        {
            InitializeComponent();
        }
        public string? nombre = null;
        public string? apellido = null;
        public string? usuario = null;
        public int rol = -1;

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            llenarCombos();
        }

        private void llenarCombos()
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                cboRoles.DataSource = db.Roles.ToList();
                cboRoles.DisplayMember = "Nombre";
                cboRoles.ValueMember = "IdRol";
                cboRoles.SelectedIndex = -1;
            }
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
                nombre = txtNombres.Text;
            if (txtApellidos.Text != "")
                apellido = txtApellidos.Text;
            if (txtUsuario.Text != "")
                usuario= txtUsuario.Text;
            if (cboRoles.SelectedIndex > -1)
                rol = Convert.ToInt32(cboRoles.SelectedValue);
        }
    }
}
