namespace SAESoft.AdministracionSistema.Seguridad
{
    partial class frmBuscarPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPermisos));
            icbBuscar = new FontAwesome.Sharp.IconButton();
            cboModulos = new ComboBox();
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
            icbBuscar.TabIndex = 39;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // cboModulos
            // 
            cboModulos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModulos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboModulos.FormattingEnabled = true;
            cboModulos.IntegralHeight = false;
            cboModulos.Location = new Point(132, 48);
            cboModulos.Name = "cboModulos";
            cboModulos.Size = new Size(241, 29);
            cboModulos.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 56);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 37;
            label7.Text = "Módulo";
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(132, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 27);
            txtNombre.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 31;
            label2.Text = "Nombres";
            // 
            // frmBuscarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 139);
            Controls.Add(icbBuscar);
            Controls.Add(cboModulos);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarPermisos";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmBuscarPermisos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private ComboBox cboModulos;
        private Label label7;
        private TextBox txtNombre;
        private Label label2;
    }
}