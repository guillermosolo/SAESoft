﻿using SAESoft.Administracion;
using SAESoft.AdministracionSistema;
using SAESoft.CambioPassword;
using SAESoft.Importaciones;
using SAESoft.Exportaciones;
using System.Runtime.InteropServices;
using static SAESoft.Cache.UserData;
using static SAESoft.Utilitarios.ControlFormularios;
using SAESoft.Incentivo;

namespace SAESoft
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            this.Icon = new Icon("logo-blue.ico");
        }
        #region Funcionalidades del Formulario
        // **********CODIGO PARA HACER QUE SE PUEDA ARRASTAR EL FORMULARIO************
        internal static partial class User32
        {
            [LibraryImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            public static partial void ReleaseCapture();

            [LibraryImport("user32.DLL", EntryPoint = "SendMessageA")]
            public static partial void SendMessage(nint hwnd, int wmsg, int wparam, int lparam);
        }

        //********* FIN CODIGO ARRASTRAR FORMULARIO***********************

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private readonly int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            User32.ReleaseCapture();
            User32.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icbMaximizar_Click(object sender, EventArgs e)
        {
            icbMaximizar.Visible = false;
            icbRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void icbRestaurar_Click(object sender, EventArgs e)
        {
            icbMaximizar.Visible = true;
            icbRestaurar.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmPrincipal_Move(object sender, EventArgs e)
        {
              if (this.WindowState == FormWindowState.Maximized)
            {
                icbMaximizar.Visible = false;
                icbRestaurar.Visible = true;
            } else
            {
                icbMaximizar.Visible = true;
                icbRestaurar.Visible = false;
            }
        }

        #endregion

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Abrir<frmMenuAdmin>(panelFormularios);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsslUsuario.Text = usuarioLogged?.UserName;
            tsslVersion.Text = "Versión: " + AppVersion;
            btnConfiguracion.Enabled = hasPermission("VER.ADMINISTRACION SISTEMA");
            btnImportaciones.Enabled = hasPermission("VER.IMPORTACIONES");
            btnExportaciones.Enabled = hasPermission("VER.EXPORTACIONES");
            btnAdministracion.Enabled = hasPermission("VER.ADMINISTRACION");
            btnIncentivo.Enabled = hasPermission("VER.INCENTIVOS");

        }

        private void btnImportaciones_Click(object sender, EventArgs e)
        {
            Abrir<frmMenuImportaciones>(panelFormularios);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Abrir<frmMenuAdmon>(panelFormularios);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WFCambioPwd cambio = new();
            cambio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abrir<frmMenuExportaciones>(panelFormularios);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Abrir<frmMenuIncentivo>(panelFormularios);
        }

       
    }
}
