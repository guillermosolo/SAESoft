namespace SAESoft.AdministracionSistema.Importaciones
{
    partial class frmBuscarAgente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAgente));
            txtNombres = new TextBox();
            label2 = new Label();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            textBox1 = new TextBox();
            label1 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            icbBuscar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtNombres
            // 
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(148, 17);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(241, 27);
            txtNombres.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 20);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 49;
            label2.Text = "Nombres";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(132, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 47;
            label1.Text = "Nombre";
            // 
            // txtApellidos
            // 
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(148, 50);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(241, 27);
            txtApellidos.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 53);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 51;
            label3.Text = "Apellidos";
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
            icbBuscar.Location = new Point(148, 83);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 55;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // frmBuscarAgente
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 131);
            Controls.Add(icbBuscar);
            Controls.Add(txtApellidos);
            Controls.Add(label3);
            Controls.Add(txtNombres);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBuscarAgente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBuscarAgente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombres;
        private Label label2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtApellidos;
        private Label label3;
        private FontAwesome.Sharp.IconButton icbBuscar;
    }
}