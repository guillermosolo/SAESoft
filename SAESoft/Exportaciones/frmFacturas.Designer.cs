namespace SAESoft.Exportaciones
{
    partial class frmFacturas
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
            toolStripContainer1 = new ToolStripContainer();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            cboExportador = new ComboBox();
            label8 = new Label();
            lblNotaCredito = new Label();
            txtNotaCredito = new TextBox();
            tsActivo = new Utilitarios.toggleSwitch();
            lblActivo = new Label();
            cboModalidad = new ComboBox();
            label7 = new Label();
            cboAduana = new ComboBox();
            label6 = new Label();
            cboConsignatario = new ComboBox();
            label5 = new Label();
            cboTipoFac = new ComboBox();
            label4 = new Label();
            txtNumero = new TextBox();
            label3 = new Label();
            txtReferencia = new TextBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbModificar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAceptar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbAnterior = new ToolStripButton();
            tslIndice = new ToolStripLabel();
            tsbSiguiente = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(groupBox4);
            toolStripContainer1.ContentPanel.Controls.Add(cboExportador);
            toolStripContainer1.ContentPanel.Controls.Add(label8);
            toolStripContainer1.ContentPanel.Controls.Add(lblNotaCredito);
            toolStripContainer1.ContentPanel.Controls.Add(txtNotaCredito);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(lblActivo);
            toolStripContainer1.ContentPanel.Controls.Add(cboModalidad);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(cboAduana);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(cboConsignatario);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(cboTipoFac);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(txtNumero);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(txtReferencia);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(dtpFecha);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Margin = new Padding(4);
            toolStripContainer1.ContentPanel.Size = new Size(669, 687);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(669, 726);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listView1);
            groupBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(44, 342);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(277, 294);
            groupBox4.TabIndex = 59;
            groupBox4.TabStop = false;
            groupBox4.Text = "Archivos de Soporte";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorProvider1.SetIconAlignment(listView1, ErrorIconAlignment.MiddleLeft);
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(3, 23);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(271, 268);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.ItemActivate += listView1_ItemActivate;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // cboExportador
            // 
            cboExportador.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExportador.Enabled = false;
            cboExportador.FormattingEnabled = true;
            cboExportador.Location = new Point(192, 281);
            cboExportador.Name = "cboExportador";
            cboExportador.Size = new Size(368, 29);
            cboExportador.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 284);
            label8.Name = "label8";
            label8.Size = new Size(97, 21);
            label8.TabIndex = 44;
            label8.Text = "Exportador";
            // 
            // lblNotaCredito
            // 
            lblNotaCredito.AutoSize = true;
            lblNotaCredito.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotaCredito.Location = new Point(413, 19);
            lblNotaCredito.Name = "lblNotaCredito";
            lblNotaCredito.Size = new Size(42, 21);
            lblNotaCredito.TabIndex = 43;
            lblNotaCredito.Text = "N/C";
            lblNotaCredito.Visible = false;
            // 
            // txtNotaCredito
            // 
            txtNotaCredito.Enabled = false;
            txtNotaCredito.Location = new Point(461, 16);
            txtNotaCredito.Name = "txtNotaCredito";
            txtNotaCredito.Size = new Size(100, 27);
            txtNotaCredito.TabIndex = 42;
            txtNotaCredito.Visible = false;
            // 
            // tsActivo
            // 
            tsActivo.Checked = true;
            tsActivo.CheckState = CheckState.Checked;
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsActivo.Location = new Point(364, 18);
            tsActivo.MinimumSize = new Size(45, 22);
            tsActivo.Name = "tsActivo";
            tsActivo.OffBackColor = Color.Firebrick;
            tsActivo.OffDisabledColor = Color.IndianRed;
            tsActivo.OffTogglecolor = Color.Firebrick;
            tsActivo.OnBackColor = Color.FromArgb(0, 122, 172);
            tsActivo.OnDisabledcolor = Color.LightSteelBlue;
            tsActivo.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsActivo.Size = new Size(45, 25);
            tsActivo.SolidStyle = false;
            tsActivo.TabIndex = 41;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            tsActivo.Visible = false;
            tsActivo.CheckedChanged += tsActivo_CheckedChanged;
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivo.Location = new Point(297, 19);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(64, 21);
            lblActivo.TabIndex = 40;
            lblActivo.Text = "Activa";
            lblActivo.Visible = false;
            // 
            // cboModalidad
            // 
            cboModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModalidad.Enabled = false;
            cboModalidad.FormattingEnabled = true;
            cboModalidad.Location = new Point(193, 233);
            cboModalidad.Name = "cboModalidad";
            cboModalidad.Size = new Size(368, 29);
            cboModalidad.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 236);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 12;
            label7.Text = "Modalidad";
            // 
            // cboAduana
            // 
            cboAduana.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAduana.Enabled = false;
            cboAduana.FormattingEnabled = true;
            cboAduana.Location = new Point(193, 188);
            cboAduana.Name = "cboAduana";
            cboAduana.Size = new Size(368, 29);
            cboAduana.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 191);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 10;
            label6.Text = "Aduana";
            // 
            // cboConsignatario
            // 
            cboConsignatario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsignatario.Enabled = false;
            cboConsignatario.FormattingEnabled = true;
            cboConsignatario.Location = new Point(193, 143);
            cboConsignatario.Name = "cboConsignatario";
            cboConsignatario.Size = new Size(368, 29);
            cboConsignatario.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 146);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 8;
            label5.Text = "Consignatario";
            // 
            // cboTipoFac
            // 
            cboTipoFac.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoFac.Enabled = false;
            cboTipoFac.FormattingEnabled = true;
            cboTipoFac.Location = new Point(193, 100);
            cboTipoFac.Name = "cboTipoFac";
            cboTipoFac.Size = new Size(368, 29);
            cboTipoFac.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 103);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Factura";
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(367, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(194, 27);
            txtNumero.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 61);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 4;
            label3.Text = "Número";
            // 
            // txtReferencia
            // 
            txtReferencia.Enabled = false;
            txtReferencia.Location = new Point(144, 58);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(100, 27);
            txtReferencia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 61);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 2;
            label2.Text = "Referencia";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(144, 19);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(119, 27);
            dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(198, 39);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Enabled = false;
            tsbNuevo.Image = Properties.Resources.add_file;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(36, 36);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextAlign = ContentAlignment.BottomCenter;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = Properties.Resources.file;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(36, 36);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbModificar
            // 
            tsbModificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbModificar.Enabled = false;
            tsbModificar.Image = Properties.Resources.edit;
            tsbModificar.ImageTransparentColor = Color.Magenta;
            tsbModificar.Name = "tsbModificar";
            tsbModificar.Size = new Size(36, 36);
            tsbModificar.Text = "Editar";
            tsbModificar.Click += tsbModificar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Enabled = false;
            tsbEliminar.Image = Properties.Resources.delete;
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(36, 36);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbAceptar
            // 
            tsbAceptar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAceptar.Image = Properties.Resources.check;
            tsbAceptar.ImageTransparentColor = Color.Magenta;
            tsbAceptar.Name = "tsbAceptar";
            tsbAceptar.Size = new Size(36, 36);
            tsbAceptar.Text = "Guardar";
            tsbAceptar.Visible = false;
            tsbAceptar.Click += tsbAceptar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = Properties.Resources.close;
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(36, 36);
            tsbCancelar.Text = "Cancelar";
            tsbCancelar.Visible = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbAnterior
            // 
            tsbAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAnterior.Image = Properties.Resources.arrow_l;
            tsbAnterior.ImageTransparentColor = Color.Magenta;
            tsbAnterior.Name = "tsbAnterior";
            tsbAnterior.Size = new Size(36, 36);
            tsbAnterior.Text = "Anterior";
            tsbAnterior.Visible = false;
            tsbAnterior.Click += tsbAnterior_Click;
            // 
            // tslIndice
            // 
            tslIndice.Name = "tslIndice";
            tslIndice.Size = new Size(84, 36);
            tslIndice.Text = "Registro 0 de 0";
            tslIndice.Visible = false;
            // 
            // tsbSiguiente
            // 
            tsbSiguiente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSiguiente.Image = Properties.Resources.arrow_r;
            tsbSiguiente.ImageTransparentColor = Color.Magenta;
            tsbSiguiente.Name = "tsbSiguiente";
            tsbSiguiente.Size = new Size(36, 36);
            tsbSiguiente.Text = "Siguiente";
            tsbSiguiente.Visible = false;
            tsbSiguiente.Click += tsbSiguiente_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalir.Image = Properties.Resources.logout;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 36);
            tsbSalir.Text = "Salir";
            tsbSalir.Click += tsbSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Created += fileSystemWatcher1_Created;
            fileSystemWatcher1.Deleted += fileSystemWatcher1_Deleted;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 726);
            Controls.Add(toolStripContainer1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmFacturas";
            Text = "frmFacturas";
            Load += frmFacturas_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            groupBox4.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbModificar;
        private ToolStripButton tsbEliminar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAceptar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbAnterior;
        private ToolStripLabel tslIndice;
        private ToolStripButton tsbSiguiente;
        private ToolStripButton tsbSalir;
        private ErrorProvider errorProvider1;
        private TextBox txtReferencia;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Label label3;
        private ComboBox cboTipoFac;
        private Label label4;
        private TextBox txtNumero;
        private ComboBox cboModalidad;
        private Label label7;
        private ComboBox cboAduana;
        private Label label6;
        private ComboBox cboConsignatario;
        private Label label5;
        private Label lblNotaCredito;
        private TextBox txtNotaCredito;
        private Utilitarios.toggleSwitch tsActivo;
        private Label lblActivo;
        private ComboBox cboExportador;
        private Label label8;
        private GroupBox groupBox4;
        private ListView listView1;
        private ImageList imageList1;
        private FileSystemWatcher fileSystemWatcher1;
    }
}