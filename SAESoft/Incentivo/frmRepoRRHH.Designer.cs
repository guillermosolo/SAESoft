namespace SAESoft.Incentivo
{
    partial class frmRepoRRHH
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
            icbPrint = new FontAwesome.Sharp.IconButton();
            icbRefresh = new FontAwesome.Sharp.IconButton();
            dgvEvaluaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            SuspendLayout();
            // 
            // icbPrint
            // 
            icbPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            icbPrint.IconColor = Color.DodgerBlue;
            icbPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbPrint.IconSize = 16;
            icbPrint.Location = new Point(647, 18);
            icbPrint.Margin = new Padding(6);
            icbPrint.Name = "icbPrint";
            icbPrint.Size = new Size(127, 45);
            icbPrint.TabIndex = 53;
            icbPrint.Text = "Imprimir";
            icbPrint.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbPrint.UseVisualStyleBackColor = true;
            icbPrint.Click += icbPrint_Click;
            // 
            // icbRefresh
            // 
            icbRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            icbRefresh.IconColor = Color.Green;
            icbRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRefresh.IconSize = 16;
            icbRefresh.Location = new Point(19, 18);
            icbRefresh.Margin = new Padding(6);
            icbRefresh.Name = "icbRefresh";
            icbRefresh.Size = new Size(120, 45);
            icbRefresh.TabIndex = 51;
            icbRefresh.Text = "Actualizar";
            icbRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbRefresh.UseVisualStyleBackColor = true;
            icbRefresh.Click += icbRefresh_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AllowUserToAddRows = false;
            dgvEvaluaciones.AllowUserToDeleteRows = false;
            dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvaluaciones.Location = new Point(19, 69);
            dgvEvaluaciones.Margin = new Padding(6);
            dgvEvaluaciones.MultiSelect = false;
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.ReadOnly = true;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.Size = new Size(755, 333);
            dgvEvaluaciones.TabIndex = 50;
            // 
            // frmRepoRRHH
            // 
            AcceptButton = icbPrint;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 417);
            Controls.Add(icbPrint);
            Controls.Add(icbRefresh);
            Controls.Add(dgvEvaluaciones);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRepoRRHH";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRepoRRHH";
            Load += frmRepoRRHH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbPrint;
        private FontAwesome.Sharp.IconButton icbRefresh;
        private DataGridView dgvEvaluaciones;
    }
}