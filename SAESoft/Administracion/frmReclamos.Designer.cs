namespace SAESoft.Administracion
{
    partial class frmReclamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReclamos));
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboEmpleados = new ComboBox();
            label3 = new Label();
            cboFamiliares = new ComboBox();
            label4 = new Label();
            cboTipoReclamo = new ComboBox();
            cboStatus = new ComboBox();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtMontoCheque = new TextBox();
            label16 = new Label();
            txtOtrosGastos = new TextBox();
            label15 = new Label();
            txtNoCubierto = new TextBox();
            label14 = new Label();
            txtTimbres = new TextBox();
            label13 = new Label();
            txtCoaseguro = new TextBox();
            label12 = new Label();
            txtDeducible = new TextBox();
            label11 = new Label();
            dtpFechaRecepcion = new DateTimePicker();
            label7 = new Label();
            txtNoCheque = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            dgvHistorial = new DataGridView();
            label8 = new Label();
            txtMonto = new TextBox();
            label9 = new Label();
            cboMonedas = new ComboBox();
            label10 = new Label();
            txtObservaciones = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(127, 16);
            txtId.Name = "txtId";
            txtId.Size = new Size(103, 27);
            txtId.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 19);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 16;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 17;
            label1.Text = "Empleado";
            // 
            // cboEmpleados
            // 
            cboEmpleados.FormattingEnabled = true;
            cboEmpleados.Location = new Point(127, 54);
            cboEmpleados.Name = "cboEmpleados";
            cboEmpleados.Size = new Size(292, 29);
            cboEmpleados.TabIndex = 18;
            cboEmpleados.SelectedIndexChanged += cboEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 19;
            label3.Text = "Familiar";
            // 
            // cboFamiliares
            // 
            cboFamiliares.FormattingEnabled = true;
            cboFamiliares.Location = new Point(127, 96);
            cboFamiliares.Name = "cboFamiliares";
            cboFamiliares.Size = new Size(292, 29);
            cboFamiliares.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 142);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 21;
            label4.Text = "Tipo";
            // 
            // cboTipoReclamo
            // 
            cboTipoReclamo.FormattingEnabled = true;
            cboTipoReclamo.Location = new Point(127, 139);
            cboTipoReclamo.Name = "cboTipoReclamo";
            cboTipoReclamo.Size = new Size(179, 29);
            cboTipoReclamo.TabIndex = 22;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(398, 139);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(138, 29);
            cboStatus.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(325, 142);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 23;
            label5.Text = "Status";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(21, 319);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(554, 214);
            tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtMontoCheque);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(txtOtrosGastos);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtNoCubierto);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(txtTimbres);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(txtCoaseguro);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(txtDeducible);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dtpFechaRecepcion);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtNoCheque);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(546, 180);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos de Cheque";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMontoCheque
            // 
            txtMontoCheque.BackColor = Color.Gainsboro;
            txtMontoCheque.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMontoCheque.Location = new Point(425, 123);
            txtMontoCheque.Name = "txtMontoCheque";
            txtMontoCheque.Size = new Size(100, 27);
            txtMontoCheque.TabIndex = 32;
            txtMontoCheque.KeyPress += NumericTextBox_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(241, 126);
            label16.Name = "label16";
            label16.Size = new Size(182, 19);
            label16.TabIndex = 31;
            label16.Text = "Monto del Cheque (Q)";
            // 
            // txtOtrosGastos
            // 
            txtOtrosGastos.Location = new Point(425, 87);
            txtOtrosGastos.Name = "txtOtrosGastos";
            txtOtrosGastos.Size = new Size(100, 27);
            txtOtrosGastos.TabIndex = 30;
            txtOtrosGastos.KeyPress += NumericTextBox_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(241, 90);
            label15.Name = "label15";
            label15.Size = new Size(140, 21);
            label15.TabIndex = 29;
            label15.Text = "Otros Gastos (Q)";
            // 
            // txtNoCubierto
            // 
            txtNoCubierto.Location = new Point(425, 49);
            txtNoCubierto.Name = "txtNoCubierto";
            txtNoCubierto.Size = new Size(100, 27);
            txtNoCubierto.TabIndex = 28;
            txtNoCubierto.KeyPress += NumericTextBox_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(241, 52);
            label14.Name = "label14";
            label14.Size = new Size(141, 21);
            label14.TabIndex = 27;
            label14.Text = "No Cubiertos (Q)";
            // 
            // txtTimbres
            // 
            txtTimbres.Location = new Point(128, 120);
            txtTimbres.Name = "txtTimbres";
            txtTimbres.Size = new Size(97, 27);
            txtTimbres.TabIndex = 26;
            txtTimbres.KeyPress += NumericTextBox_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 123);
            label13.Name = "label13";
            label13.Size = new Size(98, 21);
            label13.TabIndex = 25;
            label13.Text = "Timbres (Q)";
            // 
            // txtCoaseguro
            // 
            txtCoaseguro.Location = new Point(128, 87);
            txtCoaseguro.Name = "txtCoaseguro";
            txtCoaseguro.Size = new Size(97, 27);
            txtCoaseguro.TabIndex = 24;
            txtCoaseguro.KeyPress += NumericTextBox_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 90);
            label12.Name = "label12";
            label12.Size = new Size(126, 21);
            label12.TabIndex = 23;
            label12.Text = "Coaseguro (Q)";
            // 
            // txtDeducible
            // 
            txtDeducible.Location = new Point(128, 49);
            txtDeducible.Name = "txtDeducible";
            txtDeducible.Size = new Size(97, 27);
            txtDeducible.TabIndex = 22;
            txtDeducible.KeyPress += NumericTextBox_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 52);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 21;
            label11.Text = "Deducible (Q)";
            // 
            // dtpFechaRecepcion
            // 
            dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
            dtpFechaRecepcion.Location = new Point(398, 10);
            dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            dtpFechaRecepcion.Size = new Size(127, 27);
            dtpFechaRecepcion.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(241, 13);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 19;
            label7.Text = "Fecha Recepción";
            // 
            // txtNoCheque
            // 
            txtNoCheque.Location = new Point(102, 10);
            txtNoCheque.Name = "txtNoCheque";
            txtNoCheque.Size = new Size(123, 27);
            txtNoCheque.TabIndex = 18;
            txtNoCheque.KeyPress += txtNoCheque_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 13);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 17;
            label6.Text = "Número";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 185);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 26;
            label8.Text = "Monto (Q)";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(127, 182);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(109, 27);
            txtMonto.TabIndex = 27;
            txtMonto.KeyPress += NumericTextBox_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(292, 185);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 28;
            label9.Text = "Moneda";
            // 
            // cboMonedas
            // 
            cboMonedas.FormattingEnabled = true;
            cboMonedas.Location = new Point(375, 182);
            cboMonedas.Name = "cboMonedas";
            cboMonedas.Size = new Size(161, 29);
            cboMonedas.TabIndex = 29;
            cboMonedas.SelectedIndexChanged += cboMonedas_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(21, 225);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 30;
            label10.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(153, 225);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(383, 79);
            txtObservaciones.TabIndex = 31;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(436, 13);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(113, 108);
            iconButton1.TabIndex = 32;
            iconButton1.Text = "Guardar";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmReclamos
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 533);
            Controls.Add(iconButton1);
            Controls.Add(txtObservaciones);
            Controls.Add(label10);
            Controls.Add(cboMonedas);
            Controls.Add(label9);
            Controls.Add(txtMonto);
            Controls.Add(label8);
            Controls.Add(tabControl1);
            Controls.Add(cboStatus);
            Controls.Add(label5);
            Controls.Add(cboTipoReclamo);
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
            Name = "frmReclamos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ingreso de Reclamos";
            Load += frmReclamos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label2;
        private Label label1;
        private ComboBox cboEmpleados;
        private Label label3;
        private ComboBox cboFamiliares;
        private Label label4;
        private ComboBox cboTipoReclamo;
        private ComboBox cboStatus;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label7;
        private TextBox txtNoCheque;
        private Label label6;
        private TabPage tabPage2;
        private DataGridView dgvHistorial;
        private DateTimePicker dtpFechaRecepcion;
        private Label label8;
        private TextBox txtMonto;
        private Label label9;
        private ComboBox cboMonedas;
        private Label label10;
        private TextBox txtObservaciones;
        private TextBox txtMontoCheque;
        private Label label16;
        private TextBox txtOtrosGastos;
        private Label label15;
        private TextBox txtNoCubierto;
        private Label label14;
        private TextBox txtTimbres;
        private Label label13;
        private TextBox txtCoaseguro;
        private Label label12;
        private TextBox txtDeducible;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ErrorProvider errorProvider1;
    }
}