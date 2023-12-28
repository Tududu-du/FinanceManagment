namespace FinanceManagment
{
    // Declaration of the LoginBtn class, which is a Form
    public partial class LoginBtn : Form
    {
        // Constructor for the LoginBtn class
        public LoginBtn()
        {
            // Initialize the form components
            InitializeComponent();
        }

        // Event handler for the click event of the label (closing the application)
        private void label1_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler for the click event of the login button
        private void LoginBtt_Click(object sender, EventArgs e)
        {
            // Check if the username or password is empty
            if (UserNameTab.Text == "" || PasswordTab.Text == "")
            {
                // Show a message box indicating missing data
                MessageBox.Show("Brak danych");
            }
            // Check if the entered username and password are "admin"
            else if (UserNameTab.Text == "admin" && PasswordTab.Text == "admin")
            {
                // If the login is successful, create an instance of the Dochod form
                Dochod Obj = new Dochod();
                // Show the Dochod form
                Obj.Show();
                // Hide the current form (LoginBtn)
                this.Hide();
            }
            else
            {
                // Show a message box for incorrect login credentials
                MessageBox.Show("Zły login lub hasło ");
            }
        }
    }
}
