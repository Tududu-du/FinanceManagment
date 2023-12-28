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

// Declaration of the Dochod class, which is a Form
namespace FinanceManagment
{
    public partial class Dochod : Form
    {
        // Declaration of Funkcje instance for database operations
        Funkcje Con;

        // Constructor for the Dochod class
        public Dochod()
        {
            // Initialize the Funkcje instance
            Con = new Funkcje();

            // Initialize form components
            InitializeComponent();

            // Call method to show income entries
            ShowIncomes();
        }

        // Method to show income entries in the DataGridView
        private void ShowIncomes()
        {
            // SQL query to select all columns from the Income table
            string Query = "select * from dbo.Income";

            // Get the result from the database using Funkcje class and set it as the data source for the DataGridView
            IncomeList.DataSource = Con.GetData(Query);
        }

        // Event handler for the click event of the "Income" label (unused, can be commented or removed)
        private void Income_Click(object sender, EventArgs e)
        {
            Dochod Obj = new Dochod();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of the "Dashboard" label (redirecting to Dashboard form)
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of the pictureBox (redirecting to LoginBtn form)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginBtn Obj = new LoginBtn();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the click event of the "Dodaj" button (add income entry)
        private void Dodaj_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (IncNameBOX.Text == "" || IncValueBOX.Text == "" || CatIncBOX.Text == "" || DescIncBOX.Text == "")
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    // Extract values from input controls
                    string IncName = IncNameBOX.Text;
                    int IncAmount = Convert.ToInt32(IncValueBOX.Text);
                    string IncCategory = CatIncBOX.Text;
                    string IncDescription = DescIncBOX.Text;

                    // Format the date using the appropriate format specifier for SQL Server
                    string formattedDate = DateTab.Value.Date.ToString("yyyy-MM-dd");

                    // SQL query to insert a new income entry
                    string Query = "insert into dbo.Income values('{0}',{1},'{2}','{3}','{4}')";
                    Query = string.Format(Query, IncName, IncAmount, IncCategory, formattedDate, IncDescription);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed incomes
                    MessageBox.Show("Dochód dodany");
                    ShowIncomes();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Variable to store the selected income entry key
        int key = 0;

        // Event handler for the cell click event of the IncomeList DataGridView
        private void IncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fill text boxes with the values of the selected income entry
            IncNameBOX.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
            IncValueBOX.Text = IncomeList.SelectedRows[0].Cells[2].Value.ToString();
            CatIncBOX.Text = IncomeList.SelectedRows[0].Cells[3].Value.ToString();
            DescIncBOX.Text = IncomeList.SelectedRows[0].Cells[5].Value.ToString();

            // Store the key of the selected income entry
            if (IncNameBOX.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(IncomeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // Event handler for the click event of the "Edytuj" button (edit income entry)
        private void Edytuj_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (IncNameBOX.Text == "" || IncValueBOX.Text == "" || CatIncBOX.Text == "" || DescIncBOX.Text == "")
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    // Extract values from input controls
                    string IncName = IncNameBOX.Text;
                    int IncAmt = Convert.ToInt32(IncValueBOX.Text);
                    string IncCat = CatIncBOX.Text;
                    string IncDesc = DescIncBOX.Text;

                    // SQL query to update the selected income entry
                    string Query = "update dbo.Income set IncName='{0}',IncAmt='{1}',IncCat='{2}',IncDate='{3}',IncDesc='{4}' where IncId = {5}";
                    Query = string.Format(Query, IncName, IncAmt, IncCat, DateTab.Value.Date, IncDesc, key);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed incomes
                    MessageBox.Show("Dochód poprawiony");
                    ShowIncomes();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the click event of the "Usuń" button (delete income entry)
        private void Usuń_Click(object sender, EventArgs e)
        {
            // Check if a key has been selected
            if (key == 0)
            {
                MessageBox.Show("Wybierz dochód");
            }
            else
            {
                try
                {
                    // SQL query to delete the selected income entry
                    string Query = "delete from dbo.Income where IncId ={0}";
                    Query = string.Format(Query, key);

                    // Execute the query using Funkcje class
                    Con.SetData(Query);

                    // Show success message and refresh the displayed incomes
                    MessageBox.Show("Dochód usunięty");
                    ShowIncomes();
                }
                catch (Exception Ex)
                {
                    // Show error message if an exception occurs
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the click event of the pictureBox (unused, can be commented or removed)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Optional: Add code for pictureBox4_Click event
        }

        // Event handler for the click event of the "Expenses" pictureBox (redirecting to Expenses form)
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
    }
}
