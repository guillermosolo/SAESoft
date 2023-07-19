using FontAwesome.Sharp;
using SAESoft.Models;
using static SAESoft.Cache.UserData;
using SAESoft.Models.Comunes;

namespace SAESoft.Utilitarios
{
    public class ControlFormularios
    {
        public static void Abrir<MiForm>(Panel panel) where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public static void BotonesIniciales(ToolStrip toolbar)
        {
            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbComentarios", "tsbPago", "tsddbSwitchUser", "tsbRelatives", "tsddbDocumentos","tsbFicha", "tsbSalir" };
            CambiarVisibilidadBotones(botones, toolbar, true);
        }

        public static void BotonesInicialesNavegacion(ToolStrip toolbar)
        {
            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar", "tsddbProceso", "tsbUpload", "tsbComentarios", "tsbPago", "tsddbSwitchUser", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbRelatives", "tsddbDocumentos","tsbFicha", "tsbSalir" };
            CambiarVisibilidadBotones(botones, toolbar, true);
        }

        public static void CambiarVisibilidadBotones(String[] botones, ToolStrip toolbar, Boolean visible)
        {
            foreach (ToolStripItem btn in toolbar.Items)
            {
                if (btn.GetType() == typeof(ToolStripButton) || btn.GetType() == typeof(ToolStripLabel) || btn.GetType() == typeof(ToolStripDropDownButton))
                {
                    if (botones.Contains(btn.Name))
                    {
                        btn.Visible = visible;
                    }
                    else
                    {
                        btn.Visible = !visible;
                    }
                }
            }
        }

        public static void CambiarEstadoBotones(String[] botones, Boolean estado, ToolStrip toolbar, string Opcion)
        {
            foreach (ToolStripItem btn in toolbar.Items)
            {
                if (btn.GetType() == typeof(ToolStripButton) || btn.GetType() == typeof(ToolStripDropDownButton))
                {
                    if (botones.Contains(btn.Name))
                    {
                        btn.Enabled = btn.Name switch
                        {
                            "tsbNuevo" => estado && hasPermission("CREAR." + Opcion),
                            "tsbModificar" => estado && hasPermission("MODIFICAR." + Opcion),
                            "tsbEliminar" => estado && hasPermission("ELIMINAR." + Opcion),
                            _ => estado,
                        };
                    }
                }
            }
        }

        public static void habilitarFormulario(Control cont, Boolean opcion)
        {
            foreach (Control c in cont.Controls)
            {
                if (c is TextBox || c is ComboBox || c is CheckBox || c is NumericUpDown || c is DateTimePicker || c is toggleSwitch || c is CheckedListBox || c is RadioButton)
                {
                    if (c.Name != "txtId")
                    {
                        if (c is TextBox txt && !txt.ReadOnly)
                            c.Enabled = opcion;
                        else
                            c.Enabled = opcion;
                    }
                }
                if (c is TabControl || c is TabPage || c is GroupBox || c is Panel || c is ToolStripContainer)
                {
                    habilitarFormulario(c, opcion);
                }
            }
        }

        public static void limpiarFormulario(Control cont)
        {
            foreach (Control c in cont.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox box)
                {
                    if (box.Items.Count > 0)
                    {
                        box.SelectedIndex = 0;
                    }
                }
                if (c is CheckBox box1 && c is not toggleSwitch)
                {
                    box1.Checked = false;
                }
                if (c is NumericUpDown down)
                {
                    down.Value = 1;
                }
                if (c is DateTimePicker picker)
                {
                    picker.Value = DateTime.Now;
                }
                if (c is ListBox box2 && c is not CheckedListBox)
                {
                    box2.DataSource = null;
                    box2.Items.Clear();
                }
                if (c is CheckedListBox box3)
                {
                    for (int i = 0; i < box3.Items.Count; i++)
                    {
                        box3.SetItemChecked(i, false);
                    }
                }
                if (c is ListView view)
                {
                    view.Items.Clear();
                }
                if (c is TabControl or TabPage or GroupBox or Panel or ToolStripContainer)
                {
                    limpiarFormulario(c);
                }
            }
        }
        public static void menuActivo(IconButton boton, Panel panel)
        {
            IconButton btn;
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl.GetType() == typeof(IconButton))
                {
                    btn = (IconButton)ctrl;
                    if (btn.Name == boton.Name)
                    {
                        boton.BackColor = Color.FromArgb(0, 140, 250);
                    }
                    else
                    {
                        btn.BackColor = Color.FromArgb(0, 122, 204);
                    }
                }
            }
        }

        public static void msgError(Label label, string msg)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }

        public static void cambiarColorIcono(object sender)
        {
            if (((IconButton)sender).Enabled)
                ((IconButton)sender).IconColor = Color.White;
            else
                ((IconButton)sender).IconColor = Color.DarkGray;
        }

        public static void llenarNombres(ComboBox c, string g, Boolean ninguno = false)
        {
            if (ninguno)
            {
                using SAESoftContext db = new();
                var listado = db.Nombres.Where(n => n.Grupo.Nombre == g).OrderBy(n => n.Descripcion).ToList();
                listado.Insert(0, new Nombre { IdNombre = 0, Descripcion = "(NINGUNO)" });
                c.DataSource = listado;
                c.DisplayMember = "Descripcion";
                c.ValueMember = "IdNombre";
            }
            else
            {
                using SAESoftContext db = new();
                c.DataSource = db.Nombres.Where(n => n.Grupo.Nombre == g).OrderBy(n => n.Descripcion).ToList();
                c.DisplayMember = "Descripcion";
                c.ValueMember = "IdNombre";
            }
        }

        public static void llenarNombres(CheckedListBox c, string g, Boolean ninguno = false)
        {
            if (ninguno)
            {
                using SAESoftContext db = new();
                var listado = db.Nombres.Where(n => n.Grupo.Nombre == g).OrderBy(n => n.Descripcion).ToList();
                listado.Insert(0, new Nombre { IdNombre = 0, Descripcion = "(NINGUNO)" });
                c.DataSource = listado;
                c.DisplayMember = "Descripcion";
                c.ValueMember = "IdNombre";
            }
            else
            {
                using SAESoftContext db = new();
                c.DataSource = db.Nombres.Where(n => n.Grupo.Nombre == g).OrderBy(n => n.Descripcion).ToList();
                c.DisplayMember = "Descripcion";
                c.ValueMember = "IdNombre";
            }
        }

        public static bool IsFileOpen (string filePath)
        {
            if (!File.Exists(filePath))
            {
                // El archivo no existe
                return false;
            }
            try
            {
                using FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                // El archivo no está abierto
                return false;
            }
            catch (IOException)
            {
                // El archivo está abierto o no se puede acceder
                return true;
            }
        }
    }
}
