using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SAESoft.Cache.Constantes;

namespace SAESoft.Incentivo
{
    public partial class frmBuscarDepto : Form
    {
        public string NombreDepto = string.Empty;
        public int IdEncargado = 0;

        private readonly List<int> jefes = [IdSuperAdmin, JefeDeptoIncentivo];
        public frmBuscarDepto()
        {
            InitializeComponent();
        }

        private void frmBuscarDepto_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void llenarCombo()
        {
            using SAESoftContext db = new();
            var listaUsuarios = db.Usuarios.Where(a => jefes.Contains(a.IdRol)).ToList();
            listaUsuarios.Insert(0, new Usuario { IdUsuario = 0, Nombres = "", Apellidos = "", Email = "", UserName = "", Password = "", });
            cboEncargado.DataSource = listaUsuarios;
            cboEncargado.DisplayMember = "NombreCompleto";
            cboEncargado.ValueMember = "IdUsuario";
            cboEncargado.SelectedValue = 0;
        }

        private void icbBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboEncargado.SelectedValue);
            if (id != 0)
            {
                IdEncargado = id;
            }
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                NombreDepto = txtNombre.Text;
            }
        }
    }
}
