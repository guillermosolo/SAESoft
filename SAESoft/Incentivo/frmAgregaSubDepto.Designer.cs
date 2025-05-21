namespace SAESoft.Incentivo
{
    partial class frmAgregaSubDepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregaSubDepto));
            cboEncargado = new ComboBox();
            label1 = new Label();
            tsActivo = new SAESoft.Utilitarios.toggleSwitch();
            label13 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cboEncargado
            // 
            cboEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEncargado.Font = new Font("Century Gothic", 12F);
            cboEncargado.FormattingEnabled = true;
            cboEncargado.Location = new Point(142, 99);
            cboEncargado.Name = "cboEncargado";
            cboEncargado.Size = new Size(331, 29);
            cboEncargado.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(38, 99);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 56;
            label1.Text = "Encargado";
            // 
            // tsActivo
            // 
            tsActivo.Checked = true;
            tsActivo.CheckState = CheckState.Checked;
            tsActivo.Font = new Font("Century Gothic", 12F);
            tsActivo.Location = new Point(418, 15);
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
            tsActivo.TabIndex = 55;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F);
            label13.Location = new Point(343, 16);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 54;
            label13.Text = "Activo";
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Century Gothic", 12F);
            txtCodigo.Location = new Point(142, 16);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(93, 27);
            txtCodigo.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(68, 19);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 53;
            label4.Text = "Código";
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Font = new Font("Century Gothic", 12F);
            txtNombres.Location = new Point(142, 56);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(331, 27);
            txtNombres.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(63, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 52;
            label2.Text = "Nombre";
            // 
            // iconButton1
            // 
            iconButton1.DialogResult = DialogResult.OK;
            iconButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.ForestGreen;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.ForestGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(179, 142);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(135, 48);
            iconButton1.TabIndex = 58;
            iconButton1.Text = "Guardar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregaSubDepto
            // 
            AcceptButton = iconButton1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 211);
            Controls.Add(iconButton1);
            Controls.Add(cboEncargado);
            Controls.Add(label1);
            Controls.Add(tsActivo);
            Controls.Add(label13);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgregaSubDepto";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmAgregaSubDepto_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEncargado;
        private Label label1;
        private Utilitarios.toggleSwitch tsActivo;
        private Label label13;
        private TextBox txtCodigo;
        private Label label4;
        private TextBox txtNombres;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}