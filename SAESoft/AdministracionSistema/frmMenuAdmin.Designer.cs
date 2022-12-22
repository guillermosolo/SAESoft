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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnModulos = new FontAwesome.Sharp.IconButton();
            this.ibtnPermisos = new FontAwesome.Sharp.IconButton();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnRoles = new FontAwesome.Sharp.IconButton();
            this.ibtnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.ibtnModulos);
            this.panelMenu.Controls.Add(this.ibtnPermisos);
            this.panelMenu.Controls.Add(this.ibtnSalir);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.ibtnRoles);
            this.panelMenu.Controls.Add(this.ibtnUsuarios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnModulos
            // 
            this.ibtnModulos.FlatAppearance.BorderSize = 0;
            this.ibtnModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnModulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnModulos.ForeColor = System.Drawing.Color.White;
            this.ibtnModulos.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            this.ibtnModulos.IconColor = System.Drawing.Color.White;
            this.ibtnModulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnModulos.IconSize = 32;
            this.ibtnModulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnModulos.Location = new System.Drawing.Point(3, 178);
            this.ibtnModulos.Name = "ibtnModulos";
            this.ibtnModulos.Size = new System.Drawing.Size(197, 55);
            this.ibtnModulos.TabIndex = 5;
            this.ibtnModulos.Text = "Módulos";
            this.ibtnModulos.UseVisualStyleBackColor = true;
            this.ibtnModulos.Click += new System.EventHandler(this.ibtnModulos_Click);
            // 
            // ibtnPermisos
            // 
            this.ibtnPermisos.FlatAppearance.BorderSize = 0;
            this.ibtnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPermisos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnPermisos.ForeColor = System.Drawing.Color.White;
            this.ibtnPermisos.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.ibtnPermisos.IconColor = System.Drawing.Color.White;
            this.ibtnPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPermisos.IconSize = 32;
            this.ibtnPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPermisos.Location = new System.Drawing.Point(3, 134);
            this.ibtnPermisos.Name = "ibtnPermisos";
            this.ibtnPermisos.Size = new System.Drawing.Size(197, 55);
            this.ibtnPermisos.TabIndex = 4;
            this.ibtnPermisos.Text = "Permisos";
            this.ibtnPermisos.UseVisualStyleBackColor = true;
            this.ibtnPermisos.Click += new System.EventHandler(this.ibtnRolPermiso_Click);
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnSalir.FlatAppearance.BorderSize = 0;
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnSalir.ForeColor = System.Drawing.Color.White;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.ibtnSalir.IconColor = System.Drawing.Color.White;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 32;
            this.ibtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSalir.Location = new System.Drawing.Point(3, 377);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(197, 43);
            this.ibtnSalir.TabIndex = 3;
            this.ibtnSalir.Text = "Salir";
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administración del Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ibtnRoles
            // 
            this.ibtnRoles.FlatAppearance.BorderSize = 0;
            this.ibtnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRoles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnRoles.ForeColor = System.Drawing.Color.White;
            this.ibtnRoles.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.ibtnRoles.IconColor = System.Drawing.Color.White;
            this.ibtnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRoles.IconSize = 32;
            this.ibtnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRoles.Location = new System.Drawing.Point(3, 95);
            this.ibtnRoles.Name = "ibtnRoles";
            this.ibtnRoles.Size = new System.Drawing.Size(197, 43);
            this.ibtnRoles.TabIndex = 1;
            this.ibtnRoles.Text = "Roles";
            this.ibtnRoles.UseVisualStyleBackColor = true;
            this.ibtnRoles.Click += new System.EventHandler(this.ibtnRoles_Click);
            // 
            // ibtnUsuarios
            // 
            this.ibtnUsuarios.FlatAppearance.BorderSize = 0;
            this.ibtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.ibtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnUsuarios.IconColor = System.Drawing.Color.White;
            this.ibtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUsuarios.IconSize = 32;
            this.ibtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnUsuarios.Location = new System.Drawing.Point(3, 55);
            this.ibtnUsuarios.Name = "ibtnUsuarios";
            this.ibtnUsuarios.Size = new System.Drawing.Size(197, 43);
            this.ibtnUsuarios.TabIndex = 0;
            this.ibtnUsuarios.Text = "Usuarios";
            this.ibtnUsuarios.UseVisualStyleBackColor = true;
            this.ibtnUsuarios.Click += new System.EventHandler(this.ibtnUsuarios_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(200, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(600, 450);
            this.panelFormularios.TabIndex = 1;
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMenuAdmin";
            this.Text = "frmMenuAdmin";
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelFormularios;
        private FontAwesome.Sharp.IconButton ibtnRoles;
        private FontAwesome.Sharp.IconButton ibtnUsuarios;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnPermisos;
        private FontAwesome.Sharp.IconButton ibtnModulos;
    }
}