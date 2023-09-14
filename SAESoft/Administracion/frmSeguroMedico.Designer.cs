namespace SAESoft.Administracion
{
    partial class frmSeguroMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguroMedico));
            cboFamiliar = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            txtCertificado = new TextBox();
            label2 = new Label();
            txtCarnet = new TextBox();
            dtpVencimiento = new DateTimePicker();
            dtpEmision = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cboFamiliar
            // 
            cboFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFamiliar.FormattingEnabled = true;
            cboFamiliar.Location = new Point(127, 67);
            cboFamiliar.Name = "cboFamiliar";
            cboFamiliar.Size = new Size(247, 29);
            cboFamiliar.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 70);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 35;
            label3.Text = "Familiar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 110);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 37;
            label1.Text = "Certificado";
            // 
            // txtCertificado
            // 
            txtCertificado.Location = new Point(127, 107);
            txtCertificado.Name = "txtCertificado";
            txtCertificado.Size = new Size(100, 27);
            txtCertificado.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 147);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 39;
            label2.Text = "Carnet";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(127, 144);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(185, 27);
            txtCarnet.TabIndex = 40;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(127, 211);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(110, 27);
            dtpVencimiento.TabIndex = 43;
            // 
            // dtpEmision
            // 
            dtpEmision.Format = DateTimePickerFormat.Short;
            dtpEmision.Location = new Point(127, 178);
            dtpEmision.Name = "dtpEmision";
            dtpEmision.Size = new Size(110, 27);
            dtpEmision.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 183);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 41;
            label4.Text = "Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 216);
            label5.Name = "label5";
            label5.Size = new Size(31, 21);
            label5.TabIndex = 44;
            label5.Text = "Fin";
            // 
            // icbFinalizar
            // 
            icbFinalizar.DialogResult = DialogResult.OK;
            icbFinalizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icbFinalizar.ForeColor = Color.Green;
            icbFinalizar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            icbFinalizar.IconColor = Color.Green;
            icbFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbFinalizar.IconSize = 24;
            icbFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            icbFinalizar.Location = new Point(138, 253);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 45;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(353, 40);
            lblTitulo.TabIndex = 46;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmSeguroMedico
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 305);
            Controls.Add(lblTitulo);
            Controls.Add(icbFinalizar);
            Controls.Add(label5);
            Controls.Add(dtpVencimiento);
            Controls.Add(dtpEmision);
            Controls.Add(label4);
            Controls.Add(txtCarnet);
            Controls.Add(label2);
            Controls.Add(txtCertificado);
            Controls.Add(label1);
            Controls.Add(cboFamiliar);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSeguroMedico";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmSeguroMedico_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFamiliar;
        private Label label3;
        private Label label1;
        private TextBox txtCertificado;
        private Label label2;
        private TextBox txtCarnet;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpEmision;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private ErrorProvider errorProvider1;
        private Label lblTitulo;
    }
}