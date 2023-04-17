using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Models;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;

namespace SAESoft.AdministracionSistema.Importaciones
{
    public partial class frmAgentes : Form
    {
        private Boolean esNuevo = true;
        private List<Agente>? rs = new();
        private int CurrentIndex = 0;
        public frmAgentes()
        {
            InitializeComponent();
        }

        private void frmAgentes_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "AGENTES");
        }

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdAgente.ToString();
            txtNombre.Text = rs?[CurrentIndex].Nombres;
            txtApellido.Text = rs?[CurrentIndex].Apellidos;
            tsActivo.Checked = rs[CurrentIndex].Activo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAgente buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.Agentes.Where(b => 1 == 1);
                if (buscar.nombre != null)
                    queryable = queryable.Where(b => b.Nombres.Contains(buscar.nombre));
                if (buscar.apellido != null)
                    queryable = queryable.Where(b => b.Apellidos.Contains(buscar.apellido));
                rs = queryable.ToList();
                buscar.Dispose();
                if (rs.Count > 0)
                {
                    CurrentIndex = 0;
                    despliegaDatos();
                    if (rs.Count > 1)
                    {
                        BotonesInicialesNavegacion(toolStrip1);
                    }
                    else
                    {
                        BotonesIniciales(toolStrip1);
                    }
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AGENTES");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AGENTES");
                }
            }
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (CurrentIndex <= 0)
                return;
            CurrentIndex--;
            despliegaDatos();
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (CurrentIndex + 1 >= rs?.Count)
                return;
            CurrentIndex++;
            despliegaDatos();
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
                label4.Text = "Activo";
            else
                label4.Text = "Inactivo";
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.Agentes.Select(p => new { p.IdAgente, p.Nombres, p.Apellidos, p.Activo }).ToList();
                formListar.ds.DataSource = lista;
                formListar.ajustar = false;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = db.Agentes.Where(p => p.IdAgente == formListar.Id).ToList();
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AGENTES");
            }
            formListar.Dispose();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            txtNombre.Focus();
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
                using SAESoftContext db = new();
                try
                {
                    db.Agentes.Remove(rs[CurrentIndex]);
                    db.SaveChanges();
                    rs.Remove(rs[CurrentIndex]);
                    if (rs.Count > 0)
                    {
                        if (rs.Count > 1)
                        {
                            if (CurrentIndex != 0)
                                CurrentIndex--;
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            CurrentIndex = 0;
                            BotonesIniciales(toolStrip1);
                        }
                        despliegaDatos();
                    }
                    else
                    {
                        limpiarFormulario(this);
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AGENTES");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {

            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AGENTES");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AGENTES");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "AGENTES");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
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
            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "No puede estar vacío.");
                txtApellido.Focus();
                return false;
            }
            return true;
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using SAESoftContext db = new();
                    try
                    {
                        Agente agente = new()
                        {
                            Nombres = txtNombre.Text,
                            Apellidos = txtApellido.Text,
                            Activo = tsActivo.Checked,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Agentes.Add(agente);
                        db.SaveChanges();
                        rs.Add(agente);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Agente Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    Agente temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Nombres = txtNombre.Text;
                        rs[CurrentIndex].Apellidos = txtApellido.Text;
                        rs[CurrentIndex].Activo = tsActivo.Checked;
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Agentes.Update(rs[CurrentIndex]);
                        db.SaveChanges();
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
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "AGENTES");
                habilitarFormulario(this, false);
            }
        }
    }
}
