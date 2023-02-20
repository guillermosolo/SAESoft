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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.icbRefresh = new FontAwesome.Sharp.IconButton();
            this.chkFinalizado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Location = new System.Drawing.Point(12, 36);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.RowTemplate.Height = 25;
            this.dgvDashboard.Size = new System.Drawing.Size(780, 297);
            this.dgvDashboard.TabIndex = 0;
            // 
            // icbRefresh
            // 
            this.icbRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            this.icbRefresh.IconColor = System.Drawing.Color.Green;
            this.icbRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbRefresh.IconSize = 16;
            this.icbRefresh.Location = new System.Drawing.Point(703, 2);
            this.icbRefresh.Name = "icbRefresh";
            this.icbRefresh.Size = new System.Drawing.Size(85, 28);
            this.icbRefresh.TabIndex = 1;
            this.icbRefresh.Text = "Actualizar";
            this.icbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbRefresh.UseVisualStyleBackColor = true;
            this.icbRefresh.Click += new System.EventHandler(this.icbRefresh_Click);
            // 
            // chkFinalizado
            // 
            this.chkFinalizado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFinalizado.AutoSize = true;
            this.chkFinalizado.Checked = true;
            this.chkFinalizado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFinalizado.FlatAppearance.BorderSize = 0;
            this.chkFinalizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkFinalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFinalizado.Image = global::SAESoft.Properties.Resources.Nchecked;
            this.chkFinalizado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkFinalizado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFinalizado.Location = new System.Drawing.Point(580, 4);
            this.chkFinalizado.Name = "chkFinalizado";
            this.chkFinalizado.Size = new System.Drawing.Size(116, 25);
            this.chkFinalizado.TabIndex = 46;
            this.chkFinalizado.Text = "  Ver Finalizados";
            this.chkFinalizado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkFinalizado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkFinalizado.UseVisualStyleBackColor = true;
            this.chkFinalizado.CheckedChanged += new System.EventHandler(this.chkCheckedChange);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.chkFinalizado);
            this.Controls.Add(this.icbRefresh);
            this.Controls.Add(this.dgvDashboard);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Shown += new System.EventHandler(this.frmDashboard_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDashboard;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private CheckBox chkFinalizado;
    }
}