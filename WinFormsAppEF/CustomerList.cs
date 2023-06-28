using System.Data;
using WinFormsAppEF.Models;

namespace WinFormsAppEF
{
    public partial class CustomerList : Form
    {
        #region Constructor and Disposer
        public CustomerList()
        {
            InitializeComponent();
            CustomerData();
        }
        #endregion Constructor and Disposer

        #region Private Method
        private void CustomerData()
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

        private void EditCustomerInfoByGrid()
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            customerUpdate.emailTextBox.Text = currentRow.Cells[0].Value?.ToString();
            customerUpdate.firstNameTextBox.Text = currentRow.Cells[1].Value?.ToString();
            customerUpdate.lastNameTextBox.Text = currentRow.Cells[2].Value?.ToString();
            customerUpdate.companyTextBox.Text = currentRow.Cells[3].Value?.ToString();
            customerUpdate.addressTextBox.Text = currentRow.Cells[4].Value?.ToString();
            customerUpdate.address2TextBox.Text = currentRow.Cells[5].Value?.ToString();
            customerUpdate.zipTextBox.Text = currentRow.Cells[6].Value?.ToString();
            customerUpdate.cityTextBox.Text = currentRow.Cells[7].Value?.ToString();
            customerUpdate.countryComboBox.Text = currentRow.Cells[8].Value?.ToString();
            customerUpdate.stateComboBox.Text = currentRow.Cells[9].Value?.ToString();
            customerUpdate.phoneTextBox.Text = currentRow.Cells[10].Value?.ToString();
            customerUpdate.descriptionTextBox.Text = currentRow.Cells[11].Value?.ToString();
            customerUpdate.createdByComboBox.Text = currentRow.Cells[12].Value?.ToString();
            customerUpdate.createDateTextBox.Text = currentRow.Cells[13].Value?.ToString();
            customerUpdate.modifyDateTextBox.Text = currentRow.Cells[14].Value?.ToString();
            customerUpdate.modifiedByComboBox.Text = currentRow.Cells[15].Value?.ToString();
            customerUpdate.uidTextBox.Text = currentRow.Cells[16].Value?.ToString();

            customerUpdate.newCustomerBtn.Visible = false;


            //customerUpdate.displayBox.Text = currentRow.Cells[1].Value?.ToString();

            if (!string.IsNullOrEmpty(customerUpdate.emailTextBox.Text))
            {
                customerUpdate.emailTextBox.Enabled = false;
            }

            if (!string.IsNullOrEmpty(customerUpdate.createdByComboBox.Text))
            {
                customerUpdate.createdByComboBox.Enabled = false;
            }
            if (!string.IsNullOrEmpty(customerUpdate.createDateTextBox.Text))
            {
                customerUpdate.createDateTextBox.Enabled = false;
            }
            if (!string.IsNullOrEmpty(customerUpdate.modifyDateTextBox.Text))
            {
                customerUpdate.modifyDateTextBox.Enabled = false;
            }

            customerUpdate.ShowDialog();

            RefreshCustomerData();
        }

        private void RefreshCustomerData()
        {
            CustomerData();
            //library.ResetSearch(firstNameSearch, lastNameSearch, zipSearch, phoneSearch, companySearch, stateSearch);
        }
        #endregion Private Method

        #region Event Handlers
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCustomerInfoByGrid();
        }

        private void newCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerUpdate newCustomer = new CustomerUpdate();

            newCustomer.saveBtn.Visible = false;
            newCustomer.deleteBtn.Visible = false;
            newCustomer.label13.Visible = false;
            newCustomer.createDateTextBox.Visible = false;
            newCustomer.label15.Visible = false;
            newCustomer.modifyDateTextBox.Visible = false;
            newCustomer.label16.Visible = false;
            newCustomer.modifiedByComboBox.Visible = false;
            newCustomer.newCustomerBtn.Location = new Point(680, 68);
            newCustomer.Size = new Size(875, 667);

            newCustomer.ShowDialog();
            RefreshCustomerData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshCustomerData();
        }
        #endregion Event Handlers
    }
}
