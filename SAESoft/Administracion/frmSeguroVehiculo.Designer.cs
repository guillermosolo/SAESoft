﻿namespace SAESoft.Administracion
{
    partial class frmSeguroVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguroVehiculo));
            txtMarca = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtColor = new TextBox();
            label2 = new Label();
            txtPlacas = new TextBox();
            label4 = new Label();
            cboAseguradora = new ComboBox();
            txtPoliza = new TextBox();
            label5 = new Label();
            dtpVencimiento = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPrima = new TextBox();
            txtDeducible = new TextBox();
            icbFinalizar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(117, 29);
            txtMarca.Margin = new Padding(4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(351, 27);
            txtMarca.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 8;
            label3.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 10;
            label1.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(117, 68);
            txtColor.Margin = new Padding(4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(351, 27);
            txtColor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 12;
            label2.Text = "Placas";
            // 
            // txtPlacas
            // 
            txtPlacas.CharacterCasing = CharacterCasing.Upper;
            txtPlacas.Location = new Point(117, 108);
            txtPlacas.Margin = new Padding(4);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(351, 27);
            txtPlacas.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 14;
            label4.Text = "Aseguradora";
            // 
            // cboAseguradora
            // 
            cboAseguradora.FormattingEnabled = true;
            cboAseguradora.Location = new Point(158, 148);
            cboAseguradora.Name = "cboAseguradora";
            cboAseguradora.Size = new Size(310, 29);
            cboAseguradora.TabIndex = 15;
            // 
            // txtPoliza
            // 
            txtPoliza.CharacterCasing = CharacterCasing.Upper;
            txtPoliza.Location = new Point(117, 193);
            txtPoliza.Margin = new Padding(4);
            txtPoliza.Name = "txtPoliza";
            txtPoliza.Size = new Size(351, 27);
            txtPoliza.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 196);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 16;
            label5.Text = "Póliza";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(358, 232);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(110, 27);
            dtpVencimiento.TabIndex = 19;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(117, 232);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(110, 27);
            dtpInicio.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 237);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 20;
            label6.Text = "Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 237);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 21;
            label7.Text = "Vencimiento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 274);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 22;
            label8.Text = "Prima";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 274);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 23;
            label9.Text = "Deducible";
            // 
            // txtPrima
            // 
            txtPrima.Location = new Point(117, 271);
            txtPrima.Margin = new Padding(4);
            txtPrima.Name = "txtPrima";
            txtPrima.Size = new Size(124, 27);
            txtPrima.TabIndex = 24;
            // 
            // txtDeducible
            // 
            txtDeducible.Location = new Point(344, 271);
            txtDeducible.Margin = new Padding(4);
            txtDeducible.Name = "txtDeducible";
            txtDeducible.Size = new Size(124, 27);
            txtDeducible.TabIndex = 25;
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
            icbFinalizar.Location = new Point(178, 323);
            icbFinalizar.Name = "icbFinalizar";
            icbFinalizar.Size = new Size(124, 36);
            icbFinalizar.TabIndex = 33;
            icbFinalizar.Text = "Guardar";
            icbFinalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbFinalizar.UseVisualStyleBackColor = true;
            icbFinalizar.Click += icbFinalizar_Click;
            // 
            // frmSeguroVehiculo
            // 
            AcceptButton = icbFinalizar;
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 375);
            Controls.Add(icbFinalizar);
            Controls.Add(txtDeducible);
            Controls.Add(txtPrima);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dtpVencimiento);
            Controls.Add(dtpInicio);
            Controls.Add(txtPoliza);
            Controls.Add(label5);
            Controls.Add(cboAseguradora);
            Controls.Add(label4);
            Controls.Add(txtPlacas);
            Controls.Add(label2);
            Controls.Add(txtColor);
            Controls.Add(label1);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSeguroVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmSeguroVehiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private Label label3;
        private Label label1;
        private TextBox txtColor;
        private Label label2;
        private TextBox txtPlacas;
        private Label label4;
        private ComboBox cboAseguradora;
        private TextBox txtPoliza;
        private Label label5;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpInicio;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPrima;
        private TextBox txtDeducible;
        private FontAwesome.Sharp.IconButton icbFinalizar;
    }
}