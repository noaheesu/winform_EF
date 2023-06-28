using System.Data;
using WinFormsAppEF.Models;

namespace WinFormsAppEF
{
    public partial class UserList : Form
    {
        #region Constructor and Disposer
        public UserList()
        {
            InitializeComponent();
            UserData();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void UserData()
        {
            using (var dbContext = new WinformDbContext())
            {
                //List<UserInformation> userInformations = dbContext.UserInformations.ToList();
                var userInformations = dbContext.UserInformations
                    .Select(u => new
                    {
                        u.Email,
                        u.UserFirstName,
                        u.UserLastName,
                        u.Company,
                        u.Address1,
                        u.Address2,
                        u.City,
                        u.StateProvinceId,
                        u.ZipPostalCode,
                        u.Country,
                        u.PhoneNumber,
                        u.Description,
                        u.CreatedBy,
                        u.CreateDate,
                        u.ModifyDate,
                        u.ModifiedBy,
                        u.Uid
                    })
                    .ToList();

                dataGridView1.Columns["ModifyDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
                dataGridView1.Columns["CreateDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";

                dataGridView1.DataSource = userInformations;
            }
        }

        private void EditUserInfoByGrid()
        {
            UserUpdate userUpdate = new UserUpdate();

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            userUpdate.emailTextBox.Text = currentRow.Cells[0].Value?.ToString();
            userUpdate.firstNameTextBox.Text = currentRow.Cells[1].Value?.ToString();
            userUpdate.lastNameTextBox.Text = currentRow.Cells[2].Value?.ToString();
            userUpdate.companyTextBox.Text = currentRow.Cells[3].Value?.ToString();
            userUpdate.addressTextBox.Text = currentRow.Cells[4].Value?.ToString();
            userUpdate.address2TextBox.Text = currentRow.Cells[5].Value?.ToString();
            userUpdate.zipTextBox.Text = currentRow.Cells[6].Value?.ToString();
            userUpdate.cityTextBox.Text = currentRow.Cells[7].Value?.ToString();
            userUpdate.countryComboBox.Text = currentRow.Cells[8].Value?.ToString();
            userUpdate.stateComboBox.Text = currentRow.Cells[9].Value?.ToString();
            userUpdate.phoneTextBox.Text = currentRow.Cells[10].Value?.ToString();
            userUpdate.descriptionTextBox.Text = currentRow.Cells[11].Value?.ToString();
            userUpdate.createdByComboBox.Text = currentRow.Cells[12].Value?.ToString();
            userUpdate.createDateTextBox.Text = currentRow.Cells[13].Value?.ToString();
            userUpdate.modifyDateTextBox.Text = currentRow.Cells[14].Value?.ToString();
            userUpdate.modifiedByComboBox.Text = currentRow.Cells[15].Value?.ToString();
            userUpdate.uidTextBox.Text = currentRow.Cells[16].Value?.ToString();

            userUpdate.createNewUserBtn.Visible = false;


            //userUpdate.displayBox.Text = currentRow.Cells[1].Value?.ToString();

            if (!string.IsNullOrEmpty(userUpdate.emailTextBox.Text))
            {
                userUpdate.emailTextBox.Enabled = false;
            }

            if (!string.IsNullOrEmpty(userUpdate.createdByComboBox.Text))
            {
                userUpdate.createdByComboBox.Enabled = false;
            }
            if (!string.IsNullOrEmpty(userUpdate.createDateTextBox.Text))
            {
                userUpdate.createDateTextBox.Enabled = false;
            }
            if (!string.IsNullOrEmpty(userUpdate.modifyDateTextBox.Text))
            {
                userUpdate.modifyDateTextBox.Enabled = false;
            }

            userUpdate.ShowDialog();

            RefreshUserData();
        }

        private void RefreshUserData()
        {
            UserData();
            //library.ResetSearch(firstNameSearch, lastNameSearch, zipSearch, phoneSearch, companySearch, stateSearch);
        }

        private void FilterData(Func<UserInformation, bool> filterPredicate)
        {
            using (var dbContext = new WinformDbContext())
            {
                var filteredData = dbContext.UserInformations
                    .Where(filterPredicate)
                    .Select(u => new
                    {
                        u.Email,
                        u.UserFirstName,
                        u.UserLastName,
                        u.Company,
                        u.Address1,
                        u.Address2,
                        u.City,
                        u.StateProvinceId,
                        u.ZipPostalCode,
                        u.Country,
                        u.PhoneNumber,
                        u.Description,
                        u.CreatedBy,
                        u.CreateDate,
                        u.ModifyDate,
                        u.ModifiedBy,
                        u.Uid
                    })
                    .ToList();

                dataGridView1.Columns["ModifyDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
                dataGridView1.Columns["CreateDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";

                dataGridView1.DataSource = filteredData;
            }
        }

        private void ApplyFilters()
        {
            string firstNameKeyword = firstNameSearch.Text.Trim().ToLower();
            string lastNameKeyword = lastNameSearch.Text.Trim().ToLower();
            string zipKeyword = zipSearch.Text.Trim();
            string phoneKeyword = phoneSearch.Text.Trim();
            string companyKeyword = companySearch.Text.Trim();
            string stateKeyword = stateSearch.Text.Trim();

            FilterData(u =>
                (string.IsNullOrEmpty(firstNameKeyword) || (u.UserFirstName != null && u.UserFirstName.ToLower().Contains(firstNameKeyword))) &&
                (string.IsNullOrEmpty(lastNameKeyword) || (u.UserLastName != null && u.UserLastName.ToLower().Contains(lastNameKeyword))) &&
                (string.IsNullOrEmpty(zipKeyword) || (u.ZipPostalCode != null && u.ZipPostalCode.Contains(zipKeyword))) &&
                (string.IsNullOrEmpty(phoneKeyword) || (u.PhoneNumber != null && u.PhoneNumber.Contains(phoneKeyword))) &&
                (string.IsNullOrEmpty(companyKeyword) || (u.Company != null && u.Company.Contains(companyKeyword))) &&
                (string.IsNullOrEmpty(stateKeyword) || (u.StateProvinceId != null && u.StateProvinceId.Contains(stateKeyword))));
        }
        #endregion Private Method

        #region Event Handlers
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUserInfoByGrid();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            UserUpdate newUser = new UserUpdate();

            newUser.saveBtn.Visible = false;
            newUser.deleteBtn.Visible = false;
            newUser.label13.Visible = false;
            newUser.createDateTextBox.Visible = false;
            newUser.label15.Visible = false;
            newUser.modifyDateTextBox.Visible = false;
            newUser.label16.Visible = false;
            newUser.modifiedByComboBox.Visible = false;
            newUser.createNewUserBtn.Location = new Point(680, 68);
            newUser.Size = new Size(875, 667);

            newUser.ShowDialog();
            RefreshUserData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        private void firstNameSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void zipSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void companySearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void stateSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        #endregion Event Handlers        
    }
}
