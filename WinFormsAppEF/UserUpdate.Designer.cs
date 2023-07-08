namespace WinFormsAppEF
{
    partial class UserUpdate
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
            emailTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            companyTextBox = new TextBox();
            addressTextBox = new TextBox();
            address2TextBox = new TextBox();
            zipTextBox = new TextBox();
            cityTextBox = new TextBox();
            phoneTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            createDateTextBox = new TextBox();
            modifyDateTextBox = new TextBox();
            uidTextBox = new TextBox();
            countryComboBox = new ComboBox();
            stateComboBox = new ComboBox();
            createdByComboBox = new ComboBox();
            modifiedByComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            createNewUserBtn = new Button();
            deleteBtn = new Button();
            saveBtn = new Button();
            panel3 = new Panel();
            editUserLabel = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(247, 149);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(394, 23);
            emailTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(247, 178);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(394, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(247, 207);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(394, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // companyTextBox
            // 
            companyTextBox.Location = new Point(247, 236);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.Size = new Size(394, 23);
            companyTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(247, 265);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(394, 23);
            addressTextBox.TabIndex = 4;
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(247, 294);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(394, 23);
            address2TextBox.TabIndex = 5;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(247, 323);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(394, 23);
            zipTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(247, 352);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(394, 23);
            cityTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(247, 439);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(394, 23);
            phoneTextBox.TabIndex = 10;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(247, 468);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(394, 72);
            descriptionTextBox.TabIndex = 11;
            // 
            // createDateTextBox
            // 
            createDateTextBox.Location = new Point(247, 575);
            createDateTextBox.Name = "createDateTextBox";
            createDateTextBox.Size = new Size(394, 23);
            createDateTextBox.TabIndex = 13;
            // 
            // modifyDateTextBox
            // 
            modifyDateTextBox.Location = new Point(247, 604);
            modifyDateTextBox.Name = "modifyDateTextBox";
            modifyDateTextBox.Size = new Size(394, 23);
            modifyDateTextBox.TabIndex = 14;
            // 
            // uidTextBox
            // 
            uidTextBox.Location = new Point(12, 149);
            uidTextBox.Name = "uidTextBox";
            uidTextBox.ReadOnly = true;
            uidTextBox.Size = new Size(100, 23);
            uidTextBox.TabIndex = 16;
            uidTextBox.Visible = false;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(247, 381);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(394, 23);
            countryComboBox.Sorted = true;
            countryComboBox.TabIndex = 8;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(247, 410);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(394, 23);
            stateComboBox.TabIndex = 9;
            // 
            // createdByComboBox
            // 
            createdByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            createdByComboBox.FormattingEnabled = true;
            createdByComboBox.Location = new Point(247, 546);
            createdByComboBox.Name = "createdByComboBox";
            createdByComboBox.Size = new Size(394, 23);
            createdByComboBox.TabIndex = 12;
            createdByComboBox.SelectedIndexChanged += createdByComboBox_SelectedIndexChanged;
            // 
            // modifiedByComboBox
            // 
            modifiedByComboBox.FormattingEnabled = true;
            modifiedByComboBox.Location = new Point(247, 633);
            modifiedByComboBox.Name = "modifiedByComboBox";
            modifiedByComboBox.Size = new Size(394, 23);
            modifiedByComboBox.TabIndex = 15;
            modifiedByComboBox.SelectedIndexChanged += modifiedByComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 152);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 17;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 181);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 18;
            label2.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 210);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 19;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 239);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 20;
            label4.Text = "Company name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 268);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 21;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 297);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 22;
            label6.Text = "Address 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 326);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 23;
            label7.Text = "Zip / postal code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 355);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 24;
            label8.Text = "City";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 384);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 25;
            label9.Text = "Country";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(108, 413);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 26;
            label10.Text = "State / province";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(157, 442);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 27;
            label11.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(131, 471);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 28;
            label12.Text = "Description";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(130, 578);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 29;
            label13.Text = "Create Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(134, 549);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 30;
            label14.Text = "Created by";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(127, 607);
            label15.Name = "label15";
            label15.Size = new Size(71, 15);
            label15.TabIndex = 31;
            label15.Text = "Modify date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(127, 636);
            label16.Name = "label16";
            label16.Size = new Size(71, 15);
            label16.TabIndex = 32;
            label16.Text = "Modified By";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 54);
            panel1.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(uidTextBox);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(modifiedByComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(firstNameTextBox);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(modifyDateTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(createdByComboBox);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(companyTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(createDateTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(addressTextBox);
            panel2.Controls.Add(descriptionTextBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(stateComboBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(phoneTextBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(address2TextBox);
            panel2.Controls.Add(countryComboBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(zipTextBox);
            panel2.Controls.Add(cityTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(859, 719);
            panel2.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(editUserLabel);
            panel4.Controls.Add(createNewUserBtn);
            panel4.Controls.Add(deleteBtn);
            panel4.Controls.Add(saveBtn);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(859, 129);
            panel4.TabIndex = 1;
            // 
            // createNewUserBtn
            // 
            createNewUserBtn.BackColor = Color.Chocolate;
            createNewUserBtn.FlatStyle = FlatStyle.Flat;
            createNewUserBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createNewUserBtn.ForeColor = Color.Gainsboro;
            createNewUserBtn.Location = new Point(525, 68);
            createNewUserBtn.Name = "createNewUserBtn";
            createNewUserBtn.Size = new Size(131, 43);
            createNewUserBtn.TabIndex = 33;
            createNewUserBtn.Text = "New User";
            createNewUserBtn.UseVisualStyleBackColor = false;
            createNewUserBtn.Click += createNewUserBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(221, 75, 57);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.Gainsboro;
            deleteBtn.Location = new Point(758, 68);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(89, 43);
            deleteBtn.TabIndex = 35;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(0, 115, 183);
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.Gainsboro;
            saveBtn.Location = new Point(663, 68);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(89, 43);
            saveBtn.TabIndex = 34;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 665);
            panel3.Name = "panel3";
            panel3.Size = new Size(859, 54);
            panel3.TabIndex = 0;
            // 
            // editUserLabel
            // 
            editUserLabel.AutoSize = true;
            editUserLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            editUserLabel.Location = new Point(12, 71);
            editUserLabel.Name = "editUserLabel";
            editUserLabel.Size = new Size(207, 31);
            editUserLabel.TabIndex = 36;
            editUserLabel.Text = "Edit user details";
            // 
            // UserUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 719);
            Controls.Add(panel1);
            Controls.Add(emailTextBox);
            Controls.Add(panel2);
            Name = "UserUpdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserUpdate";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox emailTextBox;
        public TextBox firstNameTextBox;
        public TextBox lastNameTextBox;
        public TextBox companyTextBox;
        public TextBox addressTextBox;
        public TextBox address2TextBox;
        public TextBox zipTextBox;
        public TextBox cityTextBox;
        public TextBox phoneTextBox;
        public TextBox descriptionTextBox;
        public TextBox createDateTextBox;
        public TextBox modifyDateTextBox;
        public TextBox uidTextBox;
        public ComboBox countryComboBox;
        public ComboBox stateComboBox;
        public ComboBox createdByComboBox;
        public ComboBox modifiedByComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        public Button createNewUserBtn;
        public Button deleteBtn;
        public Button saveBtn;
        public Label label15;
        public Label label16;
        public Label label13;
        public Label editUserLabel;
    }
}