namespace SAESoft.Incentivo
{
    partial class frmCerrar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtObservaciones = new TextBox();
            label3 = new Label();
            icbGuardar = new FontAwesome.Sharp.IconButton();
            dtpFin = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            dgvAsistencia = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtObservaciones.Location = new Point(194, 55);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ReadOnly = true;
            txtObservaciones.Size = new Size(372, 84);
            txtObservaciones.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 55);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 16;
            label3.Text = "Observaciones";
            // 
            // icbGuardar
            // 
            icbGuardar.Enabled = false;
            icbGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            icbGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            icbGuardar.IconColor = Color.DodgerBlue;
            icbGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbGuardar.IconSize = 24;
            icbGuardar.Location = new Point(585, 12);
            icbGuardar.Name = "icbGuardar";
            icbGuardar.Size = new Size(148, 62);
            icbGuardar.TabIndex = 15;
            icbGuardar.Text = "Cerrar Período";
            icbGuardar.TextAlign = ContentAlignment.BottomCenter;
            icbGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            icbGuardar.UseVisualStyleBackColor = true;
            icbGuardar.Click += icbGuardar_Click;
            // 
            // dtpFin
            // 
            dtpFin.Enabled = false;
            dtpFin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(447, 22);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(119, 27);
            dtpFin.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 27);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 13;
            label2.Text = "Fecha Hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 12;
            label1.Text = "Fecha Desde";
            // 
            // dtpInicio
            // 
            dtpInicio.Enabled = false;
            dtpInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(194, 22);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(119, 27);
            dtpInicio.TabIndex = 11;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToDeleteRows = false;
            dgvAsistencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(12, 157);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsistencia.RowTemplate.Height = 25;
            dgvAsistencia.Size = new Size(721, 247);
            dgvAsistencia.TabIndex = 10;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(585, 80);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(148, 62);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Actualizar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmCerrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 416);
            Controls.Add(iconButton1);
            Controls.Add(txtObservaciones);
            Controls.Add(label3);
            Controls.Add(icbGuardar);
            Controls.Add(dtpFin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpInicio);
            Controls.Add(dgvAsistencia);
            Name = "frmCerrar";
            Text = "frmCerrar";
            Load += frmCerrar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObservaciones;
        private Label label3;
        private FontAwesome.Sharp.IconButton icbGuardar;
        private DateTimePicker dtpFin;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpInicio;
        private DataGridView dgvAsistencia;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}