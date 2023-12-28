using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// Declaration of the Expenses class, which is a Form
namespace FinanceManagment
{
    public partial class Expenses : Form
    {
        // Declaration of Funkcje instance for database operations
        Funkcje Con;

        // Constructor for the Expenses class
        public Expenses()
        {
            // Initialize the Funkcje instance
            Con = new Funkcje();

            // Initialize form components
            InitializeComponent();

            // Call method to show expense entries
            ShowExpenses();
        }

        // Method to show expense entries in the DataGridView
        private void ShowExpenses()
        {
            // SQL query to select all columns from the Expenses table
            string Query = "select * from dbo.Expenses ";

            // Get the result from the database using Funkcje class and set it as the data source for the DataGridView
            ExpList.DataSource = Con.GetData(Query);
        }

        // Event handler for the click event of a pictureBox (redirecting to Dochod form)
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Dochod Obj = new Dochod();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of a pictureBox (redirecting to Dashboard form)
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of a pictureBox (refreshing the Expenses form)
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of a pictureBox (redirecting to LoginBtn form)
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoginBtn Obj = new LoginBtn();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the text changed event of a textBox (unused, can be commented or removed)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add code for textBox2_TextChanged event
        }

        // Event handler for the click event of the "Dodaj" button (add expense entry)
        private void Dodaj_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (ExpNameBox.Text == "" || ExpValueBox.Text == "" || ExpCatBox.Text == "" || ExpDescBox.Text == "")
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    // Extract values from input controls
                    string ExpName = ExpNameBox.Text;
                    int ExpAmount = Convert.ToInt32(ExpValueBox.Text);
                    string ExpCat = ExpCatBox.Text;
                    string ExpDesc = ExpDescBox.Text;

                    // Format the date using the appropriate format specifier for SQL Server
                    string formattedDate = DateTab.Value.Date.ToString("yyyy-MM-dd");

                    // Explicitly mention the columns in the INSERT statement
                    string Query = "INSERT INTO dbo.Expenses (ExpName, ExpAmount, ExpCat, ExpDate, ExpDesc) VALUES('{0}', {1}, '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, ExpName, ExpAmount, ExpCat, formattedDate, ExpDesc);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed expenses
                    MessageBox.Show("Wydatek dodany");
                    ShowExpenses();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Variable to store the selected expense entry key
        int key = 0;

        // Event handler for the cell click event of the ExpList DataGridView
        private void ExpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fill text boxes with the values of the selected expense entry
            ExpNameBox.Text = ExpList.SelectedRows[0].Cells[1].Value.ToString();
            ExpValueBox.Text = ExpList.SelectedRows[0].Cells[2].Value.ToString();
            ExpCatBox.Text = ExpList.SelectedRows[0].Cells[3].Value.ToString();
            ExpDescBox.Text = ExpList.SelectedRows[0].Cells[5].Value.ToString();

            // Store the key of the selected expense entry
            if (ExpNameBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ExpList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // Event handler for the click event of the "Edytuj" button (edit expense entry)
        private void Edytuj_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (ExpNameBox.Text == "" || ExpValueBox.Text == "" || ExpCatBox.Text == "" || ExpDescBox.Text == "")
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    // Extract values from input controls
                    string ExpName = ExpNameBox.Text;
                    int ExpAmt = Convert.ToInt32(ExpValueBox.Text);
                    string ExpCat = ExpCatBox.Text;
                    string ExpDesc = ExpDescBox.Text;

                    // SQL query to update the selected expense entry
                    string Query = "UPDATE Expenses SET ExpName='{0}',ExpAmount='{1}',ExpCat='{2}',ExpDate='{3}',ExpDesc='{4}' WHERE ExpID = {5}";
                    Query = string.Format(Query, ExpName, ExpAmt, ExpCat, DateTab.Value.Date, ExpDesc, key);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed expenses
                    MessageBox.Show("Wydatek poprawiony");
                    ShowExpenses();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the click event of the "Usuñ" button (delete expense entry)
        private void Usuñ_Click(object sender, EventArgs e)
        {
            // Check if a key has been selected
            if (key == 0)
            {
                MessageBox.Show("Wybierz wydatek");
            }
            else
            {
                try
                {
                    // SQL query to delete the selected expense entry
                    string Query = "DELETE FROM dbo.Expenses WHERE ExpID ={0}";
                    Query = string.Format(Query, key);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed expenses
                    MessageBox.Show("Wydatek usuniêty");
                    ShowExpenses();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}