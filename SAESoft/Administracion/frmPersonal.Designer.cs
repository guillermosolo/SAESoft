namespace SAESoft.Administracion
{
    partial class frmPersonal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            label10 = new Label();
            cboEmpresa = new ComboBox();
            label9 = new Label();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvFamiliares = new DataGridView();
            tabPage2 = new TabPage();
            tsActivo = new Utilitarios.toggleSwitch();
            label13 = new Label();
            tsBoletoOrnato = new Utilitarios.toggleSwitch();
            label12 = new Label();
            tsCuotaAnual = new Utilitarios.toggleSwitch();
            label11 = new Label();
            dtpFechaNac = new DateTimePicker();
            label8 = new Label();
            txtNombreCOR = new TextBox();
            label7 = new Label();
            txtNombreESP = new TextBox();
            label6 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            cboDepartamento = new ComboBox();
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
            tsbRelatives = new ToolStripButton();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFamiliares).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(label10);
            toolStripContainer1.ContentPanel.Controls.Add(cboEmpresa);
            toolStripContainer1.ContentPanel.Controls.Add(label9);
            toolStripContainer1.ContentPanel.Controls.Add(rdbFemenino);
            toolStripContainer1.ContentPanel.Controls.Add(rdbMasculino);
            toolStripContainer1.ContentPanel.Controls.Add(tabControl1);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(label13);
            toolStripContainer1.ContentPanel.Controls.Add(tsBoletoOrnato);
            toolStripContainer1.ContentPanel.Controls.Add(label12);
            toolStripContainer1.ContentPanel.Controls.Add(tsCuotaAnual);
            toolStripContainer1.ContentPanel.Controls.Add(label11);
            toolStripContainer1.ContentPanel.Controls.Add(dtpFechaNac);
            toolStripContainer1.ContentPanel.Controls.Add(label8);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombreCOR);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombreESP);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(txtApellidos);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(txtCodigo);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(cboDepartamento);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombres);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(txtId);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 696);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 735);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(442, 138);
            label10.Name = "label10";
            label10.Size = new Size(69, 21);
            label10.TabIndex = 45;
            label10.Text = "Género";
            // 
            // cboEmpresa
            // 
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.Enabled = false;
            cboEmpresa.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.ItemHeight = 21;
            cboEmpresa.Location = new Point(211, 182);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(417, 29);
            cboEmpresa.TabIndex = 43;
            cboEmpresa.SelectedIndexChanged += cboEmpresa_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(68, 182);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 44;
            label9.Text = "Empresa";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Enabled = false;
            rdbFemenino.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemenino.Location = new Point(522, 151);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(104, 25);
            rdbFemenino.TabIndex = 42;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Checked = true;
            rdbMasculino.Enabled = false;
            rdbMasculino.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMasculino.Location = new Point(522, 124);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(106, 25);
            rdbMasculino.TabIndex = 41;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(74, 339);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(561, 250);
            tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvFamiliares);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(553, 222);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Familiares";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFamiliares
            // 
            dgvFamiliares.AllowUserToAddRows = false;
            dgvFamiliares.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFamiliares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFamiliares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFamiliares.Dock = DockStyle.Fill;
            dgvFamiliares.Location = new Point(3, 3);
            dgvFamiliares.Name = "dgvFamiliares";
            dgvFamiliares.ReadOnly = true;
            dgvFamiliares.RowHeadersVisible = false;
            dgvFamiliares.RowTemplate.Height = 25;
            dgvFamiliares.Size = new Size(547, 216);
            dgvFamiliares.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(553, 222);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Documentos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tsActivo
            // 
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsActivo.Location = new Point(480, 262);
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
            tsActivo.TabIndex = 39;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(389, 266);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 38;
            label13.Text = "Activo";
            // 
            // tsBoletoOrnato
            // 
            tsBoletoOrnato.Enabled = false;
            tsBoletoOrnato.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsBoletoOrnato.Location = new Point(480, 305);
            tsBoletoOrnato.MinimumSize = new Size(45, 22);
            tsBoletoOrnato.Name = "tsBoletoOrnato";
            tsBoletoOrnato.OffBackColor = Color.Firebrick;
            tsBoletoOrnato.OffDisabledColor = Color.Gray;
            tsBoletoOrnato.OffTogglecolor = Color.Firebrick;
            tsBoletoOrnato.OnBackColor = Color.FromArgb(0, 122, 172);
            tsBoletoOrnato.OnDisabledcolor = Color.Gray;
            tsBoletoOrnato.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsBoletoOrnato.Size = new Size(45, 25);
            tsBoletoOrnato.SolidStyle = false;
            tsBoletoOrnato.TabIndex = 37;
            tsBoletoOrnato.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsBoletoOrnato.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(322, 309);
            label12.Name = "label12";
            label12.Size = new Size(145, 21);
            label12.TabIndex = 36;
            label12.Text = "Boleto de Ornato";
            // 
            // tsCuotaAnual
            // 
            tsCuotaAnual.Enabled = false;
            tsCuotaAnual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsCuotaAnual.Location = new Point(254, 305);
            tsCuotaAnual.MinimumSize = new Size(45, 22);
            tsCuotaAnual.Name = "tsCuotaAnual";
            tsCuotaAnual.OffBackColor = Color.Firebrick;
            tsCuotaAnual.OffDisabledColor = Color.Gray;
            tsCuotaAnual.OffTogglecolor = Color.Firebrick;
            tsCuotaAnual.OnBackColor = Color.FromArgb(0, 122, 172);
            tsCuotaAnual.OnDisabledcolor = Color.Gray;
            tsCuotaAnual.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsCuotaAnual.Size = new Size(45, 25);
            tsCuotaAnual.SolidStyle = false;
            tsCuotaAnual.TabIndex = 35;
            tsCuotaAnual.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsCuotaAnual.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(69, 309);
            label11.Name = "label11";
            label11.Size = new Size(178, 21);
            label11.TabIndex = 34;
            label11.Text = "Cuota Anual Vigente";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNac.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(253, 261);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(120, 27);
            dtpFechaNac.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(68, 262);
            label8.Name = "label8";
            label8.Size = new Size(179, 21);
            label8.TabIndex = 28;
            label8.Text = "Fecha de Nacimiento";
            // 
            // txtNombreCOR
            // 
            txtNombreCOR.CharacterCasing = CharacterCasing.Upper;
            txtNombreCOR.Enabled = false;
            txtNombreCOR.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreCOR.Location = new Point(211, 132);
            txtNombreCOR.Name = "txtNombreCOR";
            txtNombreCOR.Size = new Size(217, 27);
            txtNombreCOR.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(68, 135);
            label7.Name = "label7";
            label7.Size = new Size(146, 21);
            label7.TabIndex = 26;
            label7.Text = "Nombre Coreano";
            // 
            // txtNombreESP
            // 
            txtNombreESP.CharacterCasing = CharacterCasing.Upper;
            txtNombreESP.Enabled = false;
            txtNombreESP.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreESP.Location = new Point(211, 91);
            txtNombreESP.Name = "txtNombreESP";
            txtNombreESP.Size = new Size(417, 27);
            txtNombreESP.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(68, 94);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 24;
            label6.Text = "Nombre Español";
            // 
            // txtApellidos
            // 
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(458, 50);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(170, 27);
            txtApellidos.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(372, 53);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 22;
            label5.Text = "Apellidos";
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(458, 13);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(93, 27);
            txtCodigo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(372, 16);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 20;
            label4.Text = "Código";
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.Enabled = false;
            cboDepartamento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.ItemHeight = 21;
            cboDepartamento.Location = new Point(211, 218);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(417, 29);
            cboDepartamento.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 218);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 18;
            label3.Text = "Departamento";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(188, 50);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(178, 27);
            txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 16;
            label2.Text = "Nombres";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(188, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 16);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 14;
            label1.Text = "Id";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, tsbRelatives, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(270, 39);
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
            // tsbRelatives
            // 
            tsbRelatives.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbRelatives.Enabled = false;
            tsbRelatives.Image = Properties.Resources.relatives;
            tsbRelatives.ImageTransparentColor = Color.Magenta;
            tsbRelatives.Name = "tsbRelatives";
            tsbRelatives.Size = new Size(36, 36);
            tsbRelatives.Text = "Familiares";
            tsbRelatives.Click += tsbRelatives_Click;
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
            // frmPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 735);
            Controls.Add(toolStripContainer1);
            Name = "frmPersonal";
            Text = "frmPersonal";
            Load += frmPersonal_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFamiliares).EndInit();
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
        private TextBox txtCodigo;
        private Label label4;
        private ComboBox cboDepartamento;
        private Label label3;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Label label5;
        private TextBox txtNombreCOR;
        private Label label7;
        private TextBox txtNombreESP;
        private Label label6;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNac;
        private Label label8;
        private Label label11;
        private Utilitarios.toggleSwitch tsCuotaAnual;
        private Utilitarios.toggleSwitch tsBoletoOrnato;
        private Label label12;
        private Utilitarios.toggleSwitch tsActivo;
        private Label label13;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripButton tsbRelatives;
        private DataGridView dgvFamiliares;
        private Label label10;
        private ComboBox cboEmpresa;
        private Label label9;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
    }
}