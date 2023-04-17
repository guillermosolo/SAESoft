namespace SAESoft.AdministracionSistema.Importaciones
{
    partial class frmBuscarAduana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAduana));
            txtDescripcion = new TextBox();
            label2 = new Label();
            icbBuscar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cboVia = new ComboBox();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(132, 6);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 27);
            txtDescripcion.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 47;
            label2.Text = "Nombre";
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
            icbBuscar.Location = new Point(132, 99);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 50;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 51;
            label1.Text = "Vía";
            // 
            // cboVia
            // 
            cboVia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVia.Enabled = false;
            cboVia.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboVia.FormattingEnabled = true;
            cboVia.Location = new Point(132, 51);
            cboVia.Name = "cboVia";
            cboVia.Size = new Size(241, 29);
            cboVia.TabIndex = 52;
            // 
            // frmBuscarAduana
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 152);
            Controls.Add(cboVia);
            Controls.Add(label1);
            Controls.Add(icbBuscar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarAduana";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBuscarAduana";
            Load += frmBuscarAduana_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label2;
        private FontAwesome.Sharp.IconButton icbBuscar;
        private Label label1;
        private ComboBox cboVia;
    }
}