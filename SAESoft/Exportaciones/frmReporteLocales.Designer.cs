namespace SAESoft.Exportaciones
{
    partial class frmReporteLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteLocales));
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(84, 13);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(129, 27);
            dtpInicio.TabIndex = 1;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(84, 58);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(129, 27);
            dtpFin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 63);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 2;
            label2.Text = "Fin";
            // 
            // iconButton1
            // 
            iconButton1.ForeColor = Color.Green;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(236, 18);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(102, 64);
            iconButton1.TabIndex = 13;
            iconButton1.Text = "Finalizar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmReporteLocales
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 111);
            Controls.Add(iconButton1);
            Controls.Add(dtpFin);
            Controls.Add(label2);
            Controls.Add(dtpInicio);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReporteLocales";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmReporteLocales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}