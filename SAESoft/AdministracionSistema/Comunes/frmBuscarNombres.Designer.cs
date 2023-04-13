namespace SAESoft.AdministracionSistema.Comunes
{
    partial class frmBuscarNombres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarNombres));
            icbBuscar = new FontAwesome.Sharp.IconButton();
            cboGrupos = new ComboBox();
            label7 = new Label();
            txtDescripcion = new TextBox();
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
            icbBuscar.Location = new Point(154, 92);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 44;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // cboGrupos
            // 
            cboGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrupos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboGrupos.FormattingEnabled = true;
            cboGrupos.IntegralHeight = false;
            cboGrupos.Location = new Point(139, 54);
            cboGrupos.Name = "cboGrupos";
            cboGrupos.Size = new Size(241, 29);
            cboGrupos.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 62);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 42;
            label7.Text = "Módulo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(139, 12);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 27);
            txtDescripcion.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 15);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 40;
            label2.Text = "Nombres";
            // 
            // frmBuscarNombres
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 139);
            Controls.Add(icbBuscar);
            Controls.Add(cboGrupos);
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarNombres";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmBuscarNombres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private ComboBox cboGrupos;
        private Label label7;
        private TextBox txtDescripcion;
        private Label label2;
    }
}