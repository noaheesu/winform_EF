namespace WinFormsAppEF
{
    public partial class Home : Form
    {
        public Library library = new Library();
        #region Constructor and Disposer
        public Home()
        {
            InitializeComponent();

        }
        #endregion Constructor and Disposer

        #region Event Handlers
        private void userBtn_Click_1(object sender, EventArgs e)
        {
            library.OpenForm<UserList>(this);
            //UserList userListForm = new UserList();
            //userListForm.MdiParent = this;
            //userListForm.StartPosition = FormStartPosition.CenterParent;
            //userListForm.Show();
        }
        #endregion Event Handlers
    }
}
