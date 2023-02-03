using Microsoft.EntityFrameworkCore;
using SAESoft.Comunes;
using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using System.Data;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Cache.UserData;
using SAESoft.Utilitarios;

namespace SAESoft.AdministracionSistema
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private Boolean esNuevo = true;
        private List<Rol>? rs = new List<Rol>();
        private int CurrentIndex = 0;
        DataTable dt = new DataTable();

        private void estructuraGrid()
        {
            dt.Columns.Add("Nombre").DataType = Type.GetType("System.String");
            dt.Columns.Add("Crear").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Ver").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Modificar").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Eliminar").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("Otro").DataType = Type.GetType("System.Boolean");
            dt.Columns.Add("idModulo").DataType = Type.GetType("System.Int32");
        }
        private void llenarGridVacio()
        {
            String? nombre = null;
            String? nombreAnt = null;
            String? modulo = null;
            String? moduloAnt = null;
            DataRow row;
            dt.Clear();
            using (SAESoftContext db = new SAESoftContext())
            {
                var permisos = db.Permisos.Include(p => p.Modulo).ToList();
                foreach (var p in permisos)
                {
                    nombre = p.Nombre.Substring(p.Nombre.IndexOf(".") + 1);
                    modulo = p.Modulo.Nombre;
                    if (modulo != moduloAnt)
                    {
                        row = dt.NewRow();
                        row["Nombre"] = modulo;
                        row["idModulo"] = 0;
                        moduloAnt = modulo;
                        dt.Rows.Add(row);
                    }
                    if (nombre != nombreAnt)
                    {
                        row = dt.NewRow();
                        row["Nombre"] = nombre;
                        row["Crear"] = false;
                        row["Ver"] = false;
                        row["Modificar"] = false;
                        row["Eliminar"] = false;
                        row["Otro"] = false;
                        row["idModulo"] = p.IdModulo;
                        dt.Rows.Add(row);
                        nombreAnt = nombre;
                    }
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[0].Width = 119;
            for (int i = 1; i < 6; i++)
                dataGridView1.Columns[i].Width = 85;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.ClearSelection();
            titulosGrid();
        }

        private void titulosGrid()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (Convert.ToInt32(dataGridView1[6, j].Value) == 0)
                {
                    for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
                    {
                        if (i == 0)
                        {
                            dataGridView1[i, j].Style.ForeColor = Color.White;
                            dataGridView1[i, j].Style.SelectionForeColor = Color.White;
                        }
                        else
                        {
                            dataGridView1[i, j] = new DataGridViewTextBoxCell();
                            dataGridView1[i, j].Value = null;
                            dataGridView1[i, j].Style.ForeColor = Color.Black;
                            dataGridView1[i, j].Style.SelectionForeColor = Color.Black;
                        }
                        dataGridView1[i, j].Style.BackColor = Color.Black;
                        dataGridView1[i, j].Style.SelectionBackColor = Color.Black;
                    }
                }
            }

        }

        private void permisosInexistentes()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 1; i < 6; i++)
                {
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        string nom = dt.Columns[i].ColumnName.ToUpper() + "." + row.Cells[0].Value.ToString();
                        var existe = db.Permisos.FirstOrDefault(p => p.Nombre == nom);
                        if (existe == null)
                        {
                            row.Cells[i].ReadOnly = true;
                            if (Convert.ToInt32(row.Cells[6].Value) != 0)
                            {
                                row.Cells[i].Style.BackColor = Color.DarkGray;
                                row.Cells[i].Style.SelectionBackColor = Color.DarkGray;
                            }
                        }
                    }
                }
            }
        }

        private void despliegaGrid(int IdRol)
        {
            dataGridView1.ClearSelection();
            using (SAESoftContext db = new SAESoftContext())
            {
                var rs = db.Roles.Include(p => p.Permisos).Where(r => r.IdRol == IdRol).First();
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        string nom = dt.Columns[i].ColumnName.ToUpper() + "." + row["Nombre"];
                        if (rs.Permisos.Where(p => p.Nombre == nom).FirstOrDefault() != null)
                        {
                            row[i] = true;
                        }
                        else
                        {
                            row[i] = false;
                        }
                    }
                }
            }
            permisosInexistentes();
        }

        private void despliegaDatos()
        {
            txtId.Text = rs[CurrentIndex].IdRol.ToString();
            txtNombre.Text = rs[CurrentIndex].Nombre;
            tsActivo.Checked = rs[CurrentIndex].Habilitado;
            tslIndice.Text = $"Registro {CurrentIndex + 1} de {rs.Count}";
            despliegaGrid(rs[CurrentIndex].IdRol);
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRoles buscar = new frmBuscarRoles();
            DialogResult resp = buscar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    var queryable = db.Roles.Include(p => p.Permisos).Where(b => 1 == 1);
                    if (buscar.nombre != null)
                        queryable = queryable.Where(b => b.Nombre.Contains(buscar.nombre));
                    rs = queryable.ToList();
                    buscar.Dispose();
                    if (rs.Count > 0)
                    {
                        despliegaDatos();
                        if (rs.Count > 1)
                        {
                            BotonesInicialesNavegacion(toolStrip1);
                        }
                        else
                        {
                            BotonesIniciales(toolStrip1);
                        }
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "ROLES");
                    }
                    else
                    {
                        MessageBox.Show("No existen registros para ese criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarFormulario(this);
                        llenarGridVacio();
                        BotonesIniciales(toolStrip1);
                        CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "ROLES");
                    }
                }
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            CambiarEstadoBotones(new[] { "tsbNuevo" }, true, toolStrip1, "ROLES");
            estructuraGrid();
            llenarGridVacio();
        }

        private void tsActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (tsActivo.Checked)
            {
                lblActivo.Text = "Habilitado";
            }
            else
            {
                lblActivo.Text = "Inhabilitado";
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

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (rs?[CurrentIndex].IdRol == 1)
            {
                MessageBox.Show("No puede borrar el rol de Super Admin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resp = MessageBox.Show("¿En realidad desea borrar este registro?", "Verificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        using (var dbContextTransaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                Rol? rolActual = db.Roles.Include(r => r.Permisos).Where(r => r.IdRol == rs[CurrentIndex].IdRol).FirstOrDefault();
                                rolActual.Permisos.Clear();
                                db.Roles.Remove(rolActual);
                                db.SaveChanges();
                                dbContextTransaction.Commit();
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
                                    llenarGridVacio();
                                    BotonesIniciales(toolStrip1);
                                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "ROLES");
                                }
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                if (ex.InnerException != null)
                                    MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            if (rs?.Count > 0)
            {
                despliegaDatos();
                if (rs.Count > 1)
                {
                    BotonesInicialesNavegacion(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "ROLES");
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1, "ROLES");
                }
            }
            else
            {
                BotonesIniciales(toolStrip1);
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, false, toolStrip1, "ROLES");
                limpiarFormulario(this);
                llenarGridVacio();
            }
            habilitarFormulario(this, false);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            txtNombre.Focus();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            String[] botones = { "tsbAceptar", "tsbCancelar" };
            CambiarVisibilidadBotones(botones, toolStrip1, true);
            habilitarFormulario(this, true);
            limpiarFormulario(this);
            llenarGridVacio();
            permisosInexistentes();

            tsActivo.Checked = true;
            txtNombre.Focus();
        }

        private void frmRoles_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            titulosGrid();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string ex = e.Exception.Message;
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            frmListar formListar = new frmListar();
            using (SAESoftContext db = new SAESoftContext())
            {
                var lista = db.Roles.Select(p => new { p.IdRol, p.Nombre, p.Habilitado }).ToList();
                formListar.ds.DataSource = lista;
            }
            DialogResult resp = formListar.ShowDialog();
            if (resp == DialogResult.OK)
            {
                using (SAESoftContext db = new SAESoftContext())
                {
                    rs = db.Roles.Include(r => r.Permisos).Where(p => p.IdRol == formListar.Id).ToList();
                    CurrentIndex = 0;
                    despliegaDatos();
                    BotonesIniciales(toolStrip1);
                    CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"ROLES");
                }
            }
            formListar.Dispose();
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
        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        try
                        {
                            Rol rol = new Rol()
                            {
                                Nombre = txtNombre.Text,
                                Habilitado = tsActivo.Checked,
                                FechaCreacion = DatosServer.FechaServer(),
                                IdUsuarioCreacion = usuarioLogged.IdUsuario
                            };
                            db.Roles.Add(rol);
                            db.SaveChanges();
                            actualizarPermisos(rol.IdRol);
                            rs.Add(rol);
                            CurrentIndex = rs.Count - 1;
                            despliegaDatos();
                            MessageBox.Show("Rol Grabado Exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Rol temp = rs[CurrentIndex];
                    using (SAESoftContext db = new SAESoftContext())
                    {
                        try
                        {
                            Rol rolActual = db.Roles.Include(r => r.Permisos).Where(r => r.IdRol == rs[CurrentIndex].IdRol).FirstOrDefault();
                            db.Entry(rolActual).State = EntityState.Modified;
                            rolActual.Nombre = txtNombre.Text;
                            rolActual.Habilitado = tsActivo.Checked;
                            rolActual.FechaUltimaMod = DatosServer.FechaServer();
                            rolActual.IdUsuarioMod = usuarioLogged.IdUsuario;
                            db.Roles.Update(rolActual);
                            db.SaveChanges();
                            actualizarPermisos(rolActual.IdRol);
                        }
                        catch (Exception ex)
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
                    BotonesInicialesNavegacion(toolStrip1);
                }
                else
                {
                    BotonesIniciales(toolStrip1);
                }
                CambiarEstadoBotones(new[] { "tsbModificar", "tsbEliminar" }, true, toolStrip1,"ROLES");
                habilitarFormulario(this, false);
            }
        }

        private void actualizarPermisos(int rolId)
        {
            string nom;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr[6]) != 0)
                {
                    for (int i = 1; i < 6; i++)
                    {

                        using (SAESoftContext db = new SAESoftContext())
                        {
                            Rol rol = db.Roles.Include(r => r.Permisos).FirstOrDefault(r => r.IdRol == rolId);
                            nom = dt.Columns[i].ColumnName.ToUpper() + "." + dr[0].ToString();
                            Permiso per = db.Permisos.FirstOrDefault(p => p.Nombre == nom);
                            if (Convert.ToBoolean(dr[i]))
                            {
                                if (rol.Permisos.FirstOrDefault(p => p.Nombre == nom) == null)
                                    rol.Permisos.Add(per);
                            }
                            else
                            {
                                if (per != null && rol.Permisos.FirstOrDefault(p => p.Nombre == nom) != null)
                                    rol.Permisos.Remove(per);
                            }
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}