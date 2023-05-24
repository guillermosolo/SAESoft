namespace SAESoft
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            button2 = new Button();
            btnAdministracion = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            tsslUsuario = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            tsslVersion = new ToolStripStatusLabel();
            btnImportaciones = new Button();
            btnConfiguracion = new Button();
            panelBarraTitulo = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            icbRestaurar = new FontAwesome.Sharp.IconButton();
            icbMinimizar = new FontAwesome.Sharp.IconButton();
            icbMaximizar = new FontAwesome.Sharp.IconButton();
            icbCerrar = new FontAwesome.Sharp.IconButton();
            panelContenedor.SuspendLayout();
            panelFormularios.SuspendLayout();
            statusStrip1.SuspendLayout();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1000, 800);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // panelFormularios
            // 
            panelFormularios.Controls.Add(button2);
            panelFormularios.Controls.Add(btnAdministracion);
            panelFormularios.Controls.Add(button1);
            panelFormularios.Controls.Add(statusStrip1);
            panelFormularios.Controls.Add(btnImportaciones);
            panelFormularios.Controls.Add(btnConfiguracion);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(0, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1000, 760);
            panelFormularios.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.password;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 688);
            button2.Name = "button2";
            button2.Size = new Size(147, 43);
            button2.TabIndex = 8;
            button2.Text = "Contraseña";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAdministracion
            // 
            btnAdministracion.FlatAppearance.BorderSize = 0;
            btnAdministracion.FlatStyle = FlatStyle.Flat;
            btnAdministracion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministracion.Image = Properties.Resources.organize;
            btnAdministracion.Location = new Point(459, 22);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(186, 197);
            btnAdministracion.TabIndex = 7;
            btnAdministracion.Text = "Administración";
            btnAdministracion.TextAlign = ContentAlignment.BottomCenter;
            btnAdministracion.UseVisualStyleBackColor = true;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.logout;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(878, 688);
            button1.Name = "button1";
            button1.Size = new Size(119, 43);
            button1.TabIndex = 6;
            button1.Text = "Logout";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUsuario, toolStripStatusLabel2, tsslVersion });
            statusStrip1.Location = new Point(0, 734);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            tsslUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsslUsuario.Name = "tsslUsuario";
            tsslUsuario.Size = new Size(65, 21);
            tsslUsuario.Text = "usuario";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.RightToLeft = RightToLeft.Yes;
            toolStripStatusLabel2.Size = new Size(816, 21);
            toolStripStatusLabel2.Spring = true;
            // 
            // tsslVersion
            // 
            tsslVersion.Name = "tsslVersion";
            tsslVersion.Size = new Size(104, 21);
            tsslVersion.Text = "Versión 1.0.0";
            // 
            // btnImportaciones
            // 
            btnImportaciones.FlatAppearance.BorderSize = 0;
            btnImportaciones.FlatStyle = FlatStyle.Flat;
            btnImportaciones.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportaciones.Image = Properties.Resources.cargo_boat;
            btnImportaciones.Location = new Point(249, 22);
            btnImportaciones.Name = "btnImportaciones";
            btnImportaciones.Size = new Size(186, 197);
            btnImportaciones.TabIndex = 4;
            btnImportaciones.Text = "Importaciones";
            btnImportaciones.TextAlign = ContentAlignment.BottomCenter;
            btnImportaciones.UseVisualStyleBackColor = true;
            btnImportaciones.Click += btnImportaciones_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfiguracion.Image = Properties.Resources.settings;
            btnConfiguracion.Location = new Point(57, 22);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(186, 197);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.BottomCenter;
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = SystemColors.HotTrack;
            panelBarraTitulo.Controls.Add(label1);
            panelBarraTitulo.Controls.Add(pictureBox1);
            panelBarraTitulo.Controls.Add(icbRestaurar);
            panelBarraTitulo.Controls.Add(icbMinimizar);
            panelBarraTitulo.Controls.Add(icbMaximizar);
            panelBarraTitulo.Controls.Add(icbCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1000, 40);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(41, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 7;
            label1.Text = "S&&G, S.A.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_blue;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // icbRestaurar
            // 
            icbRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbRestaurar.FlatAppearance.BorderSize = 0;
            icbRestaurar.FlatStyle = FlatStyle.Flat;
            icbRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            icbRestaurar.IconColor = Color.White;
            icbRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRestaurar.IconSize = 36;
            icbRestaurar.Location = new Point(928, 0);
            icbRestaurar.Name = "icbRestaurar";
            icbRestaurar.Size = new Size(36, 40);
            icbRestaurar.TabIndex = 5;
            icbRestaurar.UseVisualStyleBackColor = true;
            icbRestaurar.Visible = false;
            icbRestaurar.Click += icbRestaurar_Click;
            // 
            // icbMinimizar
            // 
            icbMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbMinimizar.FlatAppearance.BorderSize = 0;
            icbMinimizar.FlatStyle = FlatStyle.Flat;
            icbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            icbMinimizar.IconColor = Color.White;
            icbMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbMinimizar.IconSize = 36;
            icbMinimizar.Location = new Point(896, 0);
            icbMinimizar.Name = "icbMinimizar";
            icbMinimizar.Size = new Size(36, 40);
            icbMinimizar.TabIndex = 4;
            icbMinimizar.UseVisualStyleBackColor = true;
            icbMinimizar.Click += icbMinimizar_Click;
            // 
            // icbMaximizar
            // 
            icbMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbMaximizar.FlatAppearance.BorderSize = 0;
            icbMaximizar.FlatStyle = FlatStyle.Flat;
            icbMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            icbMaximizar.IconColor = Color.White;
            icbMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbMaximizar.IconSize = 36;
            icbMaximizar.Location = new Point(928, 0);
            icbMaximizar.Name = "icbMaximizar";
            icbMaximizar.Size = new Size(36, 40);
            icbMaximizar.TabIndex = 3;
            icbMaximizar.UseVisualStyleBackColor = true;
            icbMaximizar.Click += icbMaximizar_Click;
            // 
            // icbCerrar
            // 
            icbCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbCerrar.FlatAppearance.BorderSize = 0;
            icbCerrar.FlatStyle = FlatStyle.Flat;
            icbCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            icbCerrar.IconColor = Color.White;
            icbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbCerrar.IconSize = 36;
            icbCerrar.Location = new Point(961, 0);
            icbCerrar.Name = "icbCerrar";
            icbCerrar.Size = new Size(36, 40);
            icbCerrar.TabIndex = 2;
            icbCerrar.UseVisualStyleBackColor = true;
            icbCerrar.Click += icbCerrar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 400);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            panelFormularios.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelBarraTitulo.ResumeLayout(false);
            panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconButton icbRestaurar;
        private FontAwesome.Sharp.IconButton icbMinimizar;
        private FontAwesome.Sharp.IconButton icbMaximizar;
        private FontAwesome.Sharp.IconButton icbCerrar;
        private Panel panelFormularios;
        private Button btnImportaciones;
        private Button btnConfiguracion;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuario;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tsslVersion;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAdministracion;
        private Button button2;
    }
}