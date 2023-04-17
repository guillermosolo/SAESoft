namespace SAESoft.AdministracionSistema
{
    partial class frmMenuAdmin
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
            panelImportaciones = new Panel();
            ibtnAgentes = new FontAwesome.Sharp.IconButton();
            ibtnTerminales = new FontAwesome.Sharp.IconButton();
            ibtnAduanas = new FontAwesome.Sharp.IconButton();
            ibtnShippers = new FontAwesome.Sharp.IconButton();
            ibtnRevisiones = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            ibtnImportaciones = new FontAwesome.Sharp.IconButton();
            panelComunes = new Panel();
            ibtnGrupos = new FontAwesome.Sharp.IconButton();
            ibtnNombres = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            ibtnComunes = new FontAwesome.Sharp.IconButton();
            panelSeguridad = new Panel();
            ibtnModulos = new FontAwesome.Sharp.IconButton();
            ibtnPermisos = new FontAwesome.Sharp.IconButton();
            ibtnRoles = new FontAwesome.Sharp.IconButton();
            ibtnUsuarios = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            ibtnSeguridad = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            panelFormularios = new Panel();
            panelMenu.SuspendLayout();
            panelImportaciones.SuspendLayout();
            panel4.SuspendLayout();
            panelComunes.SuspendLayout();
            panel3.SuspendLayout();
            panelSeguridad.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(panelImportaciones);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panelComunes);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(panelSeguridad);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(ibtnSalir);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 597);
            panelMenu.TabIndex = 0;
            // 
            // panelImportaciones
            // 
            panelImportaciones.BackColor = Color.FromArgb(0, 122, 204);
            panelImportaciones.Controls.Add(ibtnAgentes);
            panelImportaciones.Controls.Add(ibtnTerminales);
            panelImportaciones.Controls.Add(ibtnAduanas);
            panelImportaciones.Controls.Add(ibtnShippers);
            panelImportaciones.Controls.Add(ibtnRevisiones);
            panelImportaciones.Dock = DockStyle.Top;
            panelImportaciones.Location = new Point(0, 266);
            panelImportaciones.Name = "panelImportaciones";
            panelImportaciones.Size = new Size(200, 154);
            panelImportaciones.TabIndex = 11;
            // 
            // ibtnAgentes
            // 
            ibtnAgentes.FlatAppearance.BorderSize = 0;
            ibtnAgentes.FlatStyle = FlatStyle.Flat;
            ibtnAgentes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnAgentes.ForeColor = Color.White;
            ibtnAgentes.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ibtnAgentes.IconColor = Color.White;
            ibtnAgentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAgentes.IconSize = 24;
            ibtnAgentes.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnAgentes.Location = new Point(6, 115);
            ibtnAgentes.Name = "ibtnAgentes";
            ibtnAgentes.Size = new Size(197, 35);
            ibtnAgentes.TabIndex = 12;
            ibtnAgentes.Text = "Agentes";
            ibtnAgentes.UseVisualStyleBackColor = true;
            ibtnAgentes.Click += ibtnAgentes_Click;
            // 
            // ibtnTerminales
            // 
            ibtnTerminales.FlatAppearance.BorderSize = 0;
            ibtnTerminales.FlatStyle = FlatStyle.Flat;
            ibtnTerminales.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnTerminales.ForeColor = Color.White;
            ibtnTerminales.IconChar = FontAwesome.Sharp.IconChar.BuildingLock;
            ibtnTerminales.IconColor = Color.White;
            ibtnTerminales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnTerminales.IconSize = 24;
            ibtnTerminales.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnTerminales.Location = new Point(5, 87);
            ibtnTerminales.Name = "ibtnTerminales";
            ibtnTerminales.Size = new Size(197, 35);
            ibtnTerminales.TabIndex = 11;
            ibtnTerminales.Text = "Terminales";
            ibtnTerminales.UseVisualStyleBackColor = true;
            ibtnTerminales.Click += ibtnTerminales_Click;
            // 
            // ibtnAduanas
            // 
            ibtnAduanas.FlatAppearance.BorderSize = 0;
            ibtnAduanas.FlatStyle = FlatStyle.Flat;
            ibtnAduanas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnAduanas.ForeColor = Color.White;
            ibtnAduanas.IconChar = FontAwesome.Sharp.IconChar.Building;
            ibtnAduanas.IconColor = Color.White;
            ibtnAduanas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAduanas.IconSize = 24;
            ibtnAduanas.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnAduanas.Location = new Point(5, 58);
            ibtnAduanas.Name = "ibtnAduanas";
            ibtnAduanas.Size = new Size(197, 35);
            ibtnAduanas.TabIndex = 10;
            ibtnAduanas.Text = "Aduanas";
            ibtnAduanas.UseVisualStyleBackColor = true;
            ibtnAduanas.Click += ibtnAduanas_Click;
            // 
            // ibtnShippers
            // 
            ibtnShippers.FlatAppearance.BorderSize = 0;
            ibtnShippers.FlatStyle = FlatStyle.Flat;
            ibtnShippers.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnShippers.ForeColor = Color.White;
            ibtnShippers.IconChar = FontAwesome.Sharp.IconChar.Ship;
            ibtnShippers.IconColor = Color.White;
            ibtnShippers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnShippers.IconSize = 24;
            ibtnShippers.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnShippers.Location = new Point(5, 30);
            ibtnShippers.Name = "ibtnShippers";
            ibtnShippers.Size = new Size(197, 35);
            ibtnShippers.TabIndex = 9;
            ibtnShippers.Text = "Shippers";
            ibtnShippers.UseVisualStyleBackColor = true;
            ibtnShippers.Click += ibtnShippers_Click;
            // 
            // ibtnRevisiones
            // 
            ibtnRevisiones.FlatAppearance.BorderSize = 0;
            ibtnRevisiones.FlatStyle = FlatStyle.Flat;
            ibtnRevisiones.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnRevisiones.ForeColor = Color.White;
            ibtnRevisiones.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            ibtnRevisiones.IconColor = Color.White;
            ibtnRevisiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRevisiones.IconSize = 24;
            ibtnRevisiones.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnRevisiones.Location = new Point(6, 3);
            ibtnRevisiones.Name = "ibtnRevisiones";
            ibtnRevisiones.Size = new Size(197, 32);
            ibtnRevisiones.TabIndex = 8;
            ibtnRevisiones.Text = "Revisiones";
            ibtnRevisiones.UseVisualStyleBackColor = true;
            ibtnRevisiones.Click += ibtnRevisiones_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 122, 204);
            panel4.Controls.Add(ibtnImportaciones);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 220);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 46);
            panel4.TabIndex = 10;
            // 
            // ibtnImportaciones
            // 
            ibtnImportaciones.FlatAppearance.BorderSize = 0;
            ibtnImportaciones.FlatStyle = FlatStyle.Flat;
            ibtnImportaciones.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnImportaciones.ForeColor = Color.White;
            ibtnImportaciones.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            ibtnImportaciones.IconColor = Color.White;
            ibtnImportaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnImportaciones.IconSize = 24;
            ibtnImportaciones.ImageAlign = ContentAlignment.MiddleRight;
            ibtnImportaciones.Location = new Point(0, 3);
            ibtnImportaciones.Name = "ibtnImportaciones";
            ibtnImportaciones.Size = new Size(197, 40);
            ibtnImportaciones.TabIndex = 7;
            ibtnImportaciones.Text = "Importaciones";
            ibtnImportaciones.UseVisualStyleBackColor = true;
            ibtnImportaciones.Click += ibtnImportaciones_Click;
            // 
            // panelComunes
            // 
            panelComunes.BackColor = Color.FromArgb(0, 122, 204);
            panelComunes.Controls.Add(ibtnGrupos);
            panelComunes.Controls.Add(ibtnNombres);
            panelComunes.Dock = DockStyle.Top;
            panelComunes.Location = new Point(0, 197);
            panelComunes.Name = "panelComunes";
            panelComunes.Size = new Size(200, 23);
            panelComunes.TabIndex = 9;
            // 
            // ibtnGrupos
            // 
            ibtnGrupos.FlatAppearance.BorderSize = 0;
            ibtnGrupos.FlatStyle = FlatStyle.Flat;
            ibtnGrupos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnGrupos.ForeColor = Color.White;
            ibtnGrupos.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            ibtnGrupos.IconColor = Color.White;
            ibtnGrupos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGrupos.IconSize = 24;
            ibtnGrupos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnGrupos.Location = new Point(5, 32);
            ibtnGrupos.Name = "ibtnGrupos";
            ibtnGrupos.Size = new Size(197, 35);
            ibtnGrupos.TabIndex = 9;
            ibtnGrupos.Text = "Grupos";
            ibtnGrupos.UseVisualStyleBackColor = true;
            ibtnGrupos.EnabledChanged += ibtnGrupos_EnabledChanged;
            ibtnGrupos.Click += ibtnGrupos_Click;
            // 
            // ibtnNombres
            // 
            ibtnNombres.FlatAppearance.BorderSize = 0;
            ibtnNombres.FlatStyle = FlatStyle.Flat;
            ibtnNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnNombres.ForeColor = Color.White;
            ibtnNombres.IconChar = FontAwesome.Sharp.IconChar.N;
            ibtnNombres.IconColor = Color.White;
            ibtnNombres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnNombres.IconSize = 24;
            ibtnNombres.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnNombres.Location = new Point(6, 3);
            ibtnNombres.Name = "ibtnNombres";
            ibtnNombres.Size = new Size(197, 32);
            ibtnNombres.TabIndex = 8;
            ibtnNombres.Text = "Nombres";
            ibtnNombres.UseVisualStyleBackColor = true;
            ibtnNombres.EnabledChanged += ibtnNombres_EnabledChanged;
            ibtnNombres.Click += ibtnNombres_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 122, 204);
            panel3.Controls.Add(ibtnComunes);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 68);
            panel3.TabIndex = 8;
            // 
            // ibtnComunes
            // 
            ibtnComunes.FlatAppearance.BorderSize = 0;
            ibtnComunes.FlatStyle = FlatStyle.Flat;
            ibtnComunes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnComunes.ForeColor = Color.White;
            ibtnComunes.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            ibtnComunes.IconColor = Color.White;
            ibtnComunes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnComunes.IconSize = 24;
            ibtnComunes.ImageAlign = ContentAlignment.MiddleRight;
            ibtnComunes.Location = new Point(0, 3);
            ibtnComunes.Name = "ibtnComunes";
            ibtnComunes.Size = new Size(197, 59);
            ibtnComunes.TabIndex = 7;
            ibtnComunes.Text = "Elementos Comunes";
            ibtnComunes.UseVisualStyleBackColor = true;
            ibtnComunes.Click += ibtnComunes_Click;
            // 
            // panelSeguridad
            // 
            panelSeguridad.BackColor = Color.FromArgb(0, 122, 204);
            panelSeguridad.Controls.Add(ibtnModulos);
            panelSeguridad.Controls.Add(ibtnPermisos);
            panelSeguridad.Controls.Add(ibtnRoles);
            panelSeguridad.Controls.Add(ibtnUsuarios);
            panelSeguridad.Dock = DockStyle.Top;
            panelSeguridad.Location = new Point(0, 112);
            panelSeguridad.Name = "panelSeguridad";
            panelSeguridad.Size = new Size(200, 17);
            panelSeguridad.TabIndex = 0;
            // 
            // ibtnModulos
            // 
            ibtnModulos.FlatAppearance.BorderSize = 0;
            ibtnModulos.FlatStyle = FlatStyle.Flat;
            ibtnModulos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnModulos.ForeColor = Color.White;
            ibtnModulos.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            ibtnModulos.IconColor = Color.White;
            ibtnModulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnModulos.IconSize = 24;
            ibtnModulos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnModulos.Location = new Point(0, 96);
            ibtnModulos.Name = "ibtnModulos";
            ibtnModulos.Size = new Size(197, 33);
            ibtnModulos.TabIndex = 9;
            ibtnModulos.Text = "Módulos";
            ibtnModulos.UseVisualStyleBackColor = true;
            ibtnModulos.EnabledChanged += ibtnModulos_EnabledChanged;
            ibtnModulos.Click += ibtnModulos_Click;
            // 
            // ibtnPermisos
            // 
            ibtnPermisos.FlatAppearance.BorderSize = 0;
            ibtnPermisos.FlatStyle = FlatStyle.Flat;
            ibtnPermisos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnPermisos.ForeColor = Color.White;
            ibtnPermisos.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            ibtnPermisos.IconColor = Color.White;
            ibtnPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnPermisos.IconSize = 24;
            ibtnPermisos.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnPermisos.Location = new Point(0, 67);
            ibtnPermisos.Name = "ibtnPermisos";
            ibtnPermisos.Size = new Size(197, 32);
            ibtnPermisos.TabIndex = 8;
            ibtnPermisos.Text = "Permisos";
            ibtnPermisos.UseVisualStyleBackColor = true;
            ibtnPermisos.EnabledChanged += ibtnPermisos_EnabledChanged;
            ibtnPermisos.Click += ibtnRolPermiso_Click;
            // 
            // ibtnRoles
            // 
            ibtnRoles.FlatAppearance.BorderSize = 0;
            ibtnRoles.FlatStyle = FlatStyle.Flat;
            ibtnRoles.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnRoles.ForeColor = Color.White;
            ibtnRoles.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            ibtnRoles.IconColor = Color.White;
            ibtnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRoles.IconSize = 24;
            ibtnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnRoles.Location = new Point(0, 36);
            ibtnRoles.Name = "ibtnRoles";
            ibtnRoles.Size = new Size(197, 33);
            ibtnRoles.TabIndex = 7;
            ibtnRoles.Text = "Roles";
            ibtnRoles.UseVisualStyleBackColor = true;
            ibtnRoles.EnabledChanged += ibtnRoles_EnabledChanged;
            ibtnRoles.Click += ibtnRoles_Click;
            // 
            // ibtnUsuarios
            // 
            ibtnUsuarios.FlatAppearance.BorderSize = 0;
            ibtnUsuarios.FlatStyle = FlatStyle.Flat;
            ibtnUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnUsuarios.ForeColor = Color.White;
            ibtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ibtnUsuarios.IconColor = Color.White;
            ibtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnUsuarios.IconSize = 24;
            ibtnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnUsuarios.Location = new Point(0, 3);
            ibtnUsuarios.Name = "ibtnUsuarios";
            ibtnUsuarios.Size = new Size(197, 37);
            ibtnUsuarios.TabIndex = 6;
            ibtnUsuarios.Text = "Usuarios";
            ibtnUsuarios.UseVisualStyleBackColor = true;
            ibtnUsuarios.EnabledChanged += ibtnUsuarios_EnabledChanged;
            ibtnUsuarios.Click += ibtnUsuarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(ibtnSeguridad);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 44);
            panel2.TabIndex = 2;
            // 
            // ibtnSeguridad
            // 
            ibtnSeguridad.FlatAppearance.BorderSize = 0;
            ibtnSeguridad.FlatStyle = FlatStyle.Flat;
            ibtnSeguridad.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnSeguridad.ForeColor = Color.White;
            ibtnSeguridad.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            ibtnSeguridad.IconColor = Color.White;
            ibtnSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSeguridad.IconSize = 24;
            ibtnSeguridad.ImageAlign = ContentAlignment.MiddleRight;
            ibtnSeguridad.Location = new Point(0, 3);
            ibtnSeguridad.Name = "ibtnSeguridad";
            ibtnSeguridad.Size = new Size(197, 37);
            ibtnSeguridad.TabIndex = 7;
            ibtnSeguridad.Text = "Seguridad";
            ibtnSeguridad.UseVisualStyleBackColor = true;
            ibtnSeguridad.Click += ibtnSeguridad_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 68);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 53);
            label1.TabIndex = 3;
            label1.Text = "Administración del Sistema";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            ibtnSalir.IconSize = 24;
            ibtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnSalir.Location = new Point(3, 524);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(197, 43);
            ibtnSalir.TabIndex = 3;
            ibtnSalir.Text = "Salir";
            ibtnSalir.UseVisualStyleBackColor = true;
            ibtnSalir.Click += iconButton1_Click;
            // 
            // panelFormularios
            // 
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(200, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(600, 597);
            panelFormularios.TabIndex = 1;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(panelFormularios);
            Controls.Add(panelMenu);
            Name = "frmMenuAdmin";
            Text = "frmMenuAdmin";
            Load += frmMenuAdmin_Load;
            panelMenu.ResumeLayout(false);
            panelImportaciones.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelComunes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelSeguridad.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelFormularios;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Panel panelSeguridad;
        private FontAwesome.Sharp.IconButton ibtnModulos;
        private FontAwesome.Sharp.IconButton ibtnPermisos;
        private FontAwesome.Sharp.IconButton ibtnRoles;
        private FontAwesome.Sharp.IconButton ibtnUsuarios;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnSeguridad;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton ibtnComunes;
        private Panel panelComunes;
        private FontAwesome.Sharp.IconButton ibtnGrupos;
        private FontAwesome.Sharp.IconButton ibtnNombres;
        private Panel panelImportaciones;
        private FontAwesome.Sharp.IconButton ibtnAgentes;
        private FontAwesome.Sharp.IconButton ibtnTerminales;
        private FontAwesome.Sharp.IconButton ibtnAduanas;
        private FontAwesome.Sharp.IconButton ibtnShippers;
        private FontAwesome.Sharp.IconButton ibtnRevisiones;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton ibtnImportaciones;
    }
}