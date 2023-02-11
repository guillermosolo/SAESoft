namespace SAESoft.Importaciones
{
    partial class frmFecha
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.icbFinalizar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(94, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(116, 27);
            this.dtpFecha.TabIndex = 1;
            // 
            // icbFinalizar
            // 
            this.icbFinalizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.icbFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbFinalizar.ForeColor = System.Drawing.Color.Green;
            this.icbFinalizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.icbFinalizar.IconColor = System.Drawing.Color.Green;
            this.icbFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbFinalizar.IconSize = 24;
            this.icbFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbFinalizar.Location = new System.Drawing.Point(59, 49);
            this.icbFinalizar.Name = "icbFinalizar";
            this.icbFinalizar.Size = new System.Drawing.Size(124, 36);
            this.icbFinalizar.TabIndex = 9;
            this.icbFinalizar.Text = "Aceptar";
            this.icbFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbFinalizar.UseVisualStyleBackColor = true;
            this.icbFinalizar.Click += new System.EventHandler(this.icbFinalizar_Click);
            // 
            // frmFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 97);
            this.Controls.Add(this.icbFinalizar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFecha;
        private FontAwesome.Sharp.IconButton icbFinalizar;
    }
}