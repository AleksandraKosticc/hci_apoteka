namespace hci_apoteka.Forms
{
    partial class FormEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.iconButtonBrowse = new FontAwesome.Sharp.IconButton();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pnUsername = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.panelState = new System.Windows.Forms.Panel();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pnJmbg = new System.Windows.Forms.Panel();
            this.textBoxJmbg = new System.Windows.Forms.TextBox();
            this.lbJmbg = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.iconButtonEditEmployee = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddEmployee = new FontAwesome.Sharp.IconButton();
            this.metroGridEmployees = new MetroFramework.Controls.MetroGrid();
            this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJmbg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbFilterEmployee = new System.Windows.Forms.TextBox();
            this.iconPictureBoxRefresh = new FontAwesome.Sharp.IconPictureBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.pnUsername.SuspendLayout();
            this.panelState.SuspendLayout();
            this.pnJmbg.SuspendLayout();
            this.pnName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.White;
            this.gbInfo.Controls.Add(this.iconButtonBrowse);
            this.gbInfo.Controls.Add(this.pictureBoxEmployee);
            this.gbInfo.Controls.Add(this.textBoxPass);
            this.gbInfo.Controls.Add(this.pnUsername);
            this.gbInfo.Controls.Add(this.textBoxSurname);
            this.gbInfo.Controls.Add(this.lbPass);
            this.gbInfo.Controls.Add(this.panelState);
            this.gbInfo.Controls.Add(this.lbSurname);
            this.gbInfo.Controls.Add(this.comboBoxUserType);
            this.gbInfo.Controls.Add(this.textBoxEmail);
            this.gbInfo.Controls.Add(this.pnJmbg);
            this.gbInfo.Controls.Add(this.lbUserType);
            this.gbInfo.Controls.Add(this.lbEmail);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.pnName);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(371, 568);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Basic information";
            // 
            // iconButtonBrowse
            // 
            this.iconButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonBrowse.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonBrowse.IconColor = System.Drawing.Color.White;
            this.iconButtonBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBrowse.IconSize = 15;
            this.iconButtonBrowse.Location = new System.Drawing.Point(141, 159);
            this.iconButtonBrowse.Name = "iconButtonBrowse";
            this.iconButtonBrowse.Size = new System.Drawing.Size(81, 24);
            this.iconButtonBrowse.TabIndex = 1;
            this.iconButtonBrowse.Text = "Browse";
            this.iconButtonBrowse.UseVisualStyleBackColor = false;
            this.iconButtonBrowse.Click += new System.EventHandler(this.IconButtonBrowse_Click);
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Location = new System.Drawing.Point(120, 28);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 40;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(111, 250);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(254, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // pnUsername
            // 
            this.pnUsername.BackColor = System.Drawing.SystemColors.Control;
            this.pnUsername.Controls.Add(this.textBoxUsername);
            this.pnUsername.Controls.Add(this.lbUsername);
            this.pnUsername.Location = new System.Drawing.Point(0, 199);
            this.pnUsername.Name = "pnUsername";
            this.pnUsername.Size = new System.Drawing.Size(371, 41);
            this.pnUsername.TabIndex = 10;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(111, 10);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(254, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbUsername.Location = new System.Drawing.Point(3, 12);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(81, 18);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(111, 331);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(254, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPass.Location = new System.Drawing.Point(3, 252);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(79, 18);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // panelState
            // 
            this.panelState.BackColor = System.Drawing.SystemColors.Control;
            this.panelState.Controls.Add(this.textBoxState);
            this.panelState.Controls.Add(this.lbState);
            this.panelState.Location = new System.Drawing.Point(0, 441);
            this.panelState.Name = "panelState";
            this.panelState.Size = new System.Drawing.Size(371, 79);
            this.panelState.TabIndex = 13;
            // 
            // textBoxState
            // 
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxState.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(111, 7);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(254, 60);
            this.textBoxState.TabIndex = 1;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbState.Location = new System.Drawing.Point(3, 7);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(86, 18);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "State, town:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbSurname.Location = new System.Drawing.Point(3, 332);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(72, 18);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "Surname:";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.ItemHeight = 18;
            this.comboBoxUserType.Location = new System.Drawing.Point(111, 530);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(254, 26);
            this.comboBoxUserType.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(111, 412);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(254, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // pnJmbg
            // 
            this.pnJmbg.BackColor = System.Drawing.SystemColors.Control;
            this.pnJmbg.Controls.Add(this.textBoxJmbg);
            this.pnJmbg.Controls.Add(this.lbJmbg);
            this.pnJmbg.Location = new System.Drawing.Point(0, 360);
            this.pnJmbg.Name = "pnJmbg";
            this.pnJmbg.Size = new System.Drawing.Size(371, 41);
            this.pnJmbg.TabIndex = 12;
            // 
            // textBoxJmbg
            // 
            this.textBoxJmbg.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxJmbg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJmbg.Location = new System.Drawing.Point(111, 11);
            this.textBoxJmbg.Multiline = true;
            this.textBoxJmbg.Name = "textBoxJmbg";
            this.textBoxJmbg.Size = new System.Drawing.Size(257, 20);
            this.textBoxJmbg.TabIndex = 1;
            // 
            // lbJmbg
            // 
            this.lbJmbg.AutoSize = true;
            this.lbJmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJmbg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbJmbg.Location = new System.Drawing.Point(3, 11);
            this.lbJmbg.Name = "lbJmbg";
            this.lbJmbg.Size = new System.Drawing.Size(55, 18);
            this.lbJmbg.TabIndex = 0;
            this.lbJmbg.Text = "JMBG:";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbUserType.Location = new System.Drawing.Point(3, 533);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(75, 18);
            this.lbUserType.TabIndex = 8;
            this.lbUserType.Text = "User type:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbEmail.Location = new System.Drawing.Point(3, 412);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 18);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.SystemColors.Control;
            this.pnName.Controls.Add(this.textBoxName);
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Location = new System.Drawing.Point(0, 281);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(371, 41);
            this.pnName.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(111, 11);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(254, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbName.Location = new System.Drawing.Point(3, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 18);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Firstname:";
            // 
            // iconButtonEditEmployee
            // 
            this.iconButtonEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonEditEmployee.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButtonEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonEditEmployee.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEditEmployee.IconColor = System.Drawing.Color.White;
            this.iconButtonEditEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditEmployee.IconSize = 17;
            this.iconButtonEditEmployee.Location = new System.Drawing.Point(61, 586);
            this.iconButtonEditEmployee.Name = "iconButtonEditEmployee";
            this.iconButtonEditEmployee.Size = new System.Drawing.Size(37, 37);
            this.iconButtonEditEmployee.TabIndex = 3;
            this.iconButtonEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditEmployee.UseVisualStyleBackColor = false;
            this.iconButtonEditEmployee.Click += new System.EventHandler(this.IconButtonEditEmployee_Click);
            // 
            // iconButtonAddEmployee
            // 
            this.iconButtonAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(31)))));
            this.iconButtonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonAddEmployee.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddEmployee.IconColor = System.Drawing.Color.White;
            this.iconButtonAddEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddEmployee.IconSize = 20;
            this.iconButtonAddEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonAddEmployee.Location = new System.Drawing.Point(12, 586);
            this.iconButtonAddEmployee.Name = "iconButtonAddEmployee";
            this.iconButtonAddEmployee.Size = new System.Drawing.Size(37, 37);
            this.iconButtonAddEmployee.TabIndex = 2;
            this.iconButtonAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddEmployee.UseVisualStyleBackColor = false;
            this.iconButtonAddEmployee.Click += new System.EventHandler(this.IconButtonAddEmployee_Click);
            // 
            // metroGridEmployees
            // 
            this.metroGridEmployees.AllowUserToAddRows = false;
            this.metroGridEmployees.AllowUserToDeleteRows = false;
            this.metroGridEmployees.AllowUserToOrderColumns = true;
            this.metroGridEmployees.AllowUserToResizeRows = false;
            this.metroGridEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.metroGridEmployees.BackgroundColor = System.Drawing.Color.White;
            this.metroGridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnUsername,
            this.columnPassword,
            this.columnFirstname,
            this.columnSurname,
            this.columnJmbg,
            this.columnEmail,
            this.columnState,
            this.columnUserType});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridEmployees.EnableHeadersVisualStyles = false;
            this.metroGridEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEmployees.Location = new System.Drawing.Point(389, 12);
            this.metroGridEmployees.Name = "metroGridEmployees";
            this.metroGridEmployees.ReadOnly = true;
            this.metroGridEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridEmployees.RowHeadersWidth = 30;
            this.metroGridEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEmployees.Size = new System.Drawing.Size(614, 568);
            this.metroGridEmployees.TabIndex = 1;
            this.metroGridEmployees.TabStop = false;
            this.metroGridEmployees.DoubleClick += new System.EventHandler(this.MetroGridEmployees_DoubleClick);
            // 
            // columnUsername
            // 
            this.columnUsername.FillWeight = 80F;
            this.columnUsername.HeaderText = "Username";
            this.columnUsername.Name = "columnUsername";
            this.columnUsername.ReadOnly = true;
            this.columnUsername.Width = 94;
            // 
            // columnPassword
            // 
            this.columnPassword.FillWeight = 80F;
            this.columnPassword.HeaderText = "Password";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            this.columnPassword.Width = 90;
            // 
            // columnFirstname
            // 
            this.columnFirstname.FillWeight = 120F;
            this.columnFirstname.HeaderText = "Firstname";
            this.columnFirstname.Name = "columnFirstname";
            this.columnFirstname.ReadOnly = true;
            this.columnFirstname.Width = 92;
            // 
            // columnSurname
            // 
            this.columnSurname.FillWeight = 90.77908F;
            this.columnSurname.HeaderText = "Surname";
            this.columnSurname.Name = "columnSurname";
            this.columnSurname.ReadOnly = true;
            this.columnSurname.Width = 86;
            // 
            // columnJmbg
            // 
            this.columnJmbg.FillWeight = 170F;
            this.columnJmbg.HeaderText = "JMBG";
            this.columnJmbg.Name = "columnJmbg";
            this.columnJmbg.ReadOnly = true;
            this.columnJmbg.Width = 68;
            // 
            // columnEmail
            // 
            this.columnEmail.FillWeight = 200F;
            this.columnEmail.HeaderText = "E-mail";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 70;
            // 
            // columnState
            // 
            this.columnState.FillWeight = 200F;
            this.columnState.HeaderText = "State, town";
            this.columnState.Name = "columnState";
            this.columnState.ReadOnly = true;
            this.columnState.Width = 101;
            // 
            // columnUserType
            // 
            this.columnUserType.FillWeight = 160F;
            this.columnUserType.HeaderText = "User type";
            this.columnUserType.Name = "columnUserType";
            this.columnUserType.ReadOnly = true;
            this.columnUserType.Width = 91;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(387, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 27);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::hci_apoteka.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 21);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // tbFilterEmployee
            // 
            this.tbFilterEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilterEmployee.Location = new System.Drawing.Point(415, 586);
            this.tbFilterEmployee.Multiline = true;
            this.tbFilterEmployee.Name = "tbFilterEmployee";
            this.tbFilterEmployee.Size = new System.Drawing.Size(588, 27);
            this.tbFilterEmployee.TabIndex = 5;
            this.tbFilterEmployee.TextChanged += new System.EventHandler(this.TbFilterEmployee_TextChanged);
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
            this.iconPictureBoxRefresh.Location = new System.Drawing.Point(104, 586);
            this.iconPictureBoxRefresh.Name = "iconPictureBoxRefresh";
            this.iconPictureBoxRefresh.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBoxRefresh.TabIndex = 48;
            this.iconPictureBoxRefresh.TabStop = false;
            this.iconPictureBoxRefresh.Click += new System.EventHandler(this.IconPictureBoxRefresh_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 630);
            this.Controls.Add(this.iconPictureBoxRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbFilterEmployee);
            this.Controls.Add(this.metroGridEmployees);
            this.Controls.Add(this.iconButtonAddEmployee);
            this.Controls.Add(this.iconButtonEditEmployee);
            this.Controls.Add(this.gbInfo);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.pnUsername.ResumeLayout(false);
            this.pnUsername.PerformLayout();
            this.panelState.ResumeLayout(false);
            this.panelState.PerformLayout();
            this.pnJmbg.ResumeLayout(false);
            this.pnJmbg.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Panel pnJmbg;
        private System.Windows.Forms.TextBox textBoxJmbg;
        private System.Windows.Forms.Label lbJmbg;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Panel pnUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panelState;
        private FontAwesome.Sharp.IconButton iconButtonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private FontAwesome.Sharp.IconButton iconButtonEditEmployee;
        private FontAwesome.Sharp.IconButton iconButtonAddEmployee;
        private MetroFramework.Controls.MetroGrid metroGridEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbFilterEmployee;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnJmbg;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUserType;
    }
}