namespace SAESoft.Administracion
{
    partial class frmDashboardTramit
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
            chkFinalizado = new CheckBox();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            dgvDashboardTramit = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDashboardTramit).BeginInit();
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
            chkFinalizado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkFinalizado.Image = Properties.Resources.Nunchecked;
            chkFinalizado.ImageAlign = ContentAlignment.MiddleLeft;
            chkFinalizado.ImeMode = ImeMode.NoControl;
            chkFinalizado.Location = new Point(578, 12);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(116, 25);
            chkFinalizado.TabIndex = 51;
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
            icbRefresh.Location = new Point(701, 10);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(85, 28);
            icbRefresh.TabIndex = 50;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvDashboardTramit
            // 
            dgvDashboardTramit.AllowUserToDeleteRows = false;
            dgvDashboardTramit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDashboardTramit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDashboardTramit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboardTramit.Location = new Point(12, 43);
            dgvDashboardTramit.Name = "dgvDashboardTramit";
            dgvDashboardTramit.ReadOnly = true;
            dgvDashboardTramit.RowTemplate.Height = 25;
            dgvDashboardTramit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDashboardTramit.Size = new Size(776, 397);
            dgvDashboardTramit.TabIndex = 49;
            dgvDashboardTramit.CellDoubleClick += dgvDashboardTramit_CellDoubleClick;
            // 
            // frmDashboardTramit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkFinalizado);
            Controls.Add(icbRefresh);
            Controls.Add(dgvDashboardTramit);
            Name = "frmDashboardTramit";
            Text = "frmDashboardTramit";
            Load += frmDashboardTramit_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDashboardTramit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkFinalizado;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private DataGridView dgvDashboardTramit;
    }
}