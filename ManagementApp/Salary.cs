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
    public partial class Salary : Form
    {
        Utilities Con;
        public Salary()
        {
            InitializeComponent();
            Con = new Utilities();
            DisplaySalaries();
            GetEmployees();
        }

        private void GetEmployees()
        {
            string Query = "SELECT * FROM Employees"; // Getting Employees to display
            EmployeeSO.DisplayMember = Con.GetData(Query).Columns["Name"].ToString();
            EmployeeSO.ValueMember = Con.GetData(Query).Columns["EmployeeId"].ToString();
            EmployeeSO.DataSource = Con.GetData(Query);
        }

        private void DisplaySalaries()
        {
            try
            {
                string Query = "SELECT * FROM Salaries"; // Getting all employees
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {

                throw;

            }

        }

        int d = 1;
        int Sal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "SELECT * FROM Employees WHERE EmployeeId = {0}"; // Getting Departments to display
            Query = string.Format(Query, EmployeeSO.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                Sal = Convert.ToInt32(dr["Salary"].ToString());
            }

            //  MessageBox.Show("" + Sal);
            //  EmployeeSO.DataSource = Con.GetData(Query);
            if (DaysWorked.Text == "")
            {
                SalAmount.Text = "$ " + (d * Sal);
            }
            else if (Convert.ToInt32(DaysWorked.Text) > 31)
            {
                MessageBox.Show("Days Worked Cannot be Greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysWorked.Text);
                SalAmount.Text = "$ " + (d * Sal);
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeSO.SelectedIndex == -1 || DaysWorked.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Data is Missing");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = Sal * Convert.ToInt32(DaysWorked.Text);

                    int Days = Convert.ToInt32(DaysWorked.Text);

                    string Query = "INSERT INTO Salaries VALUES ({0}, {1}, '{2}',{3}, '{4}')";
                    Query = string.Format(Query, EmployeeSO.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    DisplaySalaries();
                    MessageBox.Show("Salary has beed Paid");
                    DaysWorked.Text = "";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void EmployeeSO_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }


      

       


        // Nav to other pages

        private void SalaryTab_Click(object sender, EventArgs e)
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
        private void EmpFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
