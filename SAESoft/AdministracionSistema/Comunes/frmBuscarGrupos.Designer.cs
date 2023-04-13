namespace SAESoft.AdministracionSistema.Comunes
{
    partial class frmBuscarGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarGrupos));
            icbBuscar = new FontAwesome.Sharp.IconButton();
            cboModulo = new ComboBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // icbBuscar
            // 
            icbBuscar.DialogResult = DialogResult.OK;
            icbBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icbBuscar.ForeColor = Color.FromArgb(0, 122, 172);
            icbBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icbBuscar.IconColor = Color.FromArgb(0, 122, 204);
            icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbBuscar.IconSize = 24;
            icbBuscar.Location = new Point(147, 86);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 49;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // cboModulo
            // 
            cboModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModulo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboModulo.FormattingEnabled = true;
            cboModulo.IntegralHeight = false;
            cboModulo.Location = new Point(132, 48);
            cboModulo.Name = "cboModulo";
            cboModulo.Size = new Size(241, 29);
            cboModulo.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 56);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 47;
            label7.Text = "Módulo";
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(132, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 27);
            txtNombre.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 45;
            label2.Text = "Nombres";
            // 
            // frmBuscarGrupos
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 129);
            Controls.Add(icbBuscar);
            Controls.Add(cboModulo);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarGrupos";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmBuscarGrupos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private ComboBox cboModulo;
        private Label label7;
        private TextBox txtNombre;
        private Label label2;
    }
}