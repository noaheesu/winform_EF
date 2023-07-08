using System.Text.RegularExpressions;
using WinFormsAppEF.Models;

namespace WinFormsAppEF
{
    public partial class UserUpdate : Form
    {
        #region Fields and Properties
        public Library library = new Library();
        #endregion Fields and Properties

        #region Constructor and Disposer
        public UserUpdate()
        {
            InitializeComponent();

            library.CreatedBy(createdByComboBox);
            library.States(stateComboBox);
            library.CountryList(countryComboBox);
            library.ModifiedBy(modifiedByComboBox);
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void UpdateUserInfo()
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
                        modifyDateTextBox.ReadOnly = true;
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

        private bool DataValidate()
        {
            bool rv = true;

            string email = emailTextBox.Text.Trim();
            // Email format validation using regular expression
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTextBox.Focus();
                rv = false;
            }

            else if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(companyTextBox.Text))
            {
                MessageBox.Show("Please enter company.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                companyTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please enter address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(zipTextBox.Text))
            {
                MessageBox.Show("Please enter zip/postalCode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zipTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                MessageBox.Show("Please enter city.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cityTextBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrEmpty(countryComboBox.Text))
            {
                MessageBox.Show("Please enter country.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                countryComboBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrEmpty(stateComboBox.Text))
            {
                MessageBox.Show("Please enter state.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stateComboBox.Focus();
                rv = false;
            }
            else if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                MessageBox.Show("Please enter phone number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTextBox.Focus();
                rv = false;
            }
            return rv;
        }

        private void CreateNewUser()
        {
            if (!DataValidate())
                return;

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

                bool recordExists = dbContext.UserInformations.Any(e => e.Email == emailTextBox.Text);

                if (!recordExists)
                {
                    try
                    {
                        dbContext.UserInformations.Add(newUser);
                        dbContext.SaveChanges();
                        this.uidTextBox.Text = newUser.Uid.ToString();
                        MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        emailTextBox.ReadOnly = true;
                        createNewUserBtn.Visible = false;
                        saveBtn.Visible = true;
                        deleteBtn.Visible = true;
                        label13.Visible = true;
                        createDateTextBox.Visible = true;
                        label15.Visible = true;
                        modifyDateTextBox.Visible = true;
                        label16.Visible = true;
                        modifiedByComboBox.Visible = true;
                        createDateTextBox.Text = newUser.CreateDate.ToString();
                        createDateTextBox.ReadOnly = true;
                        this.Size = new Size(875, 758);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to create user. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Email already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void DeleteUser()
        {
            using (var dbContext = new WinformDbContext())
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
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
            UpdateUserInfo();
        }

        private void createNewUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUser();
            this.Close();
        }

        private void createdByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(createdByComboBox);
        }

        private void modifiedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            library.ComboBoxIndexChange(modifiedByComboBox);
        }
        #endregion Event Handlers
    }
}
