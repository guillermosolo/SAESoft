namespace SAESoft.Administracion
{
    partial class frmMenuAdmon
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
            ibtnPersonal = new FontAwesome.Sharp.IconButton();
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
            panelMenu.Controls.Add(ibtnPersonal);
            panelMenu.Controls.Add(ibtnDashboard);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(ibtnSalir);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 538);
            panelMenu.TabIndex = 2;
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
            ibtnReporte.Location = new Point(2, 248);
            ibtnReporte.Name = "ibtnReporte";
            ibtnReporte.Size = new Size(197, 43);
            ibtnReporte.TabIndex = 12;
            ibtnReporte.Text = "Reportes";
            ibtnReporte.UseVisualStyleBackColor = true;
            ibtnReporte.Click += ibtnReporte_Click;
            // 
            // ibtnPersonal
            // 
            ibtnPersonal.FlatAppearance.BorderSize = 0;
            ibtnPersonal.FlatStyle = FlatStyle.Flat;
            ibtnPersonal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnPersonal.ForeColor = Color.White;
            ibtnPersonal.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            ibtnPersonal.IconColor = Color.White;
            ibtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnPersonal.IconSize = 24;
            ibtnPersonal.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnPersonal.Location = new Point(3, 91);
            ibtnPersonal.Name = "ibtnPersonal";
            ibtnPersonal.Size = new Size(197, 43);
            ibtnPersonal.TabIndex = 8;
            ibtnPersonal.Text = "Personal";
            ibtnPersonal.UseVisualStyleBackColor = true;
            ibtnPersonal.Click += ibtnPersonal_Click;
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
            iconButton1.Location = new Point(3, 538);
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
            ibtnSalir.Location = new Point(0, 456);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(197, 43);
            ibtnSalir.TabIndex = 3;
            ibtnSalir.Text = "Salir";
            ibtnSalir.UseVisualStyleBackColor = true;
            ibtnSalir.Click += ibtnSalir_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 11);
            label1.Name = "label1";
            label1.Size = new Size(200, 43);
            label1.TabIndex = 2;
            label1.Text = "Administración";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFormularios
            // 
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(630, 538);
            panelFormularios.TabIndex = 3;
            // 
            // frmMenuAdmon
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 538);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmMenuAdmon";
            Text = "frmMenuAdmon";
            Load += frmMenuAdmon_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnPersonal;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnReporte;
        private Panel panelFormularios;
    }
}