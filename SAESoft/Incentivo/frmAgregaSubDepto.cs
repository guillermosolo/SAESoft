using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.Incentivos;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Cache.UserData;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Cache.Constantes;

namespace SAESoft.Incentivo
{
    public partial class frmAgregaSubDepto : Form
    {
        private readonly List<int> subjefes = [IdSuperAdmin, SubJefeDeptoIncentivo];
        public DeptoIncentivo depto;
        public GrupoDeptoIncentivo grupo;
        private bool esNuevo = true;
        private List<Usuario> listaUsuarios = [];

        public frmAgregaSubDepto()
        {
            InitializeComponent();
        }

        private void frmAgregaSubDepto_Load(object sender, EventArgs e)
        {
            llenarCombo();
            if (depto != null)
            {
                esNuevo = false;
                txtCodigo.Text = depto.IdDepto.ToString();
                txtNombres.Text = depto.Nombre;
                cboEncargado.SelectedValue = listaUsuarios.Select(u=>u.IdUsuario).Contains(depto.IdUsuario) ? depto.IdUsuario:IdSuperAdmin; 
                tsActivo.Checked = depto.Activo;
            }
        }

        private void llenarCombo()
        {
            using SAESoftContext db = new();
            listaUsuarios = [.. db.Usuarios.Where(a => a.Activo && subjefes.Contains(a.IdRol))];
            cboEncargado.DataSource = listaUsuarios;
            cboEncargado.DisplayMember = "NombreCompleto";
            cboEncargado.ValueMember = "IdUsuario";
            cboEncargado.SelectedValue = IdSuperAdmin;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                using SAESoftContext db = new();
                if (esNuevo)
                {
                    depto = new DeptoIncentivo
                    {
                        Nombre = txtNombres.Text,
                        IdUsuario = Convert.ToInt32(cboEncargado.SelectedValue),
                        Activo = tsActivo.Checked,
                        IdGrupo = grupo.IdGrupo,
                        IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        FechaCreacion = DatosServer.FechaServer(),
                    };
                    db.DeptoIncentivo.Add(depto);
                    db.SaveChanges();
                    depto.Encargado = cboEncargado.SelectedItem as Usuario;
                } else
                {
                    db.Entry(depto).State = EntityState.Modified;
                    depto.Nombre = txtNombres.Text;
                    depto.IdUsuario = Convert.ToInt32(cboEncargado.SelectedValue);
                    depto.Activo = tsActivo.Checked;
                    depto.IdUsuarioMod = usuarioLogged.IdUsuario;
                    depto.FechaUltimaMod = DatosServer.FechaServer();
                    depto.Encargado = cboEncargado.SelectedItem as Usuario;
                    db.SaveChanges();
                }
            }
        }

        private Boolean ValidaDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "Campo requerido");
                txtNombres.Focus();
                return false;
            }
            return true;
        }
    }
}
