namespace SAESoft.Importaciones
{
    partial class frmMaritimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaritimo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            cboAgente = new ComboBox();
            label13 = new Label();
            txtValorExtra2 = new TextBox();
            label12 = new Label();
            chkDocOriginales = new CheckBox();
            txtValorExtra = new TextBox();
            label11 = new Label();
            txtDemora = new TextBox();
            label10 = new Label();
            txtTiempoLibre = new TextBox();
            label8 = new Label();
            chkConsolidado = new CheckBox();
            dgvHistorial = new DataGridView();
            grpEquipos = new GroupBox();
            lsbEquipos = new ListBox();
            txtEquipos = new TextBox();
            grpBL = new GroupBox();
            lsbBL = new ListBox();
            txtBL = new TextBox();
            cboTerminal = new ComboBox();
            cboShipper = new ComboBox();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            cboNaviera = new ComboBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            clbRevisiones = new CheckedListBox();
            cboAduana = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpETA = new DateTimePicker();
            label4 = new Label();
            cboDestino = new ComboBox();
            label3 = new Label();
            cboForwarder = new ComboBox();
            label2 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbListarXXX = new ToolStripButton();
            tsbModificar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbPago = new ToolStripButton();
            tsbUpload = new ToolStripButton();
            tsddbSwitchUser = new ToolStripDropDownButton();
            tsddbProceso = new ToolStripDropDownButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAceptar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbAnterior = new ToolStripButton();
            tslIndice = new ToolStripLabel();
            tsbSiguiente = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            openFileDialog1 = new OpenFileDialog();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            grpEquipos.SuspendLayout();
            grpBL.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
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
            toolStripContainer1.ContentPanel.Controls.Add(cboAgente);
            toolStripContainer1.ContentPanel.Controls.Add(label13);
            toolStripContainer1.ContentPanel.Controls.Add(txtValorExtra2);
            toolStripContainer1.ContentPanel.Controls.Add(label12);
            toolStripContainer1.ContentPanel.Controls.Add(chkDocOriginales);
            toolStripContainer1.ContentPanel.Controls.Add(txtValorExtra);
            toolStripContainer1.ContentPanel.Controls.Add(label11);
            toolStripContainer1.ContentPanel.Controls.Add(txtDemora);
            toolStripContainer1.ContentPanel.Controls.Add(label10);
            toolStripContainer1.ContentPanel.Controls.Add(txtTiempoLibre);
            toolStripContainer1.ContentPanel.Controls.Add(label8);
            toolStripContainer1.ContentPanel.Controls.Add(chkConsolidado);
            toolStripContainer1.ContentPanel.Controls.Add(dgvHistorial);
            toolStripContainer1.ContentPanel.Controls.Add(grpEquipos);
            toolStripContainer1.ContentPanel.Controls.Add(grpBL);
            toolStripContainer1.ContentPanel.Controls.Add(cboTerminal);
            toolStripContainer1.ContentPanel.Controls.Add(cboShipper);
            toolStripContainer1.ContentPanel.Controls.Add(groupBox4);
            toolStripContainer1.ContentPanel.Controls.Add(cboNaviera);
            toolStripContainer1.ContentPanel.Controls.Add(label9);
            toolStripContainer1.ContentPanel.Controls.Add(groupBox2);
            toolStripContainer1.ContentPanel.Controls.Add(cboAduana);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(label5);
            toolStripContainer1.ContentPanel.Controls.Add(dtpETA);
            toolStripContainer1.ContentPanel.Controls.Add(label4);
            toolStripContainer1.ContentPanel.Controls.Add(cboDestino);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Controls.Add(cboForwarder);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(txtId);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            resources.ApplyResources(toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(toolStripContainer1, "toolStripContainer1");
            toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // cboAgente
            // 
            cboAgente.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboAgente, "cboAgente");
            cboAgente.FormattingEnabled = true;
            cboAgente.Name = "cboAgente";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // txtValorExtra2
            // 
            resources.ApplyResources(txtValorExtra2, "txtValorExtra2");
            txtValorExtra2.Name = "txtValorExtra2";
            txtValorExtra2.KeyPress += txtValorExtra2_KeyPress;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // chkDocOriginales
            // 
            resources.ApplyResources(chkDocOriginales, "chkDocOriginales");
            chkDocOriginales.FlatAppearance.BorderSize = 0;
            chkDocOriginales.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkDocOriginales.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkDocOriginales.Image = Properties.Resources.Nunchecked;
            chkDocOriginales.Name = "chkDocOriginales";
            chkDocOriginales.UseVisualStyleBackColor = true;
            chkDocOriginales.CheckedChanged += chkCheckedChange;
            // 
            // txtValorExtra
            // 
            resources.ApplyResources(txtValorExtra, "txtValorExtra");
            txtValorExtra.Name = "txtValorExtra";
            txtValorExtra.KeyPress += txtValorExtra_KeyPress;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // txtDemora
            // 
            resources.ApplyResources(txtDemora, "txtDemora");
            txtDemora.Name = "txtDemora";
            txtDemora.KeyPress += txtDemora_KeyPress;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // txtTiempoLibre
            // 
            resources.ApplyResources(txtTiempoLibre, "txtTiempoLibre");
            txtTiempoLibre.Name = "txtTiempoLibre";
            txtTiempoLibre.KeyPress += txtTiempoLibre_KeyPress;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // chkConsolidado
            // 
            resources.ApplyResources(chkConsolidado, "chkConsolidado");
            chkConsolidado.FlatAppearance.BorderSize = 0;
            chkConsolidado.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkConsolidado.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkConsolidado.Image = Properties.Resources.Nunchecked;
            chkConsolidado.Name = "chkConsolidado";
            chkConsolidado.UseVisualStyleBackColor = true;
            chkConsolidado.CheckedChanged += chkCheckedChange;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvHistorial, "dgvHistorial");
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // grpEquipos
            // 
            grpEquipos.Controls.Add(lsbEquipos);
            grpEquipos.Controls.Add(txtEquipos);
            resources.ApplyResources(grpEquipos, "grpEquipos");
            grpEquipos.Name = "grpEquipos";
            grpEquipos.TabStop = false;
            // 
            // lsbEquipos
            // 
            resources.ApplyResources(lsbEquipos, "lsbEquipos");
            lsbEquipos.FormattingEnabled = true;
            lsbEquipos.Name = "lsbEquipos";
            lsbEquipos.TabStop = false;
            lsbEquipos.KeyDown += lsbEquipos_KeyDown;
            // 
            // txtEquipos
            // 
            txtEquipos.CharacterCasing = CharacterCasing.Upper;
            resources.ApplyResources(txtEquipos, "txtEquipos");
            txtEquipos.Name = "txtEquipos";
            txtEquipos.KeyDown += txtEquipos_KeyDown;
            // 
            // grpBL
            // 
            grpBL.Controls.Add(lsbBL);
            grpBL.Controls.Add(txtBL);
            resources.ApplyResources(grpBL, "grpBL");
            grpBL.Name = "grpBL";
            grpBL.TabStop = false;
            // 
            // lsbBL
            // 
            resources.ApplyResources(lsbBL, "lsbBL");
            lsbBL.FormattingEnabled = true;
            lsbBL.Name = "lsbBL";
            lsbBL.TabStop = false;
            lsbBL.KeyDown += lsbBL_KeyDown;
            // 
            // txtBL
            // 
            txtBL.CharacterCasing = CharacterCasing.Upper;
            resources.ApplyResources(txtBL, "txtBL");
            txtBL.Name = "txtBL";
            txtBL.KeyDown += txtBL_KeyDown;
            // 
            // cboTerminal
            // 
            cboTerminal.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboTerminal, "cboTerminal");
            cboTerminal.FormattingEnabled = true;
            cboTerminal.Name = "cboTerminal";
            // 
            // cboShipper
            // 
            cboShipper.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboShipper, "cboShipper");
            cboShipper.FormattingEnabled = true;
            cboShipper.Name = "cboShipper";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listView1);
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // listView1
            // 
            resources.ApplyResources(listView1, "listView1");
            errorProvider1.SetIconAlignment(listView1, (ErrorIconAlignment)resources.GetObject("listView1.IconAlignment"));
            listView1.LargeImageList = imageList1;
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.ItemActivate += listView1_ItemActivate;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            resources.ApplyResources(imageList1, "imageList1");
            imageList1.TransparentColor = Color.Transparent;
            // 
            // cboNaviera
            // 
            cboNaviera.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboNaviera, "cboNaviera");
            cboNaviera.FormattingEnabled = true;
            cboNaviera.Name = "cboNaviera";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clbRevisiones);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // clbRevisiones
            // 
            clbRevisiones.CheckOnClick = true;
            resources.ApplyResources(clbRevisiones, "clbRevisiones");
            clbRevisiones.FormattingEnabled = true;
            clbRevisiones.Name = "clbRevisiones";
            // 
            // cboAduana
            // 
            cboAduana.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboAduana, "cboAduana");
            cboAduana.FormattingEnabled = true;
            cboAduana.Name = "cboAduana";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // dtpETA
            // 
            resources.ApplyResources(dtpETA, "dtpETA");
            dtpETA.Format = DateTimePickerFormat.Short;
            dtpETA.Name = "dtpETA";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // cboDestino
            // 
            cboDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboDestino, "cboDestino");
            cboDestino.FormattingEnabled = true;
            cboDestino.Name = "cboDestino";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // cboForwarder
            // 
            cboForwarder.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cboForwarder, "cboForwarder");
            cboForwarder.FormattingEnabled = true;
            cboForwarder.Name = "cboForwarder";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // txtId
            // 
            resources.ApplyResources(txtId, "txtId");
            txtId.Name = "txtId";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListarXXX, tsbModificar, tsbEliminar, tsbPago, tsbUpload, tsddbSwitchUser, tsddbProceso, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Name = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsbNuevo, "tsbNuevo");
            tsbNuevo.Image = Properties.Resources.add_file;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBuscar.Image = Properties.Resources.file;
            resources.ApplyResources(tsbBuscar, "tsbBuscar");
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbListarXXX
            // 
            tsbListarXXX.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbListarXXX.Image = Properties.Resources.listar;
            resources.ApplyResources(tsbListarXXX, "tsbListarXXX");
            tsbListarXXX.Name = "tsbListarXXX";
            // 
            // tsbModificar
            // 
            tsbModificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsbModificar, "tsbModificar");
            tsbModificar.Image = Properties.Resources.edit;
            tsbModificar.Name = "tsbModificar";
            tsbModificar.Click += tsbModificar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsbEliminar, "tsbEliminar");
            tsbEliminar.Image = Properties.Resources.delete;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbPago
            // 
            tsbPago.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsbPago, "tsbPago");
            tsbPago.Name = "tsbPago";
            tsbPago.Click += tsbPago_Click;
            // 
            // tsbUpload
            // 
            tsbUpload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsbUpload, "tsbUpload");
            tsbUpload.Image = Properties.Resources.upload;
            tsbUpload.Name = "tsbUpload";
            tsbUpload.Click += tsbUpload_Click;
            // 
            // tsddbSwitchUser
            // 
            tsddbSwitchUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsddbSwitchUser, "tsddbSwitchUser");
            tsddbSwitchUser.Image = Properties.Resources.exchangeUser;
            tsddbSwitchUser.Name = "tsddbSwitchUser";
            tsddbSwitchUser.Click += tsddbSwitchUser_Click;
            // 
            // tsddbProceso
            // 
            tsddbProceso.DisplayStyle = ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(tsddbProceso, "tsddbProceso");
            tsddbProceso.Image = Properties.Resources.location;
            tsddbProceso.Name = "tsddbProceso";
            tsddbProceso.DropDownItemClicked += tsddbProceso_DropDownItemClicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsbAceptar
            // 
            tsbAceptar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAceptar.Image = Properties.Resources.check;
            resources.ApplyResources(tsbAceptar, "tsbAceptar");
            tsbAceptar.Name = "tsbAceptar";
            tsbAceptar.Click += tsbAceptar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = Properties.Resources.close;
            resources.ApplyResources(tsbCancelar, "tsbCancelar");
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbAnterior
            // 
            tsbAnterior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAnterior.Image = Properties.Resources.arrow_l;
            resources.ApplyResources(tsbAnterior, "tsbAnterior");
            tsbAnterior.Name = "tsbAnterior";
            tsbAnterior.Click += tsbAnterior_Click;
            // 
            // tslIndice
            // 
            tslIndice.Name = "tslIndice";
            resources.ApplyResources(tslIndice, "tslIndice");
            // 
            // tsbSiguiente
            // 
            tsbSiguiente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSiguiente.Image = Properties.Resources.arrow_r;
            resources.ApplyResources(tsbSiguiente, "tsbSiguiente");
            tsbSiguiente.Name = "tsbSiguiente";
            tsbSiguiente.Click += tsbSiguiente_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSalir.Image = Properties.Resources.logout;
            resources.ApplyResources(tsbSalir, "tsbSalir");
            tsbSalir.Name = "tsbSalir";
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(openFileDialog1, "openFileDialog1");
            // 
            // frmMaritimo
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStripContainer1);
            Name = "frmMaritimo";
            Load += frmMaritimo_Load;
            Shown += frmMaritimo_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            grpEquipos.ResumeLayout(false);
            grpEquipos.PerformLayout();
            grpBL.ResumeLayout(false);
            grpBL.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ErrorProvider errorProvider1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbListarXXX;
        private ToolStripButton tsbModificar;
        private ToolStripButton tsbEliminar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAceptar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbAnterior;
        private ToolStripLabel tslIndice;
        private ToolStripButton tsbSiguiente;
        private ToolStripButton tsbSalir;
        private TextBox txtId;
        private Label label1;
        private ComboBox cboForwarder;
        private Label label2;
        private Label label7;
        private ComboBox cboAduana;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpETA;
        private Label label4;
        private ComboBox cboDestino;
        private Label label3;
        private ComboBox cboNaviera;
        private Label label9;
        private GroupBox groupBox2;
        private CheckedListBox clbRevisiones;
        private GroupBox groupBox4;
        private ListView listView1;
        private ImageList imageList1;
        private FileSystemWatcher fileSystemWatcher1;
        private ToolStripButton tsbUpload;
        private OpenFileDialog openFileDialog1;
        private ComboBox cboShipper;
        private ComboBox cboTerminal;
        private ToolStripDropDownButton tsddbProceso;
        private GroupBox grpBL;
        private ListBox lsbBL;
        private TextBox txtBL;
        private GroupBox grpEquipos;
        private ListBox lsbEquipos;
        private TextBox txtEquipos;
        private DataGridView dgvHistorial;
        private TextBox txtValorExtra;
        private Label label11;
        private TextBox txtDemora;
        private Label label10;
        private TextBox txtTiempoLibre;
        private Label label8;
        private CheckBox chkConsolidado;
        private CheckBox chkDocOriginales;
        private TextBox txtValorExtra2;
        private Label label12;
        private ToolStripButton tsbPago;
        private ComboBox cboAgente;
        private Label label13;
        private ToolStripDropDownButton tsddbSwitchUser;
    }
}