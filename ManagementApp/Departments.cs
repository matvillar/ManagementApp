using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class Departments : Form
    {
        private Utilities Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Utilities();
            DisplayDepartments();
            DepartList.CellClick += DepartList_CellClick;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;



        }


        private void DisplayDepartments()
        {
            string Query = "SELECT * FROM Departments"; // Getting all deptos.
            DepartList.DataSource = Con.GetData(Query);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department name missing or invalid. ");
                }
                else
                {
                    string Depto = DepartNameTb.Text;
                    string Query = "INSERT INTO Departments VALUES ('{0}')";
                    Query = string.Format(Query, DepartNameTb.Text);
                    Con.SetData(Query);
                    DisplayDepartments();
                    MessageBox.Show("A Department has been Added.");
                    DepartNameTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public int Key = 0;
        private void DepartList_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            DepartNameTb.Text = DepartList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepartNameTb.Text == "")
            {

                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepartList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void UpdateButton_Click(Object sender, EventArgs e)
        {
            try
            {
                if (DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department name missing or invalid. ");
                }
                else
                {
                    string Depto = DepartNameTb.Text;
                    string Query = "UPDATE Departments SET DepartName = '{0}' WHERE DepartId = {1}";
                    Query = string.Format(Query, DepartNameTb.Text, Key);
                    Con.SetData(Query);
                    DisplayDepartments();
                    MessageBox.Show("A Department has been Updated.");
                    DepartNameTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                string Depto = DepartNameTb.Text;
                string Query = "DELETE FROM Departments WHERE DepartId = '{0}'";
                Query = string.Format(Query, Key);
                Con.SetData(Query);
                DisplayDepartments();
                MessageBox.Show("A Department has been Deleted.");
                DepartNameTb.Text = "";



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        // Nav other windows

        private void EmployeeTab_Click(object sender, EventArgs e)
        {
            Employees EmployeeForm = new Employees();
            EmployeeForm.Show();
            this.Hide();
        }

        private void SalaryForm_Click(object sender, EventArgs e)
        {
            Salary SalaryForm = new Salary();
            SalaryForm.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }












        // Created by mistake 


        private void Departments_Load(object sender, EventArgs e)
        {

        }

      
    }
}
