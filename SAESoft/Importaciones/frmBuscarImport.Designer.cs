namespace SAESoft.Importaciones
{
    partial class frmBuscarImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarImport));
            rbBL = new RadioButton();
            label1 = new Label();
            txtNumero = new TextBox();
            rbContendor = new RadioButton();
            rbPoliza = new RadioButton();
            icbBuscar = new FontAwesome.Sharp.IconButton();
            rbID = new RadioButton();
            SuspendLayout();
            // 
            // rbBL
            // 
            rbBL.AutoSize = true;
            rbBL.Checked = true;
            rbBL.Location = new Point(12, 60);
            rbBL.Name = "rbBL";
            rbBL.Size = new Size(52, 25);
            rbBL.TabIndex = 0;
            rbBL.TabStop = true;
            rbBL.Text = "B.L.";
            rbBL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 1;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Location = new Point(90, 18);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(223, 27);
            txtNumero.TabIndex = 2;
            // 
            // rbContendor
            // 
            rbContendor.AutoSize = true;
            rbContendor.Location = new Point(70, 60);
            rbContendor.Name = "rbContendor";
            rbContendor.Size = new Size(124, 25);
            rbContendor.TabIndex = 3;
            rbContendor.Text = "Contenedor";
            rbContendor.UseVisualStyleBackColor = true;
            // 
            // rbPoliza
            // 
            rbPoliza.AutoSize = true;
            rbPoliza.Location = new Point(200, 60);
            rbPoliza.Name = "rbPoliza";
            rbPoliza.Size = new Size(71, 25);
            rbPoliza.TabIndex = 4;
            rbPoliza.Text = "Póliza";
            rbPoliza.UseVisualStyleBackColor = true;
            // 
            // icbBuscar
            // 
            icbBuscar.DialogResult = DialogResult.OK;
            icbBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icbBuscar.IconColor = Color.FromArgb(0, 122, 172);
            icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbBuscar.IconSize = 32;
            icbBuscar.Location = new Point(124, 99);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(143, 44);
            icbBuscar.TabIndex = 5;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.Location = new Point(277, 60);
            rbID.Name = "rbID";
            rbID.Size = new Size(45, 25);
            rbID.TabIndex = 6;
            rbID.Text = "ID";
            rbID.UseVisualStyleBackColor = true;
            // 
            // frmBuscarImport
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 155);
            Controls.Add(rbID);
            Controls.Add(icbBuscar);
            Controls.Add(rbPoliza);
            Controls.Add(rbContendor);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(rbBL);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarImport";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbBL;
        private Label label1;
        private TextBox txtNumero;
        private RadioButton rbContendor;
        private RadioButton rbPoliza;
        private FontAwesome.Sharp.IconButton icbBuscar;
        private RadioButton rbID;
    }
}