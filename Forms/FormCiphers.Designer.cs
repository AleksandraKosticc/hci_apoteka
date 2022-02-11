namespace hci_apoteka.Forms
{
    partial class FormCiphers
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
            this.tabControlChipers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.metroGridCompany = new MetroFramework.Controls.MetroGrid();
            this.columnNameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStateCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonEditCompany = new FontAwesome.Sharp.IconButton();
            this.lbPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxNameCompany = new System.Windows.Forms.TextBox();
            this.iconButtonDeleteCompany = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddCompany = new FontAwesome.Sharp.IconButton();
            this.lbState = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroGridUserType = new MetroFramework.Controls.MetroGrid();
            this.columnNoUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNameUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonEditUserTypes = new FontAwesome.Sharp.IconButton();
            this.textBoxUserTypes = new System.Windows.Forms.TextBox();
            this.iconButtonAddUserTypes = new FontAwesome.Sharp.IconButton();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbNameUserTypes = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.tabControlChipers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompany)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUserType)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlChipers
            // 
            this.tabControlChipers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlChipers.Controls.Add(this.tabPage1);
            this.tabControlChipers.Controls.Add(this.tabPage2);
            this.tabControlChipers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlChipers.Location = new System.Drawing.Point(3, 0);
            this.tabControlChipers.Name = "tabControlChipers";
            this.tabControlChipers.SelectedIndex = 0;
            this.tabControlChipers.Size = new System.Drawing.Size(805, 450);
            this.tabControlChipers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gbCompany);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Companies";
            // 
            // gbCompany
            // 
            this.gbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCompany.BackColor = System.Drawing.Color.White;
            this.gbCompany.Controls.Add(this.metroGridCompany);
            this.gbCompany.Controls.Add(this.iconButtonEditCompany);
            this.gbCompany.Controls.Add(this.lbPhone);
            this.gbCompany.Controls.Add(this.textBoxPhone);
            this.gbCompany.Controls.Add(this.textBoxNameCompany);
            this.gbCompany.Controls.Add(this.iconButtonDeleteCompany);
            this.gbCompany.Controls.Add(this.iconButtonAddCompany);
            this.gbCompany.Controls.Add(this.lbState);
            this.gbCompany.Controls.Add(this.lbCompanyName);
            this.gbCompany.Controls.Add(this.textBoxState);
            this.gbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompany.Location = new System.Drawing.Point(3, 0);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(797, 441);
            this.gbCompany.TabIndex = 0;
            this.gbCompany.TabStop = false;
            // 
            // metroGridCompany
            // 
            this.metroGridCompany.AllowUserToAddRows = false;
            this.metroGridCompany.AllowUserToDeleteRows = false;
            this.metroGridCompany.AllowUserToResizeRows = false;
            this.metroGridCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridCompany.BackgroundColor = System.Drawing.Color.White;
            this.metroGridCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCompany.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNameCompany,
            this.columnStateCompany,
            this.columnPhone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridCompany.EnableHeadersVisualStyles = false;
            this.metroGridCompany.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCompany.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCompany.Location = new System.Drawing.Point(27, 119);
            this.metroGridCompany.Name = "metroGridCompany";
            this.metroGridCompany.ReadOnly = true;
            this.metroGridCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridCompany.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCompany.Size = new System.Drawing.Size(742, 294);
            this.metroGridCompany.TabIndex = 7;
            this.metroGridCompany.DoubleClick += new System.EventHandler(this.MetroGridCompany_DoubleClick);
            // 
            // columnNameCompany
            // 
            this.columnNameCompany.HeaderText = "Name";
            this.columnNameCompany.Name = "columnNameCompany";
            this.columnNameCompany.ReadOnly = true;
            // 
            // columnStateCompany
            // 
            this.columnStateCompany.HeaderText = "State";
            this.columnStateCompany.Name = "columnStateCompany";
            this.columnStateCompany.ReadOnly = true;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            // 
            // iconButtonEditCompany
            // 
            this.iconButtonEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEditCompany.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonEditCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonEditCompany.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEditCompany.IconColor = System.Drawing.Color.White;
            this.iconButtonEditCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditCompany.IconSize = 17;
            this.iconButtonEditCompany.Location = new System.Drawing.Point(689, 46);
            this.iconButtonEditCompany.Name = "iconButtonEditCompany";
            this.iconButtonEditCompany.Size = new System.Drawing.Size(37, 37);
            this.iconButtonEditCompany.TabIndex = 5;
            this.iconButtonEditCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditCompany.UseVisualStyleBackColor = false;
            this.iconButtonEditCompany.Click += new System.EventHandler(this.IconButtonEditCompany_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPhone.Location = new System.Drawing.Point(415, 26);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 17);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(418, 46);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(194, 54);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxNameCompany
            // 
            this.textBoxNameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameCompany.Location = new System.Drawing.Point(27, 46);
            this.textBoxNameCompany.Multiline = true;
            this.textBoxNameCompany.Name = "textBoxNameCompany";
            this.textBoxNameCompany.Size = new System.Drawing.Size(185, 54);
            this.textBoxNameCompany.TabIndex = 1;
            // 
            // iconButtonDeleteCompany
            // 
            this.iconButtonDeleteCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDeleteCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.iconButtonDeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDeleteCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonDeleteCompany.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonDeleteCompany.IconColor = System.Drawing.Color.White;
            this.iconButtonDeleteCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteCompany.IconSize = 22;
            this.iconButtonDeleteCompany.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDeleteCompany.Location = new System.Drawing.Point(732, 46);
            this.iconButtonDeleteCompany.Name = "iconButtonDeleteCompany";
            this.iconButtonDeleteCompany.Size = new System.Drawing.Size(37, 37);
            this.iconButtonDeleteCompany.TabIndex = 6;
            this.iconButtonDeleteCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDeleteCompany.UseVisualStyleBackColor = false;
            this.iconButtonDeleteCompany.Click += new System.EventHandler(this.IconButtonDeleteCompany_Click);
            // 
            // iconButtonAddCompany
            // 
            this.iconButtonAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAddCompany.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddCompany.IconColor = System.Drawing.Color.White;
            this.iconButtonAddCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddCompany.IconSize = 20;
            this.iconButtonAddCompany.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAddCompany.Location = new System.Drawing.Point(646, 46);
            this.iconButtonAddCompany.Name = "iconButtonAddCompany";
            this.iconButtonAddCompany.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAddCompany.TabIndex = 4;
            this.iconButtonAddCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddCompany.UseVisualStyleBackColor = false;
            this.iconButtonAddCompany.Click += new System.EventHandler(this.IconButtonAddCompany_Click);
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbState.Location = new System.Drawing.Point(215, 26);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(45, 17);
            this.lbState.TabIndex = 9;
            this.lbState.Text = "State:";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCompanyName.Location = new System.Drawing.Point(24, 26);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(49, 17);
            this.lbCompanyName.TabIndex = 8;
            this.lbCompanyName.Text = "Name:";
            // 
            // textBoxState
            // 
            this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(218, 46);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(194, 54);
            this.textBoxState.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User types";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroGridUserType);
            this.groupBox1.Controls.Add(this.iconButtonEditUserTypes);
            this.groupBox1.Controls.Add(this.textBoxUserTypes);
            this.groupBox1.Controls.Add(this.iconButtonAddUserTypes);
            this.groupBox1.Controls.Add(this.lbDescription);
            this.groupBox1.Controls.Add(this.lbNameUserTypes);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 431);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // metroGridUserType
            // 
            this.metroGridUserType.AllowUserToAddRows = false;
            this.metroGridUserType.AllowUserToDeleteRows = false;
            this.metroGridUserType.AllowUserToOrderColumns = true;
            this.metroGridUserType.AllowUserToResizeRows = false;
            this.metroGridUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridUserType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridUserType.BackgroundColor = System.Drawing.Color.White;
            this.metroGridUserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridUserType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridUserType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUserType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridUserType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridUserType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNoUsers,
            this.columnNameUserType,
            this.columnDescription});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridUserType.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridUserType.EnableHeadersVisualStyles = false;
            this.metroGridUserType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridUserType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridUserType.Location = new System.Drawing.Point(27, 119);
            this.metroGridUserType.Name = "metroGridUserType";
            this.metroGridUserType.ReadOnly = true;
            this.metroGridUserType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUserType.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridUserType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridUserType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridUserType.Size = new System.Drawing.Size(742, 294);
            this.metroGridUserType.TabIndex = 39;
            this.metroGridUserType.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MetroGridUserType_CellMouseDoubleClick);
            // 
            // columnNoUsers
            // 
            this.columnNoUsers.FillWeight = 30F;
            this.columnNoUsers.HeaderText = "No";
            this.columnNoUsers.Name = "columnNoUsers";
            this.columnNoUsers.ReadOnly = true;
            // 
            // columnNameUserType
            // 
            this.columnNameUserType.HeaderText = "Name";
            this.columnNameUserType.Name = "columnNameUserType";
            this.columnNameUserType.ReadOnly = true;
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.ReadOnly = true;
            // 
            // iconButtonEditUserTypes
            // 
            this.iconButtonEditUserTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonEditUserTypes.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonEditUserTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditUserTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditUserTypes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonEditUserTypes.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEditUserTypes.IconColor = System.Drawing.Color.White;
            this.iconButtonEditUserTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditUserTypes.IconSize = 17;
            this.iconButtonEditUserTypes.Location = new System.Drawing.Point(732, 46);
            this.iconButtonEditUserTypes.Name = "iconButtonEditUserTypes";
            this.iconButtonEditUserTypes.Size = new System.Drawing.Size(37, 37);
            this.iconButtonEditUserTypes.TabIndex = 38;
            this.iconButtonEditUserTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditUserTypes.UseVisualStyleBackColor = false;
            this.iconButtonEditUserTypes.Click += new System.EventHandler(this.IconButtonEditUserTypes_Click);
            // 
            // textBoxUserTypes
            // 
            this.textBoxUserTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserTypes.Location = new System.Drawing.Point(27, 46);
            this.textBoxUserTypes.Multiline = true;
            this.textBoxUserTypes.Name = "textBoxUserTypes";
            this.textBoxUserTypes.Size = new System.Drawing.Size(202, 27);
            this.textBoxUserTypes.TabIndex = 35;
            // 
            // iconButtonAddUserTypes
            // 
            this.iconButtonAddUserTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonAddUserTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAddUserTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddUserTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddUserTypes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAddUserTypes.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddUserTypes.IconColor = System.Drawing.Color.White;
            this.iconButtonAddUserTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddUserTypes.IconSize = 20;
            this.iconButtonAddUserTypes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAddUserTypes.Location = new System.Drawing.Point(689, 46);
            this.iconButtonAddUserTypes.Name = "iconButtonAddUserTypes";
            this.iconButtonAddUserTypes.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAddUserTypes.TabIndex = 33;
            this.iconButtonAddUserTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddUserTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddUserTypes.UseVisualStyleBackColor = false;
            this.iconButtonAddUserTypes.Click += new System.EventHandler(this.IconButtonAddUserTypes_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescription.Location = new System.Drawing.Point(232, 26);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(83, 17);
            this.lbDescription.TabIndex = 10;
            this.lbDescription.Text = "Description:";
            // 
            // lbNameUserTypes
            // 
            this.lbNameUserTypes.AutoSize = true;
            this.lbNameUserTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNameUserTypes.Location = new System.Drawing.Point(24, 26);
            this.lbNameUserTypes.Name = "lbNameUserTypes";
            this.lbNameUserTypes.Size = new System.Drawing.Size(49, 17);
            this.lbNameUserTypes.TabIndex = 9;
            this.lbNameUserTypes.Text = "Name:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(235, 46);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(418, 54);
            this.textBoxDescription.TabIndex = 6;
            // 
            // FormCiphers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlChipers);
            this.Name = "FormCiphers";
            this.Text = "FormCiphers";
            this.tabControlChipers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCompany)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUserType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlChipers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxNameCompany;
        private FontAwesome.Sharp.IconButton iconButtonDeleteCompany;
        private FontAwesome.Sharp.IconButton iconButtonAddCompany;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label lbPhone;
        private FontAwesome.Sharp.IconButton iconButtonEditCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonEditUserTypes;
        private System.Windows.Forms.TextBox textBoxUserTypes;
        private FontAwesome.Sharp.IconButton iconButtonAddUserTypes;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbNameUserTypes;
        private System.Windows.Forms.TextBox textBoxDescription;
        private MetroFramework.Controls.MetroGrid metroGridCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStateCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private MetroFramework.Controls.MetroGrid metroGridUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNoUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameUserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
    }
}