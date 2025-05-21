namespace SAESoft.Incentivo
{
    partial class frmMenuIncentivo
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
            ibtnCerrar = new FontAwesome.Sharp.IconButton();
            ibtnSuspension = new FontAwesome.Sharp.IconButton();
            ibtnEvaluar = new FontAwesome.Sharp.IconButton();
            ibtnAsistencia = new FontAwesome.Sharp.IconButton();
            ibtnReporte = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            ibtnPersonal = new FontAwesome.Sharp.IconButton();
            ibtnDashboard = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            ibtnDeptos = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormularios
            // 
            panelFormularios.BackgroundImageLayout = ImageLayout.Zoom;
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(220, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(580, 565);
            panelFormularios.TabIndex = 6;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(ibtnDeptos);
            panelMenu.Controls.Add(ibtnCerrar);
            panelMenu.Controls.Add(ibtnSuspension);
            panelMenu.Controls.Add(ibtnEvaluar);
            panelMenu.Controls.Add(ibtnAsistencia);
            panelMenu.Controls.Add(ibtnReporte);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(ibtnPersonal);
            panelMenu.Controls.Add(ibtnDashboard);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(ibtnSalir);
            panelMenu.Controls.Add(label1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 565);
            panelMenu.TabIndex = 5;
            // 
            // ibtnCerrar
            // 
            ibtnCerrar.FlatAppearance.BorderSize = 0;
            ibtnCerrar.FlatStyle = FlatStyle.Flat;
            ibtnCerrar.Font = new Font("Century Gothic", 12F);
            ibtnCerrar.ForeColor = Color.White;
            ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            ibtnCerrar.IconColor = Color.White;
            ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCerrar.IconSize = 24;
            ibtnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnCerrar.Location = new Point(5, 306);
            ibtnCerrar.Name = "ibtnCerrar";
            ibtnCerrar.Size = new Size(211, 43);
            ibtnCerrar.TabIndex = 16;
            ibtnCerrar.Text = "Cerrar Evaluación";
            ibtnCerrar.UseVisualStyleBackColor = true;
            ibtnCerrar.Click += iconButton2_Click_2;
            // 
            // ibtnSuspension
            // 
            ibtnSuspension.FlatAppearance.BorderSize = 0;
            ibtnSuspension.FlatStyle = FlatStyle.Flat;
            ibtnSuspension.Font = new Font("Century Gothic", 12F);
            ibtnSuspension.ForeColor = Color.White;
            ibtnSuspension.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            ibtnSuspension.IconColor = Color.White;
            ibtnSuspension.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSuspension.IconSize = 24;
            ibtnSuspension.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnSuspension.Location = new Point(3, 182);
            ibtnSuspension.Name = "ibtnSuspension";
            ibtnSuspension.Size = new Size(211, 43);
            ibtnSuspension.TabIndex = 15;
            ibtnSuspension.Text = "Suspensiones";
            ibtnSuspension.UseVisualStyleBackColor = true;
            ibtnSuspension.Click += iconButton2_Click_1;
            // 
            // ibtnEvaluar
            // 
            ibtnEvaluar.FlatAppearance.BorderSize = 0;
            ibtnEvaluar.FlatStyle = FlatStyle.Flat;
            ibtnEvaluar.Font = new Font("Century Gothic", 12F);
            ibtnEvaluar.ForeColor = Color.White;
            ibtnEvaluar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            ibtnEvaluar.IconColor = Color.White;
            ibtnEvaluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEvaluar.IconSize = 24;
            ibtnEvaluar.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnEvaluar.Location = new Point(3, 263);
            ibtnEvaluar.Name = "ibtnEvaluar";
            ibtnEvaluar.Size = new Size(211, 43);
            ibtnEvaluar.TabIndex = 9;
            ibtnEvaluar.Text = "Evaluar Personal";
            ibtnEvaluar.UseVisualStyleBackColor = true;
            ibtnEvaluar.Click += iconButton2_Click;
            // 
            // ibtnAsistencia
            // 
            ibtnAsistencia.FlatAppearance.BorderSize = 0;
            ibtnAsistencia.FlatStyle = FlatStyle.Flat;
            ibtnAsistencia.Font = new Font("Century Gothic", 12F);
            ibtnAsistencia.ForeColor = Color.White;
            ibtnAsistencia.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            ibtnAsistencia.IconColor = Color.White;
            ibtnAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAsistencia.IconSize = 24;
            ibtnAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnAsistencia.Location = new Point(3, 225);
            ibtnAsistencia.Name = "ibtnAsistencia";
            ibtnAsistencia.Size = new Size(211, 38);
            ibtnAsistencia.TabIndex = 14;
            ibtnAsistencia.Text = "Asistencia";
            ibtnAsistencia.UseVisualStyleBackColor = true;
            ibtnAsistencia.Click += ibtnAsistencia_Click;
            // 
            // ibtnReporte
            // 
            ibtnReporte.FlatAppearance.BorderSize = 0;
            ibtnReporte.FlatStyle = FlatStyle.Flat;
            ibtnReporte.Font = new Font("Century Gothic", 12F);
            ibtnReporte.ForeColor = Color.White;
            ibtnReporte.IconChar = FontAwesome.Sharp.IconChar.Print;
            ibtnReporte.IconColor = Color.White;
            ibtnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnReporte.IconSize = 24;
            ibtnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnReporte.Location = new Point(5, 381);
            ibtnReporte.Name = "ibtnReporte";
            ibtnReporte.Size = new Size(197, 43);
            ibtnReporte.TabIndex = 13;
            ibtnReporte.Text = "Reportes";
            ibtnReporte.UseVisualStyleBackColor = true;
            ibtnReporte.Click += ibtnReporte_Click;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 12F);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 24;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 493);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(197, 29);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Salir";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // ibtnPersonal
            // 
            ibtnPersonal.FlatAppearance.BorderSize = 0;
            ibtnPersonal.FlatStyle = FlatStyle.Flat;
            ibtnPersonal.Font = new Font("Century Gothic", 12F);
            ibtnPersonal.ForeColor = Color.White;
            ibtnPersonal.IconChar = FontAwesome.Sharp.IconChar.Users;
            ibtnPersonal.IconColor = Color.White;
            ibtnPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnPersonal.IconSize = 24;
            ibtnPersonal.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnPersonal.Location = new Point(3, 96);
            ibtnPersonal.Name = "ibtnPersonal";
            ibtnPersonal.Size = new Size(211, 43);
            ibtnPersonal.TabIndex = 8;
            ibtnPersonal.Text = "Personal";
            ibtnPersonal.UseVisualStyleBackColor = true;
            ibtnPersonal.Click += ibtnPersonal_Click;
            // 
            // ibtnDashboard
            // 
            ibtnDashboard.FlatAppearance.BorderSize = 0;
            ibtnDashboard.FlatStyle = FlatStyle.Flat;
            ibtnDashboard.Font = new Font("Century Gothic", 12F);
            ibtnDashboard.ForeColor = Color.White;
            ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            ibtnDashboard.IconColor = Color.White;
            ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnDashboard.IconSize = 24;
            ibtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnDashboard.Location = new Point(3, 53);
            ibtnDashboard.Name = "ibtnDashboard";
            ibtnDashboard.Size = new Size(211, 43);
            ibtnDashboard.TabIndex = 7;
            ibtnDashboard.Text = "Dashboard";
            ibtnDashboard.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 12F);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(3, 1330);
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
            ibtnSalir.Font = new Font("Century Gothic", 12F);
            ibtnSalir.ForeColor = Color.White;
            ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            ibtnSalir.IconColor = Color.White;
            ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSalir.IconSize = 32;
            ibtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnSalir.Location = new Point(3, 1662);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(197, 43);
            ibtnSalir.TabIndex = 3;
            ibtnSalir.Text = "Salir";
            ibtnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-3, 11);
            label1.Name = "label1";
            label1.Size = new Size(200, 43);
            label1.TabIndex = 2;
            label1.Text = "Incentivos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ibtnDeptos
            // 
            ibtnDeptos.FlatAppearance.BorderSize = 0;
            ibtnDeptos.FlatStyle = FlatStyle.Flat;
            ibtnDeptos.Font = new Font("Century Gothic", 12F);
            ibtnDeptos.ForeColor = Color.White;
            ibtnDeptos.IconChar = FontAwesome.Sharp.IconChar.Building;
            ibtnDeptos.IconColor = Color.White;
            ibtnDeptos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnDeptos.IconSize = 24;
            ibtnDeptos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnDeptos.Location = new Point(3, 139);
            ibtnDeptos.Name = "ibtnDeptos";
            ibtnDeptos.Size = new Size(211, 43);
            ibtnDeptos.TabIndex = 17;
            ibtnDeptos.Text = "Departamentos";
            ibtnDeptos.UseVisualStyleBackColor = true;
            ibtnDeptos.Click += ibtnDeptos_Click;
            // 
            // frmMenuIncentivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Name = "frmMenuIncentivo";
            Text = "frmMenuIncentivo";
            Load += frmMenuIncentivo_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormularios;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnReporte;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ibtnPersonal;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnAsistencia;
        private FontAwesome.Sharp.IconButton ibtnEvaluar;
        private FontAwesome.Sharp.IconButton ibtnSuspension;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton ibtnDeptos;
    }
}