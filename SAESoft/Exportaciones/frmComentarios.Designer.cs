namespace SAESoft.Exportaciones
{
    partial class frmComentarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComentarios));
            label1 = new Label();
            txtCometario = new TextBox();
            dgvComentarios = new DataGridView();
            ibtnGuardar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Comentario";
            // 
            // txtCometario
            // 
            txtCometario.Location = new Point(122, 6);
            txtCometario.Multiline = true;
            txtCometario.Name = "txtCometario";
            txtCometario.Size = new Size(381, 79);
            txtCometario.TabIndex = 1;
            // 
            // dgvComentarios
            // 
            dgvComentarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvComentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new Point(6, 91);
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.RowTemplate.Height = 25;
            dgvComentarios.Size = new Size(613, 186);
            dgvComentarios.TabIndex = 2;
            // 
            // ibtnGuardar
            // 
            ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            ibtnGuardar.IconColor = Color.Green;
            ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardar.IconSize = 24;
            ibtnGuardar.Location = new Point(509, 6);
            ibtnGuardar.Name = "ibtnGuardar";
            ibtnGuardar.Size = new Size(110, 79);
            ibtnGuardar.TabIndex = 11;
            ibtnGuardar.Text = "Guardar";
            ibtnGuardar.TextAlign = ContentAlignment.BottomCenter;
            ibtnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            ibtnGuardar.UseVisualStyleBackColor = true;
            ibtnGuardar.Click += ibtnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // frmComentarios
            // 
            AcceptButton = ibtnGuardar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 285);
            Controls.Add(label2);
            Controls.Add(ibtnGuardar);
            Controls.Add(dgvComentarios);
            Controls.Add(txtCometario);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmComentarios";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmComentarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCometario;
        private DataGridView dgvComentarios;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private Label label2;
    }
}