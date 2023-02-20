namespace SAESoft.Importaciones
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
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.icbExcel = new FontAwesome.Sharp.IconButton();
            this.pnlReportes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.groupBox1);
            this.pnlReportes.Controls.Add(this.groupBox2);
            this.pnlReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlReportes.Location = new System.Drawing.Point(0, 0);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(800, 450);
            this.pnlReportes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(409, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 362);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.icbExcel);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(33, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 362);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // icbExcel
            // 
            this.icbExcel.FlatAppearance.BorderSize = 0;
            this.icbExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icbExcel.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.icbExcel.IconColor = System.Drawing.Color.Green;
            this.icbExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbExcel.IconSize = 32;
            this.icbExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbExcel.Location = new System.Drawing.Point(19, 28);
            this.icbExcel.Name = "icbExcel";
            this.icbExcel.Size = new System.Drawing.Size(298, 55);
            this.icbExcel.TabIndex = 1;
            this.icbExcel.Text = "Excel para ERP";
            this.icbExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbExcel.UseVisualStyleBackColor = true;
            this.icbExcel.Click += new System.EventHandler(this.icbExcel_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlReportes);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.pnlReportes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlReportes;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icbExcel;
    }
}