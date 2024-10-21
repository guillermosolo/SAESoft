using FontAwesome.Sharp;
using SAESoft.Models;
using static SAESoft.Cache.UserData;
using SAESoft.Models.Comunes;
using System.Globalization;
using DocumentFormat.OpenXml.Office.CoverPageProps;

namespace SAESoft.Utilitarios
{
    public class ControlFormularios
    {
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            bool isValidInput = false;

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            // Event handler for buttonOk to validate input
            buttonOk.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("El campo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Prevent closing the form by resetting DialogResult to None
                    form.DialogResult = DialogResult.None;
                }
                else
                {
                    isValidInput = true;
                }
            };

            DialogResult dialogResult = form.ShowDialog();

            if (isValidInput)
            {
                value = textBox.Text;
            }
 
            return dialogResult;
        }

        public static string FormatFileName(string fileName)
        {
            // Máxima longitud permitida
            const int maxLength = 40;

            // Si el nombre del archivo ya es suficientemente corto, devolverlo tal cual
            if (fileName.Length <= maxLength)
            {
                return fileName;
            }

            // Obtener la parte desde la última barra invertida
            string fileNameFromLastSlash = fileName[fileName.LastIndexOf('\\')..];

            // Calcular cuántos caracteres tomar del inicio para que el total sea 50 incluyendo los puntos y la parte final
            int prefixLength = maxLength - fileNameFromLastSlash.Length - 5;

            // Asegurarse de que no se tome un prefijo demasiado corto
            if (prefixLength < 1)
            {
                prefixLength = 1;
            }

            // Obtener el prefijo del nombre de archivo
            string prefix = fileName[..prefixLength];

            // Formatear el nombre de archivo resultante
            string formattedFileName = prefix + "....." + fileNameFromLastSlash;

            return formattedFileName;
        }
        public static void EstablecerNumerosEncabezado(DataGridView dataGridView)
        {
            // Recorre cada fila del DataGridView
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                // Establece el número de fila en el encabezado de fila
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
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

        public static void llenarNumeros(NumericUpDown control, int inicio, int fin)
        {
            control.Minimum = Math.Min(inicio, fin);
            control.Maximum = Math.Max(inicio, fin);

            control.Value = inicio;
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
                            "tsbPago" => estado && hasPermission("MODIFICAR." + Opcion),
                            "tsbUpload" => estado && hasPermission("MODIFICAR." + Opcion),
                            "tsbComentarios" => estado && hasPermission("MODIFICAR." + Opcion),
                            "tsddbSwitchUser" => estado && hasPermission("MODIFICAR." + Opcion),
                            "tsddbProceso" => estado && hasPermission("MODIFICAR." + Opcion),
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

        public static CultureInfo GetCultureInfo(string codigoMoneda)
        {
            return codigoMoneda.ToUpper() switch
            {
                //Quetzales
                "GTQ" => new CultureInfo("es-GT"),
                // Dólares estadounidenses
                "USD" => new CultureInfo("en-US"),
                // Wones
                "KRW" => new CultureInfo("ko-KR"),
                // Agrega más casos según sea necesario para otras monedas
                _ => throw new ArgumentException("Código de moneda no válido"),
            };
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
