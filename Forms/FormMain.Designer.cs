namespace hci_apoteka
{
    partial class FormMain
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
            this.panelBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.iconPictureBoxMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInvoice = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.btnMedicine = new FontAwesome.Sharp.IconButton();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBar.Controls.Add(this.pictureBox1);
            this.panelBar.Controls.Add(this.lbUser);
            this.panelBar.Controls.Add(this.iconPictureBoxMinimize);
            this.panelBar.Controls.Add(this.iconPictureBoxMaximize);
            this.panelBar.Controls.Add(this.iconExit);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(179, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1005, 45);
            this.panelBar.TabIndex = 1;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hci_apoteka.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(49, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(45, 16);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "label1";
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
            this.iconPictureBoxMinimize.TabIndex = 2;
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
            this.iconPictureBoxMaximize.TabIndex = 1;
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
            this.iconExit.TabIndex = 0;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightGray;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(179, 45);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1005, 606);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnInvoice);
            this.panelMenu.Controls.Add(this.btnSales);
            this.panelMenu.Controls.Add(this.btnMedicine);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 651);
            this.panelMenu.TabIndex = 0;
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInvoice.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnInvoice.IconColor = System.Drawing.Color.LightGray;
            this.btnInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoice.IconSize = 32;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(0, 258);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInvoice.Size = new System.Drawing.Size(179, 84);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "    Invoice";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.BtnFakture_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnSales.IconColor = System.Drawing.Color.LightGray;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 32;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 168);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSales.Size = new System.Drawing.Size(179, 84);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "    Sales";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMedicine.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.btnMedicine.IconColor = System.Drawing.Color.LightGray;
            this.btnMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicine.IconSize = 32;
            this.btnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.Location = new System.Drawing.Point(0, 78);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMedicine.Size = new System.Drawing.Size(179, 84);
            this.btnMedicine.TabIndex = 0;
            this.btnMedicine.Text = "    Medicine";
            this.btnMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.BtnProizvodi_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 651);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteka";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMinimize;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxMaximize;
        private FontAwesome.Sharp.IconButton btnMedicine;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnInvoice;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

