namespace WinFormsAppEF
{
    public partial class LogIn : Form
    {
        #region Constructor and Disposer
        public LogIn()
        {
            InitializeComponent();
        }
        #endregion Constructor and Disposer

        #region Event Handlers
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        #endregion Event Handlers
    }
}