namespace WinFormsAppEF
{
    public partial class Library
    {
        #region Public Method

        public void CountryList(ComboBox country)
        {
            List<string> countries = new List<string>()
                {
                    "Select State",
                    "United States",
                    "China",
                    "Japan",
                    "Germany",
                    "United Kingdom",
                    "France",
                    "Italy",
                    "Canada",
                    "South Korea",
                    "Australia",
                    "Brazil",
                    "India",
                    "Russia",
                    "Mexico",
                    "Indonesia",
                    "Turkey",
                    "Netherlands",
                    "Switzerland",
                    "Sweden",
                    "Saudi Arabia"
                };
            country.Items.AddRange(countries.ToArray());
        }
        public void States(ComboBox state)
        {
            List<string> states = new List<string>()
            {
                "Select State", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
                "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa",
                "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan",
                "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio",
                "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
                "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia",
                "Wisconsin", "Wyoming"
            };
            state.Items.AddRange(states.ToArray());
        }
        public void CreatedBy(ComboBox By)
        {
            List<string> createdBy = new List<string>()
            {
                "Select State", "User", "Admin", "Manager"
            };
            By.Items.AddRange(createdBy.ToArray());
        }
        public void ModifiedBy(ComboBox By)
        {
            List<string> modifiedBy = new List<string>()
            {
                "Select State", "Admin", "Manager"
            };
            By.Items.AddRange(modifiedBy.ToArray());
        }




        public void OpenForm<T>(Form form) where T : Form, new()
        {
            T userListForm = null;

            for (int i = 0; i < form.MdiChildren.Length; i++)
            {
                if (form.MdiChildren[i] is T && form.MdiChildren[i].Name == typeof(T).Name)
                {
                    userListForm = (T)form.MdiChildren[i];
                    userListForm.Focus();
                    userListForm.Activate();
                    userListForm.WindowState = FormWindowState.Normal;
                    break;
                }
            }

            if (userListForm == null)
            {
                userListForm = new T();
                userListForm.MdiParent = form;
                userListForm.Show();
            }
        }

        #endregion Public Method
    }
}
