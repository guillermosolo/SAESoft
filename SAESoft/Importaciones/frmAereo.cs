using SAESoft.Models.Importaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static SAESoft.Cache.UserData;
using static SAESoft.Cache.Constantes;
using static SAESoft.Utilitarios.ControlFormularios;
using static SAESoft.Utilitarios.DatosServer;

namespace SAESoft.Importaciones
{
    public partial class frmAereo : Form
    {
        public frmAereo()
        {
            InitializeComponent();
        }
        private Boolean esNuevo = false;
        private List<Importacion>? rs = new List<Importacion>();
        private int CurrentIndex = 0;
        DataTable dt = new DataTable();

        List<string> listFiles = new List<string>();
        string path = PATH_Import;
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
