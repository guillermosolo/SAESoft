﻿namespace SAESoft.Importaciones
{
    partial class frmMenuImportaciones
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnDashboard = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.ibtnDashboard);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.ibtnSalir);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // ibtnDashboard
            // 
            this.ibtnDashboard.FlatAppearance.BorderSize = 0;
            this.ibtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnDashboard.ForeColor = System.Drawing.Color.White;
            this.ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibtnDashboard.IconColor = System.Drawing.Color.White;
            this.ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDashboard.IconSize = 32;
            this.ibtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDashboard.Location = new System.Drawing.Point(3, 47);
            this.ibtnDashboard.Name = "ibtnDashboard";
            this.ibtnDashboard.Size = new System.Drawing.Size(197, 29);
            this.ibtnDashboard.TabIndex = 7;
            this.ibtnDashboard.Text = "Dashboard";
            this.ibtnDashboard.UseVisualStyleBackColor = true;
            this.ibtnDashboard.Click += new System.EventHandler(this.ibtnDashboard_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 395);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 29);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Salir";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnSalir.FlatAppearance.BorderSize = 0;
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnSalir.ForeColor = System.Drawing.Color.White;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.White;
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 32;
            this.ibtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSalir.Location = new System.Drawing.Point(3, 727);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(197, 43);
            this.ibtnSalir.TabIndex = 3;
            this.ibtnSalir.Text = "Salir";
            this.ibtnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(200, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(600, 450);
            this.panelFormularios.TabIndex = 2;
            // 
            // frmMenuImportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMenuImportaciones";
            this.Text = "frmMenuImportaciones";
            this.Load += new System.EventHandler(this.frmMenuImportaciones_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private Panel panelFormularios;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
    }
}