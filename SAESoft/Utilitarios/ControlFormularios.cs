using FontAwesome.Sharp;
using SAESoft.Models;
using static SAESoft.Cache.UserData;

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
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
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
            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar","tsddbProceso","tsbUpload", "tsbSalir" };
            CambiarVisibilidadBotones(botones, toolbar, true);
        }

        public static void BotonesInicialesNavegacion(ToolStrip toolbar)
        {
            String[] botones = { "tsbNuevo", "tsbBuscar", "tsbListar", "tsbModificar", "tsbEliminar","tsddbProceso","tsbUpload", "tsbAnterior", "tslIndice", "tsbSiguiente", "tsbSalir" };
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
                        switch (btn.Name)
                        {
                            case "tsbNuevo":
                                btn.Enabled = estado && hasPermission("CREAR." + Opcion);
                                break;
                            case "tsbModificar":
                                btn.Enabled = estado && hasPermission("MODIFICAR." + Opcion);
                                break;
                            case "tsbEliminar":
                                btn.Enabled = estado && hasPermission("ELIMINAR." + Opcion);
                                break;
                            default:
                                btn.Enabled = estado;
                                break;
                        }
                    }
                }
            }
        }

        public static void habilitarFormulario(Control cont, Boolean opcion)
        {
            foreach (Control c in cont.Controls)
            {
                if (c is TextBox || c is ComboBox || c is CheckBox || c is NumericUpDown || c is DateTimePicker || c is toggleSwitch || c is DataGridView || c is ListBox || c is CheckedListBox)
                {
                    if (c.Name != "txtId")
                    {
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
                if (c is ComboBox)
                {
                    if (((ComboBox)c).Items.Count > 0)
                    {
                        ((ComboBox)c).SelectedIndex = 0;
                    }
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                if (c is toggleSwitch)
                {
                    ((toggleSwitch)c).Checked = false;
                }
                if (c is ListBox && !(c is CheckedListBox))
                {
                    ((ListBox)c).DataSource = null;
                    ((ListBox)c).Items.Clear();
                }
                if (c is CheckedListBox)
                {
                    for (int i = 0;i< ((CheckedListBox)c).Items.Count;i++)
                    {
                        ((CheckedListBox)c).SetItemChecked(i, false);
                    }
                }
                if (c is ListView)
                {
                    ((ListView)c).Items.Clear();
                }
                if (c is TabControl || c is TabPage || c is GroupBox || c is Panel || c is ToolStripContainer)
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

        public static void llenarNombres(ComboBox c,string g)
        {
            using (SAESoftContext db = new SAESoftContext())
            {
                c.DataSource = db.Nombres.Where(n=>n.Grupo.Nombre ==g).OrderBy(n=>n.Descripcion).ToList();
                c.DisplayMember = "Descripcion";
                c.ValueMember = "IdNombre";
            }
        }
    }
}
