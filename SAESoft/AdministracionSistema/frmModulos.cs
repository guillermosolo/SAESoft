using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.Comunes;

namespace SAESoft.AdministracionSistema
{
    public partial class frmModulos : Form
    {
        public frmModulos()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = true;
        private List<Modulo>? rs = new List<Modulo>();
        private int CurrentIndex = 0;
        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
            {
                lblActivo.Text = "Habilitado";
            } else
            {
                lblActivo.Text = "Inhabilitado";
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            tsActivo.Checked = true;
            txtNombre.Focus();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior","tslIndice", "tsbSiguiente", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MODULOS");
                }
                else
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MODULOS");
                }
            }
            else
            {
                String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                CambiarVisibilidadBotones(botones, toolStrip1, true);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1,"MODULOS");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdModulo.ToString();
            txtNombre.Text = rs?[CurrentIndex].Nombre;
            tsActivo.Checked = rs[CurrentIndex].Habilitado;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            Modulo modulo = new Modulo()
                            {
                                Nombre = txtNombre.Text,
                                Habilitado = tsActivo.Checked,
                                FechaCreacion = DateTime.UtcNow,
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            _Contexto.Modulos.Add(modulo);
                            _Contexto.SaveChanges();
                            rs.Add(modulo);
                            CurrentIndex = rs.Count - 1;
                            despliegaDatos();
                            MessageBox.Show("Usuario Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (DbUpdateException ex)
                        {
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    Modulo temp = rs[CurrentIndex];
                    using (DB_Context _Contexto = new DB_Context())
                    {
                        try
                        {
                            _Contexto.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                            rs[CurrentIndex].Nombre = txtNombre.Text;
                            rs[CurrentIndex].Habilitado = tsActivo.Checked;
                            rs[CurrentIndex].FechaUltimaMod = DateTime.UtcNow;
                            rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                            _Contexto.Modulos.Update(rs[CurrentIndex]);
                            _Contexto.SaveChanges();
                        }
                        catch (DbUpdateException ex)
                        {
                            if (ex.InnerException != null)
                                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rs[CurrentIndex] = temp;
                            return;
                        }
                    }
                }
                if (rs.Count > 1)
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior","tslIndice", "tsbSiguiente", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                }
                else
                {
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"MODULOS");
                habilitarFormulario(this, false);
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No puede estar vacío.");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarModulos buscar = new frmBuscarModulos();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    var queryable = _Contexto.Modulos.Where(b => 1 == 1);
                    if (buscar.nombre != null)
                        queryable = queryable.Where(b => b.Nombre.Contains(buscar.nombre));
                    rs = queryable.ToList();
                    if (rs.Count > 0)
                    {
                        despliegaDatos();
                        if (rs.Count > 1)
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior","tslIndice", "tsbSiguiente", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                        }
                        else
                        {
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "MODULOS");
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                        CambiarVisibilidadBotones(botones, toolStrip1, true);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "MODULOS");
                    }
                }
            }
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombre.Focus();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    try
                    {
                        _Contexto.Modulos.Remove(rs[CurrentIndex]);
                        _Contexto.SaveChanges();
                        rs.Remove(rs[CurrentIndex]);
                        if (rs.Count > 0)
                        {
                            if (rs.Count > 1)
                            {
                                CurrentIndex--;
                                String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbAnterior","tslIndice", "tsbSiguiente", "tsbSalir" };
                                CambiarVisibilidadBotones(botones, toolStrip1, true);
                            }
                            else
                            {
                                CurrentIndex = 0;
                                String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                                CambiarVisibilidadBotones(botones, toolStrip1, true);
                            }
                            despliegaDatos();
                        }
                        else
                        {
                            limpiarFormulario(this);
                            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                            CambiarVisibilidadBotones(botones, toolStrip1, true);
                            CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1,"MODULOS");
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        if (ex.InnerException != null)
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (CurrentIndex + 1 >= rs?.Count)
                return;
            CurrentIndex++;
            despliegaDatos();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (CurrentIndex <= 0)
                return;
            CurrentIndex--;
            despliegaDatos();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new frmListar();
            using (DB_Context _Contexto = new DB_Context())
            {
                var lista = _Contexto.Modulos.Select(p => new {p.IdModulo, p.Nombre,p.Habilitado }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (DB_Context _Contexto = new DB_Context())
                {
                    rs = _Contexto.Modulos.Where(p => p.IdModulo == formListar.Id).ToList();
                    CurrentIndex = 0;
                    despliegaDatos();
                    String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsbSalir" };
                    CambiarVisibilidadBotones(botones, toolStrip1, true);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"MODULOS");
                }
            }
        }

        private void frmModulos_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "MODULOS");
        }
    }
}
