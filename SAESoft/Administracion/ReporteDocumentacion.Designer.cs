namespace SAESoft.Administracion
{
    partial class ReporteDocumentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteDocumentacion));
            checkBox2 = new CheckBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            checkBox1 = new CheckBox();
            clbEmpresas = new CheckedListBox();
            cboDocumento = new ComboBox();
            label1 = new Label();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(150, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Incluir Familiares";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.ForeColor = Color.Green;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(401, 49);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(102, 64);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Finalizar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(172, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Incluir Todos los Empleados";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // clbEmpresas
            // 
            clbEmpresas.CheckOnClick = true;
            clbEmpresas.FormattingEnabled = true;
            clbEmpresas.Location = new Point(12, 33);
            clbEmpresas.Name = "clbEmpresas";
            clbEmpresas.Size = new Size(121, 148);
            clbEmpresas.TabIndex = 14;
            // 
            // cboDocumento
            // 
            cboDocumento.FormattingEnabled = true;
            cboDocumento.Location = new Point(226, 9);
            cboDocumento.Name = "cboDocumento";
            cboDocumento.Size = new Size(277, 23);
            cboDocumento.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 19;
            label1.Text = "Documento";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(12, 8);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(57, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Todos";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // ReporteDocumentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 193);
            Controls.Add(checkBox3);
            Controls.Add(label1);
            Controls.Add(cboDocumento);
            Controls.Add(checkBox2);
            Controls.Add(iconButton1);
            Controls.Add(checkBox1);
            Controls.Add(clbEmpresas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReporteDocumentacion";
            StartPosition = FormStartPosition.CenterParent;
            Load += ReporteDocumentacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CheckBox checkBox1;
        private CheckedListBox clbEmpresas;
        private ComboBox cboDocumento;
        private Label label1;
        private CheckBox checkBox3;
    }
}