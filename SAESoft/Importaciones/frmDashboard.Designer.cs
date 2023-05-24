namespace SAESoft.Importaciones
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvDashboard = new DataGridView();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            chkFinalizado = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).BeginInit();
            SuspendLayout();
            // 
            // dgvDashboard
            // 
            dgvDashboard.AllowUserToAddRows = false;
            dgvDashboard.AllowUserToDeleteRows = false;
            dgvDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDashboard.Location = new Point(12, 36);
            dgvDashboard.Name = "dgvDashboard";
            dgvDashboard.ReadOnly = true;
            dgvDashboard.RowTemplate.Height = 25;
            dgvDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDashboard.Size = new Size(780, 667);
            dgvDashboard.TabIndex = 0;
            dgvDashboard.CellContentDoubleClick += dgvDashboard_CellContentDoubleClick;
            dgvDashboard.ColumnHeaderMouseClick += dgvDashboard_ColumnHeaderMouseClick;
            dgvDashboard.RowPostPaint += dgvDashboard_RowPostPaint;
            // 
            // icbRefresh
            // 
            icbRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            icbRefresh.IconColor = Color.Green;
            icbRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRefresh.IconSize = 16;
            icbRefresh.Location = new Point(703, 2);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(85, 28);
            icbRefresh.TabIndex = 1;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            icbRefresh.Click += icbRefresh_Click;
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
            chkFinalizado.Location = new Point(580, 4);
            chkFinalizado.Name = "chkFinalizado";
            chkFinalizado.Size = new Size(116, 25);
            chkFinalizado.TabIndex = 46;
            chkFinalizado.Text = "  Ver Finalizados";
            chkFinalizado.TextAlign = ContentAlignment.BottomCenter;
            chkFinalizado.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkFinalizado.UseVisualStyleBackColor = true;
            chkFinalizado.CheckedChanged += chkCheckedChange;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 715);
            Controls.Add(chkFinalizado);
            Controls.Add(icbRefresh);
            Controls.Add(dgvDashboard);
            Name = "frmDashboard";
            Text = "frmDashboard";
            Shown += frmDashboard_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDashboard;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private CheckBox chkFinalizado;
    }
}