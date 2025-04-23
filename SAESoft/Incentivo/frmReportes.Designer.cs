namespace SAESoft.Incentivo
{
    partial class frmReportes
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
            groupBox2 = new GroupBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(iconButton4);
            groupBox2.Controls.Add(iconButton3);
            groupBox2.Controls.Add(iconButton1);
            groupBox2.Controls.Add(iconButton2);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(85, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 362);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reportes";
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Century Gothic", 12F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton4.IconColor = Color.Green;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(19, 191);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(298, 55);
            iconButton4.TabIndex = 6;
            iconButton4.Text = "Reporte General de Datos";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Century Gothic", 12F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton3.IconColor = Color.Green;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(19, 136);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(298, 55);
            iconButton3.TabIndex = 5;
            iconButton3.Text = "Reporte de Tardanzas";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(19, 81);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(298, 55);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Reporte para Sistema HR";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 12F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(19, 26);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(298, 55);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Reporte General de Incentivos";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Name = "frmReportes";
            Text = "frmReportes";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}