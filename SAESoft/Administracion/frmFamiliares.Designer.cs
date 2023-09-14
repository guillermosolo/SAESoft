namespace SAESoft.Administracion
{
    partial class frmFamiliares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFamiliares));
            cboParentesco = new ComboBox();
            label3 = new Label();
            txtApellidos = new TextBox();
            label5 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            dtpFechaNac = new DateTimePicker();
            label8 = new Label();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cboParentesco
            // 
            cboParentesco.DropDownStyle = ComboBoxStyle.DropDownList;
            cboParentesco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboParentesco.FormattingEnabled = true;
            cboParentesco.ItemHeight = 21;
            cboParentesco.Location = new Point(144, 63);
            cboParentesco.Name = "cboParentesco";
            cboParentesco.Size = new Size(373, 29);
            cboParentesco.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 63);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 20;
            label3.Text = "Parentesco";
            // 
            // txtApellidos
            // 
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(388, 108);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(129, 27);
            txtApellidos.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(302, 111);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 26;
            label5.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(144, 108);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(129, 27);
            txtNombres.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 25;
            label2.Text = "Nombres";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNac.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(209, 154);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(120, 27);
            dtpFechaNac.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 155);
            label8.Name = "label8";
            label8.Size = new Size(179, 21);
            label8.TabIndex = 30;
            label8.Text = "Fecha de Nacimiento";
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
            icbFinalizar.Location = new Point(209, 202);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 31;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(335, 160);
            label10.Name = "label10";
            label10.Size = new Size(69, 21);
            label10.TabIndex = 48;
            label10.Text = "Género";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbFemenino.Location = new Point(415, 173);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(104, 25);
            rdbFemenino.TabIndex = 47;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Checked = true;
            rdbMasculino.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbMasculino.Location = new Point(415, 146);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(106, 25);
            rdbMasculino.TabIndex = 46;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(24, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(493, 40);
            lblTitulo.TabIndex = 49;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmFamiliares
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 272);
            Controls.Add(lblTitulo);
            Controls.Add(label10);
            Controls.Add(rdbFemenino);
            Controls.Add(rdbMasculino);
            Controls.Add(icbFinalizar);
            Controls.Add(dtpFechaNac);
            Controls.Add(label8);
            Controls.Add(txtApellidos);
            Controls.Add(label5);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            Controls.Add(cboParentesco);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFamiliares";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmFamiliares_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboParentesco;
        private Label label3;
        private TextBox txtApellidos;
        private Label label5;
        private TextBox txtNombres;
        private Label label2;
        private DateTimePicker dtpFechaNac;
        private Label label8;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private Label label10;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private ErrorProvider errorProvider1;
        private Label lblTitulo;
    }
}