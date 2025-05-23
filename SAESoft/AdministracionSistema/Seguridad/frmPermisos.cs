﻿using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Utilitarios;

namespace SAESoft.AdministracionSistema.Seguridad
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = true;
        private List<Permiso>? rs = [];
        private int CurrentIndex = 0;

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            txtNombre.Focus();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(["tsbNuevo"], true, toolStrip1, "PERMISOS");
            llenarCombos();
        }

        private void llenarCombos()
        {
            using SAESoftContext db = new();
            cboModulos.DataSource = db.Modulos.ToList();
            cboModulos.DisplayMember = "Nombre";
            cboModulos.ValueMember = "IdModulo";
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
                        Permiso permiso = new()
                        {
                            Nombre = txtNombre.Text,
                            IdModulo = Convert.ToInt32(cboModulos.SelectedValue),
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario
                        };
                        db.Permisos.Add(permiso);
                        db.SaveChanges();
                        rs.Add(permiso);
                        CurrentIndex = rs.Count - 1;
                        despliegaDatos();
                        MessageBox.Show("Permiso Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Permiso temp = rs[CurrentIndex];
                    using SAESoftContext db = new();
                    try
                    {
                        db.Entry(rs[CurrentIndex]).State = EntityState.Modified;
                        rs[CurrentIndex].Nombre = txtNombre.Text;
                        rs[CurrentIndex].IdModulo = Convert.ToInt32(cboModulos.SelectedValue);
                        rs[CurrentIndex].FechaUltimaMod = DatosServer.FechaServer();
                        rs[CurrentIndex].IdUsuarioMod = usuarioLogged?.IdUsuario;
                        db.Permisos.Update(rs[CurrentIndex]);
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
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "PERMISOS");
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
            if (cboModulos.SelectedIndex == -1)
            {
                errorProvider1.SetError(cboModulos, "No puede estar vacío.");
                cboModulos.Focus();
                return false;
            }
            return true;
        }

        private void despliegaDatos()
        {
            txtId.Text = rs?[CurrentIndex].IdPermiso.ToString();
            txtNombre.Text = rs?[CurrentIndex].Nombre;
            cboModulos.SelectedValue = rs?[CurrentIndex].IdModulo;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "PERMISOS");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "PERMISOS");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "PERMISOS");
                limpiarFormulario(this);
            }
            habilitarFormulario(this, false);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = ["tsbAceptar", "tsbCancelar"];
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
                    db.Permisos.Remove(rs[CurrentIndex]);
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
                        CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "PERMISOS");
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

        private void tsbListar_Click(object sender, EventArgs e)
        {
            using frmListar formListar = new();
            using (SAESoftContext db = new())
            {
                var lista = db.Permisos.Include(p => p.Modulo).Select(p => new { p.IdPermiso, p.Nombre,Módulo = p.Modulo.Nombre }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                rs = [.. db.Permisos.Where(p => p.IdPermiso == formListar.Id)];
                CurrentIndex = 0;
                despliegaDatos();
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "PERMISOS");
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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            using frmBuscarPermisos buscar = new();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using SAESoftContext db = new();
                var queryable = db.Permisos.AsQueryable();
                if (buscar.nombre != null)
                    queryable = queryable.Where(b => b.Nombre.Contains(buscar.nombre));
                if (buscar.modulo != -1)
                    queryable = queryable.Where(b => b.IdModulo == buscar.modulo);
                rs = [.. queryable];
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
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], true, toolStrip1, "PERMISOS");
                }
                else
                {
                    MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiarFormulario(this);
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(["tsbModificar", "tsbEliminar"], false, toolStrip1, "PERMISOS");
                }
            }
        }
    }
}
