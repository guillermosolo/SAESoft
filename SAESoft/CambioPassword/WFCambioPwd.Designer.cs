namespace SAESoft.CambioPassword
{
    partial class WFCambioPwd
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            lblValida = new Label();
            lblIguales = new Label();
            iBtnCambio = new FontAwesome.Sharp.IconButton();
            panelBarraTitulo = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            icbRestaurar = new FontAwesome.Sharp.IconButton();
            icbMinimizar = new FontAwesome.Sharp.IconButton();
            icbMaximizar = new FontAwesome.Sharp.IconButton();
            icbCerrar = new FontAwesome.Sharp.IconButton();
            panelBarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(161, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 5061;
            label2.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(325, 59);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 31);
            textBox1.TabIndex = 5062;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 25);
            label3.TabIndex = 5063;
            label3.Text = "Contraseña Actual:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(325, 102);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(283, 31);
            textBox2.TabIndex = 5064;
            textBox2.KeyUp += textBox2_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 25);
            label4.TabIndex = 5065;
            label4.Text = "Contraseña Nueva:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(325, 148);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(283, 31);
            textBox3.TabIndex = 5066;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(249, 25);
            label5.TabIndex = 5067;
            label5.Text = "Confirmar Contraseña:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(325, 191);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(283, 31);
            textBox4.TabIndex = 5068;
            textBox4.KeyUp += textBox4_KeyUp;
            // 
            // lblValida
            // 
            lblValida.AutoSize = true;
            lblValida.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValida.Location = new Point(626, 106);
            lblValida.Margin = new Padding(4, 0, 4, 0);
            lblValida.Name = "lblValida";
            lblValida.Size = new Size(0, 24);
            lblValida.TabIndex = 5069;
            // 
            // lblIguales
            // 
            lblIguales.AutoSize = true;
            lblIguales.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIguales.Location = new Point(626, 195);
            lblIguales.Margin = new Padding(4, 0, 4, 0);
            lblIguales.Name = "lblIguales";
            lblIguales.Size = new Size(0, 24);
            lblIguales.TabIndex = 5070;
            // 
            // iBtnCambio
            // 
            iBtnCambio.BackColor = Color.FromArgb(217, 236, 244);
            iBtnCambio.Enabled = false;
            iBtnCambio.FlatAppearance.BorderSize = 0;
            iBtnCambio.FlatStyle = FlatStyle.Flat;
            iBtnCambio.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iBtnCambio.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            iBtnCambio.IconColor = Color.FromArgb(0, 122, 204);
            iBtnCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnCambio.ImageAlign = ContentAlignment.MiddleLeft;
            iBtnCambio.Location = new Point(209, 238);
            iBtnCambio.Margin = new Padding(4, 3, 4, 3);
            iBtnCambio.Name = "iBtnCambio";
            iBtnCambio.Size = new Size(226, 77);
            iBtnCambio.TabIndex = 5071;
            iBtnCambio.Text = "Cambiar Contraseña";
            iBtnCambio.TextAlign = ContentAlignment.MiddleLeft;
            iBtnCambio.TextImageRelation = TextImageRelation.ImageBeforeText;
            iBtnCambio.UseVisualStyleBackColor = false;
            iBtnCambio.Click += iBtnCambio_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = SystemColors.HotTrack;
            panelBarraTitulo.Controls.Add(iconButton1);
            panelBarraTitulo.Controls.Add(icbRestaurar);
            panelBarraTitulo.Controls.Add(icbMinimizar);
            panelBarraTitulo.Controls.Add(icbMaximizar);
            panelBarraTitulo.Controls.Add(icbCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(742, 36);
            panelBarraTitulo.TabIndex = 5072;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 36;
            iconButton1.Location = new Point(706, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(36, 40);
            iconButton1.TabIndex = 6;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // icbRestaurar
            // 
            icbRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbRestaurar.FlatAppearance.BorderSize = 0;
            icbRestaurar.FlatStyle = FlatStyle.Flat;
            icbRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            icbRestaurar.IconColor = Color.White;
            icbRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbRestaurar.IconSize = 36;
            icbRestaurar.Location = new Point(1470, 0);
            icbRestaurar.Name = "icbRestaurar";
            icbRestaurar.Size = new Size(36, 40);
            icbRestaurar.TabIndex = 5;
            icbRestaurar.UseVisualStyleBackColor = true;
            icbRestaurar.Visible = false;
            // 
            // icbMinimizar
            // 
            icbMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbMinimizar.FlatAppearance.BorderSize = 0;
            icbMinimizar.FlatStyle = FlatStyle.Flat;
            icbMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            icbMinimizar.IconColor = Color.White;
            icbMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbMinimizar.IconSize = 36;
            icbMinimizar.Location = new Point(1438, 0);
            icbMinimizar.Name = "icbMinimizar";
            icbMinimizar.Size = new Size(36, 40);
            icbMinimizar.TabIndex = 4;
            icbMinimizar.UseVisualStyleBackColor = true;
            // 
            // icbMaximizar
            // 
            icbMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbMaximizar.FlatAppearance.BorderSize = 0;
            icbMaximizar.FlatStyle = FlatStyle.Flat;
            icbMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            icbMaximizar.IconColor = Color.White;
            icbMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbMaximizar.IconSize = 36;
            icbMaximizar.Location = new Point(1470, 0);
            icbMaximizar.Name = "icbMaximizar";
            icbMaximizar.Size = new Size(36, 40);
            icbMaximizar.TabIndex = 3;
            icbMaximizar.UseVisualStyleBackColor = true;
            // 
            // icbCerrar
            // 
            icbCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icbCerrar.FlatAppearance.BorderSize = 0;
            icbCerrar.FlatStyle = FlatStyle.Flat;
            icbCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            icbCerrar.IconColor = Color.White;
            icbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbCerrar.IconSize = 36;
            icbCerrar.Location = new Point(1503, 0);
            icbCerrar.Name = "icbCerrar";
            icbCerrar.Size = new Size(36, 40);
            icbCerrar.TabIndex = 2;
            icbCerrar.UseVisualStyleBackColor = true;
            // 
            // WFCambioPwd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(742, 326);
            Controls.Add(panelBarraTitulo);
            Controls.Add(iBtnCambio);
            Controls.Add(lblIguales);
            Controls.Add(lblValida);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WFCambioPwd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cambio de Contraseña de Acceso";
            Load += WFCambioPwd_Load;
            panelBarraTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblValida;
        private System.Windows.Forms.Label lblIguales;
        private FontAwesome.Sharp.IconButton iBtnCambio;
        private Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconButton icbRestaurar;
        private FontAwesome.Sharp.IconButton icbMinimizar;
        private FontAwesome.Sharp.IconButton icbMaximizar;
        private FontAwesome.Sharp.IconButton icbCerrar;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}