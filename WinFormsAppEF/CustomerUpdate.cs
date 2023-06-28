using WinFormsAppEF.Models;

namespace WinFormsAppEF
{
    public partial class CustomerUpdate : Form
    {
        #region Fields and Properties
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public CustomerUpdate()
        {
            InitializeComponent();

            library.States(stateComboBox);
            library.CountryList(countryComboBox);
            library.CreatedBy(createdByComboBox);
            library.ModifiedBy(modifiedByComboBox);
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void UpdateCustomerInfo()
        {
            using (var dbContext = new WinformDbContext())
            {
                int uid = int.Parse(uidTextBox.Text);

                // Retrieve the user information entity from the context based on the UID
                var userInformation = dbContext.UserInformations.FirstOrDefault(u => u.Uid == uid);

                if (userInformation != null)
                {
                    // Update the properties of the retrieved entity with the new values
                    userInformation.UserFirstName = firstNameTextBox.Text;
                    userInformation.UserLastName = lastNameTextBox.Text;
                    userInformation.Company = companyTextBox.Text;
                    userInformation.Address1 = addressTextBox.Text;
                    userInformation.Address2 = address2TextBox.Text;
                    userInformation.ZipPostalCode = zipTextBox.Text;
                    userInformation.City = cityTextBox.Text;
                    userInformation.Country = countryComboBox.Text;
                    userInformation.StateProvinceId = stateComboBox.Text;
                    userInformation.PhoneNumber = phoneTextBox.Text;
                    userInformation.Description = descriptionTextBox.Text;
                    userInformation.CreatedBy = createdByComboBox.Text;
                    userInformation.ModifiedBy = modifiedByComboBox.Text;
                    userInformation.ModifyDate = DateTime.Now;

                    try
                    {
                        // Save the changes to the database
                        dbContext.SaveChanges();
                        MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to update user information. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateNewCustomer()
        {
            using (var dbContext = new WinformDbContext())
            {
                UserInformation newUser = new UserInformation
                {
                    Email = emailTextBox.Text,
                    Password = "",
                    UserFirstName = firstNameTextBox.Text,
                    UserLastName = lastNameTextBox.Text,
                    Company = companyTextBox.Text,
                    Address1 = addressTextBox.Text,
                    Address2 = address2TextBox.Text,
                    ZipPostalCode = zipTextBox.Text,
                    City = cityTextBox.Text,
                    Country = countryComboBox.Text,
                    StateProvinceId = stateComboBox.Text,
                    PhoneNumber = phoneTextBox.Text,
                    Description = descriptionTextBox.Text,
                    CreatedBy = createdByComboBox.Text,
                    CreateDate = DateTime.Now
                };

                try
                {
                    dbContext.UserInformations.Add(newUser);
                    dbContext.SaveChanges();
                    int newUserId = newUser.Uid;
                    MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to create user. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteUser()
        {
            using (var dbContext = new WinformDbContext())
            {
                int uid = int.Parse(uidTextBox.Text);

                UserInformation? userInformation = dbContext.UserInformations.FirstOrDefault(u => u.Uid == uid);

                if (userInformation != null)
                {
                    try
                    {
                        dbContext.Remove(userInformation);
                        dbContext.SaveChanges();
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to delete user. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Private Method

        #region Event Handlers
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            modifyDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            UpdateCustomerInfo();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateNewCustomer();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUser();      
        }
        #endregion Event Handlers
    }
}
