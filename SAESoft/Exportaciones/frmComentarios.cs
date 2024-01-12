using SAESoft.Models;
using SAESoft.Models.Exportaciones;
using SAESoft.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Exportaciones
{
    public partial class frmComentarios : Form
    {
        private readonly DataTable dt = new();
        public string referencia;
        public int idLicencia;
        public frmComentarios()
        {
            InitializeComponent();
        }

        private void frmComentarios_Load(object sender, EventArgs e)
        {
            label2.Text = "Ref. " + referencia;
            estructuraTabla();
            llenarTabla();
        }

        private void estructuraTabla()
        {
            dt.Columns.Add("IdComentario").DataType = Type.GetType("System.Int32");
            dt.Columns.Add("Fecha").DataType = Type.GetType("System.DateTime");
            dt.Columns.Add("Comentario").DataType = Type.GetType("System.String");
            dgvComentarios.DataSource = dt;
            dgvComentarios.Columns[0].Visible = false;
            dgvComentarios.Columns[1].Width = 120;
            dgvComentarios.Columns[2].Width = 450;
        }

        private void llenarTabla()
        {
            using SAESoftContext db = new();
            var com = db.ComentFacsExport.Where(f => f.IdLicencia == idLicencia);
            foreach (var item in com)
            {
                DataRow row = dt.NewRow();
                row["IdComentario"] = item.IdComment;
                row["Fecha"] = item.Fecha.Date;
                row["Comentario"] = item.Comentario;
                dt.Rows.Add(row);
            }
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCometario.Text))
            {
                txtCometario.Focus();
            }
            else
            {
                using SAESoftContext db = new();
                var comment = new ComentFacExport()
                {
                    Fecha = DatosServer.FechaServer(),
                    IdLicencia = idLicencia,
                    Comentario = txtCometario.Text,
                };
                db.ComentFacsExport.Add(comment);
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
