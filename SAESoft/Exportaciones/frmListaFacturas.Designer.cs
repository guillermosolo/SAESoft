namespace SAESoft.Exportaciones
{
    partial class frmListaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFacturas));
            dgvLista = new DataGridView();
            ibtnFacturas = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(0, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.RowTemplate.Height = 25;
            dgvLista.Size = new Size(645, 299);
            dgvLista.TabIndex = 0;
            // 
            // ibtnFacturas
            // 
            ibtnFacturas.IconChar = FontAwesome.Sharp.IconChar.Add;
            ibtnFacturas.IconColor = Color.Green;
            ibtnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnFacturas.IconSize = 24;
            ibtnFacturas.Location = new Point(253, 313);
            ibtnFacturas.Name = "ibtnFacturas";
            ibtnFacturas.Size = new Size(110, 34);
            ibtnFacturas.TabIndex = 9;
            ibtnFacturas.Text = "Agregar";
            ibtnFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnFacturas.UseVisualStyleBackColor = true;
            ibtnFacturas.Click += ibtnFacturas_Click;
            // 
            // frmListaFacturas
            // 
            AcceptButton = ibtnFacturas;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 359);
            Controls.Add(ibtnFacturas);
            Controls.Add(dgvLista);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListaFacturas";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmListaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLista;
        private FontAwesome.Sharp.IconButton ibtnFacturas;
    }
}