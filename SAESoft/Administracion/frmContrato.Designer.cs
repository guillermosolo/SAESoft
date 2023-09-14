namespace SAESoft.Administracion
{
    partial class frmContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrato));
            txtNumero = new TextBox();
            label1 = new Label();
            cboEmpresa = new ComboBox();
            label2 = new Label();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Location = new Point(113, 61);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(247, 27);
            txtNumero.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // cboEmpresa
            // 
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(113, 107);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(247, 29);
            cboEmpresa.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 6;
            label2.Text = "Empresa";
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
            icbFinalizar.Location = new Point(130, 151);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 33;
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
            lblTitulo.Location = new Point(38, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 40);
            lblTitulo.TabIndex = 34;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmContrato
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 206);
            Controls.Add(lblTitulo);
            Controls.Add(icbFinalizar);
            Controls.Add(cboEmpresa);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmContrato";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmContrato_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private ComboBox cboEmpresa;
        private Label label2;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private ErrorProvider errorProvider1;
        private Label lblTitulo;
    }
}