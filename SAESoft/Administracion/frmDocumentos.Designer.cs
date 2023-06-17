namespace SAESoft.Administracion
{
    partial class frmDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentos));
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            dtpEmision = new DateTimePicker();
            chkVence = new CheckBox();
            dtpVencimiento = new DateTimePicker();
            lblTitulo = new Label();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 52);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(112, 49);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(247, 27);
            txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 90);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Emisión";
            // 
            // dtpEmision
            // 
            dtpEmision.Format = DateTimePickerFormat.Short;
            dtpEmision.Location = new Point(249, 82);
            dtpEmision.Name = "dtpEmision";
            dtpEmision.Size = new Size(110, 27);
            dtpEmision.TabIndex = 3;
            // 
            // chkVence
            // 
            chkVence.AutoSize = true;
            chkVence.Location = new Point(37, 122);
            chkVence.Name = "chkVence";
            chkVence.Size = new Size(206, 25);
            chkVence.TabIndex = 4;
            chkVence.Text = "Fecha de Vencimiento";
            chkVence.UseVisualStyleBackColor = true;
            chkVence.CheckedChanged += chkVence_CheckedChanged;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Enabled = false;
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(249, 122);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(110, 27);
            dtpVencimiento.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(37, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 40);
            lblTitulo.TabIndex = 6;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.TextChanged += lblTitulo_TextChanged;
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
            icbFinalizar.Location = new Point(131, 160);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 32;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // frmDocumentos
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 208);
            Controls.Add(icbFinalizar);
            Controls.Add(lblTitulo);
            Controls.Add(dtpVencimiento);
            Controls.Add(chkVence);
            Controls.Add(dtpEmision);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDocumentos";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmDocumentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private DateTimePicker dtpEmision;
        private CheckBox chkVence;
        private DateTimePicker dtpVencimiento;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconButton icbFinalizar;
    }
}