namespace SAESoft.Incentivo
{
    partial class frmImportarAsistencia
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dgvAsistencia = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            dtpInicio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpFin = new DateTimePicker();
            icbGuardar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtObservaciones = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Century Gothic", 12F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 24;
            iconButton1.Location = new Point(385, 30);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(133, 66);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Importar Excel";
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToDeleteRows = false;
            dgvAsistencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(29, 225);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsistencia.Size = new Size(759, 213);
            dgvAsistencia.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Century Gothic", 12F);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(202, 30);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(119, 27);
            dtpInicio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 3;
            label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(39, 74);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 4;
            label2.Text = "Fecha Hasta";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Century Gothic", 12F);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(202, 69);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(119, 27);
            dtpFin.TabIndex = 5;
            // 
            // icbGuardar
            // 
            icbGuardar.Enabled = false;
            icbGuardar.Font = new Font("Century Gothic", 12F);
            icbGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            icbGuardar.IconColor = Color.DodgerBlue;
            icbGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbGuardar.IconSize = 24;
            icbGuardar.Location = new Point(556, 29);
            icbGuardar.Name = "icbGuardar";
            icbGuardar.Size = new Size(148, 66);
            icbGuardar.TabIndex = 6;
            icbGuardar.Text = "Guardar Datos";
            icbGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            icbGuardar.UseVisualStyleBackColor = true;
            icbGuardar.Click += icbGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(39, 112);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 7;
            label3.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Century Gothic", 12F);
            txtObservaciones.Location = new Point(202, 112);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(502, 84);
            txtObservaciones.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(45, 203);
            label4.Name = "label4";
            label4.Size = new Size(705, 17);
            label4.TabIndex = 9;
            label4.Text = "* Recuerde que los encabezados de columna deben ser las palabras: CODIGO, TARDANZA, PERMISO Y AUSENCIA.";
            // 
            // frmImportarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtObservaciones);
            Controls.Add(label3);
            Controls.Add(icbGuardar);
            Controls.Add(dtpFin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpInicio);
            Controls.Add(dgvAsistencia);
            Controls.Add(iconButton1);
            Name = "frmImportarAsistencia";
            Text = "ImportarAsistencia";
            Load += frmImportarAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgvAsistencia;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dtpInicio;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFin;
        private FontAwesome.Sharp.IconButton icbGuardar;
        private Label label3;
        private TextBox txtObservaciones;
        private ErrorProvider errorProvider1;
        private Label label4;
    }
}