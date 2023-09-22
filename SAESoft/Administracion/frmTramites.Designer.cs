namespace SAESoft.Administracion
{
    partial class frmTramites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTramites));
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cboStatus = new ComboBox();
            label5 = new Label();
            cboTipoTramite = new ComboBox();
            label4 = new Label();
            cboFamiliares = new ComboBox();
            label3 = new Label();
            cboEmpleados = new ComboBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtObservaciones = new TextBox();
            label10 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chkCita = new CheckBox();
            dtpHoraCita = new DateTimePicker();
            label8 = new Label();
            dtpFechaCita = new DateTimePicker();
            label7 = new Label();
            txtNoSolicitud = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            dgvHistorial = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(437, 18);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(113, 108);
            iconButton1.TabIndex = 43;
            iconButton1.Text = "Guardar";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(128, 179);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(292, 29);
            cboStatus.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 182);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 41;
            label5.Text = "Status";
            // 
            // cboTipoTramite
            // 
            cboTipoTramite.FormattingEnabled = true;
            cboTipoTramite.Location = new Point(128, 144);
            cboTipoTramite.Name = "cboTipoTramite";
            cboTipoTramite.Size = new Size(422, 29);
            cboTipoTramite.TabIndex = 40;
            cboTipoTramite.SelectedIndexChanged += cboTipoTramite_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 147);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 39;
            label4.Text = "Tipo";
            // 
            // cboFamiliares
            // 
            cboFamiliares.FormattingEnabled = true;
            cboFamiliares.Location = new Point(128, 101);
            cboFamiliares.Name = "cboFamiliares";
            cboFamiliares.Size = new Size(292, 29);
            cboFamiliares.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 37;
            label3.Text = "Familiar";
            // 
            // cboEmpleados
            // 
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(128, 59);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(292, 29);
            cboEmpleados.TabIndex = 36;
            cboEmpleados.SelectedIndexChanged += cboEmpleados_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 62);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 35;
            label1.Text = "Empleado";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(128, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(103, 27);
            txtId.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 24);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 34;
            label2.Text = "Id";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(154, 231);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(383, 79);
            txtObservaciones.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(22, 231);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 44;
            label10.Text = "Observaciones";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 317);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 214);
            tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkCita);
            tabPage1.Controls.Add(dtpHoraCita);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dtpFechaCita);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtNoSolicitud);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(546, 180);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cita";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCita
            // 
            chkCita.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkCita.Appearance = Appearance.Button;
            chkCita.AutoSize = true;
            chkCita.FlatAppearance.BorderSize = 0;
            chkCita.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkCita.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkCita.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkCita.FlatStyle = FlatStyle.Flat;
            chkCita.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCita.Image = Properties.Resources.Nunchecked;
            chkCita.ImageAlign = ContentAlignment.MiddleLeft;
            chkCita.ImeMode = ImeMode.NoControl;
            chkCita.Location = new Point(9, 12);
            chkCita.Name = "chkCita";
            chkCita.Size = new Size(123, 31);
            chkCita.TabIndex = 49;
            chkCita.Text = "  Tiene Cita";
            chkCita.TextAlign = ContentAlignment.BottomCenter;
            chkCita.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkCita.UseVisualStyleBackColor = true;
            chkCita.CheckedChanged += chkCheckedChange;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.CustomFormat = "HH:mm";
            dtpHoraCita.Enabled = false;
            dtpHoraCita.Format = DateTimePickerFormat.Custom;
            dtpHoraCita.Location = new Point(421, 11);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.Size = new Size(77, 27);
            dtpHoraCita.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(364, 16);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 21;
            label8.Text = "Hora ";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Enabled = false;
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(221, 12);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(127, 27);
            dtpFechaCita.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(156, 16);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 19;
            label7.Text = "Fecha";
            // 
            // txtNoSolicitud
            // 
            txtNoSolicitud.Location = new Point(178, 58);
            txtNoSolicitud.Name = "txtNoSolicitud";
            txtNoSolicitud.Size = new Size(123, 27);
            txtNoSolicitud.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 61);
            label6.Name = "label6";
            label6.Size = new Size(166, 21);
            label6.TabIndex = 17;
            label6.Text = "Número de Solicitud";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvHistorial);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(546, 186);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Historial";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Fill;
            dgvHistorial.Location = new Point(3, 3);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(540, 180);
            dgvHistorial.TabIndex = 0;
            // 
            // frmTramites
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(589, 552);
            Controls.Add(tabControl1);
            Controls.Add(txtObservaciones);
            Controls.Add(label10);
            Controls.Add(iconButton1);
            Controls.Add(cboStatus);
            Controls.Add(label5);
            Controls.Add(cboTipoTramite);
            Controls.Add(label4);
            Controls.Add(cboFamiliares);
            Controls.Add(label3);
            Controls.Add(cboEmpleados);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTramites";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingreso de Trámites";
            Load += frmTramites_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox cboStatus;
        private Label label5;
        private ComboBox cboTipoTramite;
        private Label label4;
        private ComboBox cboFamiliares;
        private Label label3;
        private ComboBox cboEmpleados;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtObservaciones;
        private Label label10;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DateTimePicker dtpFechaCita;
        private Label label7;
        private TextBox txtNoSolicitud;
        private Label label6;
        private TabPage tabPage2;
        private DataGridView dgvHistorial;
        private DateTimePicker dtpHoraCita;
        private Label label8;
        private CheckBox chkCita;
    }
}