namespace hci_apoteka
{
    partial class FormMainAdmin
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
            this.panelMenuAdmin = new System.Windows.Forms.Panel();
            this.btnCiphers = new FontAwesome.Sharp.IconButton();
            this.btnEmployees = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBoxMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktopAdmin = new System.Windows.Forms.Panel();
            this.panelMenuAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuAdmin
            // 
            this.panelMenuAdmin.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenuAdmin.Controls.Add(this.btnCiphers);
            this.panelMenuAdmin.Controls.Add(this.btnEmployees);
            this.panelMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAdmin.Name = "panelMenuAdmin";
            this.panelMenuAdmin.Size = new System.Drawing.Size(179, 681);
            this.panelMenuAdmin.TabIndex = 0;
            // 
            // btnCiphers
            // 
            this.btnCiphers.FlatAppearance.BorderSize = 0;
            this.btnCiphers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCiphers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiphers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCiphers.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnCiphers.IconColor = System.Drawing.Color.LightGray;
            this.btnCiphers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCiphers.IconSize = 32;
            this.btnCiphers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiphers.Location = new System.Drawing.Point(0, 135);
            this.btnCiphers.Name = "btnCiphers";
            this.btnCiphers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCiphers.Size = new System.Drawing.Size(179, 84);
            this.btnCiphers.TabIndex = 8;
            this.btnCiphers.Text = "    Ciphers";
            this.btnCiphers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCiphers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCiphers.UseVisualStyleBackColor = true;
            this.btnCiphers.Click += new System.EventHandler(this.BtnSifarnici_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployees.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmployees.IconColor = System.Drawing.Color.LightGray;
            this.btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployees.IconSize = 32;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 45);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmployees.Size = new System.Drawing.Size(179, 84);
            this.btnEmployees.TabIndex = 7;
            this.btnEmployees.Text = "    Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.BtnZaposleni_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iconPictureBoxMinimize);
            this.panel2.Controls.Add(this.iconPictureBoxMaximize);
            this.panel2.Controls.Add(this.iconExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 45);
            this.panel2.TabIndex = 1;
            // 
            // iconPictureBoxMinimize
            // 
            this.iconPictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxMinimize.BackColor = System.Drawing.SystemColors.Window;
            this.iconPictureBoxMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconPictureBoxMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBoxMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconPictureBoxMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxMinimize.IconSize = 25;
            this.iconPictureBoxMinimize.Location = new System.Drawing.Point(909, 12);
            this.iconPictureBoxMinimize.Name = "iconPictureBoxMinimize";
            this.iconPictureBoxMinimize.Size = new System.Drawing.Size(25, 27);
            this.iconPictureBoxMinimize.TabIndex = 5;
            this.iconPictureBoxMinimize.TabStop = false;
            this.iconPictureBoxMinimize.Click += new System.EventHandler(this.IconPictureBoxMinimize_Click);
            // 
            // iconPictureBoxMaximize
            // 
            this.iconPictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBoxMaximize.BackColor = System.Drawing.SystemColors.Window;
            this.iconPictureBoxMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconPictureBoxMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBoxMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconPictureBoxMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxMaximize.IconSize = 22;
            this.iconPictureBoxMaximize.Location = new System.Drawing.Point(940, 12);
            this.iconPictureBoxMaximize.Name = "iconPictureBoxMaximize";
            this.iconPictureBoxMaximize.Size = new System.Drawing.Size(22, 27);
            this.iconPictureBoxMaximize.TabIndex = 4;
            this.iconPictureBoxMaximize.TabStop = false;
            this.iconPictureBoxMaximize.Click += new System.EventHandler(this.IconPictureBoxMaximize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.SystemColors.Window;
            this.iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(968, 12);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(25, 27);
            this.iconExit.TabIndex = 3;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // panelDesktopAdmin
            // 
            this.panelDesktopAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopAdmin.Location = new System.Drawing.Point(179, 45);
            this.panelDesktopAdmin.Name = "panelDesktopAdmin";
            this.panelDesktopAdmin.Size = new System.Drawing.Size(1005, 636);
            this.panelDesktopAdmin.TabIndex = 2;
            this.panelDesktopAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktopAdmin_Paint);
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panelDesktopAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenuAdmin);
            this.Name = "FormMainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenuAdmin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktopAdmin;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnCiphers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMaximize;
        private FontAwesome.Sharp.IconPictureBox iconExit;
    }
}