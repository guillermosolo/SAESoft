namespace SAESoft.AdministracionSistema
{
    partial class frmBuscarModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarModulos));
            this.icbBuscar = new FontAwesome.Sharp.IconButton();
            this.txtNombres = new System.Windows.Forms.TextBox();
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
            this.icbBuscar.Location = new System.Drawing.Point(197, 60);
            this.icbBuscar.Name = "icbBuscar";
            this.icbBuscar.Size = new System.Drawing.Size(107, 35);
            this.icbBuscar.TabIndex = 33;
            this.icbBuscar.Text = "Buscar";
            this.icbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbBuscar.UseVisualStyleBackColor = true;
            this.icbBuscar.Click += new System.EventHandler(this.icbBuscar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombres.Location = new System.Drawing.Point(127, 7);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(352, 27);
            this.txtNombres.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombres";
            // 
            // frmBuscarModulos
            // 
            this.AcceptButton = this.icbBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 107);
            this.Controls.Add(this.icbBuscar);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private TextBox txtNombres;
        private Label label2;
    }
}