namespace SAESoft.AdministracionSistema.Importaciones
{
    partial class frmAgentes
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
            tsActivo = new Utilitarios.toggleSwitch();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
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
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(txtApellido);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombre);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(txtId);
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
            // tsActivo
            // 
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsActivo.Location = new Point(207, 144);
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
            tsActivo.TabIndex = 29;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            tsActivo.CheckedChanged += tsActivo_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 148);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 28;
            label4.Text = "Activo";
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Enabled = false;
            txtApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(207, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(296, 27);
            txtApellido.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 105);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 26;
            label3.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(207, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(296, 27);
            txtNombre.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 23);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 22;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 24;
            label2.Text = "Nombres";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(207, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 23;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(234, 39);
            toolStrip1.TabIndex = 5;
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
            // frmAgentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "frmAgentes";
            Text = "frmAgentes";
            Load += frmAgentes_Load;
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
        private ToolStripButton tsbListar;
        private ToolStripButton tsbModificar;
        private ToolStripButton tsbEliminar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAceptar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbAnterior;
        private ToolStripLabel tslIndice;
        private ToolStripButton tsbSiguiente;
        private ToolStripButton tsbSalir;
        private ErrorProvider errorProvider1;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Utilitarios.toggleSwitch tsActivo;
    }
}