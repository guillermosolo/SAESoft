namespace SAESoft.AdministracionSistema.Seguridad
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            dataGridView1 = new DataGridView();
            lblActivo = new Label();
            tsActivo = new Utilitarios.toggleSwitch();
            txtNombre = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbListar = new ToolStripButton();
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
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dataGridView1);
            toolStripContainer1.ContentPanel.Controls.Add(lblActivo);
            toolStripContainer1.ContentPanel.Controls.Add(tsActivo);
            toolStripContainer1.ContentPanel.Controls.Add(txtNombre);
            toolStripContainer1.ContentPanel.Controls.Add(label2);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // lblActivo
            // 
            resources.ApplyResources(lblActivo, "lblActivo");
            lblActivo.Name = "lblActivo";
            // 
            // tsActivo
            // 
            resources.ApplyResources(tsActivo, "tsActivo");
            tsActivo.Name = "tsActivo";
            tsActivo.OffBackColor = Color.Firebrick;
            tsActivo.OffDisabledColor = Color.Gray;
            tsActivo.OffTogglecolor = Color.Firebrick;
            tsActivo.OnBackColor = Color.FromArgb(0, 122, 172);
            tsActivo.OnDisabledcolor = Color.Gray;
            tsActivo.OnTogglecolor = Color.FromArgb(0, 122, 172);
            tsActivo.SolidStyle = false;
            tsActivo.UseVisualStyleBackColor = true;
            tsActivo.CheckedChanged += tsActivo_CheckedChanged;
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBuscar, tsbListar, tsbModificar, tsbEliminar, toolStripSeparator1, tsbAceptar, tsbCancelar, tsbAnterior, tslIndice, tsbSiguiente, tsbSalir });
            toolStrip1.Name = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = Properties.Resources.add_file;
            resources.ApplyResources(tsbNuevo, "tsbNuevo");
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
            // tsbListar
            // 
            tsbListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbListar.Image = Properties.Resources.listar;
            resources.ApplyResources(tsbListar, "tsbListar");
            tsbListar.Name = "tsbListar";
            tsbListar.Click += tsbListar_Click;
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
            // frmRoles
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStripContainer1);
            Name = "frmRoles";
            Load += frmRoles_Load;
            Shown += frmRoles_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ToolStripButton tsbListar;
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
        private DataGridView dataGridView1;
        private Label lblActivo;
        private Utilitarios.toggleSwitch tsActivo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtId;
        private Label label1;
    }
}