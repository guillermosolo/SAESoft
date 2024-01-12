namespace SAESoft.Exportaciones
{
    partial class frmMenuExportaciones
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
            panelFormularios = new Panel();
            panelMenu = new Panel();
            ibtnLocal = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ibtnFacturas = new FontAwesome.Sharp.IconButton();
            ibtnDashboard = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ibtnReporte = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormularios
            // 
            panelFormularios.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(600, 450);
            panelFormularios.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(ibtnReporte);
            panelMenu.Controls.Add(ibtnLocal);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(ibtnFacturas);
            panelMenu.Controls.Add(ibtnDashboard);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(ibtnSalir);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 3;
            // 
            // ibtnLocal
            // 
            ibtnLocal.FlatAppearance.BorderSize = 0;
            ibtnLocal.FlatStyle = FlatStyle.Flat;
            ibtnLocal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnLocal.ForeColor = Color.White;
            ibtnLocal.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            ibtnLocal.IconColor = Color.White;
            ibtnLocal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnLocal.IconSize = 24;
            ibtnLocal.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnLocal.Location = new Point(3, 127);
            ibtnLocal.Name = "ibtnLocal";
            ibtnLocal.Size = new Size(197, 43);
            ibtnLocal.TabIndex = 10;
            ibtnLocal.Text = "Facturas Locales";
            ibtnLocal.UseVisualStyleBackColor = true;
            ibtnLocal.Click += ibtnLocal_Click;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 24;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(3, 409);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(197, 29);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Salir";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += ibtnSalir_Click;
            // 
            // ibtnFacturas
            // 
            ibtnFacturas.FlatAppearance.BorderSize = 0;
            ibtnFacturas.FlatStyle = FlatStyle.Flat;
            ibtnFacturas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnFacturas.ForeColor = Color.White;
            ibtnFacturas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            ibtnFacturas.IconColor = Color.White;
            ibtnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnFacturas.IconSize = 24;
            ibtnFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnFacturas.Location = new Point(3, 90);
            ibtnFacturas.Name = "ibtnFacturas";
            ibtnFacturas.Size = new Size(197, 43);
            ibtnFacturas.TabIndex = 8;
            ibtnFacturas.Text = "Facturas Export";
            ibtnFacturas.UseVisualStyleBackColor = true;
            ibtnFacturas.Click += ibtnFacturas_Click;
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
            iconButton1.Location = new Point(3, 745);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(197, 29);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Salir";
            iconButton1.UseVisualStyleBackColor = true;
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
            ibtnSalir.Location = new Point(3, 1077);
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
            label1.Text = "Exportaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            ibtnReporte.Location = new Point(2, 204);
            ibtnReporte.Name = "ibtnReporte";
            ibtnReporte.Size = new Size(197, 43);
            ibtnReporte.TabIndex = 13;
            ibtnReporte.Text = "Reportes";
            ibtnReporte.UseVisualStyleBackColor = true;
            ibtnReporte.Click += ibtnReporte_Click;
            // 
            // frmMenuExportaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Name = "frmMenuExportaciones";
            Text = "frmMenuExportaciones";
            Load += frmMenuExportaciones_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormularios;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnFacturas;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibtnLocal;
        private FontAwesome.Sharp.IconButton ibtnReporte;
    }
}