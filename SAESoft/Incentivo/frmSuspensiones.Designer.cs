namespace SAESoft.Incentivo
{
    partial class frmSuspensiones
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
            txtObs = new TextBox();
            label2 = new Label();
            tsActivo = new Utilitarios.toggleSwitch();
            label13 = new Label();
            cboEmpleado = new ComboBox();
            label1 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            cboDepto = new ComboBox();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbModificar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbAceptar = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbAnterior = new ToolStripButton();
            tslIndice = new ToolStripLabel();
            tsbSiguiente = new ToolStripButton();
            tsbSalir = new ToolStripButton();
            errorProvider1 = new ErrorProvider(components);
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(txtObs);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(label13);
            toolStripContainer1.ContentPanel.Controls.Add(cboEmpleado);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(dtpInicio);
            toolStripContainer1.ContentPanel.Controls.Add(dtpFin);
            toolStripContainer1.ContentPanel.Controls.Add(label7);
            toolStripContainer1.ContentPanel.Controls.Add(label6);
            toolStripContainer1.ContentPanel.Controls.Add(cboDepto);
            toolStripContainer1.ContentPanel.Controls.Add(label3);
            toolStripContainer1.ContentPanel.Size = new Size(632, 356);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(632, 395);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // txtObs
            // 
            txtObs.Enabled = false;
            txtObs.Location = new Point(188, 179);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(387, 89);
            txtObs.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 179);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 55;
            label2.Text = "Observaciones";
            // 
            // tsActivo
            // 
            tsActivo.Checked = true;
            tsActivo.CheckState = CheckState.Checked;
            tsActivo.Enabled = false;
            tsActivo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsActivo.Location = new Point(530, 24);
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
            tsActivo.TabIndex = 54;
            tsActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            tsActivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(455, 25);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 53;
            label13.Text = "Activo";
            // 
            // cboEmpleado
            // 
            cboEmpleado.Enabled = false;
            cboEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(188, 65);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(387, 29);
            cboEmpleado.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 51;
            label1.Text = "Empleado";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Enabled = false;
            dtpInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(188, 105);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(116, 27);
            dtpInicio.TabIndex = 50;
            // 
            // dtpFin
            // 
            dtpFin.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFin.Enabled = false;
            dtpFin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(188, 142);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(116, 27);
            dtpFin.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(53, 142);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 48;
            label7.Text = "Fecha de Fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 105);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 47;
            label6.Text = "Fecha de Inicio";
            // 
            // cboDepto
            // 
            cboDepto.Enabled = false;
            cboDepto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboDepto.FormattingEnabled = true;
            cboDepto.Location = new Point(188, 22);
            cboDepto.Name = "cboDepto";
            cboDepto.Size = new Size(239, 29);
            cboDepto.TabIndex = 46;
            cboDepto.SelectedIndexChanged += cboDepto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 22);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 45;
            label3.Text = "Departamento";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbModificar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(162, 39);
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
            // frmSuspensiones
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 395);
            Controls.Add(toolStripContainer1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSuspensiones";
            Text = "frmSuspensiones";
            Load += frmSuspensiones_Load;
            Shown += frmSuspensiones_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbModificar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAceptar;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbAnterior;
        private ToolStripLabel tslIndice;
        private ToolStripButton tsbSiguiente;
        private ToolStripButton tsbSalir;
        private ErrorProvider errorProvider1;
        private ComboBox cboEmpleado;
        private Label label1;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Label label7;
        private Label label6;
        private ComboBox cboDepto;
        private Label label3;
        private TextBox txtObs;
        private Label label2;
        private Utilitarios.toggleSwitch tsActivo;
        private Label label13;
    }
}