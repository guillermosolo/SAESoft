namespace SAESoft.Administracion
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
            pnlReportes = new Panel();
            groupBox2 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            icbExcel = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pnlReportes.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReportes
            // 
            pnlReportes.Controls.Add(groupBox2);
            pnlReportes.Dock = DockStyle.Fill;
            pnlReportes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlReportes.Location = new Point(0, 0);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(800, 450);
            pnlReportes.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(iconButton2);
            groupBox2.Controls.Add(iconButton1);
            groupBox2.Controls.Add(icbExcel);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(33, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 362);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reportes";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(19, 68);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(298, 55);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Reporte de Seguro Médico";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // icbExcel
            // 
            icbExcel.FlatAppearance.BorderSize = 0;
            icbExcel.FlatStyle = FlatStyle.Flat;
            icbExcel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            icbExcel.IconChar = FontAwesome.Sharp.IconChar.TableList;
            icbExcel.IconColor = Color.Green;
            icbExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbExcel.IconSize = 32;
            icbExcel.ImageAlign = ContentAlignment.MiddleLeft;
            icbExcel.Location = new Point(19, 111);
            icbExcel.Name = "icbExcel";
            icbExcel.Size = new Size(298, 55);
            icbExcel.TabIndex = 1;
            icbExcel.Text = "Reporte de Seguro de Vehículos";
            icbExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbExcel.UseVisualStyleBackColor = true;
            icbExcel.Click += icbExcel_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TableList;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(19, 26);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(298, 55);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Reporte de Documentación";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlReportes);
            Name = "frmReportes";
            Text = "frmReportes";
            pnlReportes.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReportes;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icbExcel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}