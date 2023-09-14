namespace SAESoft.Administracion
{
    partial class frmResidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidencia));
            label2 = new Label();
            cboTipo = new ComboBox();
            label3 = new Label();
            txtResolucion = new TextBox();
            label4 = new Label();
            dtpVencimiento = new DateTimePicker();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            cboFamiliar = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 106);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 4;
            label2.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(138, 103);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(247, 29);
            cboTipo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "Resolución";
            // 
            // txtResolucion
            // 
            txtResolucion.CharacterCasing = CharacterCasing.Upper;
            txtResolucion.Location = new Point(138, 140);
            txtResolucion.Name = "txtResolucion";
            txtResolucion.Size = new Size(247, 27);
            txtResolucion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 180);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 8;
            label4.Text = "Vencimiento";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(138, 180);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(135, 27);
            dtpVencimiento.TabIndex = 9;
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
            icbFinalizar.Location = new Point(138, 224);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 33;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // cboFamiliar
            // 
            cboFamiliar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFamiliar.FormattingEnabled = true;
            cboFamiliar.Location = new Point(138, 68);
            cboFamiliar.Name = "cboFamiliar";
            cboFamiliar.Size = new Size(247, 29);
            cboFamiliar.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 69);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 35;
            label1.Text = "Familiar";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(23, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(362, 40);
            lblTitulo.TabIndex = 37;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmResidencia
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 309);
            Controls.Add(lblTitulo);
            Controls.Add(cboFamiliar);
            Controls.Add(label1);
            Controls.Add(icbFinalizar);
            Controls.Add(dtpVencimiento);
            Controls.Add(label4);
            Controls.Add(txtResolucion);
            Controls.Add(label3);
            Controls.Add(cboTipo);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResidencia";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmResidencia_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cboTipo;
        private Label label3;
        private TextBox txtResolucion;
        private Label label4;
        private DateTimePicker dtpVencimiento;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private ComboBox cboFamiliar;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label lblTitulo;
    }
}