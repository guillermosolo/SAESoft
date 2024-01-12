using Microsoft.EntityFrameworkCore.Storage;
using SAESoft.Models;
using SAESoft.Models.Exportaciones;
using SAESoft.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using Microsoft.EntityFrameworkCore;


namespace SAESoft.Exportaciones
{
    public partial class frmLicencias : Form
    {
        Boolean nuevo = true;
        readonly Dictionary<string, int> items = new();
        public frmLicencias()
        {
            InitializeComponent();
        }

        private void frmLicencias_Load(object sender, EventArgs e)
        {

        }

        private void ibtnFacturas_Click(object sender, EventArgs e)
        {
            frmListaFacturas facturas = new();
            var resp = facturas.ShowDialog();
            if (resp == DialogResult.OK)
            {
                SAESoftContext db = new();
                var facturasSelec = db.FacturasExport.Where(f => facturas.facturas.Contains(f.IdFactura)).ToList();
                foreach (var fac in facturasSelec)
                {
                    if (!items.ContainsKey(fac.NoFactura))
                    {
                        items.Add(fac.NoFactura, fac.IdFactura);
                    }
                }
                lsbFacturas.DataSource = new BindingSource(items, null);
                lsbFacturas.DisplayMember = "Key";
                lsbFacturas.ValueMember = "Value";
            }
            if (lsbFacturas.Items.Count > 0)
            {
                ibtnArchivos.Enabled = true;
            }
            else
            {
                ibtnArchivos.Enabled = false;
            }
        }

        private void lsbFacturas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && nuevo)
            {
                var elementosSeleccionados = lsbFacturas.SelectedItems.Cast<KeyValuePair<string, int>>().ToList();

                // Eliminar los elementos seleccionados del diccionario
                foreach (var elemento in elementosSeleccionados)
                {
                    items.Remove(elemento.Key);
                }

                // Actualizar la fuente de datos del ListBox
                lsbFacturas.DataSource = new BindingSource(items, null);
                lsbFacturas.DisplayMember = "Key";
                lsbFacturas.ValueMember = "Value";
            }
            if (items.Count == 0)
            {
                ibtnArchivos.Enabled = false;
                lsbFacturas.DataSource = null;
            }
        }

        private void ibtnArchivos_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog1.FileNames)
                {
                    if (!ListViewItemExists(fileName))
                    {
                        Icon fileIcon = Icon.ExtractAssociatedIcon(fileName);
                        imageList1.Images.Add(fileIcon);

                        // Usar el índice del último icono agregado al ImageList
                        int iconIndex = imageList1.Images.Count - 1;

                        // Crear el ListViewItem con el nombre del archivo y el índice del icono
                        ListViewItem item = new(Path.GetFileName(fileName), iconIndex)
                        {
                            Tag = fileName
                        };

                        // Agregar el ListViewItem al ListView
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private bool ListViewItemExists(string fileName)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                string existingFileName = (string)item.Tag;
                if (string.Equals(existingFileName, fileName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;  // El archivo ya existe en el ListView
                }
            }
            return false;  // El archivo no existe en el ListView
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && nuevo)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    // Obtener el índice del icono asociado al ListViewItem
                    int iconIndex = selectedItem.ImageIndex;

                    // Eliminar el ListViewItem del ListView
                    listView1.Items.Remove(selectedItem);

                    // Eliminar el icono del ImageList
                    if (iconIndex >= 0 && iconIndex < imageList1.Images.Count)
                    {
                        imageList1.Images.RemoveAt(iconIndex);
                    }
                }
            }

        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                SAESoftContext db = new();
                using IDbContextTransaction transaction = db.Database.BeginTransaction();
                string path = PATH_Export;
                try
                {
                    Licencia licencia;
                    if (nuevo)
                    {
                        licencia = new Licencia
                        {
                            NumLicencia = txtNumero.Text,
                            Fecha = dtpFecha.Value.Date,
                            FechaCreacion = DatosServer.FechaServer(),
                            IdUsuarioCreacion = usuarioLogged.IdUsuario,
                        };
                        db.Licencias.Add(licencia);
                        db.SaveChanges();
                    }
                    else
                    {
                        licencia = db.Licencias
                             .Include(d => d.Descargos)
                             .Include(f => f.Facturas)
                             .FirstOrDefault(l => l.NumLicencia == txtNumero.Text);
                    }
                    path += @"\" + licencia.Codigo.ToString();
                    Directory.CreateDirectory(path);
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string archivoOrigen = item.Tag.ToString();
                        string archivoDestino = Path.Combine(path, Path.GetFileName(archivoOrigen));
                        if (!File.Exists(archivoDestino))
                        {
                            File.Copy(archivoOrigen, archivoDestino);
                        }
                    }
                    foreach (var item in items)
                    {
                        var factura = db.FacturasExport.Find(item.Value);
                        if (factura != null)
                        {
                            factura.IdLicencia = licencia.IdLicencia;
                        }
                    }
                    db.SaveChanges();
                    transaction.Commit();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private Boolean ValidarDatos()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "No puede estar vacío.");
                txtNumero.Focus();
                return false;
            }
            if (lsbFacturas.Items.Count == 0)
            {
                errorProvider1.SetError(groupBox1, "No puede estar vacío.");
                ibtnFacturas.Focus();
                return false;
            }
            if (listView1.Items.Count == 0)
            {
                errorProvider1.SetError(groupBox2, "No puede estar vacío.");
                ibtnArchivos.Focus();
                return false;
            }
            if (listView1.Items.Count < lsbFacturas.Items.Count)
            {
                errorProvider1.SetError(groupBox2, "Cantidad menor de archivos de soporte.");
                ibtnArchivos.Focus();
                return false;
            }
            return true;
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            nuevo = true;
            string path = PATH_Export;
            SAESoftContext db = new();
            var licencia = db.Licencias
                             .Include(d => d.Descargos)
                             .Include(f => f.Facturas)
                             .FirstOrDefault(l => l.NumLicencia == txtNumero.Text);
            if (licencia != null)
            {
                if (licencia.Descargos.Any(d => d.final))
                {
                    MessageBox.Show("No se pueden agregar facturas a esta licencia porque ya tiene descargos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                }
                else
                {
                    nuevo = false;
                    ibtnArchivos.Enabled = true;
                    path += @"\" + licencia.Codigo.ToString();
                    string[] files = Directory.GetFiles(path);
                    foreach (var fac in licencia.Facturas)
                    {
                        if (!items.ContainsKey(fac.NoFactura))
                        {
                            items.Add(fac.NoFactura, fac.IdFactura);
                        }
                    }

                    lsbFacturas.DataSource = new BindingSource(items, null);
                    lsbFacturas.DisplayMember = "Key";
                    lsbFacturas.ValueMember = "Value";

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string fileExtension = Path.GetExtension(file);

                        // Obtener el icono asociado al archivo
                        Icon fileIcon = Icon.ExtractAssociatedIcon(file);

                        // Agregar el icono al ImageList
                        imageList1.Images.Add(fileExtension, fileIcon);

                        // Agregar el archivo al ListView
                        ListViewItem item = new ListViewItem(fileName, fileExtension);
                        item.Tag = fileName;
                        listView1.Items.Add(item);
                    }

                    listView1.SmallImageList = imageList1;
                }
            }
        }
    }
}
