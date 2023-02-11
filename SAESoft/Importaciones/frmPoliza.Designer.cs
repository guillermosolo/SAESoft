namespace SAESoft.Importaciones
{
    partial class frmPoliza
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboModalidad = new System.Windows.Forms.ComboBox();
            this.dgvPoliza = new System.Windows.Forms.DataGridView();
            this.icbAgregar = new FontAwesome.Sharp.IconButton();
            this.icbFinalizar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContenedores = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "B.L.";
            // 
            // cboBL
            // 
            this.cboBL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboBL.FormattingEnabled = true;
            this.cboBL.Location = new System.Drawing.Point(51, 11);
            this.cboBL.Name = "cboBL";
            this.cboBL.Size = new System.Drawing.Size(179, 29);
            this.cboBL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(236, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Póliza";
            // 
            // txtPoliza
            // 
            this.txtPoliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPoliza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoliza.Location = new System.Drawing.Point(324, 11);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(181, 27);
            this.txtPoliza.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modalidad";
            // 
            // cboModalidad
            // 
            this.cboModalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboModalidad.FormattingEnabled = true;
            this.cboModalidad.Location = new System.Drawing.Point(606, 9);
            this.cboModalidad.Name = "cboModalidad";
            this.cboModalidad.Size = new System.Drawing.Size(70, 29);
            this.cboModalidad.TabIndex = 5;
            // 
            // dgvPoliza
            // 
            this.dgvPoliza.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPoliza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoliza.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPoliza.Location = new System.Drawing.Point(12, 163);
            this.dgvPoliza.Name = "dgvPoliza";
            this.dgvPoliza.ReadOnly = true;
            this.dgvPoliza.RowTemplate.Height = 25;
            this.dgvPoliza.Size = new System.Drawing.Size(664, 150);
            this.dgvPoliza.TabIndex = 6;
            // 
            // icbAgregar
            // 
            this.icbAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.icbAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.icbAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbAgregar.IconSize = 24;
            this.icbAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbAgregar.Location = new System.Drawing.Point(552, 79);
            this.icbAgregar.Name = "icbAgregar";
            this.icbAgregar.Size = new System.Drawing.Size(124, 36);
            this.icbAgregar.TabIndex = 7;
            this.icbAgregar.Text = "Agregar";
            this.icbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbAgregar.UseVisualStyleBackColor = true;
            this.icbAgregar.Click += new System.EventHandler(this.icbAgregar_Click);
            // 
            // icbFinalizar
            // 
            this.icbFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.icbFinalizar.ForeColor = System.Drawing.Color.Green;
            this.icbFinalizar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.icbFinalizar.IconColor = System.Drawing.Color.Green;
            this.icbFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbFinalizar.IconSize = 24;
            this.icbFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbFinalizar.Location = new System.Drawing.Point(552, 121);
            this.icbFinalizar.Name = "icbFinalizar";
            this.icbFinalizar.Size = new System.Drawing.Size(124, 36);
            this.icbFinalizar.TabIndex = 8;
            this.icbFinalizar.Text = "Finalizar";
            this.icbFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbFinalizar.UseVisualStyleBackColor = true;
            this.icbFinalizar.Click += new System.EventHandler(this.icbFinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservaciones.Location = new System.Drawing.Point(153, 46);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(523, 27);
            this.txtObservaciones.TabIndex = 10;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(93, 95);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contenedores";
            // 
            // txtContenedores
            // 
            this.txtContenedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContenedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContenedores.Location = new System.Drawing.Point(153, 84);
            this.txtContenedores.Multiline = true;
            this.txtContenedores.Name = "txtContenedores";
            this.txtContenedores.ReadOnly = true;
            this.txtContenedores.Size = new System.Drawing.Size(375, 73);
            this.txtContenedores.TabIndex = 13;
            // 
            // frmPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 324);
            this.Controls.Add(this.txtContenedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.icbFinalizar);
            this.Controls.Add(this.icbAgregar);
            this.Controls.Add(this.dgvPoliza);
            this.Controls.Add(this.cboModalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoliza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPoliza";
            this.Load += new System.EventHandler(this.frmPoliza_Load);
            this.Shown += new System.EventHandler(this.frmPoliza_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboBL;
        private Label label2;
        private TextBox txtPoliza;
        private Label label3;
        private ComboBox cboModalidad;
        private DataGridView dgvPoliza;
        private FontAwesome.Sharp.IconButton icbAgregar;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private Label label4;
        private TextBox txtObservaciones;
        private HScrollBar hScrollBar1;
        private Label label5;
        private TextBox txtContenedores;
    }
}