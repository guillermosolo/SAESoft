namespace SAESoft.Incentivo
{
    partial class frmBuscarDepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarDepto));
            icbBuscar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboEncargado = new ComboBox();
            SuspendLayout();
            // 
            // icbBuscar
            // 
            icbBuscar.DialogResult = DialogResult.OK;
            icbBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            icbBuscar.ForeColor = Color.FromArgb(0, 122, 172);
            icbBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            icbBuscar.IconColor = Color.FromArgb(0, 122, 204);
            icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbBuscar.IconSize = 24;
            icbBuscar.Location = new Point(120, 110);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 50;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Century Gothic", 12F);
            txtNombre.Location = new Point(120, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(41, 19);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 48;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(16, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 51;
            label1.Text = "Encargado";
            // 
            // cboEncargado
            // 
            cboEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEncargado.Font = new Font("Century Gothic", 12F);
            cboEncargado.FormattingEnabled = true;
            cboEncargado.Location = new Point(120, 60);
            cboEncargado.Name = "cboEncargado";
            cboEncargado.Size = new Size(225, 29);
            cboEncargado.TabIndex = 52;
            // 
            // frmBuscarDepto
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 160);
            Controls.Add(cboEncargado);
            Controls.Add(label1);
            Controls.Add(icbBuscar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarDepto";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmBuscarDepto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private ComboBox cboEncargado;
    }
}