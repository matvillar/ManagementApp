using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ManagementApp
{
    internal class Utilities
    {

        private SqlConnection Con;
        private SqlCommand Command;
        private DataTable DtReader;
        private SqlDataAdapter DtAdapter;
        private string ConnectStr;

        public Utilities()
        {
            // Setting up connection to Database
            ConnectStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matias\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConnectStr);
            Command = new SqlCommand();
            Command.Connection = Con;
    }
        public DataTable GetData(string Query)
        {
            DtReader = new DataTable();
            DtAdapter = new SqlDataAdapter(Query, ConnectStr); // Gets the query and the connection string 
            DtAdapter.Fill(DtReader); // Adds the data that we just pulled
            return DtReader;
        }
        public int SetData(string Query)
        {
            int count = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Command.CommandText = Query;
            count = Command.ExecuteNonQuery();
            return count;
        }

    }
}
