namespace SAESoft.AdministracionSistema.Seguridad
{
    partial class frmUsuarios
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
            components = new System.ComponentModel.Container();
            toolStripContainer1 = new ToolStripContainer();
            lblActivo = new Label();
            tsActivo = new SAESoft.Utilitarios.toggleSwitch();
            cboRoles = new ComboBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtUsuario = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbListar = new ToolStripButton();
            tsbModificar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAceptar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbAnterior = new ToolStripButton();
            tslIndice = new ToolStripLabel();
            tsbSiguiente = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(lblActivo);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(cboRoles);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(txtPassword);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(txtUsuario);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(txtEmail);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(txtApellidos);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombres);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(txtId);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 411);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Font = new Font("Century Gothic", 12F);
            lblActivo.Location = new Point(376, 35);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(76, 21);
            lblActivo.TabIndex = 16;
            lblActivo.Text = "Inactivo";
            // 
            // tsActivo
            // 
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F);
            tsActivo.Location = new Point(330, 32);
            tsActivo.MinimumSize = new Size(45, 22);
            tsActivo.Name = "tsActivo";
            tsActivo.OffBackColor = Color.Firebrick;
            tsActivo.OffDisabledColor = Color.Gray;
            tsActivo.OffTogglecolor = Color.Firebrick;
            tsActivo.OnBackColor = Color.FromArgb(0, 122, 172);
            tsActivo.OnDisabledcolor = Color.Gray;
            tsActivo.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsActivo.Size = new Size(45, 25);
            tsActivo.SolidStyle = false;
            tsActivo.TabIndex = 15;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            tsActivo.CheckedChanged += tsActivo_CheckedChanged;
            // 
            // cboRoles
            // 
            cboRoles.DrawMode = DrawMode.OwnerDrawFixed;
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.Enabled = false;
            cboRoles.Font = new Font("Century Gothic", 12F);
            cboRoles.FormattingEnabled = true;
            cboRoles.IntegralHeight = false;
            cboRoles.Location = new Point(211, 304);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(296, 28);
            cboRoles.TabIndex = 14;
            cboRoles.DrawItem += cboRoles_DrawItem;
            cboRoles.SelectionChangeCommitted += cboRoles_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(91, 312);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 13;
            label7.Text = "Rol";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Century Gothic", 12F);
            txtPassword.Location = new Point(211, 257);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(91, 260);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 10;
            label6.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Font = new Font("Century Gothic", 12F);
            txtUsuario.Location = new Point(211, 210);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 27);
            txtUsuario.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(91, 213);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 8;
            label5.Text = "Usuario";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Century Gothic", 12F);
            txtEmail.Location = new Point(211, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(296, 27);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(91, 168);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtApellidos
            // 
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Century Gothic", 12F);
            txtApellidos.Location = new Point(211, 121);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(296, 27);
            txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(91, 124);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Century Gothic", 12F);
            txtNombres.Location = new Point(211, 75);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(296, 27);
            txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(91, 78);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F);
            txtId.Location = new Point(211, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(91, 35);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(234, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Enabled = false;
            tsbNuevo.Image = Properties.Resources.add_file;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(36, 36);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextAlign = ContentAlignment.BottomCenter;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = Properties.Resources.file;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(36, 36);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbListar
            // 
            tsbListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbListar.Image = Properties.Resources.listar;
            tsbListar.ImageTransparentColor = Color.Magenta;
            tsbListar.Name = "tsbListar";
            tsbListar.Size = new Size(36, 36);
            tsbListar.Text = "Listar";
            tsbListar.Click += tsbListar_Click;
            // 
            // tsbModificar
            // 
            tsbModificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbModificar.Enabled = false;
            tsbModificar.Image = Properties.Resources.edit;
            tsbModificar.ImageTransparentColor = Color.Magenta;
            tsbModificar.Name = "tsbModificar";
            tsbModificar.Size = new Size(36, 36);
            tsbModificar.Text = "Editar";
            tsbModificar.Click += tsbModificar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Enabled = false;
            tsbEliminar.Image = Properties.Resources.delete;
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(36, 36);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbAceptar
            // 
            tsbAceptar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAceptar.Image = Properties.Resources.check;
            tsbAceptar.ImageTransparentColor = Color.Magenta;
            tsbAceptar.Name = "tsbAceptar";
            tsbAceptar.Size = new Size(36, 36);
            tsbAceptar.Text = "Guardar";
            tsbAceptar.Visible = false;
            tsbAceptar.Click += tsbAceptar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = Properties.Resources.close;
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(36, 36);
            tsbCancelar.Text = "Cancelar";
            tsbCancelar.Visible = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbAnterior
            // 
            tsbAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAnterior.Image = Properties.Resources.arrow_l;
            tsbAnterior.ImageTransparentColor = Color.Magenta;
            tsbAnterior.Name = "tsbAnterior";
            tsbAnterior.Size = new Size(36, 36);
            tsbAnterior.Text = "Anterior";
            tsbAnterior.Visible = false;
            tsbAnterior.Click += tsbAnterior_Click;
            // 
            // tslIndice
            // 
            tslIndice.Name = "tslIndice";
            tslIndice.Size = new Size(84, 36);
            tslIndice.Text = "Registro 0 de 0";
            tslIndice.Visible = false;
            // 
            // tsbSiguiente
            // 
            tsbSiguiente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSiguiente.Image = Properties.Resources.arrow_r;
            tsbSiguiente.ImageTransparentColor = Color.Magenta;
            tsbSiguiente.Name = "tsbSiguiente";
            tsbSiguiente.Size = new Size(36, 36);
            tsbSiguiente.Text = "Siguiente";
            tsbSiguiente.Visible = false;
            tsbSiguiente.Click += tsbSiguiente_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalir.Image = Properties.Resources.logout;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 36);
            tsbSalir.Text = "Salir";
            tsbSalir.Click += tsbSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            Shown += frmUsuarios_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbModificar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbAceptar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbListar;
        private ToolStripButton tsbSalir;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtUsuario;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private ComboBox cboRoles;
        private Label label7;
        private ToolStripButton tsbAnterior;
        private ToolStripButton tsbSiguiente;
        private Utilitarios.toggleSwitch tsActivo;
        private Label lblActivo;
        private ErrorProvider errorProvider1;
        private ToolStripLabel tslIndice;
    }
}