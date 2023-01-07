using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Importaciones
{
    public partial class frmMaritimo : Form
    {
        public frmMaritimo()
        {
            InitializeComponent();
            cargarArchivos();
            fileSystemWatcher1.Path = path;
        }
        List<string> listFiles = new List<string>();
        string path = @"C:\gato";
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void cargarArchivos()
        {
            listFiles.Clear();
            listView1.Items.Clear();
            imageList1.Images.Clear();
            foreach(string file in Directory.GetFiles(path).Where(f=>(new FileInfo(f).Attributes & FileAttributes.Hidden)==0))
            {
                imageList1.Images.Add(Icon.ExtractAssociatedIcon(file));
                FileInfo fi = new FileInfo(file);
                listFiles.Add(fi.FullName);
                listView1.Items.Add(fi.Name,imageList1.Images.Count - 1);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string selectedFile = listFiles[listView1.SelectedIndices[0]];
            if (File.Exists(selectedFile))
            {
                new Process { StartInfo = new ProcessStartInfo(selectedFile) { UseShellExecute = true } }.Start();
            }

        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            cargarArchivos();
        }
    }
}
