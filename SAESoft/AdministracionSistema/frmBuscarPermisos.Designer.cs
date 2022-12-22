namespace SAESoft.AdministracionSistema
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
            this.icbBuscar = new FontAwesome.Sharp.IconButton();
            this.cboModulos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // icbBuscar
            // 
            this.icbBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.icbBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.icbBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icbBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbBuscar.IconSize = 24;
            this.icbBuscar.Location = new System.Drawing.Point(147, 86);
            this.icbBuscar.Name = "icbBuscar";
            this.icbBuscar.Size = new System.Drawing.Size(107, 35);
            this.icbBuscar.TabIndex = 39;
            this.icbBuscar.Text = "Buscar";
            this.icbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbBuscar.UseVisualStyleBackColor = true;
            this.icbBuscar.Click += new System.EventHandler(this.icbBuscar_Click);
            // 
            // cboModulos
            // 
            this.cboModulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboModulos.FormattingEnabled = true;
            this.cboModulos.Location = new System.Drawing.Point(132, 48);
            this.cboModulos.Name = "cboModulos";
            this.cboModulos.Size = new System.Drawing.Size(241, 29);
            this.cboModulos.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Módulo";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(132, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 27);
            this.txtNombre.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombres";
            // 
            // frmBuscarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 139);
            this.Controls.Add(this.icbBuscar);
            this.Controls.Add(this.cboModulos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmBuscarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private ComboBox cboModulos;
        private Label label7;
        private TextBox txtNombre;
        private Label label2;
    }
}