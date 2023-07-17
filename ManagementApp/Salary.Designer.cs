namespace ManagementApp
{
    partial class Salary
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            label1 = new Label();
            SalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            PeriodTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            UpdateButton = new Button();
            AddButton = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Logout = new Label();
            pictureBox4 = new PictureBox();
            SalaryTab = new Label();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            EmployeeTab = new Label();
            pictureBox1 = new PictureBox();
            DaysWorked = new TextBox();
            SalAmount = new TextBox();
            EmployeeSO = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(446, 38);
            label1.Name = "label1";
            label1.Size = new Size(314, 39);
            label1.TabIndex = 1;
            label1.Text = "Employee System";
            // 
            // SalaryList
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            SalaryList.ColumnHeadersHeight = 25;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle9;
            SalaryList.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.Location = new Point(292, 219);
            SalaryList.Margin = new Padding(3, 2, 3, 2);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersVisible = false;
            SalaryList.RowHeadersWidth = 51;
            SalaryList.RowTemplate.Height = 29;
            SalaryList.Size = new Size(905, 319);
            SalaryList.TabIndex = 89;
            SalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalaryList.ThemeStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            SalaryList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalaryList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryList.ThemeStyle.HeaderStyle.Height = 25;
            SalaryList.ThemeStyle.ReadOnly = false;
            SalaryList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.ThemeStyle.RowsStyle.Height = 29;
            SalaryList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // PeriodTb
            // 
            PeriodTb.BackColor = Color.Transparent;
            PeriodTb.Checked = true;
            PeriodTb.CustomizableEdges = customizableEdges5;
            PeriodTb.FillColor = SystemColors.Highlight;
            PeriodTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodTb.Format = DateTimePickerFormat.Short;
            PeriodTb.Location = new Point(29, 338);
            PeriodTb.Margin = new Padding(3, 2, 3, 2);
            PeriodTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PeriodTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PeriodTb.Size = new Size(229, 25);
            PeriodTb.TabIndex = 87;
            PeriodTb.Value = new DateTime(2023, 7, 11, 0, 0, 0, 0);
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.ActiveBorder;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(151, 500);
            UpdateButton.Margin = new Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(106, 38);
            UpdateButton.TabIndex = 78;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DodgerBlue;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(28, 500);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(106, 38);
            AddButton.TabIndex = 77;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 609);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1236, 16);
            panel2.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(28, 381);
            label7.Name = "label7";
            label7.Size = new Size(128, 21);
            label7.TabIndex = 71;
            label7.Text = "Salary Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(28, 315);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 70;
            label6.Text = "Period:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(28, 255);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 68;
            label4.Text = "Days Worked:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(28, 196);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 67;
            label3.Text = "Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(292, 174);
            label2.Name = "label2";
            label2.Size = new Size(243, 29);
            label2.TabIndex = 65;
            label2.Text = "Manage Employees";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 107);
            panel1.TabIndex = 64;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.DodgerBlue;
            Logout.Location = new Point(873, 122);
            Logout.Name = "Logout";
            Logout.Size = new Size(64, 21);
            Logout.TabIndex = 99;
            Logout.Text = "Logout";
            Logout.Click += Logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(824, 122);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 98;
            pictureBox4.TabStop = false;
            // 
            // SalaryTab
            // 
            SalaryTab.AutoSize = true;
            SalaryTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SalaryTab.ForeColor = Color.DodgerBlue;
            SalaryTab.Location = new Point(752, 122);
            SalaryTab.Name = "SalaryTab";
            SalaryTab.Size = new Size(58, 21);
            SalaryTab.TabIndex = 97;
            SalaryTab.Text = "Salary";
            SalaryTab.Click += SalaryTab_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(704, 122);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 96;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(572, 122);
            label11.Name = "label11";
            label11.Size = new Size(109, 21);
            label11.TabIndex = 95;
            label11.Text = "Departments";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(523, 122);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // EmployeeTab
            // 
            EmployeeTab.AutoSize = true;
            EmployeeTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeTab.ForeColor = Color.DodgerBlue;
            EmployeeTab.Location = new Point(417, 122);
            EmployeeTab.Name = "EmployeeTab";
            EmployeeTab.Size = new Size(86, 21);
            EmployeeTab.TabIndex = 93;
            EmployeeTab.Text = "Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(368, 122);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            // 
            // DaysWorked
            // 
            DaysWorked.BackColor = SystemColors.Window;
            DaysWorked.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DaysWorked.Location = new Point(28, 278);
            DaysWorked.Margin = new Padding(3, 2, 3, 2);
            DaysWorked.Name = "DaysWorked";
            DaysWorked.Size = new Size(230, 29);
            DaysWorked.TabIndex = 100;
            // 
            // SalAmount
            // 
            SalAmount.BackColor = SystemColors.Control;
            SalAmount.BorderStyle = BorderStyle.None;
            SalAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SalAmount.ForeColor = Color.DodgerBlue;
            SalAmount.Location = new Point(27, 404);
            SalAmount.Margin = new Padding(3, 2, 3, 2);
            SalAmount.Name = "SalAmount";
            SalAmount.Size = new Size(230, 32);
            SalAmount.TabIndex = 102;
            SalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // EmployeeSO
            // 
            EmployeeSO.FormattingEnabled = true;
            EmployeeSO.Location = new Point(30, 219);
            EmployeeSO.Name = "EmployeeSO";
            EmployeeSO.Size = new Size(228, 23);
            EmployeeSO.TabIndex = 103;
            EmployeeSO.SelectedIndexChanged += EmployeeSO_SelectedIndexChanged;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 625);
            Controls.Add(EmployeeSO);
            Controls.Add(SalAmount);
            Controls.Add(DaysWorked);
            Controls.Add(Logout);
            Controls.Add(pictureBox4);
            Controls.Add(SalaryTab);
            Controls.Add(pictureBox3);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(EmployeeTab);
            Controls.Add(pictureBox1);
            Controls.Add(SalaryList);
            Controls.Add(PeriodTb);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Salary";
            Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryList;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodTb;
        private Button UpdateButton;
        private Button AddButton;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label Logout;
        private PictureBox pictureBox4;
        private Label SalaryTab;
        private PictureBox pictureBox3;
        private Label label11;
        private PictureBox pictureBox2;
        private Label EmployeeTab;
        private PictureBox pictureBox1;
        private TextBox DaysWorked;
        private TextBox SalAmount;
        private ComboBox EmployeeSO;
    }
}