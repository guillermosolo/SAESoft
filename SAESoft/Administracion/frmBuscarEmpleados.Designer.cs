namespace SAESoft.Administracion
{
    partial class frmBuscarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarEmpleados));
            txtNombreCOR = new TextBox();
            label7 = new Label();
            txtNombreESP = new TextBox();
            label6 = new Label();
            icbBuscar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // txtNombreCOR
            // 
            txtNombreCOR.CharacterCasing = CharacterCasing.Upper;
            txtNombreCOR.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreCOR.Location = new Point(156, 108);
            txtNombreCOR.Name = "txtNombreCOR";
            txtNombreCOR.Size = new Size(217, 27);
            txtNombreCOR.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 111);
            label7.Name = "label7";
            label7.Size = new Size(146, 21);
            label7.TabIndex = 49;
            label7.Text = "Nombre Coreano";
            // 
            // txtNombreESP
            // 
            txtNombreESP.CharacterCasing = CharacterCasing.Upper;
            txtNombreESP.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreESP.Location = new Point(156, 67);
            txtNombreESP.Name = "txtNombreESP";
            txtNombreESP.Size = new Size(217, 27);
            txtNombreESP.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 70);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 48;
            label6.Text = "Nombre Español";
            // 
            // icbBuscar
            // 
            icbBuscar.DialogResult = DialogResult.OK;
            icbBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            icbBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icbBuscar.IconColor = Color.FromArgb(0, 122, 172);
            icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbBuscar.IconSize = 32;
            icbBuscar.Location = new Point(125, 154);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(143, 44);
            icbBuscar.TabIndex = 53;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 25);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 54;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(156, 22);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(217, 27);
            txtCodigo.TabIndex = 0;
            // 
            // frmBuscarEmpleados
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 210);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(icbBuscar);
            Controls.Add(txtNombreCOR);
            Controls.Add(label7);
            Controls.Add(txtNombreESP);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBuscarEmpleados";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombreCOR;
        private Label label7;
        private TextBox txtNombreESP;
        private Label label6;
        private FontAwesome.Sharp.IconButton icbBuscar;
        private Label label1;
        private TextBox txtCodigo;
    }
}