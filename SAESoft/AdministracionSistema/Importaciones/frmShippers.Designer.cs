namespace SAESoft.AdministracionSistema.Importaciones
{
    partial class frmShippers
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
            label3 = new Label();
            chkTerrestre = new CheckBox();
            chkMaritimo = new CheckBox();
            chkAereo = new CheckBox();
            txtNombre = new TextBox();
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
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(chkTerrestre);
            toolStripContainer1.ContentPanel.Controls.Add(chkMaritimo);
            toolStripContainer1.ContentPanel.Controls.Add(chkAereo);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombre);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 123);
            label3.Name = "label3";
            label3.Size = new Size(35, 21);
            label3.TabIndex = 50;
            label3.Text = "Vía";
            // 
            // chkTerrestre
            // 
            chkTerrestre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkTerrestre.Appearance = Appearance.Button;
            chkTerrestre.AutoSize = true;
            chkTerrestre.BackColor = Color.Transparent;
            chkTerrestre.FlatAppearance.BorderSize = 0;
            chkTerrestre.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkTerrestre.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkTerrestre.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkTerrestre.FlatStyle = FlatStyle.Flat;
            chkTerrestre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkTerrestre.Image = Properties.Resources.Nunchecked;
            chkTerrestre.ImageAlign = ContentAlignment.MiddleLeft;
            chkTerrestre.ImeMode = ImeMode.NoControl;
            chkTerrestre.Location = new Point(427, 118);
            chkTerrestre.Name = "chkTerrestre";
            chkTerrestre.Size = new Size(110, 31);
            chkTerrestre.TabIndex = 49;
            chkTerrestre.Text = "  Terrestre";
            chkTerrestre.TextAlign = ContentAlignment.BottomCenter;
            chkTerrestre.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkTerrestre.UseVisualStyleBackColor = false;
            chkTerrestre.CheckedChanged += chkCheckedChange;
            // 
            // chkMaritimo
            // 
            chkMaritimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMaritimo.Appearance = Appearance.Button;
            chkMaritimo.AutoSize = true;
            chkMaritimo.BackColor = Color.Transparent;
            chkMaritimo.FlatAppearance.BorderSize = 0;
            chkMaritimo.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkMaritimo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkMaritimo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkMaritimo.FlatStyle = FlatStyle.Flat;
            chkMaritimo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkMaritimo.Image = Properties.Resources.Nunchecked;
            chkMaritimo.ImageAlign = ContentAlignment.MiddleLeft;
            chkMaritimo.ImeMode = ImeMode.NoControl;
            chkMaritimo.Location = new Point(308, 118);
            chkMaritimo.Name = "chkMaritimo";
            chkMaritimo.Size = new Size(113, 31);
            chkMaritimo.TabIndex = 48;
            chkMaritimo.Text = "  Marítimo";
            chkMaritimo.TextAlign = ContentAlignment.BottomCenter;
            chkMaritimo.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkMaritimo.UseVisualStyleBackColor = false;
            chkMaritimo.CheckedChanged += chkCheckedChange;
            // 
            // chkAereo
            // 
            chkAereo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAereo.Appearance = Appearance.Button;
            chkAereo.AutoSize = true;
            chkAereo.BackColor = Color.Transparent;
            chkAereo.FlatAppearance.BorderSize = 0;
            chkAereo.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkAereo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkAereo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkAereo.FlatStyle = FlatStyle.Flat;
            chkAereo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAereo.Image = Properties.Resources.Nunchecked;
            chkAereo.ImageAlign = ContentAlignment.MiddleLeft;
            chkAereo.ImeMode = ImeMode.NoControl;
            chkAereo.Location = new Point(210, 118);
            chkAereo.Name = "chkAereo";
            chkAereo.Size = new Size(92, 31);
            chkAereo.TabIndex = 47;
            chkAereo.Text = "  Aéreo";
            chkAereo.TextAlign = ContentAlignment.BottomCenter;
            chkAereo.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkAereo.UseVisualStyleBackColor = false;
            chkAereo.CheckedChanged += chkCheckedChange;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Enabled = false;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(210, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(296, 27);
            txtNombre.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 74);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 14;
            label2.Text = "Shipper";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(210, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 31);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(493, 39);
            toolStrip1.TabIndex = 3;
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
            // frmShippers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "frmShippers";
            Text = "frmShippers";
            Load += frmShippers_Load;
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
        private ErrorProvider errorProvider1;
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
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private CheckBox chkTerrestre;
        private CheckBox chkMaritimo;
        private CheckBox chkAereo;
        private Label label3;
    }
}