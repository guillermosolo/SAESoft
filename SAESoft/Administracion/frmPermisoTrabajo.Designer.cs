namespace SAESoft.Administracion
{
    partial class frmPermisoTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisoTrabajo));
            label2 = new Label();
            cboTipo = new ComboBox();
            label3 = new Label();
            txtResolucion = new TextBox();
            label4 = new Label();
            dtpVencimiento = new DateTimePicker();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            dtpInicio = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 4;
            label2.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(137, 19);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(247, 29);
            cboTipo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 56);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 6;
            label3.Text = "Resolución";
            // 
            // txtResolucion
            // 
            txtResolucion.CharacterCasing = CharacterCasing.Upper;
            txtResolucion.Location = new Point(137, 56);
            txtResolucion.Name = "txtResolucion";
            txtResolucion.Size = new Size(247, 27);
            txtResolucion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 128);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 8;
            label4.Text = "Vencimiento";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(137, 128);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(135, 27);
            dtpVencimiento.TabIndex = 9;
            // 
            // icbFinalizar
            // 
            icbFinalizar.DialogResult = DialogResult.OK;
            icbFinalizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icbFinalizar.ForeColor = Color.Green;
            icbFinalizar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            icbFinalizar.IconColor = Color.Green;
            icbFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbFinalizar.IconSize = 24;
            icbFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            icbFinalizar.Location = new Point(137, 172);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 33;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(136, 92);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(135, 27);
            dtpInicio.TabIndex = 35;
            dtpInicio.ValueChanged += dtpInicio_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 92);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 34;
            label1.Text = "Inicio";
            // 
            // frmPermisoTrabajo
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 222);
            Controls.Add(dtpInicio);
            Controls.Add(label1);
            Controls.Add(icbFinalizar);
            Controls.Add(dtpVencimiento);
            Controls.Add(label4);
            Controls.Add(txtResolucion);
            Controls.Add(label3);
            Controls.Add(cboTipo);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPermisoTrabajo";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmResidencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cboTipo;
        private Label label3;
        private TextBox txtResolucion;
        private Label label4;
        private DateTimePicker dtpVencimiento;
        private FontAwesome.Sharp.IconButton icbFinalizar;
        private DateTimePicker dtpInicio;
        private Label label1;
    }
}