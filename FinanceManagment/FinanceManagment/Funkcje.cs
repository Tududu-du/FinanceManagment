using System;
using System.Data;
using System.Data.SqlClient;

namespace FinanceManagment
{
    class Funkcje
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt = new DataTable(); // Initialize dt here
        private SqlDataAdapter Sda;
        private string ConStr;

        public Funkcje()
        {
            ConStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FinanceDB;Integrated Security=True;Connect Timeout=30;";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Sda = new SqlDataAdapter(); // Initialize Sda here if needed
        }

        public DataTable GetData(string Query)
        {
            dt.Clear(); // Clear existing data before filling new data
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
