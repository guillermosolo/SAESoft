namespace SAESoft.Exportaciones
{
    partial class frmDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            chkFinalizado = new CheckBox();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            dgvDashboard = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            SuspendLayout();
            // 
            // chkFinalizado
            // 
            chkFinalizado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkFinalizado.Appearance = Appearance.Button;
            chkFinalizado.AutoSize = true;
            chkFinalizado.FlatAppearance.BorderSize = 0;
            chkFinalizado.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkFinalizado.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkFinalizado.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkFinalizado.FlatStyle = FlatStyle.Flat;
            chkFinalizado.Image = Properties.Resources.Nunchecked;
            chkFinalizado.ImageAlign = ContentAlignment.MiddleLeft;
            chkFinalizado.ImeMode = ImeMode.NoControl;
            chkFinalizado.Location = new Point(580, 6);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(116, 25);
            chkFinalizado.TabIndex = 49;
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
            icbRefresh.Location = new Point(703, 4);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(85, 28);
            icbRefresh.TabIndex = 48;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            icbRefresh.Click += icbRefresh_Click;
            // 
            // dgvDashboard
            // 
            dgvDashboard.AllowUserToDeleteRows = false;
            dgvDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboard.Location = new Point(12, 38);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.ReadOnly = true;
            dgvDashboard.RowTemplate.Height = 25;
            dgvDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDashboard.Size = new Size(780, 474);
            dgvDashboard.TabIndex = 47;
            dgvDashboard.CellDoubleClick += dgvDashboard_CellDoubleClick;
            dgvDashboard.CellMouseClick += dgvDashboard_CellMouseClick;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(12, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(124, 28);
            iconButton1.TabIndex = 50;
            iconButton1.Text = "Exportar a Excel";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(iconButton1);
            Controls.Add(chkFinalizado);
            Controls.Add(icbRefresh);
            Controls.Add(dgvDashboard);
            Name = "frmDashboard";
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            Shown += frmDashboard_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkFinalizado;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private DataGridView dgvDashboard;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}