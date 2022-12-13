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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.btnImportaciones = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.icbRestaurar = new FontAwesome.Sharp.IconButton();
            this.icbMinimizar = new FontAwesome.Sharp.IconButton();
            this.icbMaximizar = new FontAwesome.Sharp.IconButton();
            this.icbCerrar = new FontAwesome.Sharp.IconButton();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(850, 650);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.btnImportaciones);
            this.panelFormularios.Controls.Add(this.btnConfiguracion);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(850, 610);
            this.panelFormularios.TabIndex = 1;
            // 
            // btnImportaciones
            // 
            this.btnImportaciones.FlatAppearance.BorderSize = 0;
            this.btnImportaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImportaciones.Image = global::SAESoft.Properties.Resources.cargo_boat;
            this.btnImportaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportaciones.Location = new System.Drawing.Point(259, 63);
            this.btnImportaciones.Name = "btnImportaciones";
            this.btnImportaciones.Size = new System.Drawing.Size(186, 197);
            this.btnImportaciones.TabIndex = 4;
            this.btnImportaciones.Text = "Importaciones";
            this.btnImportaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportaciones.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguracion.Image = global::SAESoft.Properties.Resources.settings;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfiguracion.Location = new System.Drawing.Point(41, 63);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(186, 197);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "Administración del Sistema";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelBarraTitulo.Controls.Add(this.icbRestaurar);
            this.panelBarraTitulo.Controls.Add(this.icbMinimizar);
            this.panelBarraTitulo.Controls.Add(this.icbMaximizar);
            this.panelBarraTitulo.Controls.Add(this.icbCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(850, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // icbRestaurar
            // 
            this.icbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbRestaurar.FlatAppearance.BorderSize = 0;
            this.icbRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.icbRestaurar.IconColor = System.Drawing.Color.White;
            this.icbRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbRestaurar.IconSize = 36;
            this.icbRestaurar.Location = new System.Drawing.Point(778, 0);
            this.icbRestaurar.Name = "icbRestaurar";
            this.icbRestaurar.Size = new System.Drawing.Size(36, 40);
            this.icbRestaurar.TabIndex = 5;
            this.icbRestaurar.UseVisualStyleBackColor = true;
            this.icbRestaurar.Visible = false;
            this.icbRestaurar.Click += new System.EventHandler(this.icbRestaurar_Click);
            // 
            // icbMinimizar
            // 
            this.icbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbMinimizar.FlatAppearance.BorderSize = 0;
            this.icbMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icbMinimizar.IconColor = System.Drawing.Color.White;
            this.icbMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbMinimizar.IconSize = 36;
            this.icbMinimizar.Location = new System.Drawing.Point(746, 0);
            this.icbMinimizar.Name = "icbMinimizar";
            this.icbMinimizar.Size = new System.Drawing.Size(36, 40);
            this.icbMinimizar.TabIndex = 4;
            this.icbMinimizar.UseVisualStyleBackColor = true;
            this.icbMinimizar.Click += new System.EventHandler(this.icbMinimizar_Click);
            // 
            // icbMaximizar
            // 
            this.icbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbMaximizar.FlatAppearance.BorderSize = 0;
            this.icbMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icbMaximizar.IconColor = System.Drawing.Color.White;
            this.icbMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbMaximizar.IconSize = 36;
            this.icbMaximizar.Location = new System.Drawing.Point(778, 0);
            this.icbMaximizar.Name = "icbMaximizar";
            this.icbMaximizar.Size = new System.Drawing.Size(36, 40);
            this.icbMaximizar.TabIndex = 3;
            this.icbMaximizar.UseVisualStyleBackColor = true;
            this.icbMaximizar.Click += new System.EventHandler(this.icbMaximizar_Click);
            // 
            // icbCerrar
            // 
            this.icbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbCerrar.FlatAppearance.BorderSize = 0;
            this.icbCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.icbCerrar.IconColor = System.Drawing.Color.White;
            this.icbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbCerrar.IconSize = 36;
            this.icbCerrar.Location = new System.Drawing.Point(811, 0);
            this.icbCerrar.Name = "icbCerrar";
            this.icbCerrar.Size = new System.Drawing.Size(36, 40);
            this.icbCerrar.TabIndex = 2;
            this.icbCerrar.UseVisualStyleBackColor = true;
            this.icbCerrar.Click += new System.EventHandler(this.icbCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}