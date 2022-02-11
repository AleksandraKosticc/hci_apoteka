namespace hci_apoteka.Forms
{
    partial class FormMedicine
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
            this.groupBoxMedicine = new System.Windows.Forms.GroupBox();
            this.iconButtonBrowseMedicine = new FontAwesome.Sharp.IconButton();
            this.pictureBoxMedicine = new System.Windows.Forms.PictureBox();
            this.textBoxNameMedicine = new System.Windows.Forms.TextBox();
            this.pnBarcode = new System.Windows.Forms.Panel();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.textBoxAvailableStrength = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbAvailableStrength = new System.Windows.Forms.Label();
            this.textBoxCellingPrice = new System.Windows.Forms.TextBox();
            this.pnDosage = new System.Windows.Forms.Panel();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.lbDosage = new System.Windows.Forms.Label();
            this.pnBuyingPrice = new System.Windows.Forms.Panel();
            this.textBoxBuyingPrice = new System.Windows.Forms.TextBox();
            this.lbBuyingPrice = new System.Windows.Forms.Label();
            this.lbCellingPrice = new System.Windows.Forms.Label();
            this.panelStock = new System.Windows.Forms.Panel();
            this.lbCompany = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.iconButtonDeleteMedicine = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddMedicine = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditMedicine = new FontAwesome.Sharp.IconButton();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.metroGridMedicine = new MetroFramework.Controls.MetroGrid();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.iconPictureBoxRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.columnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAvaibleStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBuying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).BeginInit();
            this.pnBarcode.SuspendLayout();
            this.pnDosage.SuspendLayout();
            this.pnBuyingPrice.SuspendLayout();
            this.panelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMedicine
            // 
            this.groupBoxMedicine.BackColor = System.Drawing.Color.White;
            this.groupBoxMedicine.Controls.Add(this.iconButtonBrowseMedicine);
            this.groupBoxMedicine.Controls.Add(this.pictureBoxMedicine);
            this.groupBoxMedicine.Controls.Add(this.textBoxNameMedicine);
            this.groupBoxMedicine.Controls.Add(this.pnBarcode);
            this.groupBoxMedicine.Controls.Add(this.textBoxAvailableStrength);
            this.groupBoxMedicine.Controls.Add(this.lbProductName);
            this.groupBoxMedicine.Controls.Add(this.lbAvailableStrength);
            this.groupBoxMedicine.Controls.Add(this.textBoxCellingPrice);
            this.groupBoxMedicine.Controls.Add(this.pnDosage);
            this.groupBoxMedicine.Controls.Add(this.pnBuyingPrice);
            this.groupBoxMedicine.Controls.Add(this.lbCellingPrice);
            this.groupBoxMedicine.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMedicine.Name = "groupBoxMedicine";
            this.groupBoxMedicine.Size = new System.Drawing.Size(364, 527);
            this.groupBoxMedicine.TabIndex = 26;
            this.groupBoxMedicine.TabStop = false;
            this.groupBoxMedicine.Text = "Medicine";
            // 
            // iconButtonBrowseMedicine
            // 
            this.iconButtonBrowseMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonBrowseMedicine.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonBrowseMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBrowseMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBrowseMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonBrowseMedicine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonBrowseMedicine.IconColor = System.Drawing.Color.White;
            this.iconButtonBrowseMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBrowseMedicine.IconSize = 15;
            this.iconButtonBrowseMedicine.Location = new System.Drawing.Point(144, 221);
            this.iconButtonBrowseMedicine.Name = "iconButtonBrowseMedicine";
            this.iconButtonBrowseMedicine.Size = new System.Drawing.Size(81, 24);
            this.iconButtonBrowseMedicine.TabIndex = 28;
            this.iconButtonBrowseMedicine.Text = "Browse";
            this.iconButtonBrowseMedicine.UseVisualStyleBackColor = false;
            this.iconButtonBrowseMedicine.Click += new System.EventHandler(this.IconButtonBrowseMedicine_Click);
            // 
            // pictureBoxMedicine
            // 
            this.pictureBoxMedicine.Location = new System.Drawing.Point(76, 28);
            this.pictureBoxMedicine.Name = "pictureBoxMedicine";
            this.pictureBoxMedicine.Size = new System.Drawing.Size(213, 187);
            this.pictureBoxMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMedicine.TabIndex = 40;
            this.pictureBoxMedicine.TabStop = false;
            // 
            // textBoxNameMedicine
            // 
            this.textBoxNameMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameMedicine.Location = new System.Drawing.Point(130, 301);
            this.textBoxNameMedicine.Multiline = true;
            this.textBoxNameMedicine.Name = "textBoxNameMedicine";
            this.textBoxNameMedicine.Size = new System.Drawing.Size(228, 20);
            this.textBoxNameMedicine.TabIndex = 2;
            // 
            // pnBarcode
            // 
            this.pnBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.pnBarcode.Controls.Add(this.textBoxBarcode);
            this.pnBarcode.Controls.Add(this.lbBarcode);
            this.pnBarcode.Location = new System.Drawing.Point(0, 251);
            this.pnBarcode.Name = "pnBarcode";
            this.pnBarcode.Size = new System.Drawing.Size(396, 41);
            this.pnBarcode.TabIndex = 38;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(130, 8);
            this.textBoxBarcode.Multiline = true;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(228, 26);
            this.textBoxBarcode.TabIndex = 1;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbBarcode.Location = new System.Drawing.Point(3, 12);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(68, 18);
            this.lbBarcode.TabIndex = 2;
            this.lbBarcode.Text = "Barcode:";
            // 
            // textBoxAvailableStrength
            // 
            this.textBoxAvailableStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvailableStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvailableStrength.Location = new System.Drawing.Point(130, 377);
            this.textBoxAvailableStrength.Multiline = true;
            this.textBoxAvailableStrength.Name = "textBoxAvailableStrength";
            this.textBoxAvailableStrength.Size = new System.Drawing.Size(227, 20);
            this.textBoxAvailableStrength.TabIndex = 4;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbProductName.Location = new System.Drawing.Point(3, 300);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(115, 18);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Name medicine:";
            // 
            // lbAvailableStrength
            // 
            this.lbAvailableStrength.AutoSize = true;
            this.lbAvailableStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableStrength.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbAvailableStrength.Location = new System.Drawing.Point(3, 378);
            this.lbAvailableStrength.Name = "lbAvailableStrength";
            this.lbAvailableStrength.Size = new System.Drawing.Size(126, 18);
            this.lbAvailableStrength.TabIndex = 2;
            this.lbAvailableStrength.Text = "Available strength:";
            // 
            // textBoxCellingPrice
            // 
            this.textBoxCellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCellingPrice.Location = new System.Drawing.Point(130, 454);
            this.textBoxCellingPrice.Multiline = true;
            this.textBoxCellingPrice.Name = "textBoxCellingPrice";
            this.textBoxCellingPrice.Size = new System.Drawing.Size(220, 20);
            this.textBoxCellingPrice.TabIndex = 6;
            // 
            // pnDosage
            // 
            this.pnDosage.BackColor = System.Drawing.SystemColors.Control;
            this.pnDosage.Controls.Add(this.textBoxDosage);
            this.pnDosage.Controls.Add(this.lbDosage);
            this.pnDosage.Location = new System.Drawing.Point(0, 329);
            this.pnDosage.Name = "pnDosage";
            this.pnDosage.Size = new System.Drawing.Size(396, 41);
            this.pnDosage.TabIndex = 29;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDosage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDosage.Location = new System.Drawing.Point(130, 12);
            this.textBoxDosage.Multiline = true;
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(228, 20);
            this.textBoxDosage.TabIndex = 3;
            // 
            // lbDosage
            // 
            this.lbDosage.AutoSize = true;
            this.lbDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDosage.Location = new System.Drawing.Point(3, 12);
            this.lbDosage.Name = "lbDosage";
            this.lbDosage.Size = new System.Drawing.Size(64, 18);
            this.lbDosage.TabIndex = 2;
            this.lbDosage.Text = "Dosage:";
            // 
            // pnBuyingPrice
            // 
            this.pnBuyingPrice.BackColor = System.Drawing.SystemColors.Control;
            this.pnBuyingPrice.Controls.Add(this.textBoxBuyingPrice);
            this.pnBuyingPrice.Controls.Add(this.lbBuyingPrice);
            this.pnBuyingPrice.Location = new System.Drawing.Point(0, 405);
            this.pnBuyingPrice.Name = "pnBuyingPrice";
            this.pnBuyingPrice.Size = new System.Drawing.Size(396, 41);
            this.pnBuyingPrice.TabIndex = 32;
            // 
            // textBoxBuyingPrice
            // 
            this.textBoxBuyingPrice.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxBuyingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuyingPrice.Location = new System.Drawing.Point(130, 8);
            this.textBoxBuyingPrice.Multiline = true;
            this.textBoxBuyingPrice.Name = "textBoxBuyingPrice";
            this.textBoxBuyingPrice.Size = new System.Drawing.Size(228, 26);
            this.textBoxBuyingPrice.TabIndex = 5;
            // 
            // lbBuyingPrice
            // 
            this.lbBuyingPrice.AutoSize = true;
            this.lbBuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuyingPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbBuyingPrice.Location = new System.Drawing.Point(3, 11);
            this.lbBuyingPrice.Name = "lbBuyingPrice";
            this.lbBuyingPrice.Size = new System.Drawing.Size(92, 18);
            this.lbBuyingPrice.TabIndex = 2;
            this.lbBuyingPrice.Text = "Buying price:";
            // 
            // lbCellingPrice
            // 
            this.lbCellingPrice.AutoSize = true;
            this.lbCellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCellingPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbCellingPrice.Location = new System.Drawing.Point(3, 456);
            this.lbCellingPrice.Name = "lbCellingPrice";
            this.lbCellingPrice.Size = new System.Drawing.Size(92, 18);
            this.lbCellingPrice.TabIndex = 2;
            this.lbCellingPrice.Text = "Celling price:";
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.SystemColors.Control;
            this.panelStock.Controls.Add(this.lbCompany);
            this.panelStock.Controls.Add(this.comboBoxCompany);
            this.panelStock.Location = new System.Drawing.Point(12, 496);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(364, 41);
            this.panelStock.TabIndex = 39;
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbCompany.Location = new System.Drawing.Point(6, 13);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(76, 18);
            this.lbCompany.TabIndex = 2;
            this.lbCompany.Text = "Company:";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(129, 8);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(228, 26);
            this.comboBoxCompany.TabIndex = 8;
            // 
            // iconButtonDeleteMedicine
            // 
            this.iconButtonDeleteMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonDeleteMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.iconButtonDeleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDeleteMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonDeleteMedicine.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDeleteMedicine.IconColor = System.Drawing.Color.White;
            this.iconButtonDeleteMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteMedicine.IconSize = 22;
            this.iconButtonDeleteMedicine.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDeleteMedicine.Location = new System.Drawing.Point(110, 543);
            this.iconButtonDeleteMedicine.Name = "iconButtonDeleteMedicine";
            this.iconButtonDeleteMedicine.Size = new System.Drawing.Size(37, 37);
            this.iconButtonDeleteMedicine.TabIndex = 10;
            this.iconButtonDeleteMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDeleteMedicine.UseVisualStyleBackColor = false;
            this.iconButtonDeleteMedicine.Click += new System.EventHandler(this.IconButtonDeleteMedicine_Click);
            // 
            // iconButtonAddMedicine
            // 
            this.iconButtonAddMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAddMedicine.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddMedicine.IconColor = System.Drawing.Color.White;
            this.iconButtonAddMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddMedicine.IconSize = 20;
            this.iconButtonAddMedicine.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAddMedicine.Location = new System.Drawing.Point(12, 543);
            this.iconButtonAddMedicine.Name = "iconButtonAddMedicine";
            this.iconButtonAddMedicine.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAddMedicine.TabIndex = 8;
            this.iconButtonAddMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddMedicine.UseVisualStyleBackColor = false;
            this.iconButtonAddMedicine.Click += new System.EventHandler(this.IconButtonAddMedicine_Click);
            // 
            // iconButtonEditMedicine
            // 
            this.iconButtonEditMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonEditMedicine.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonEditMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonEditMedicine.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEditMedicine.IconColor = System.Drawing.Color.White;
            this.iconButtonEditMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditMedicine.IconSize = 17;
            this.iconButtonEditMedicine.Location = new System.Drawing.Point(61, 543);
            this.iconButtonEditMedicine.Name = "iconButtonEditMedicine";
            this.iconButtonEditMedicine.Size = new System.Drawing.Size(37, 37);
            this.iconButtonEditMedicine.TabIndex = 9;
            this.iconButtonEditMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditMedicine.UseVisualStyleBackColor = false;
            this.iconButtonEditMedicine.Click += new System.EventHandler(this.IconButtonEditMedicine_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(411, 553);
            this.tbFilter.Multiline = true;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(526, 27);
            this.tbFilter.TabIndex = 11;
            this.tbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // metroGridMedicine
            // 
            this.metroGridMedicine.AllowUserToAddRows = false;
            this.metroGridMedicine.AllowUserToDeleteRows = false;
            this.metroGridMedicine.AllowUserToOrderColumns = true;
            this.metroGridMedicine.AllowUserToResizeRows = false;
            this.metroGridMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridMedicine.BackgroundColor = System.Drawing.Color.White;
            this.metroGridMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBarcode,
            this.columnName,
            this.columnStoke,
            this.columnDosage,
            this.columnAvaibleStrength,
            this.columnBuying,
            this.columnCelling,
            this.columnCompany});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMedicine.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridMedicine.EnableHeadersVisualStyles = false;
            this.metroGridMedicine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMedicine.Location = new System.Drawing.Point(382, 12);
            this.metroGridMedicine.Name = "metroGridMedicine";
            this.metroGridMedicine.ReadOnly = true;
            this.metroGridMedicine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridMedicine.RowHeadersWidth = 40;
            this.metroGridMedicine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMedicine.Size = new System.Drawing.Size(555, 527);
            this.metroGridMedicine.TabIndex = 41;
            this.metroGridMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGridMedicine_CellClick);
            this.metroGridMedicine.DoubleClick += new System.EventHandler(this.MetroGridMedicine_DoubleClick);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSearch.Image = global::hci_apoteka.Properties.Resources.search;
            this.pictureBoxSearch.Location = new System.Drawing.Point(6, 4);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(26, 21);
            this.pictureBoxSearch.TabIndex = 44;
            this.pictureBoxSearch.TabStop = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSearch.Controls.Add(this.pictureBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(382, 553);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(29, 27);
            this.panelSearch.TabIndex = 45;
            // 
            // iconPictureBoxRefresh
            // 
            this.iconPictureBoxRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBoxRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxRefresh.ForeColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBoxRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconPictureBoxRefresh.IconColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBoxRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxRefresh.IconSize = 40;
            this.iconPictureBoxRefresh.Location = new System.Drawing.Point(156, 543);
            this.iconPictureBoxRefresh.Name = "iconPictureBoxRefresh";
            this.iconPictureBoxRefresh.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBoxRefresh.TabIndex = 46;
            this.iconPictureBoxRefresh.TabStop = false;
            this.iconPictureBoxRefresh.Click += new System.EventHandler(this.IconPictureBoxRefresh_Click);
            // 
            // columnBarcode
            // 
            this.columnBarcode.FillWeight = 80F;
            this.columnBarcode.HeaderText = "Barcode";
            this.columnBarcode.Name = "columnBarcode";
            this.columnBarcode.ReadOnly = true;
            this.columnBarcode.Width = 81;
            // 
            // columnName
            // 
            this.columnName.FillWeight = 122.2188F;
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 68;
            // 
            // columnStoke
            // 
            this.columnStoke.FillWeight = 80F;
            this.columnStoke.HeaderText = "Stock";
            this.columnStoke.Name = "columnStoke";
            this.columnStoke.ReadOnly = true;
            this.columnStoke.Width = 65;
            // 
            // columnDosage
            // 
            this.columnDosage.FillWeight = 90F;
            this.columnDosage.HeaderText = "Dosage";
            this.columnDosage.Name = "columnDosage";
            this.columnDosage.ReadOnly = true;
            this.columnDosage.Width = 78;
            // 
            // columnAvaibleStrength
            // 
            this.columnAvaibleStrength.HeaderText = "Available strength";
            this.columnAvaibleStrength.Name = "columnAvaibleStrength";
            this.columnAvaibleStrength.ReadOnly = true;
            this.columnAvaibleStrength.Width = 130;
            // 
            // columnBuying
            // 
            this.columnBuying.FillWeight = 40F;
            this.columnBuying.HeaderText = "Buying price";
            this.columnBuying.Name = "columnBuying";
            this.columnBuying.ReadOnly = true;
            this.columnBuying.Width = 98;
            // 
            // columnCelling
            // 
            this.columnCelling.FillWeight = 40F;
            this.columnCelling.HeaderText = "Celling price";
            this.columnCelling.Name = "columnCelling";
            this.columnCelling.ReadOnly = true;
            this.columnCelling.Width = 97;
            // 
            // columnCompany
            // 
            this.columnCompany.FillWeight = 162.4365F;
            this.columnCompany.HeaderText = "Company";
            this.columnCompany.Name = "columnCompany";
            this.columnCompany.ReadOnly = true;
            this.columnCompany.Width = 91;
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 592);
            this.Controls.Add(this.iconPictureBoxRefresh);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.metroGridMedicine);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.iconButtonDeleteMedicine);
            this.Controls.Add(this.iconButtonAddMedicine);
            this.Controls.Add(this.iconButtonEditMedicine);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.groupBoxMedicine);
            this.Name = "FormMedicine";
            this.Text = "FormMedicine";
            this.groupBoxMedicine.ResumeLayout(false);
            this.groupBoxMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).EndInit();
            this.pnBarcode.ResumeLayout(false);
            this.pnBarcode.PerformLayout();
            this.pnDosage.ResumeLayout(false);
            this.pnDosage.PerformLayout();
            this.pnBuyingPrice.ResumeLayout(false);
            this.pnBuyingPrice.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMedicine;
        private FontAwesome.Sharp.IconButton iconButtonBrowseMedicine;
        private System.Windows.Forms.PictureBox pictureBoxMedicine;
        private System.Windows.Forms.TextBox textBoxNameMedicine;
        private System.Windows.Forms.Panel pnBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.TextBox textBoxAvailableStrength;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Label lbAvailableStrength;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.TextBox textBoxCellingPrice;
        private System.Windows.Forms.Panel pnBuyingPrice;
        private System.Windows.Forms.TextBox textBoxBuyingPrice;
        private System.Windows.Forms.Label lbBuyingPrice;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbCellingPrice;
        private System.Windows.Forms.Panel pnDosage;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.Label lbDosage;
        private FontAwesome.Sharp.IconButton iconButtonDeleteMedicine;
        private FontAwesome.Sharp.IconButton iconButtonAddMedicine;
        private FontAwesome.Sharp.IconButton iconButtonEditMedicine;
        private System.Windows.Forms.TextBox tbFilter;
        private MetroFramework.Controls.MetroGrid metroGridMedicine;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAvaibleStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBuying;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCompany;
    }
}