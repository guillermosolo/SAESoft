namespace SAESoft.AdministracionSistema.Importaciones
{
    partial class frmBuscarShipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarShipper));
            icbBuscar = new FontAwesome.Sharp.IconButton();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkTerrestre = new CheckBox();
            chkMaritimo = new CheckBox();
            chkAereo = new CheckBox();
            SuspendLayout();
            // 
            // icbBuscar
            // 
            icbBuscar.DialogResult = DialogResult.OK;
            icbBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            icbBuscar.ForeColor = Color.FromArgb(0, 122, 172);
            icbBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            icbBuscar.IconColor = Color.FromArgb(0, 122, 204);
            icbBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbBuscar.IconSize = 24;
            icbBuscar.Location = new Point(156, 140);
            icbBuscar.Name = "icbBuscar";
            icbBuscar.Size = new Size(107, 35);
            icbBuscar.TabIndex = 49;
            icbBuscar.Text = "Buscar";
            icbBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbBuscar.UseVisualStyleBackColor = true;
            icbBuscar.Click += icbBuscar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(132, 6);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 27);
            txtDescripcion.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 45;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(35, 21);
            label3.TabIndex = 54;
            label3.Text = "Vía";
            // 
            // chkTerrestre
            // 
            chkTerrestre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkTerrestre.Appearance = Appearance.Button;
            chkTerrestre.AutoSize = true;
            chkTerrestre.FlatAppearance.BorderSize = 0;
            chkTerrestre.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkTerrestre.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkTerrestre.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkTerrestre.FlatStyle = FlatStyle.Flat;
            chkTerrestre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkTerrestre.Image = Properties.Resources.Nunchecked;
            chkTerrestre.ImageAlign = ContentAlignment.MiddleLeft;
            chkTerrestre.ImeMode = ImeMode.NoControl;
            chkTerrestre.Location = new Point(132, 103);
            chkTerrestre.Name = "chkTerrestre";
            chkTerrestre.Size = new Size(110, 31);
            chkTerrestre.TabIndex = 53;
            chkTerrestre.Text = "  Terrestre";
            chkTerrestre.TextAlign = ContentAlignment.BottomCenter;
            chkTerrestre.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkTerrestre.UseVisualStyleBackColor = true;
            chkTerrestre.CheckedChanged += chkCheckedChange;
            // 
            // chkMaritimo
            // 
            chkMaritimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkMaritimo.Appearance = Appearance.Button;
            chkMaritimo.AutoSize = true;
            chkMaritimo.FlatAppearance.BorderSize = 0;
            chkMaritimo.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkMaritimo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkMaritimo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkMaritimo.FlatStyle = FlatStyle.Flat;
            chkMaritimo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkMaritimo.Image = Properties.Resources.Nunchecked;
            chkMaritimo.ImageAlign = ContentAlignment.MiddleLeft;
            chkMaritimo.ImeMode = ImeMode.NoControl;
            chkMaritimo.Location = new Point(132, 76);
            chkMaritimo.Name = "chkMaritimo";
            chkMaritimo.Size = new Size(113, 31);
            chkMaritimo.TabIndex = 52;
            chkMaritimo.Text = "  Marítimo";
            chkMaritimo.TextAlign = ContentAlignment.BottomCenter;
            chkMaritimo.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkMaritimo.UseVisualStyleBackColor = true;
            chkMaritimo.CheckedChanged += chkCheckedChange;
            // 
            // chkAereo
            // 
            chkAereo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAereo.Appearance = Appearance.Button;
            chkAereo.AutoSize = true;
            chkAereo.FlatAppearance.BorderSize = 0;
            chkAereo.FlatAppearance.CheckedBackColor = Color.Transparent;
            chkAereo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            chkAereo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            chkAereo.FlatStyle = FlatStyle.Flat;
            chkAereo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAereo.Image = Properties.Resources.Nunchecked;
            chkAereo.ImageAlign = ContentAlignment.MiddleLeft;
            chkAereo.ImeMode = ImeMode.NoControl;
            chkAereo.Location = new Point(132, 48);
            chkAereo.Name = "chkAereo";
            chkAereo.Size = new Size(92, 31);
            chkAereo.TabIndex = 51;
            chkAereo.Text = "  Aéreo";
            chkAereo.TextAlign = ContentAlignment.BottomCenter;
            chkAereo.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkAereo.UseVisualStyleBackColor = true;
            chkAereo.CheckedChanged += chkCheckedChange;
            // 
            // frmBuscarShipper
            // 
            AcceptButton = icbBuscar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 193);
            Controls.Add(label3);
            Controls.Add(chkTerrestre);
            Controls.Add(chkMaritimo);
            Controls.Add(chkAereo);
            Controls.Add(icbBuscar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscarShipper";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton icbBuscar;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private CheckBox chkTerrestre;
        private CheckBox chkMaritimo;
        private CheckBox chkAereo;
    }
}