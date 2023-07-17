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
    public partial class Employees : Form
    {
        Utilities Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Utilities();
            DisplayEmployees();
            GetDepartments();
            AddButton.Click += AddButton_Click;
        }


        private void DisplayEmployees()
        {
            try
            {
                string Query = "SELECT * FROM Employees"; // Getting all employees
                EmployeeList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {

                throw;

            }

        }


        private void GetDepartments()
        {
            string Query = "SELECT * FROM Departments"; // Getting Departments to display
            DepartSelect.DisplayMember = Con.GetData(Query).Columns["DepartName"].ToString();
            DepartSelect.ValueMember = Con.GetData(Query).Columns["DepartId"].ToString();
            DepartSelect.DataSource = Con.GetData(Query);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpFullName.Text == "" || Gender.SelectedIndex == -1 || Salary.Text == "")
                {
                    MessageBox.Show("Department name missing or invalid. ");
                }
                else
                {
                    string EmployeeName = EmpFullName.Text;
                    string EmployeeGender = Gender.SelectedItem.ToString();
                    int Department = Convert.ToInt32(DepartSelect.SelectedValue.ToString());
                    string DOB = DOBPicker.Value.ToString();
                    string StartDate = StartDateTb.Value.ToString();
                    int EmployeeSalary = Convert.ToInt32(Salary.Text);
                    string Query = "INSERT INTO Employees VALUES ('{0}', '{1}', {2},'{3}', '{4}', {5})";
                    Query = string.Format(Query, EmployeeName, EmployeeGender, Department, DOB, StartDate, EmployeeSalary);
                    Con.SetData(Query);
                    DisplayEmployees();
                    MessageBox.Show("An Employee has been Added.");
                    EmpFullName.Text = "";
                    Salary.Text = "";
                    Gender.SelectedIndex = -1;
                    DepartSelect.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpFullName.Text == "" || Gender.SelectedIndex == -1 || Salary.Text == "")
                {
                    MessageBox.Show("Department name missing or invalid. ");
                }
                else
                {
                    string EmployeeName = EmpFullName.Text;
                    string EmployeeGender = Gender.SelectedItem.ToString();
                    int Department = Convert.ToInt32(DepartSelect.SelectedValue.ToString());
                    string DOB = DOBPicker.Value.ToString();
                    string StartDate = StartDateTb.Value.ToString();
                    int EmployeeSalary = Convert.ToInt32(Salary.Text);
                    string Query = "UPDATE Employees SET Name = '{0}', Gender ='{1}', Department = {2}, DOB ='{3}', StartDate = '{4}', Salary = {5} WHERE EmployeeId = {6}";
                    Query = string.Format(Query, EmployeeName, EmployeeGender, Department, DOB, StartDate, EmployeeSalary, Key);
                    Con.SetData(Query);
                    DisplayEmployees();
                    MessageBox.Show("An Employee has been Added.");
                    EmpFullName.Text = "";
                    Salary.Text = "";
                    Gender.SelectedIndex = -1;
                    DepartSelect.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpFullName.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            Gender.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepartSelect.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBPicker.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            StartDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            Salary.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();

            if (EmpFullName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show(" invalid. ");
                }
                else
                {


                    string Query = "DELETE FROM Employees WHERE  EmployeeId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    DisplayEmployees();
                    MessageBox.Show("The Employee has been Deleted.");
                    EmpFullName.Text = "";
                    Salary.Text = "";
                    Gender.SelectedIndex = -1;
                    DepartSelect.SelectedIndex = -1;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        // Nav other pages

        private void DeptoForm_Click(object sender, EventArgs e)
        {
            Departments DeptoForm = new Departments();
            DeptoForm.Show();
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

        private void Employees_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

     
    }
}
