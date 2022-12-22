using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

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

        public static void CambiarVisibilidadBotones (String[] botones, ToolStrip toolbar, Boolean visible)
        {
            foreach (ToolStripItem btn in toolbar.Items)
            {
                if (btn.GetType() == typeof(ToolStripButton)||btn.GetType() == typeof(ToolStripLabel))
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

        public static void CambiarEstadoBotones(String[] botones, Boolean estado,ToolStrip toolbar)
        {
            foreach (ToolStripItem btn in toolbar.Items)
            {
                if (btn.GetType() == typeof(ToolStripButton))
                {
                    if (botones.Contains(btn.Name))
                    {
                        btn.Enabled = estado;
                    }
                }
            }
        }

        public static void habilitarFormulario (Control cont, Boolean opcion)
        {
            foreach (Control c in cont.Controls)
            {
                if (c is TextBox || c is ComboBox ||c is CheckBox|| c is NumericUpDown ||c is DateTimePicker || c is toggleSwitch || c is DataGridView)
                {
                    if (c.Name != "txtId")
                    {
                        c.Enabled = opcion;
                    }
                }
                if (c is TabControl ||c is TabPage ||c is GroupBox||c is Panel ||c is ToolStripContainer)
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
                if (c is TabControl || c is TabPage || c is GroupBox || c is Panel || c is ToolStripContainer)
                {
                    limpiarFormulario(c);
                }
            }
        }
        public static void menuActivo(IconButton boton,Panel panel)
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
                    } else
                    {
                        btn.BackColor = Color.FromArgb(0,122,204);
                    }
                }
            }
        }

        public static void msgError(Label label, string msg)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }
    }
}
