namespace ManagementApp
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpFullName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Salary = new TextBox();
            panel2 = new Panel();
            Gender = new ComboBox();
            DepartSelect = new ComboBox();
            AddButton = new Button();
            UpdateButton = new Button();
            Logout = new Label();
            pictureBox4 = new PictureBox();
            SalaryForm = new Label();
            pictureBox3 = new PictureBox();
            DeptoForm = new Label();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            DOBPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            StartDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            DeleteButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 143);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(510, 50);
            label1.Name = "label1";
            label1.Size = new Size(314, 39);
            label1.TabIndex = 1;
            label1.Text = "Employee System";
            label1.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(314, 225);
            label2.Name = "label2";
            label2.Size = new Size(243, 29);
            label2.TabIndex = 2;
            label2.Text = "Manage Employees";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(25, 233);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 7;
            label3.Text = "Full Name:";
            label3.Click += label3_Click;
            // 
            // EmpFullName
            // 
            EmpFullName.BackColor = SystemColors.Window;
            EmpFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpFullName.Location = new Point(25, 264);
            EmpFullName.Name = "EmpFullName";
            EmpFullName.Size = new Size(262, 29);
            EmpFullName.TabIndex = 6;
            EmpFullName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(25, 311);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 9;
            label4.Text = "Gender:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(25, 387);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 11;
            label5.Text = "Department:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(25, 465);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 13;
            label6.Text = "Birthdate:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(25, 539);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 15;
            label7.Text = "Starting Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(25, 614);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 17;
            label8.Text = "Salary:";
            // 
            // Salary
            // 
            Salary.BackColor = SystemColors.Window;
            Salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Salary.Location = new Point(25, 645);
            Salary.Name = "Salary";
            Salary.Size = new Size(262, 29);
            Salary.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 778);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 22);
            panel2.TabIndex = 19;
            // 
            // Gender
            // 
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Pick an Option", "Male", "Female" });
            Gender.Location = new Point(25, 342);
            Gender.Name = "Gender";
            Gender.Size = new Size(262, 28);
            Gender.TabIndex = 20;
            // 
            // DepartSelect
            // 
            DepartSelect.FormattingEnabled = true;
            DepartSelect.Items.AddRange(new object[] { "Male", "Female" });
            DepartSelect.Location = new Point(25, 418);
            DepartSelect.Name = "DepartSelect";
            DepartSelect.Size = new Size(262, 28);
            DepartSelect.TabIndex = 21;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DodgerBlue;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(25, 704);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(121, 51);
            AddButton.TabIndex = 23;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += button1_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.ActiveBorder;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(166, 704);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(121, 51);
            UpdateButton.TabIndex = 24;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.DodgerBlue;
            Logout.Location = new Point(1117, 162);
            Logout.Name = "Logout";
            Logout.Size = new Size(64, 21);
            Logout.TabIndex = 59;
            Logout.Text = "Logout";
            Logout.Click += Logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1061, 162);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            // 
            // SalaryForm
            // 
            SalaryForm.AutoSize = true;
            SalaryForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SalaryForm.ForeColor = Color.DodgerBlue;
            SalaryForm.Location = new Point(979, 162);
            SalaryForm.Name = "SalaryForm";
            SalaryForm.Size = new Size(58, 21);
            SalaryForm.TabIndex = 57;
            SalaryForm.Text = "Salary";
            SalaryForm.Click += SalaryForm_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(923, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // DeptoForm
            // 
            DeptoForm.AutoSize = true;
            DeptoForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeptoForm.ForeColor = Color.DodgerBlue;
            DeptoForm.Location = new Point(773, 162);
            DeptoForm.Name = "DeptoForm";
            DeptoForm.Size = new Size(109, 21);
            DeptoForm.TabIndex = 55;
            DeptoForm.Text = "Departments";
            DeptoForm.Click += DeptoForm_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(717, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(596, 162);
            label12.Name = "label12";
            label12.Size = new Size(86, 21);
            label12.TabIndex = 53;
            label12.Text = "Employee";
            label12.Click += label12_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(540, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // DOBPicker
            // 
            DOBPicker.BackColor = Color.Transparent;
            DOBPicker.Checked = true;
            DOBPicker.CustomizableEdges = customizableEdges5;
            DOBPicker.FillColor = SystemColors.Highlight;
            DOBPicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBPicker.Format = DateTimePickerFormat.Short;
            DOBPicker.Location = new Point(25, 496);
            DOBPicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBPicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DOBPicker.Name = "DOBPicker";
            DOBPicker.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DOBPicker.Size = new Size(262, 33);
            DOBPicker.TabIndex = 60;
            DOBPicker.Value = new DateTime(2023, 7, 11, 0, 0, 0, 0);
            DOBPicker.ValueChanged += DOBPicker_ValueChanged;
            // 
            // StartDateTb
            // 
            StartDateTb.BackColor = Color.White;
            StartDateTb.Checked = true;
            StartDateTb.CustomizableEdges = customizableEdges7;
            StartDateTb.FillColor = SystemColors.Highlight;
            StartDateTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartDateTb.Format = DateTimePickerFormat.Long;
            StartDateTb.Location = new Point(25, 570);
            StartDateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            StartDateTb.MinDate = new DateTime(2023, 7, 11, 0, 0, 0, 0);
            StartDateTb.Name = "StartDateTb";
            StartDateTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            StartDateTb.Size = new Size(262, 33);
            StartDateTb.TabIndex = 61;
            StartDateTb.Value = new DateTime(2023, 7, 11, 0, 0, 0, 0);
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            EmployeeList.ColumnHeadersHeight = 25;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle6;
            EmployeeList.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.Location = new Point(336, 264);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersVisible = false;
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.RowTemplate.Height = 29;
            EmployeeList.Size = new Size(1034, 387);
            EmployeeList.TabIndex = 62;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeList.ThemeStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeList.ThemeStyle.HeaderStyle.Height = 25;
            EmployeeList.ThemeStyle.ReadOnly = false;
            EmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.ThemeStyle.RowsStyle.Height = 29;
            EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(835, 669);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(64, 71);
            DeleteButton.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteButton.TabIndex = 63;
            DeleteButton.TabStop = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 800);
            Controls.Add(DeleteButton);
            Controls.Add(EmployeeList);
            Controls.Add(StartDateTb);
            Controls.Add(DOBPicker);
            Controls.Add(Logout);
            Controls.Add(pictureBox4);
            Controls.Add(SalaryForm);
            Controls.Add(pictureBox3);
            Controls.Add(DeptoForm);
            Controls.Add(pictureBox2);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(DepartSelect);
            Controls.Add(Gender);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(Salary);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpFullName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpFullName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Salary;
        private Panel panel2;
        private ComboBox Gender;
        private ComboBox DepartSelect;
        private Button AddButton;
        private Button UpdateButton;
        private Label Logout;
        private PictureBox pictureBox4;
        private Label SalaryForm;
        private PictureBox pictureBox3;
        private Label DeptoForm;
        private PictureBox pictureBox2;
        private Label label12;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBPicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDateTb;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private PictureBox DeleteButton;
    }
}