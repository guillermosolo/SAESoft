namespace SAESoft.Importaciones
{
    partial class frmMenuImportaciones
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
            panelMenu = new Panel();
            ibtnReporte = new FontAwesome.Sharp.IconButton();
            ibtnExterno = new FontAwesome.Sharp.IconButton();
            ibtnAereo = new FontAwesome.Sharp.IconButton();
            ibtnMaritimo = new FontAwesome.Sharp.IconButton();
            ibtnDashboard = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelFormularios = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(ibtnReporte);
            panelMenu.Controls.Add(ibtnExterno);
            panelMenu.Controls.Add(ibtnAereo);
            panelMenu.Controls.Add(ibtnMaritimo);
            panelMenu.Controls.Add(ibtnDashboard);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(ibtnSalir);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 1;
            // 
            // ibtnReporte
            // 
            ibtnReporte.FlatAppearance.BorderSize = 0;
            ibtnReporte.FlatStyle = FlatStyle.Flat;
            ibtnReporte.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnReporte.ForeColor = Color.White;
            ibtnReporte.IconChar = FontAwesome.Sharp.IconChar.Print;
            ibtnReporte.IconColor = Color.White;
            ibtnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnReporte.IconSize = 24;
            ibtnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnReporte.Location = new Point(3, 223);
            ibtnReporte.Name = "ibtnReporte";
            ibtnReporte.Size = new Size(197, 43);
            ibtnReporte.TabIndex = 11;
            ibtnReporte.Text = "Reportes";
            ibtnReporte.UseVisualStyleBackColor = true;
            ibtnReporte.Click += icbReporte_Click;
            // 
            // ibtnExterno
            // 
            ibtnExterno.FlatAppearance.BorderSize = 0;
            ibtnExterno.FlatStyle = FlatStyle.Flat;
            ibtnExterno.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnExterno.ForeColor = Color.White;
            ibtnExterno.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            ibtnExterno.IconColor = Color.White;
            ibtnExterno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnExterno.IconSize = 24;
            ibtnExterno.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnExterno.Location = new Point(2, 178);
            ibtnExterno.Name = "ibtnExterno";
            ibtnExterno.Size = new Size(197, 56);
            ibtnExterno.TabIndex = 10;
            ibtnExterno.Text = "     Agente Externo";
            ibtnExterno.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnExterno.UseVisualStyleBackColor = true;
            // 
            // ibtnAereo
            // 
            ibtnAereo.FlatAppearance.BorderSize = 0;
            ibtnAereo.FlatStyle = FlatStyle.Flat;
            ibtnAereo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnAereo.ForeColor = Color.White;
            ibtnAereo.IconChar = FontAwesome.Sharp.IconChar.Plane;
            ibtnAereo.IconColor = Color.White;
            ibtnAereo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAereo.IconSize = 24;
            ibtnAereo.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnAereo.Location = new Point(0, 128);
            ibtnAereo.Name = "ibtnAereo";
            ibtnAereo.Size = new Size(197, 56);
            ibtnAereo.TabIndex = 9;
            ibtnAereo.Text = "Aéreo  y\r\nTerrestre";
            ibtnAereo.UseVisualStyleBackColor = true;
            ibtnAereo.EnabledChanged += ibtnAereo_EnabledChanged;
            ibtnAereo.Click += ibtnAereo_Click;
            // 
            // ibtnMaritimo
            // 
            ibtnMaritimo.FlatAppearance.BorderSize = 0;
            ibtnMaritimo.FlatStyle = FlatStyle.Flat;
            ibtnMaritimo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnMaritimo.ForeColor = Color.White;
            ibtnMaritimo.IconChar = FontAwesome.Sharp.IconChar.Ship;
            ibtnMaritimo.IconColor = Color.White;
            ibtnMaritimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnMaritimo.IconSize = 24;
            ibtnMaritimo.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnMaritimo.Location = new Point(3, 91);
            ibtnMaritimo.Name = "ibtnMaritimo";
            ibtnMaritimo.Size = new Size(197, 43);
            ibtnMaritimo.TabIndex = 8;
            ibtnMaritimo.Text = "Marítimo";
            ibtnMaritimo.UseVisualStyleBackColor = true;
            ibtnMaritimo.EnabledChanged += ibtnMaritimo_EnabledChanged;
            ibtnMaritimo.Click += ibtnMaritimo_Click;
            // 
            // ibtnDashboard
            // 
            ibtnDashboard.FlatAppearance.BorderSize = 0;
            ibtnDashboard.FlatStyle = FlatStyle.Flat;
            ibtnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnDashboard.ForeColor = Color.White;
            ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            ibtnDashboard.IconColor = Color.White;
            ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnDashboard.IconSize = 24;
            ibtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnDashboard.Location = new Point(3, 53);
            ibtnDashboard.Name = "ibtnDashboard";
            ibtnDashboard.Size = new Size(197, 43);
            ibtnDashboard.TabIndex = 7;
            ibtnDashboard.Text = "Dashboard";
            ibtnDashboard.UseVisualStyleBackColor = true;
            ibtnDashboard.EnabledChanged += ibtnDashboard_EnabledChanged;
            ibtnDashboard.Click += ibtnDashboard_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 395);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(197, 29);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Salir";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // ibtnSalir
            // 
            ibtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ibtnSalir.FlatAppearance.BorderSize = 0;
            ibtnSalir.FlatStyle = FlatStyle.Flat;
            ibtnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnSalir.ForeColor = Color.White;
            ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            ibtnSalir.IconColor = Color.White;
            ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSalir.IconSize = 32;
            ibtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnSalir.Location = new Point(3, 727);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(197, 43);
            ibtnSalir.TabIndex = 3;
            ibtnSalir.Text = "Salir";
            ibtnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 11);
            label1.Name = "label1";
            label1.Size = new Size(200, 43);
            label1.TabIndex = 2;
            label1.Text = "Importaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFormularios
            // 
            panelFormularios.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(600, 450);
            panelFormularios.TabIndex = 2;
            // 
            // frmMenuImportaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Name = "frmMenuImportaciones";
            Text = "frmMenuImportaciones";
            Load += frmMenuImportaciones_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private Panel panelFormularios;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton ibtnAereo;
        private FontAwesome.Sharp.IconButton ibtnMaritimo;
        private FontAwesome.Sharp.IconButton ibtnExterno;
        private FontAwesome.Sharp.IconButton ibtnReporte;
    }
}