namespace SAESoft.Incentivo
{
    partial class FrmDeptoIncentivo
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            groupBox1 = new GroupBox();
            dgvDeptos = new DataGridView();
            cboEncargado = new ComboBox();
            label1 = new Label();
            tsActivo = new SAESoft.Utilitarios.toggleSwitch();
            label13 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbListar = new ToolStripButton();
            tsbModificar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbAgregarDeptos = new ToolStripButton();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeptos).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(groupBox1);
            toolStripContainer1.ContentPanel.Controls.Add(cboEncargado);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(label13);
            toolStripContainer1.ContentPanel.Controls.Add(txtId);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombres);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Margin = new Padding(4);
            toolStripContainer1.ContentPanel.Size = new Size(724, 483);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(724, 522);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDeptos);
            groupBox1.Location = new Point(36, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 275);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sub Departamentos";
            // 
            // dgvDeptos
            // 
            dgvDeptos.AllowUserToAddRows = false;
            dgvDeptos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDeptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDeptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeptos.Dock = DockStyle.Fill;
            dgvDeptos.Location = new Point(3, 23);
            dgvDeptos.MultiSelect = false;
            dgvDeptos.Name = "dgvDeptos";
            dgvDeptos.ReadOnly = true;
            dgvDeptos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeptos.Size = new Size(549, 249);
            dgvDeptos.TabIndex = 0;
            dgvDeptos.CellDoubleClick += dgvDeptos_CellDoubleClick;
            // 
            // cboEncargado
            // 
            cboEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEncargado.Enabled = false;
            cboEncargado.FormattingEnabled = true;
            cboEncargado.Location = new Point(149, 105);
            cboEncargado.Name = "cboEncargado";
            cboEncargado.Size = new Size(331, 29);
            cboEncargado.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(45, 108);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 48;
            label1.Text = "Encargado";
            // 
            // tsActivo
            // 
            tsActivo.Checked = true;
            tsActivo.CheckState = CheckState.Checked;
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F);
            tsActivo.Location = new Point(425, 21);
            tsActivo.MinimumSize = new Size(45, 22);
            tsActivo.Name = "tsActivo";
            tsActivo.OffBackColor = Color.Firebrick;
            tsActivo.OffDisabledColor = Color.IndianRed;
            tsActivo.OffTogglecolor = Color.Firebrick;
            tsActivo.OnBackColor = Color.FromArgb(0, 122, 172);
            tsActivo.OnDisabledcolor = Color.LightSteelBlue;
            tsActivo.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsActivo.Size = new Size(45, 25);
            tsActivo.SolidStyle = false;
            tsActivo.TabIndex = 47;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F);
            label13.Location = new Point(350, 22);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 46;
            label13.Text = "Activo";
            // 
            // txtId
            // 
            txtId.CharacterCasing = CharacterCasing.Upper;
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F);
            txtId.Location = new Point(149, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(93, 27);
            txtId.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(75, 25);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 45;
            label4.Text = "Código";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Century Gothic", 12F);
            txtNombres.Location = new Point(149, 62);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(331, 27);
            txtNombres.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(70, 65);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 44;
            label2.Text = "Nombre";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, tsbAgregarDeptos, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(270, 39);
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
            // tsbAgregarDeptos
            // 
            tsbAgregarDeptos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAgregarDeptos.Enabled = false;
            tsbAgregarDeptos.Image = Properties.Resources.subcategorias;
            tsbAgregarDeptos.ImageTransparentColor = Color.Magenta;
            tsbAgregarDeptos.Name = "tsbAgregarDeptos";
            tsbAgregarDeptos.Size = new Size(36, 36);
            tsbAgregarDeptos.Text = "Agregar Sub Departamento";
            tsbAgregarDeptos.Click += tsbAgregarDeptos_Click;
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
            // FrmDeptoIncentivo
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 522);
            Controls.Add(toolStripContainer1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            Name = "FrmDeptoIncentivo";
            Text = "FrmDeptoIncentivo";
            Load += FrmDeptoIncentivo_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeptos).EndInit();
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
        private GroupBox groupBox1;
        private DataGridView dgvDeptos;
        private ComboBox cboEncargado;
        private Label label1;
        private Utilitarios.toggleSwitch tsActivo;
        private Label label13;
        private TextBox txtId;
        private Label label4;
        private TextBox txtNombres;
        private Label label2;
        private ToolStripButton tsbAgregarDeptos;
        private ErrorProvider errorProvider1;
    }
}