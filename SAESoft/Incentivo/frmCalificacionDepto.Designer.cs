namespace SAESoft.Incentivo
{
    partial class frmCalificacionDepto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            cboDepto = new ComboBox();
            dgvEvaluar = new DataGridView();
            label2 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            txtExtra = new TextBox();
            icbGuardar = new FontAwesome.Sharp.IconButton();
            txtLogrado = new TextBox();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "Departamento";
            // 
            // cboDepto
            // 
            cboDepto.FormattingEnabled = true;
            cboDepto.Location = new Point(162, 29);
            cboDepto.Name = "cboDepto";
            cboDepto.Size = new Size(216, 29);
            cboDepto.TabIndex = 1;
            cboDepto.SelectedIndexChanged += cboDepto_SelectedIndexChanged;
            // 
            // dgvEvaluar
            // 
            dgvEvaluar.AllowUserToAddRows = false;
            dgvEvaluar.AllowUserToDeleteRows = false;
            dgvEvaluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvaluar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEvaluar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvaluar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEvaluar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEvaluar.Location = new Point(27, 150);
            dgvEvaluar.Name = "dgvEvaluar";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEvaluar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEvaluar.RowTemplate.Height = 25;
            dgvEvaluar.Size = new Size(995, 384);
            dgvEvaluar.TabIndex = 2;
            dgvEvaluar.CellEndEdit += dgvEvaluar_CellEndEdit;
            dgvEvaluar.CellEnter += dgvEvaluar_CellEnter;
            dgvEvaluar.CellFormatting += dgvEvaluar_CellFormatting;
            dgvEvaluar.CellPainting += dgvEvaluar_CellPainting;
            dgvEvaluar.CellValidating += dgvEvaluar_CellValidating;
            dgvEvaluar.EditingControlShowing += dgvEvaluar_EditingControlShowing;
            dgvEvaluar.Paint += dgvEvaluar_Paint;
            dgvEvaluar.KeyDown += dgvEvaluar_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Total Base";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(554, 29);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 27);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 92);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Diferencia";
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(554, 89);
            txtExtra.Name = "txtExtra";
            txtExtra.ReadOnly = true;
            txtExtra.Size = new Size(100, 27);
            txtExtra.TabIndex = 6;
            txtExtra.TextAlign = HorizontalAlignment.Right;
            // 
            // icbGuardar
            // 
            icbGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            icbGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            icbGuardar.IconColor = Color.DodgerBlue;
            icbGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbGuardar.IconSize = 24;
            icbGuardar.Location = new Point(717, 32);
            icbGuardar.Name = "icbGuardar";
            icbGuardar.Size = new Size(148, 66);
            icbGuardar.TabIndex = 7;
            icbGuardar.Text = "Guardar Datos";
            icbGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            icbGuardar.UseVisualStyleBackColor = true;
            icbGuardar.Click += icbGuardar_Click;
            // 
            // txtLogrado
            // 
            txtLogrado.Location = new Point(554, 59);
            txtLogrado.Name = "txtLogrado";
            txtLogrado.ReadOnly = true;
            txtLogrado.Size = new Size(100, 27);
            txtLogrado.TabIndex = 9;
            txtLogrado.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 62);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 8;
            label4.Text = "Total Logrado";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmCalificacionDepto
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 554);
            Controls.Add(txtLogrado);
            Controls.Add(label4);
            Controls.Add(icbGuardar);
            Controls.Add(txtExtra);
            Controls.Add(label3);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(dgvEvaluar);
            Controls.Add(cboDepto);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCalificacionDepto";
            Text = "CalificacionDepto";
            Load += frmCalificacionDepto_Load;
            Shown += frmCalificacionDepto_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboDepto;
        private DataGridView dgvEvaluar;
        private Label label2;
        private TextBox txtTotal;
        private Label label3;
        private TextBox txtExtra;
        private FontAwesome.Sharp.IconButton icbGuardar;
        private TextBox txtLogrado;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}