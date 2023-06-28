namespace WinFormsAppEF
{
    partial class UserList
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            stateSearch = new TextBox();
            companySearch = new TextBox();
            phoneSearch = new TextBox();
            zipSearch = new TextBox();
            lastNameSearch = new TextBox();
            firstNameSearch = new TextBox();
            refreshBtn = new Button();
            newUserBtn = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Email = new DataGridViewTextBoxColumn();
            UserFirstName = new DataGridViewTextBoxColumn();
            UserLastName = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Address1 = new DataGridViewTextBoxColumn();
            Address2 = new DataGridViewTextBoxColumn();
            ZipPostalCode = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            ModifyDate = new DataGridViewTextBoxColumn();
            ModifiedBy = new DataGridViewTextBoxColumn();
            UID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 45, 50);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(stateSearch);
            panel1.Controls.Add(companySearch);
            panel1.Controls.Add(phoneSearch);
            panel1.Controls.Add(zipSearch);
            panel1.Controls.Add(lastNameSearch);
            panel1.Controls.Add(firstNameSearch);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(newUserBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 76);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(609, 41);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 13;
            label6.Text = "State";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(579, 15);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 12;
            label5.Text = "Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(386, 43);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 11;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(367, 14);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 10;
            label3.Text = "Zip Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(132, 43);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 9;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(130, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 8;
            label1.Text = "First Name";
            // 
            // stateSearch
            // 
            stateSearch.BackColor = SystemColors.WindowFrame;
            stateSearch.BorderStyle = BorderStyle.None;
            stateSearch.ForeColor = SystemColors.Window;
            stateSearch.Location = new Point(680, 43);
            stateSearch.Name = "stateSearch";
            stateSearch.Size = new Size(100, 16);
            stateSearch.TabIndex = 7;
            stateSearch.TextChanged += stateSearch_TextChanged;
            // 
            // companySearch
            // 
            companySearch.BackColor = SystemColors.WindowFrame;
            companySearch.BorderStyle = BorderStyle.None;
            companySearch.ForeColor = SystemColors.Window;
            companySearch.Location = new Point(680, 15);
            companySearch.Name = "companySearch";
            companySearch.Size = new Size(100, 16);
            companySearch.TabIndex = 6;
            companySearch.TextChanged += companySearch_TextChanged;
            // 
            // phoneSearch
            // 
            phoneSearch.BackColor = SystemColors.WindowFrame;
            phoneSearch.BorderStyle = BorderStyle.None;
            phoneSearch.ForeColor = SystemColors.Window;
            phoneSearch.Location = new Point(464, 45);
            phoneSearch.Name = "phoneSearch";
            phoneSearch.Size = new Size(100, 16);
            phoneSearch.TabIndex = 5;
            phoneSearch.TextChanged += phoneSearch_TextChanged;
            // 
            // zipSearch
            // 
            zipSearch.BackColor = SystemColors.WindowFrame;
            zipSearch.BorderStyle = BorderStyle.None;
            zipSearch.ForeColor = SystemColors.Window;
            zipSearch.Location = new Point(464, 16);
            zipSearch.Name = "zipSearch";
            zipSearch.Size = new Size(100, 16);
            zipSearch.TabIndex = 4;
            zipSearch.TextChanged += zipSearch_TextChanged;
            // 
            // lastNameSearch
            // 
            lastNameSearch.BackColor = SystemColors.WindowFrame;
            lastNameSearch.BorderStyle = BorderStyle.None;
            lastNameSearch.ForeColor = SystemColors.Window;
            lastNameSearch.Location = new Point(235, 45);
            lastNameSearch.Name = "lastNameSearch";
            lastNameSearch.Size = new Size(100, 16);
            lastNameSearch.TabIndex = 3;
            lastNameSearch.TextChanged += lastNameSearch_TextChanged;
            // 
            // firstNameSearch
            // 
            firstNameSearch.BackColor = SystemColors.WindowFrame;
            firstNameSearch.BorderStyle = BorderStyle.None;
            firstNameSearch.ForeColor = Color.White;
            firstNameSearch.Location = new Point(235, 17);
            firstNameSearch.Name = "firstNameSearch";
            firstNameSearch.Size = new Size(100, 16);
            firstNameSearch.TabIndex = 2;
            firstNameSearch.TextChanged += firstNameSearch_TextChanged;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.RoyalBlue;
            refreshBtn.FlatStyle = FlatStyle.Popup;
            refreshBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            refreshBtn.ForeColor = Color.White;
            refreshBtn.Location = new Point(12, 6);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(72, 67);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // newUserBtn
            // 
            newUserBtn.BackColor = Color.Chocolate;
            newUserBtn.FlatStyle = FlatStyle.Popup;
            newUserBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            newUserBtn.ForeColor = Color.White;
            newUserBtn.Location = new Point(815, 27);
            newUserBtn.Name = "newUserBtn";
            newUserBtn.Size = new Size(102, 31);
            newUserBtn.TabIndex = 0;
            newUserBtn.Text = "New User";
            newUserBtn.UseVisualStyleBackColor = false;
            newUserBtn.Click += newUserBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(946, 548);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Email, UserFirstName, UserLastName, Company, Address1, Address2, ZipPostalCode, City, Country, State, PhoneNumber, Description, CreateDate, CreatedBy, ModifyDate, ModifiedBy, UID });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(946, 548);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 61;
            // 
            // UserFirstName
            // 
            UserFirstName.DataPropertyName = "UserFirstName";
            UserFirstName.HeaderText = "First Name";
            UserFirstName.Name = "UserFirstName";
            UserFirstName.ReadOnly = true;
            UserFirstName.Width = 89;
            // 
            // UserLastName
            // 
            UserLastName.DataPropertyName = "UserLastName";
            UserLastName.HeaderText = "Last Name";
            UserLastName.Name = "UserLastName";
            UserLastName.ReadOnly = true;
            UserLastName.Width = 88;
            // 
            // Company
            // 
            Company.DataPropertyName = "Company";
            Company.HeaderText = "Company name";
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Width = 117;
            // 
            // Address1
            // 
            Address1.DataPropertyName = "Address1";
            Address1.HeaderText = "Address";
            Address1.Name = "Address1";
            Address1.ReadOnly = true;
            Address1.Width = 74;
            // 
            // Address2
            // 
            Address2.DataPropertyName = "Address2";
            Address2.HeaderText = "Address 2";
            Address2.Name = "Address2";
            Address2.ReadOnly = true;
            Address2.Width = 83;
            // 
            // ZipPostalCode
            // 
            ZipPostalCode.DataPropertyName = "ZipPostalCode";
            ZipPostalCode.HeaderText = "Zip Code";
            ZipPostalCode.Name = "ZipPostalCode";
            ZipPostalCode.ReadOnly = true;
            ZipPostalCode.Width = 80;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 53;
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Country";
            Country.Name = "Country";
            Country.ReadOnly = true;
            Country.Width = 75;
            // 
            // State
            // 
            State.DataPropertyName = "StateProvinceId";
            State.HeaderText = "State";
            State.Name = "State";
            State.ReadOnly = true;
            State.Width = 58;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Phone";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 66;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 92;
            // 
            // CreateDate
            // 
            CreateDate.DataPropertyName = "CreateDate";
            CreateDate.HeaderText = "Create Date";
            CreateDate.Name = "CreateDate";
            CreateDate.ReadOnly = true;
            CreateDate.Width = 93;
            // 
            // CreatedBy
            // 
            CreatedBy.DataPropertyName = "CreatedBy";
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            CreatedBy.Width = 89;
            // 
            // ModifyDate
            // 
            ModifyDate.DataPropertyName = "ModifyDate";
            ModifyDate.HeaderText = "Modify Date";
            ModifyDate.Name = "ModifyDate";
            ModifyDate.ReadOnly = true;
            ModifyDate.Width = 97;
            // 
            // ModifiedBy
            // 
            ModifiedBy.DataPropertyName = "ModifiedBy";
            ModifiedBy.HeaderText = "Modified by";
            ModifiedBy.Name = "ModifiedBy";
            ModifiedBy.ReadOnly = true;
            ModifiedBy.Width = 96;
            // 
            // UID
            // 
            UID.DataPropertyName = "UID";
            UID.HeaderText = "UID";
            UID.Name = "UID";
            UID.ReadOnly = true;
            UID.Visible = false;
            UID.Width = 51;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(946, 624);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UserList";
            Text = "UserList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn UserFirstName;
        private DataGridViewTextBoxColumn UserLastName;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Address1;
        private DataGridViewTextBoxColumn Address2;
        private DataGridViewTextBoxColumn ZipPostalCode;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn CreatedBy;
        private DataGridViewTextBoxColumn ModifyDate;
        private DataGridViewTextBoxColumn ModifiedBy;
        private DataGridViewTextBoxColumn UID;
        private Button newUserBtn;
        private Button refreshBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox stateSearch;
        private TextBox companySearch;
        private TextBox phoneSearch;
        private TextBox zipSearch;
        private TextBox lastNameSearch;
        private TextBox firstNameSearch;
    }
}