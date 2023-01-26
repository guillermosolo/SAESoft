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
            this.rbBL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rbContendor = new System.Windows.Forms.RadioButton();
            this.rbPoliza = new System.Windows.Forms.RadioButton();
            this.icbBuscar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // rbBL
            // 
            this.rbBL.AutoSize = true;
            this.rbBL.Checked = true;
            this.rbBL.Location = new System.Drawing.Point(12, 60);
            this.rbBL.Name = "rbBL";
            this.rbBL.Size = new System.Drawing.Size(52, 25);
            this.rbBL.TabIndex = 0;
            this.rbBL.TabStop = true;
            this.rbBL.Text = "B.L.";
            this.rbBL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(90, 18);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(223, 27);
            this.txtNumero.TabIndex = 2;
            // 
            // rbContendor
            // 
            this.rbContendor.AutoSize = true;
            this.rbContendor.Location = new System.Drawing.Point(124, 60);
            this.rbContendor.Name = "rbContendor";
            this.rbContendor.Size = new System.Drawing.Size(124, 25);
            this.rbContendor.TabIndex = 3;
            this.rbContendor.Text = "Contenedor";
            this.rbContendor.UseVisualStyleBackColor = true;
            // 
            // rbPoliza
            // 
            this.rbPoliza.AutoSize = true;
            this.rbPoliza.Location = new System.Drawing.Point(296, 60);
            this.rbPoliza.Name = "rbPoliza";
            this.rbPoliza.Size = new System.Drawing.Size(71, 25);
            this.rbPoliza.TabIndex = 4;
            this.rbPoliza.Text = "Póliza";
            this.rbPoliza.UseVisualStyleBackColor = true;
            // 
            // icbBuscar
            // 
            this.icbBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.icbBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.icbBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbBuscar.IconSize = 32;
            this.icbBuscar.Location = new System.Drawing.Point(124, 99);
            this.icbBuscar.Name = "icbBuscar";
            this.icbBuscar.Size = new System.Drawing.Size(143, 44);
            this.icbBuscar.TabIndex = 5;
            this.icbBuscar.Text = "Buscar";
            this.icbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbBuscar.UseVisualStyleBackColor = true;
            this.icbBuscar.Click += new System.EventHandler(this.icbBuscar_Click);
            // 
            // frmBuscarImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 155);
            this.Controls.Add(this.icbBuscar);
            this.Controls.Add(this.rbPoliza);
            this.Controls.Add(this.rbContendor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBL);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbBL;
        private Label label1;
        private TextBox txtNumero;
        private RadioButton rbContendor;
        private RadioButton rbPoliza;
        private FontAwesome.Sharp.IconButton icbBuscar;
    }
}