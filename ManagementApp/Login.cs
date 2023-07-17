namespace ManagementApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void ResetPass_Click(object sender, EventArgs e)
        {
            Username.Text = string.Empty;
            Password.Text = string.Empty;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Username.Text == string.Empty || Password.Text == string.Empty)
            {
                MessageBox.Show("Username or passoword missing.");
            }
            else if (Username.Text == "Admin" && Password.Text == "Password")
            {
                Employees EmployeeForm = new Employees();
                EmployeeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Information");
                Username.Text = string.Empty;
                Password.Text = string.Empty;
            }
        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}