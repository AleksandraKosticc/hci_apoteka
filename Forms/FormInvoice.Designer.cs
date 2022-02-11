namespace hci_apoteka.Forms
{
    partial class FormInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButtonSaveInvoice = new FontAwesome.Sharp.IconButton();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.gbNewInvoice = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBarcodeInvoice = new System.Windows.Forms.TextBox();
            this.metroGridItemInvoice = new MetroFramework.Controls.MetroGrid();
            this.columnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbBuyingPrice = new System.Windows.Forms.Label();
            this.textBoxPriceInvoice = new System.Windows.Forms.TextBox();
            this.metroGridInvoice = new MetroFramework.Controls.MetroGrid();
            this.iconButtonDeleteInvoice = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddInvoice = new FontAwesome.Sharp.IconButton();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.columnNoInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.gbNewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridItemInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonSaveInvoice
            // 
            this.iconButtonSaveInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSaveInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonSaveInvoice.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSaveInvoice.IconColor = System.Drawing.Color.White;
            this.iconButtonSaveInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveInvoice.IconSize = 22;
            this.iconButtonSaveInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonSaveInvoice.Location = new System.Drawing.Point(763, 236);
            this.iconButtonSaveInvoice.Name = "iconButtonSaveInvoice";
            this.iconButtonSaveInvoice.Size = new System.Drawing.Size(37, 37);
            this.iconButtonSaveInvoice.TabIndex = 3;
            this.iconButtonSaveInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSaveInvoice.UseVisualStyleBackColor = false;
            this.iconButtonSaveInvoice.Click += new System.EventHandler(this.IconButtonSaveInvoice_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Items.AddRange(new object[] {
            "--------"});
            this.comboBoxCompany.Location = new System.Drawing.Point(6, 39);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(121, 26);
            this.comboBoxCompany.TabIndex = 5;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(394, 44);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(54, 24);
            this.numericUpDownQuantity.TabIndex = 8;
            // 
            // gbNewInvoice
            // 
            this.gbNewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewInvoice.BackColor = System.Drawing.Color.White;
            this.gbNewInvoice.Controls.Add(this.label1);
            this.gbNewInvoice.Controls.Add(this.textBoxBarcodeInvoice);
            this.gbNewInvoice.Controls.Add(this.metroGridItemInvoice);
            this.gbNewInvoice.Controls.Add(this.lbBuyingPrice);
            this.gbNewInvoice.Controls.Add(this.textBoxPriceInvoice);
            this.gbNewInvoice.Controls.Add(this.metroGridInvoice);
            this.gbNewInvoice.Controls.Add(this.iconButtonDeleteInvoice);
            this.gbNewInvoice.Controls.Add(this.iconButtonAddInvoice);
            this.gbNewInvoice.Controls.Add(this.lbQuantity);
            this.gbNewInvoice.Controls.Add(this.iconButtonSaveInvoice);
            this.gbNewInvoice.Controls.Add(this.lbBarcode);
            this.gbNewInvoice.Controls.Add(this.lbCompany);
            this.gbNewInvoice.Controls.Add(this.comboBoxCompany);
            this.gbNewInvoice.Controls.Add(this.numericUpDownQuantity);
            this.gbNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewInvoice.Location = new System.Drawing.Point(12, 12);
            this.gbNewInvoice.Name = "gbNewInvoice";
            this.gbNewInvoice.Size = new System.Drawing.Size(806, 459);
            this.gbNewInvoice.TabIndex = 9;
            this.gbNewInvoice.TabStop = false;
            this.gbNewInvoice.Text = "New invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "l";
            this.label1.Visible = false;
            // 
            // textBoxBarcodeInvoice
            // 
            this.textBoxBarcodeInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBarcodeInvoice.Location = new System.Drawing.Point(149, 41);
            this.textBoxBarcodeInvoice.Name = "textBoxBarcodeInvoice";
            this.textBoxBarcodeInvoice.Size = new System.Drawing.Size(100, 24);
            this.textBoxBarcodeInvoice.TabIndex = 46;
            this.textBoxBarcodeInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBarcodeInvoice_KeyPress);
            // 
            // metroGridItemInvoice
            // 
            this.metroGridItemInvoice.AllowUserToAddRows = false;
            this.metroGridItemInvoice.AllowUserToResizeRows = false;
            this.metroGridItemInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridItemInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridItemInvoice.BackgroundColor = System.Drawing.Color.White;
            this.metroGridItemInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridItemInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridItemInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridItemInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridItemInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridItemInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBarcode,
            this.columnName,
            this.columnPrice,
            this.columnQty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridItemInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridItemInvoice.EnableHeadersVisualStyles = false;
            this.metroGridItemInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridItemInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridItemInvoice.Location = new System.Drawing.Point(6, 74);
            this.metroGridItemInvoice.Name = "metroGridItemInvoice";
            this.metroGridItemInvoice.ReadOnly = true;
            this.metroGridItemInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridItemInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridItemInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridItemInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridItemInvoice.Size = new System.Drawing.Size(794, 156);
            this.metroGridItemInvoice.TabIndex = 45;
            // 
            // columnBarcode
            // 
            this.columnBarcode.HeaderText = "Barcode";
            this.columnBarcode.Name = "columnBarcode";
            this.columnBarcode.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnQty
            // 
            this.columnQty.HeaderText = "Quantity";
            this.columnQty.Name = "columnQty";
            this.columnQty.ReadOnly = true;
            // 
            // lbBuyingPrice
            // 
            this.lbBuyingPrice.AutoSize = true;
            this.lbBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBuyingPrice.Location = new System.Drawing.Point(270, 21);
            this.lbBuyingPrice.Name = "lbBuyingPrice";
            this.lbBuyingPrice.Size = new System.Drawing.Size(90, 17);
            this.lbBuyingPrice.TabIndex = 44;
            this.lbBuyingPrice.Text = "Buying price:";
            // 
            // textBoxPriceInvoice
            // 
            this.textBoxPriceInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxPriceInvoice.Location = new System.Drawing.Point(273, 41);
            this.textBoxPriceInvoice.Multiline = true;
            this.textBoxPriceInvoice.Name = "textBoxPriceInvoice";
            this.textBoxPriceInvoice.Size = new System.Drawing.Size(100, 24);
            this.textBoxPriceInvoice.TabIndex = 43;
            // 
            // metroGridInvoice
            // 
            this.metroGridInvoice.AllowUserToAddRows = false;
            this.metroGridInvoice.AllowUserToResizeRows = false;
            this.metroGridInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridInvoice.BackgroundColor = System.Drawing.Color.White;
            this.metroGridInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNoInvoice,
            this.columnDate,
            this.columnTotalPrice,
            this.columnCompany,
            this.columnEmployee});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridInvoice.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridInvoice.EnableHeadersVisualStyles = false;
            this.metroGridInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridInvoice.Location = new System.Drawing.Point(6, 279);
            this.metroGridInvoice.Name = "metroGridInvoice";
            this.metroGridInvoice.ReadOnly = true;
            this.metroGridInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridInvoice.Size = new System.Drawing.Size(794, 180);
            this.metroGridInvoice.TabIndex = 40;
            // 
            // iconButtonDeleteInvoice
            // 
            this.iconButtonDeleteInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDeleteInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.iconButtonDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDeleteInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonDeleteInvoice.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDeleteInvoice.IconColor = System.Drawing.Color.White;
            this.iconButtonDeleteInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteInvoice.IconSize = 22;
            this.iconButtonDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDeleteInvoice.Location = new System.Drawing.Point(763, 31);
            this.iconButtonDeleteInvoice.Name = "iconButtonDeleteInvoice";
            this.iconButtonDeleteInvoice.Size = new System.Drawing.Size(37, 37);
            this.iconButtonDeleteInvoice.TabIndex = 34;
            this.iconButtonDeleteInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDeleteInvoice.UseVisualStyleBackColor = false;
            this.iconButtonDeleteInvoice.Click += new System.EventHandler(this.IconButtonDeleteInvoice_Click);
            // 
            // iconButtonAddInvoice
            // 
            this.iconButtonAddInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAddInvoice.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddInvoice.IconColor = System.Drawing.Color.White;
            this.iconButtonAddInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddInvoice.IconSize = 20;
            this.iconButtonAddInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAddInvoice.Location = new System.Drawing.Point(720, 31);
            this.iconButtonAddInvoice.Name = "iconButtonAddInvoice";
            this.iconButtonAddInvoice.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAddInvoice.TabIndex = 33;
            this.iconButtonAddInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddInvoice.UseVisualStyleBackColor = false;
            this.iconButtonAddInvoice.Click += new System.EventHandler(this.IconButtonAddInvoice_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbQuantity.Location = new System.Drawing.Point(391, 21);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 17);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBarcode.Location = new System.Drawing.Point(146, 21);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(65, 17);
            this.lbBarcode.TabIndex = 11;
            this.lbBarcode.Text = "Barcode:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCompany.Location = new System.Drawing.Point(6, 21);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(71, 17);
            this.lbCompany.TabIndex = 9;
            this.lbCompany.Text = "Company:";
            // 
            // columnNoInvoice
            // 
            this.columnNoInvoice.HeaderText = "No invoice";
            this.columnNoInvoice.Name = "columnNoInvoice";
            this.columnNoInvoice.ReadOnly = true;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnTotalPrice
            // 
            this.columnTotalPrice.HeaderText = "Total price";
            this.columnTotalPrice.Name = "columnTotalPrice";
            this.columnTotalPrice.ReadOnly = true;
            // 
            // columnCompany
            // 
            this.columnCompany.HeaderText = "Company";
            this.columnCompany.Name = "columnCompany";
            this.columnCompany.ReadOnly = true;
            // 
            // columnEmployee
            // 
            this.columnEmployee.HeaderText = "Employees";
            this.columnEmployee.Name = "columnEmployee";
            this.columnEmployee.ReadOnly = true;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 483);
            this.Controls.Add(this.gbNewInvoice);
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.gbNewInvoice.ResumeLayout(false);
            this.gbNewInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridItemInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonSaveInvoice;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.GroupBox gbNewInvoice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.Label lbCompany;
        private FontAwesome.Sharp.IconButton iconButtonDeleteInvoice;
        private FontAwesome.Sharp.IconButton iconButtonAddInvoice;
        private MetroFramework.Controls.MetroGrid metroGridInvoice;
        private System.Windows.Forms.TextBox textBoxPriceInvoice;
        private MetroFramework.Controls.MetroGrid metroGridItemInvoice;
        private System.Windows.Forms.Label lbBuyingPrice;
        private System.Windows.Forms.TextBox textBoxBarcodeInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNoInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmployee;
    }
}