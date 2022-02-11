namespace hci_apoteka.Forms
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnSerbian = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEnglish.FlatAppearance.BorderSize = 0;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnglish.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.ForeColor = System.Drawing.Color.Navy;
            this.btnEnglish.Location = new System.Drawing.Point(709, 433);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(104, 34);
            this.btnEnglish.TabIndex = 1;
            this.btnEnglish.Text = "ENGLISH";
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnSerbian
            // 
            this.btnSerbian.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSerbian.FlatAppearance.BorderSize = 0;
            this.btnSerbian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerbian.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerbian.ForeColor = System.Drawing.Color.Navy;
            this.btnSerbian.Location = new System.Drawing.Point(599, 433);
            this.btnSerbian.Name = "btnSerbian";
            this.btnSerbian.Size = new System.Drawing.Size(104, 34);
            this.btnSerbian.TabIndex = 2;
            this.btnSerbian.Text = "SRPSKI";
            this.btnSerbian.UseVisualStyleBackColor = false;
            this.btnSerbian.Click += new System.EventHandler(this.btnSerbian_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::hci_apoteka.Properties.Resources.srce;
            this.pictureBox1.Location = new System.Drawing.Point(97, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.BackColor = System.Drawing.Color.Transparent;
            this.labelNaziv.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelNaziv.Location = new System.Drawing.Point(417, 254);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(247, 56);
            this.labelNaziv.TabIndex = 4;
            this.labelNaziv.Text = "APOTEKA";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(928, 548);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSerbian);
            this.Controls.Add(this.btnEnglish);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteka";
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnSerbian;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNaziv;
    }
}