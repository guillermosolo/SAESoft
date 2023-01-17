namespace SAESoft.AdministracionSistema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblActivo = new System.Windows.Forms.Label();
            this.tsActivo = new SAESoft.Utilitarios.toggleSwitch();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbListar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAceptar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tslIndice = new System.Windows.Forms.ToolStripLabel();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            this.errorProvider1.SetError(this.toolStripContainer1.BottomToolStripPanel, resources.GetString("toolStripContainer1.BottomToolStripPanel.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1.BottomToolStripPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.BottomToolStripPanel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1.BottomToolStripPanel, ((int)(resources.GetObject("toolStripContainer1.BottomToolStripPanel.IconPadding"))));
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblActivo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tsActivo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtNombre);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.txtId);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.errorProvider1.SetError(this.toolStripContainer1.ContentPanel, resources.GetString("toolStripContainer1.ContentPanel.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1.ContentPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.ContentPanel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1.ContentPanel, ((int)(resources.GetObject("toolStripContainer1.ContentPanel.IconPadding"))));
            this.errorProvider1.SetError(this.toolStripContainer1, resources.GetString("toolStripContainer1.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1, ((int)(resources.GetObject("toolStripContainer1.IconPadding"))));
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.errorProvider1.SetError(this.toolStripContainer1.LeftToolStripPanel, resources.GetString("toolStripContainer1.LeftToolStripPanel.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1.LeftToolStripPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.LeftToolStripPanel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1.LeftToolStripPanel, ((int)(resources.GetObject("toolStripContainer1.LeftToolStripPanel.IconPadding"))));
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            this.errorProvider1.SetError(this.toolStripContainer1.RightToolStripPanel, resources.GetString("toolStripContainer1.RightToolStripPanel.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1.RightToolStripPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.RightToolStripPanel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1.RightToolStripPanel, ((int)(resources.GetObject("toolStripContainer1.RightToolStripPanel.IconPadding"))));
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.errorProvider1.SetError(this.toolStripContainer1.TopToolStripPanel, resources.GetString("toolStripContainer1.TopToolStripPanel.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStripContainer1.TopToolStripPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStripContainer1.TopToolStripPanel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStripContainer1.TopToolStripPanel, ((int)(resources.GetObject("toolStripContainer1.TopToolStripPanel.IconPadding"))));
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // lblActivo
            // 
            resources.ApplyResources(this.lblActivo, "lblActivo");
            this.errorProvider1.SetError(this.lblActivo, resources.GetString("lblActivo.Error"));
            this.errorProvider1.SetIconAlignment(this.lblActivo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblActivo.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblActivo, ((int)(resources.GetObject("lblActivo.IconPadding"))));
            this.lblActivo.Name = "lblActivo";
            // 
            // tsActivo
            // 
            resources.ApplyResources(this.tsActivo, "tsActivo");
            this.errorProvider1.SetError(this.tsActivo, resources.GetString("tsActivo.Error"));
            this.errorProvider1.SetIconAlignment(this.tsActivo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tsActivo.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tsActivo, ((int)(resources.GetObject("tsActivo.IconPadding"))));
            this.tsActivo.Name = "tsActivo";
            this.tsActivo.OffBackColor = System.Drawing.Color.Firebrick;
            this.tsActivo.OffTogglecolor = System.Drawing.Color.Firebrick;
            this.tsActivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.tsActivo.OnTogglecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.tsActivo.SolidStyle = false;
            this.tsActivo.UseVisualStyleBackColor = true;
            this.tsActivo.CheckedChanged += new System.EventHandler(this.tsActivo_CheckedChanged);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.errorProvider1.SetError(this.txtNombre, resources.GetString("txtNombre.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNombre.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNombre, ((int)(resources.GetObject("txtNombre.IconPadding"))));
            this.txtNombre.Name = "txtNombre";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.errorProvider1.SetError(this.txtId, resources.GetString("txtId.Error"));
            this.errorProvider1.SetIconAlignment(this.txtId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtId.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtId, ((int)(resources.GetObject("txtId.IconPadding"))));
            this.txtId.Name = "txtId";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.errorProvider1.SetError(this.toolStrip1, resources.GetString("toolStrip1.Error"));
            this.errorProvider1.SetIconAlignment(this.toolStrip1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("toolStrip1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.toolStrip1, ((int)(resources.GetObject("toolStrip1.IconPadding"))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscar,
            this.tsbListar,
            this.tsbModificar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbAceptar,
            this.tsbCancelar,
            this.tsbAnterior,
            this.tslIndice,
            this.tsbSiguiente,
            this.tsbSalir});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tsbNuevo
            // 
            resources.ApplyResources(this.tsbNuevo, "tsbNuevo");
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::SAESoft.Properties.Resources.add_file;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBuscar
            // 
            resources.ApplyResources(this.tsbBuscar, "tsbBuscar");
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::SAESoft.Properties.Resources.file;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbListar
            // 
            resources.ApplyResources(this.tsbListar, "tsbListar");
            this.tsbListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListar.Image = global::SAESoft.Properties.Resources.listar;
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Click += new System.EventHandler(this.tsbListar_Click);
            // 
            // tsbModificar
            // 
            resources.ApplyResources(this.tsbModificar, "tsbModificar");
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::SAESoft.Properties.Resources.edit;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            resources.ApplyResources(this.tsbEliminar, "tsbEliminar");
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::SAESoft.Properties.Resources.delete;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsbAceptar
            // 
            resources.ApplyResources(this.tsbAceptar, "tsbAceptar");
            this.tsbAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAceptar.Image = global::SAESoft.Properties.Resources.check;
            this.tsbAceptar.Name = "tsbAceptar";
            this.tsbAceptar.Click += new System.EventHandler(this.tsbAceptar_Click);
            // 
            // tsbCancelar
            // 
            resources.ApplyResources(this.tsbCancelar, "tsbCancelar");
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = global::SAESoft.Properties.Resources.close;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbAnterior
            // 
            resources.ApplyResources(this.tsbAnterior, "tsbAnterior");
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = global::SAESoft.Properties.Resources.arrow_l;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Click += new System.EventHandler(this.tsbAnterior_Click);
            // 
            // tslIndice
            // 
            resources.ApplyResources(this.tslIndice, "tslIndice");
            this.tslIndice.Name = "tslIndice";
            // 
            // tsbSiguiente
            // 
            resources.ApplyResources(this.tsbSiguiente, "tsbSiguiente");
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = global::SAESoft.Properties.Resources.arrow_r;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Click += new System.EventHandler(this.tsbSiguiente_Click);
            // 
            // tsbSalir
            // 
            resources.ApplyResources(this.tsbSalir, "tsbSalir");
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::SAESoft.Properties.Resources.logout;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmRoles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.Shown += new System.EventHandler(this.frmRoles_Shown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

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