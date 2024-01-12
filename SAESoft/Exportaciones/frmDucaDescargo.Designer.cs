namespace SAESoft.Exportaciones
{
    partial class frmDucaDescargo
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cboTipoDoc = new ComboBox();
            label2 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            lblDUCA = new Label();
            cboDucas = new ComboBox();
            ibtnFacturas = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Documento";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new Point(194, 15);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(289, 29);
            cboTipoDoc.TabIndex = 1;
            cboTipoDoc.SelectedIndexChanged += cboTipoDoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(194, 50);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(289, 27);
            txtNumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 88);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(194, 83);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(119, 27);
            dtpFecha.TabIndex = 5;
            // 
            // lblDUCA
            // 
            lblDUCA.AutoSize = true;
            lblDUCA.Location = new Point(23, 121);
            lblDUCA.Name = "lblDUCA";
            lblDUCA.Size = new Size(147, 21);
            lblDUCA.TabIndex = 6;
            lblDUCA.Text = "DUCA Referencia";
            lblDUCA.Visible = false;
            // 
            // cboDucas
            // 
            cboDucas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDucas.FormattingEnabled = true;
            cboDucas.Location = new Point(194, 118);
            cboDucas.Name = "cboDucas";
            cboDucas.Size = new Size(289, 29);
            cboDucas.TabIndex = 7;
            cboDucas.Visible = false;
            // 
            // ibtnFacturas
            // 
            ibtnFacturas.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            ibtnFacturas.IconColor = Color.Green;
            ibtnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnFacturas.IconSize = 24;
            ibtnFacturas.Location = new Point(507, 34);
            ibtnFacturas.Name = "ibtnFacturas";
            ibtnFacturas.Size = new Size(110, 95);
            ibtnFacturas.TabIndex = 10;
            ibtnFacturas.Text = "Guardar";
            ibtnFacturas.TextAlign = ContentAlignment.BottomCenter;
            ibtnFacturas.TextImageRelation = TextImageRelation.ImageAboveText;
            ibtnFacturas.UseVisualStyleBackColor = true;
            ibtnFacturas.Click += ibtnFacturas_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDucaDescargo
            // 
            AcceptButton = ibtnFacturas;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 171);
            Controls.Add(ibtnFacturas);
            Controls.Add(cboDucas);
            Controls.Add(lblDUCA);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(cboTipoDoc);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDucaDescargo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDucaDescargo";
            Load += frmDucaDescargo_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipoDoc;
        private Label label2;
        private TextBox txtNumero;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label lblDUCA;
        private ComboBox cboDucas;
        private FontAwesome.Sharp.IconButton ibtnFacturas;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}