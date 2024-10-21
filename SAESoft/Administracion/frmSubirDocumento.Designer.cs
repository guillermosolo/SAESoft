namespace SAESoft.Administracion
{
    partial class frmSubirDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubirDocumento));
            label1 = new Label();
            cboDocumento = new ComboBox();
            label2 = new Label();
            cboTipo = new ComboBox();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cboEmpresa = new ComboBox();
            label4 = new Label();
            btnFile = new Button();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // cboDocumento
            // 
            cboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDocumento.FormattingEnabled = true;
            cboDocumento.Location = new Point(129, 63);
            cboDocumento.Name = "cboDocumento";
            cboDocumento.Size = new Size(355, 29);
            cboDocumento.TabIndex = 1;
            cboDocumento.SelectedIndexChanged += cboDocumento_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            label2.Visible = false;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(129, 103);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(355, 29);
            cboTipo.TabIndex = 3;
            cboTipo.Visible = false;
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
            icbFinalizar.Location = new Point(194, 183);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 33;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 146);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 34;
            label3.Text = "Empresa";
            label3.Visible = false;
            // 
            // cboEmpresa
            // 
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpresa.FormattingEnabled = true;
            cboEmpresa.Location = new Point(129, 143);
            cboEmpresa.Name = "cboEmpresa";
            cboEmpresa.Size = new Size(355, 29);
            cboEmpresa.TabIndex = 35;
            cboEmpresa.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 36;
            label4.Text = "Archivo";
            // 
            // btnFile
            // 
            btnFile.Location = new Point(130, 24);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(109, 28);
            btnFile.TabIndex = 37;
            btnFile.Text = "Examinar...";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(246, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 17);
            label5.TabIndex = 38;
            label5.Text = "No se ha seleccionado ningún archivo.";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf";
            // 
            // frmSubirDocumento
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 232);
            Controls.Add(label5);
            Controls.Add(btnFile);
            Controls.Add(label4);
            Controls.Add(cboEmpresa);
            Controls.Add(label3);
            Controls.Add(icbFinalizar);
            Controls.Add(cboTipo);
            Controls.Add(label2);
            Controls.Add(cboDocumento);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSubirDocumento";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmSubirDocumento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboDocumento;
        private Label label2;
        private ComboBox cboTipo;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private Label label3;
        private ComboBox cboEmpresa;
        private Label label4;
        private Button btnFile;
        private Label label5;
        private OpenFileDialog openFileDialog1;
    }
}