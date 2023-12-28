using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagment
{
    // Declaration of the Dashboard class, which is a Form
    public partial class Dashboard : Form
    {
        // Constructor for the Dashboard class
        public Dashboard()
        {
            // Initialize the form components
            InitializeComponent();

            // Create an instance of the Funkcje class
            Con = new Funkcje();

            // Call methods to display summary information
            SumExpenses();
            SumIncome();
            CountExp();
            CountInc();
        }

        // Declaration of Funkcje instance for database operations
        Funkcje Con;

        // Method to calculate and display the sum of expenses
        private void SumExpenses()
        {
            // SQL query to calculate the sum of expenses
            string Query = "select Sum(ExpAmount) from dbo.Expenses";

            // Get the result from the database using Funkcje class
            DataTable dt = Con.GetData(Query);

            // Display the sum of expenses in a label
            Wydatki.Text = dt.Rows[0][0].ToString() + " zł";
        }

        // Method to count and display the total number of expenses
        private void CountExp()
        {
            // SQL query to count the total number of expenses
            string Query = "select Count(*) from dbo.Expenses";

            // Get the result from the database using Funkcje class
            DataTable dt = Con.GetData(Query);

            // Display the total number of expenses in a label
            PodsumowanieWydatków.Text = dt.Rows[0][0].ToString();
        }

        // Method to count and display the total number of income entries
        private void CountInc()
        {
            // SQL query to count the total number of income entries
            string Query = "select Count(*) from dbo.Income";

            // Get the result from the database using Funkcje class
            DataTable dt = Con.GetData(Query);

            // Display the total number of income entries in a label
            PodsumowanieDochodu.Text = dt.Rows[0][0].ToString();
        }

        // Method to calculate and display the sum of income
        private void SumIncome()
        {
            // SQL query to calculate the sum of income
            string Query = "select Sum(IncAmt) from dbo.Income";

            // Get the result from the database using Funkcje class
            DataTable dt = Con.GetData(Query);

            // Display the sum of income in a label
            CalyDochod.Text = dt.Rows[0][0].ToString() + " zł";
        }

        // Event handler for the click event of a pictureBox (redirecting to Dochod form)
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Dochod Obj = new Dochod();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of a pictureBox (redirecting to LoginBtn form)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginBtn Obj = new LoginBtn();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of a pictureBox (redirecting to Expenses form)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void CalyDochod_Click(object sender, EventArgs e)
        {

        }
    }
}