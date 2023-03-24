namespace SAESoft
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            groupBox2 = new GroupBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            icbLogin = new FontAwesome.Sharp.IconButton();
            icbSalir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lblError = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(349, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 11);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(355, 101);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "USUARIO";
            txtUser.Size = new Size(305, 20);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(355, 164);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "CONTRASEÑA";
            txtPass.Size = new Size(305, 20);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(349, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 11);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(0, 122, 204);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.FromArgb(0, 122, 204);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 31;
            iconPictureBox1.Location = new Point(310, 96);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(33, 31);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(0, 122, 204);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(0, 122, 204);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 31;
            iconPictureBox2.Location = new Point(310, 159);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(33, 31);
            iconPictureBox2.TabIndex = 6;
            iconPictureBox2.TabStop = false;
            // 
            // icbLogin
            // 
            icbLogin.BackColor = Color.FromArgb(0, 122, 204);
            icbLogin.FlatStyle = FlatStyle.Flat;
            icbLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            icbLogin.ForeColor = Color.White;
            icbLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            icbLogin.IconColor = Color.FromArgb(0, 122, 204);
            icbLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icbLogin.IconSize = 30;
            icbLogin.ImageAlign = ContentAlignment.MiddleLeft;
            icbLogin.Location = new Point(355, 234);
            icbLogin.Name = "icbLogin";
            icbLogin.Size = new Size(124, 51);
            icbLogin.TabIndex = 7;
            icbLogin.Text = "Login";
            icbLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbLogin.UseVisualStyleBackColor = false;
            icbLogin.Click += icbLogin_Click;
            // 
            // icbSalir
            // 
            icbSalir.BackColor = Color.IndianRed;
            icbSalir.FlatStyle = FlatStyle.Flat;
            icbSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            icbSalir.ForeColor = Color.White;
            icbSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            icbSalir.IconColor = Color.FromArgb(0, 122, 204);
            icbSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            icbSalir.IconSize = 30;
            icbSalir.Location = new Point(504, 233);
            icbSalir.Name = "icbSalir";
            icbSalir.Size = new Size(124, 51);
            icbSalir.TabIndex = 10;
            icbSalir.Text = "Salir";
            icbSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            icbSalir.UseVisualStyleBackColor = false;
            icbSalir.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(458, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 11;
            label1.Text = "LOGIN";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.Red;
            lblError.Image = Properties.Resources.sign;
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(310, 198);
            lblError.Name = "lblError";
            lblError.Size = new Size(170, 21);
            lblError.TabIndex = 12;
            lblError.Text = "        Mensaje de Error";
            lblError.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(691, 306);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 330);
            Controls.Add(label2);
            Controls.Add(lblError);
            Controls.Add(label1);
            Controls.Add(icbSalir);
            Controls.Add(icbLogin);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtPass);
            Controls.Add(groupBox2);
            Controls.Add(txtUser);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLogin_Load;
            MouseDown += frmLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtUser;
        private TextBox txtPass;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton icbLogin;
        private FontAwesome.Sharp.IconButton icbSalir;
        private Label label1;
        private Label lblError;
        private PictureBox pictureBox1;
        private Label label2;
    }
}