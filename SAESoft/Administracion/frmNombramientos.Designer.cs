namespace SAESoft.Administracion
{
    partial class frmNombramientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombramientos));
            label1 = new Label();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            cboTipo = new ComboBox();
            label4 = new Label();
            cboEmpresa = new ComboBox();
            label5 = new Label();
            txtRegistro = new TextBox();
            label6 = new Label();
            txtFolio = new TextBox();
            label7 = new Label();
            txtLibro = new TextBox();
            label8 = new Label();
            txtExpediente = new TextBox();
            label3 = new Label();
            dtpVencimiento = new DateTimePicker();
            dtpEmision = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            lblTitulo = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 66);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            // 
            // icbFinalizar
            // 
            icbFinalizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icbFinalizar.ForeColor = Color.Green;
            icbFinalizar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            icbFinalizar.IconColor = Color.Green;
            icbFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbFinalizar.IconSize = 24;
            icbFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            icbFinalizar.Location = new Point(559, 140);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 32;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(388, 63);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(295, 29);
            cboTipo.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 66);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 35;
            label4.Text = "Empresa";
            // 
            // cboEmpresa
            // 
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(120, 63);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(186, 29);
            cboEmpresa.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 105);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 37;
            label5.Text = "Registro";
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(120, 102);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(80, 27);
            txtRegistro.TabIndex = 38;
            txtRegistro.KeyPress += txtRegistro_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 105);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 39;
            label6.Text = "Folio";
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(273, 102);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(64, 27);
            txtFolio.TabIndex = 40;
            txtFolio.KeyPress += txtFolio_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(368, 105);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 41;
            label7.Text = "Libro";
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(420, 102);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(58, 27);
            txtLibro.TabIndex = 42;
            txtLibro.KeyPress += txtLibro_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 105);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 43;
            label8.Text = "Expediente";
            // 
            // txtExpediente
            // 
            txtExpediente.Location = new Point(603, 102);
            txtExpediente.Name = "txtExpediente";
            txtExpediente.Size = new Size(80, 27);
            txtExpediente.TabIndex = 44;
            txtExpediente.KeyPress += txtExpediente_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 145);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 48;
            label3.Text = "Vencimiento";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(388, 140);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(110, 27);
            dtpVencimiento.TabIndex = 47;
            // 
            // dtpEmision
            // 
            dtpEmision.Format = DateTimePickerFormat.Short;
            dtpEmision.Location = new Point(136, 140);
            dtpEmision.Name = "dtpEmision";
            dtpEmision.Size = new Size(110, 27);
            dtpEmision.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 145);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 45;
            label2.Text = "Inscripción";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(646, 244);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(37, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(646, 40);
            lblTitulo.TabIndex = 50;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNombramientos
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 441);
            Controls.Add(lblTitulo);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dtpVencimiento);
            Controls.Add(dtpEmision);
            Controls.Add(label2);
            Controls.Add(txtExpediente);
            Controls.Add(label8);
            Controls.Add(txtLibro);
            Controls.Add(label7);
            Controls.Add(txtFolio);
            Controls.Add(label6);
            Controls.Add(txtRegistro);
            Controls.Add(label5);
            Controls.Add(cboEmpresa);
            Controls.Add(label4);
            Controls.Add(cboTipo);
            Controls.Add(icbFinalizar);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNombramientos";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmDocumentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private ComboBox cboTipo;
        private Label label4;
        private ComboBox cboEmpresa;
        private Label label5;
        private TextBox txtRegistro;
        private Label label6;
        private TextBox txtLibro;
        private Label label7;
        private TextBox txtFolio;
        private Label label8;
        private TextBox txtExpediente;
        private Label label3;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpEmision;
        private Label label2;
        private DataGridView dataGridView1;
        private Label lblTitulo;
        private ErrorProvider errorProvider1;
    }
}