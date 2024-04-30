namespace SAESoft.Administracion
{
    partial class frmDashboardClaims
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
            dgvDashboardClaim = new DataGridView();
            chkFinalizado = new CheckBox();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardClaim).BeginInit();
            SuspendLayout();
            // 
            // dgvDashboardClaim
            // 
            dgvDashboardClaim.AllowUserToDeleteRows = false;
            dgvDashboardClaim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDashboardClaim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDashboardClaim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboardClaim.Location = new Point(12, 41);
            dgvDashboardClaim.Name = "dgvDashboardClaim";
            dgvDashboardClaim.ReadOnly = true;
            dgvDashboardClaim.RowTemplate.Height = 25;
            dgvDashboardClaim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDashboardClaim.Size = new Size(776, 397);
            dgvDashboardClaim.TabIndex = 1;
            dgvDashboardClaim.CellDoubleClick += dgvDashboardClaim_CellDoubleClick;
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
            chkFinalizado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkFinalizado.Image = Properties.Resources.Nunchecked;
            chkFinalizado.ImageAlign = ContentAlignment.MiddleLeft;
            chkFinalizado.ImeMode = ImeMode.NoControl;
            chkFinalizado.Location = new Point(578, 10);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(116, 25);
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
            icbRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            icbRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            icbRefresh.IconColor = Color.Green;
            icbRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRefresh.IconSize = 16;
            icbRefresh.Location = new Point(701, 8);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(85, 28);
            icbRefresh.TabIndex = 47;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            icbRefresh.Click += icbRefresh_Click;
            // 
            // frmDashboardClaims
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkFinalizado);
            Controls.Add(icbRefresh);
            Controls.Add(dgvDashboardClaim);
            Name = "frmDashboardClaims";
            Text = "frmDashboardClaims";
            Load += frmDashboardClaims_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboardClaim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDashboardClaim;
        private CheckBox chkFinalizado;
        private FontAwesome.Sharp.IconButton icbRefresh;
    }
}