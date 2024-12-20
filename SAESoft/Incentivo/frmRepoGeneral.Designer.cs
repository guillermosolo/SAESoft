namespace SAESoft.Incentivo
{
    partial class frmRepoGeneral
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
            dgvEvaluaciones = new DataGridView();
            chkFinalizado = new CheckBox();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            icbPrint = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AllowUserToAddRows = false;
            dgvEvaluaciones.AllowUserToDeleteRows = false;
            dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(17, 68);
            dgvEvaluaciones.Margin = new Padding(4);
            dgvEvaluaciones.MultiSelect = false;
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.ReadOnly = true;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.Size = new Size(751, 332);
            dgvEvaluaciones.TabIndex = 0;
            // 
            // chkFinalizado
            // 
            chkFinalizado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkFinalizado.Appearance = Appearance.Button;
            chkFinalizado.AutoSize = true;
            chkFinalizado.Checked = true;
            chkFinalizado.CheckState = CheckState.Checked;
            chkFinalizado.FlatAppearance.BorderSize = 0;
            chkFinalizado.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkFinalizado.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkFinalizado.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkFinalizado.FlatStyle = FlatStyle.Flat;
            chkFinalizado.Image = Properties.Resources.Nchecked;
            chkFinalizado.ImageAlign = ContentAlignment.MiddleLeft;
            chkFinalizado.ImeMode = ImeMode.NoControl;
            chkFinalizado.Location = new Point(28, 21);
            chkFinalizado.Margin = new Padding(4);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(157, 31);
            chkFinalizado.TabIndex = 48;
            chkFinalizado.Text = "  Ver Finalizados";
            chkFinalizado.TextAlign = ContentAlignment.BottomCenter;
            chkFinalizado.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkFinalizado.UseVisualStyleBackColor = true;
            chkFinalizado.CheckedChanged += chkCheckedChange;
            // 
            // icbRefresh
            // 
            icbRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            icbRefresh.IconColor = Color.Green;
            icbRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRefresh.IconSize = 16;
            icbRefresh.Location = new Point(193, 14);
            icbRefresh.Margin = new Padding(4);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(121, 46);
            icbRefresh.TabIndex = 47;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            icbRefresh.Click += icbRefresh_Click;
            // 
            // icbPrint
            // 
            icbPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            icbPrint.IconColor = Color.DodgerBlue;
            icbPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbPrint.IconSize = 16;
            icbPrint.Location = new Point(647, 13);
            icbPrint.Margin = new Padding(4);
            icbPrint.Name = "icbPrint";
            icbPrint.Size = new Size(121, 47);
            icbPrint.TabIndex = 49;
            icbPrint.Text = "Imprimir";
            icbPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbPrint.UseVisualStyleBackColor = true;
            icbPrint.Click += icbPrint_Click;
            // 
            // frmRepoGeneral
            // 
            AcceptButton = icbPrint;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 417);
            Controls.Add(icbPrint);
            Controls.Add(chkFinalizado);
            Controls.Add(icbRefresh);
            Controls.Add(dgvEvaluaciones);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRepoGeneral";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRepoGeneral";
            Load += frmRepoGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEvaluaciones;
        private CheckBox chkFinalizado;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private FontAwesome.Sharp.IconButton icbPrint;
    }
}