namespace SAESoft.Exportaciones
{
    partial class frmLicencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicencias));
            label1 = new Label();
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            lsbFacturas = new ListBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            ibtnFacturas = new FontAwesome.Sharp.IconButton();
            ibtnArchivos = new FontAwesome.Sharp.IconButton();
            ibtnGuardar = new FontAwesome.Sharp.IconButton();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            txtNumero = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsbFacturas);
            groupBox1.Location = new Point(22, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 268);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturas";
            // 
            // lsbFacturas
            // 
            lsbFacturas.FormattingEnabled = true;
            lsbFacturas.ItemHeight = 21;
            lsbFacturas.Location = new Point(6, 26);
            lsbFacturas.Name = "lsbFacturas";
            lsbFacturas.SelectionMode = SelectionMode.MultiExtended;
            lsbFacturas.Size = new Size(198, 235);
            lsbFacturas.TabIndex = 5;
            lsbFacturas.KeyDown += lsbFacturas_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(359, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 268);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Documentos de Soporte";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(223, 242);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // ibtnFacturas
            // 
            ibtnFacturas.IconChar = FontAwesome.Sharp.IconChar.Add;
            ibtnFacturas.IconColor = Color.Green;
            ibtnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnFacturas.IconSize = 24;
            ibtnFacturas.Location = new Point(261, 156);
            ibtnFacturas.Name = "ibtnFacturas";
            ibtnFacturas.Size = new Size(86, 58);
            ibtnFacturas.TabIndex = 8;
            ibtnFacturas.Text = "Facturas";
            ibtnFacturas.TextImageRelation = TextImageRelation.ImageAboveText;
            ibtnFacturas.UseVisualStyleBackColor = true;
            ibtnFacturas.Click += ibtnFacturas_Click;
            // 
            // ibtnArchivos
            // 
            ibtnArchivos.Enabled = false;
            ibtnArchivos.IconChar = FontAwesome.Sharp.IconChar.Add;
            ibtnArchivos.IconColor = Color.Green;
            ibtnArchivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnArchivos.IconSize = 24;
            ibtnArchivos.Location = new Point(261, 237);
            ibtnArchivos.Name = "ibtnArchivos";
            ibtnArchivos.Size = new Size(86, 58);
            ibtnArchivos.TabIndex = 9;
            ibtnArchivos.Text = "Archivos";
            ibtnArchivos.TextImageRelation = TextImageRelation.ImageAboveText;
            ibtnArchivos.UseVisualStyleBackColor = true;
            ibtnArchivos.Click += ibtnArchivos_Click;
            // 
            // ibtnGuardar
            // 
            ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            ibtnGuardar.IconColor = Color.DodgerBlue;
            ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardar.IconSize = 24;
            ibtnGuardar.Location = new Point(381, 9);
            ibtnGuardar.Name = "ibtnGuardar";
            ibtnGuardar.Size = new Size(148, 86);
            ibtnGuardar.TabIndex = 10;
            ibtnGuardar.Text = "Guardar";
            ibtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardar.UseVisualStyleBackColor = true;
            ibtnGuardar.Click += ibtnGuardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            openFileDialog1.Multiselect = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 11;
            label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(106, 68);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(126, 27);
            dtpFecha.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Location = new Point(106, 15);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(241, 27);
            txtNumero.TabIndex = 13;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // frmLicencias
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 395);
            Controls.Add(txtNumero);
            Controls.Add(dtpFecha);
            Controls.Add(label2);
            Controls.Add(ibtnGuardar);
            Controls.Add(ibtnArchivos);
            Controls.Add(ibtnFacturas);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLicencias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar nueva licencia";
            Load += frmLicencias_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private GroupBox groupBox1;
        private ListBox lsbFacturas;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton ibtnFacturas;
        private FontAwesome.Sharp.IconButton ibtnArchivos;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtNumero;
    }
}