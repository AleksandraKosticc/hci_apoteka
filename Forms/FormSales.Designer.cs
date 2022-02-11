namespace hci_apoteka.Forms
{
    partial class FormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.numericUpDowQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbCashRegistar = new System.Windows.Forms.Label();
            this.panelKasaTab = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNewBill = new FontAwesome.Sharp.IconButton();
            this.dataGridViewSales = new MetroFramework.Controls.MetroGrid();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.buttonCreateBill = new FontAwesome.Sharp.IconButton();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.columnBillBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBillPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBillQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowQuantity)).BeginInit();
            this.panelKasaTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.Location = new System.Drawing.Point(732, 349);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(123, 20);
            this.lbTotalPrice.TabIndex = 3;
            this.lbTotalPrice.Text = "TOTAL PRICE";
            // 
            // lbProduct
            // 
            this.lbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbProduct.Location = new System.Drawing.Point(116, 351);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(56, 18);
            this.lbProduct.TabIndex = 4;
            this.lbProduct.Text = "Name: ";
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbQuantity.Location = new System.Drawing.Point(393, 351);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(66, 18);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity:";
            // 
            // numericUpDowQuantity
            // 
            this.numericUpDowQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDowQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDowQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDowQuantity.Location = new System.Drawing.Point(396, 378);
            this.numericUpDowQuantity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDowQuantity.Name = "numericUpDowQuantity";
            this.numericUpDowQuantity.Size = new System.Drawing.Size(50, 24);
            this.numericUpDowQuantity.TabIndex = 7;
            // 
            // lbCashRegistar
            // 
            this.lbCashRegistar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCashRegistar.AutoSize = true;
            this.lbCashRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCashRegistar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCashRegistar.Location = new System.Drawing.Point(340, 16);
            this.lbCashRegistar.Name = "lbCashRegistar";
            this.lbCashRegistar.Size = new System.Drawing.Size(174, 24);
            this.lbCashRegistar.TabIndex = 0;
            this.lbCashRegistar.Text = "CASH REGISTAR";
            this.lbCashRegistar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKasaTab
            // 
            this.panelKasaTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKasaTab.BackColor = System.Drawing.Color.SteelBlue;
            this.panelKasaTab.Controls.Add(this.lbCashRegistar);
            this.panelKasaTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelKasaTab.Location = new System.Drawing.Point(13, 0);
            this.panelKasaTab.Name = "panelKasaTab";
            this.panelKasaTab.Size = new System.Drawing.Size(842, 53);
            this.panelKasaTab.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonNewBill);
            this.groupBox1.Controls.Add(this.dataGridViewSales);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.lbBarcode);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxBarcode);
            this.groupBox1.Controls.Add(this.panelKasaTab);
            this.groupBox1.Controls.Add(this.buttonCreateBill);
            this.groupBox1.Controls.Add(this.textBoxTotalPrice);
            this.groupBox1.Controls.Add(this.lbTotalPrice);
            this.groupBox1.Controls.Add(this.iconButtonDelete);
            this.groupBox1.Controls.Add(this.lbProduct);
            this.groupBox1.Controls.Add(this.iconButtonAdd);
            this.groupBox1.Controls.Add(this.numericUpDowQuantity);
            this.groupBox1.Controls.Add(this.lbQuantity);
            this.groupBox1.Location = new System.Drawing.Point(-4, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 549);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // buttonNewBill
            // 
            this.buttonNewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNewBill.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewBill.ForeColor = System.Drawing.Color.White;
            this.buttonNewBill.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.buttonNewBill.IconColor = System.Drawing.Color.White;
            this.buttonNewBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonNewBill.IconSize = 40;
            this.buttonNewBill.Location = new System.Drawing.Point(12, 486);
            this.buttonNewBill.Name = "buttonNewBill";
            this.buttonNewBill.Size = new System.Drawing.Size(69, 37);
            this.buttonNewBill.TabIndex = 49;
            this.buttonNewBill.UseVisualStyleBackColor = false;
            this.buttonNewBill.Click += new System.EventHandler(this.ButtonNewBill_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToResizeRows = false;
            this.dataGridViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBillBarcode,
            this.columnBillName,
            this.columnBillPrice,
            this.columnBillQty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSales.EnableHeadersVisualStyles = false;
            this.dataGridViewSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewSales.Location = new System.Drawing.Point(13, 48);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(842, 287);
            this.dataGridViewSales.TabIndex = 48;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbPrice.Location = new System.Drawing.Point(273, 351);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(92, 18);
            this.lbPrice.TabIndex = 47;
            this.lbPrice.Text = "Celling price:";
            // 
            // lbBarcode
            // 
            this.lbBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbBarcode.Location = new System.Drawing.Point(13, 351);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 18);
            this.lbBarcode.TabIndex = 46;
            this.lbBarcode.Text = "Barcode:";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUser.Location = new System.Drawing.Point(6, 533);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(9, 13);
            this.labelUser.TabIndex = 44;
            this.labelUser.Text = "l";
            this.labelUser.Visible = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(276, 378);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(103, 24);
            this.textBoxPrice.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxName.Location = new System.Drawing.Point(119, 378);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 24);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxBarcode.Location = new System.Drawing.Point(13, 378);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(100, 24);
            this.textBoxBarcode.TabIndex = 12;
            this.textBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBarcode_KeyPress);
            // 
            // buttonCreateBill
            // 
            this.buttonCreateBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.buttonCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCreateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonCreateBill.IconColor = System.Drawing.Color.White;
            this.buttonCreateBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCreateBill.IconSize = 16;
            this.buttonCreateBill.Location = new System.Drawing.Point(727, 404);
            this.buttonCreateBill.Name = "buttonCreateBill";
            this.buttonCreateBill.Size = new System.Drawing.Size(130, 130);
            this.buttonCreateBill.TabIndex = 10;
            this.buttonCreateBill.Text = "Create bill";
            this.buttonCreateBill.UseVisualStyleBackColor = false;
            this.buttonCreateBill.Click += new System.EventHandler(this.IconButtonCreateBill_Click);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTotalPrice.Location = new System.Drawing.Point(727, 372);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(130, 26);
            this.textBoxTotalPrice.TabIndex = 2;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDelete.IconColor = System.Drawing.Color.White;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 22;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDelete.Location = new System.Drawing.Point(130, 486);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(37, 37);
            this.iconButtonDelete.TabIndex = 9;
            this.iconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.IconButtonDelete_Click);
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconButtonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.White;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.IconSize = 20;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAdd.Location = new System.Drawing.Point(87, 486);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAdd.TabIndex = 8;
            this.iconButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdd.UseVisualStyleBackColor = false;
            this.iconButtonAdd.Click += new System.EventHandler(this.IconButtonAdd_Click);
            // 
            // columnBillBarcode
            // 
            this.columnBillBarcode.HeaderText = "Barcode";
            this.columnBillBarcode.Name = "columnBillBarcode";
            this.columnBillBarcode.ReadOnly = true;
            // 
            // columnBillName
            // 
            this.columnBillName.HeaderText = "Name medicine";
            this.columnBillName.Name = "columnBillName";
            this.columnBillName.ReadOnly = true;
            // 
            // columnBillPrice
            // 
            this.columnBillPrice.HeaderText = "Celling price";
            this.columnBillPrice.Name = "columnBillPrice";
            this.columnBillPrice.ReadOnly = true;
            // 
            // columnBillQty
            // 
            this.columnBillQty.HeaderText = "Quantity";
            this.columnBillQty.Name = "columnBillQty";
            this.columnBillQty.ReadOnly = true;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 541);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSales";
            this.Text = "FormKasa";
            this.Load += new System.EventHandler(this.FormKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowQuantity)).EndInit();
            this.panelKasaTab.ResumeLayout(false);
            this.panelKasaTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDowQuantity;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton buttonCreateBill;
        private System.Windows.Forms.Label lbCashRegistar;
        private System.Windows.Forms.Panel panelKasaTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbBarcode;
        private MetroFramework.Controls.MetroGrid dataGridViewSales;
        private FontAwesome.Sharp.IconButton buttonNewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBillBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBillPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBillQty;
    }
}