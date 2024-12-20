﻿namespace SAESoft.Incentivo
{
    partial class frmEmpIncentivo
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            dgvHistorial = new DataGridView();
            dtpIngreso = new DateTimePicker();
            dtpBaja = new DateTimePicker();
            label7 = new Label();
            tsActivo = new Utilitarios.toggleSwitch();
            label13 = new Label();
            label6 = new Label();
            cboDepto = new ComboBox();
            label3 = new Label();
            txtBaseCalculo = new TextBox();
            label1 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dgvHistorial);
            toolStripContainer1.ContentPanel.Controls.Add(dtpIngreso);
            toolStripContainer1.ContentPanel.Controls.Add(dtpBaja);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(label13);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(cboDepto);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(txtBaseCalculo);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(txtApellidos);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(txtCodigo);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombres);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Size = new Size(800, 513);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 552);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorial.Location = new Point(69, 286);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(645, 150);
            dgvHistorial.TabIndex = 45;
            // 
            // dtpIngreso
            // 
            dtpIngreso.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngreso.Enabled = false;
            dtpIngreso.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(206, 231);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(116, 27);
            dtpIngreso.TabIndex = 44;
            // 
            // dtpBaja
            // 
            dtpBaja.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBaja.Enabled = false;
            dtpBaja.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBaja.Format = DateTimePickerFormat.Short;
            dtpBaja.Location = new Point(465, 230);
            dtpBaja.Name = "dtpBaja";
            dtpBaja.Size = new Size(116, 27);
            dtpBaja.TabIndex = 43;
            dtpBaja.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(337, 230);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 42;
            label7.Text = "Fecha de Baja";
            label7.Visible = false;
            // 
            // tsActivo
            // 
            tsActivo.Checked = true;
            tsActivo.CheckState = CheckState.Checked;
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsActivo.Location = new Point(484, 27);
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
            tsActivo.TabIndex = 41;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            tsActivo.CheckedChanged += tsActivo_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(409, 28);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 40;
            label13.Text = "Activo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 230);
            label6.Name = "label6";
            label6.Size = new Size(145, 21);
            label6.TabIndex = 33;
            label6.Text = "Fecha de Ingreso";
            // 
            // cboDepto
            // 
            cboDepto.Enabled = false;
            cboDepto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDepto.FormattingEnabled = true;
            cboDepto.Location = new Point(208, 186);
            cboDepto.Name = "cboDepto";
            cboDepto.Size = new Size(239, 29);
            cboDepto.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 189);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 31;
            label3.Text = "Departamento";
            // 
            // txtBaseCalculo
            // 
            txtBaseCalculo.CharacterCasing = CharacterCasing.Upper;
            txtBaseCalculo.Enabled = false;
            txtBaseCalculo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBaseCalculo.Location = new Point(208, 148);
            txtBaseCalculo.Name = "txtBaseCalculo";
            txtBaseCalculo.Size = new Size(142, 27);
            txtBaseCalculo.TabIndex = 29;
            txtBaseCalculo.KeyPress += txtBaseCalculo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 148);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 30;
            label1.Text = "Base de Cálculo";
            // 
            // txtApellidos
            // 
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.Enabled = false;
            txtApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(208, 107);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(331, 27);
            txtApellidos.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(120, 110);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 28;
            label5.Text = "Apellidos";
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(208, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(93, 27);
            txtCodigo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 34);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 27;
            label4.Text = "Código";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Enabled = false;
            txtNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(208, 68);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(331, 27);
            txtNombres.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 26;
            label2.Text = "Nombres";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(234, 39);
            toolStrip1.TabIndex = 4;
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
            // frmEmpIncentivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(toolStripContainer1);
            Name = "frmEmpIncentivo";
            Text = "frmEmpIncentivo";
            Load += frmEmpIncentivo_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
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
        private TextBox txtApellidos;
        private Label label5;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtBaseCalculo;
        private Label label1;
        private Label label3;
        private ComboBox cboDepto;
        private Label label6;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpBaja;
        private Label label7;
        private Utilitarios.toggleSwitch tsActivo;
        private Label label13;
        private DataGridView dgvHistorial;
    }
}