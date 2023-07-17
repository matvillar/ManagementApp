namespace ManagementApp
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            UpdateButton = new Button();
            AddButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            DepartNameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            EmployeeTab = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Logout = new Label();
            pictureBox4 = new PictureBox();
            DepartList = new Guna.UI2.WinForms.Guna2DataGridView();
            DeleteButton = new PictureBox();
            SalaryForm = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepartList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).BeginInit();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.ActiveBorder;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(267, 355);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(153, 51);
            UpdateButton.TabIndex = 41;
            UpdateButton.Text = "UPDATE";
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DodgerBlue;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(71, 355);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(153, 51);
            AddButton.TabIndex = 40;
            AddButton.Text = "ADD";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 731);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 22);
            panel2.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(71, 261);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 29;
            label3.Text = "Department Name:";
            // 
            // DepartNameTb
            // 
            DepartNameTb.BackColor = SystemColors.Window;
            DepartNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepartNameTb.Location = new Point(71, 292);
            DepartNameTb.Name = "DepartNameTb";
            DepartNameTb.Size = new Size(349, 29);
            DepartNameTb.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(538, 216);
            label2.Name = "label2";
            label2.Size = new Size(261, 29);
            label2.TabIndex = 26;
            label2.Text = "Manage Departments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 42);
            label1.Name = "label1";
            label1.Size = new Size(314, 39);
            label1.TabIndex = 1;
            label1.Text = "Employee System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 139);
            panel1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(1115, 261);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 42;
            label4.Text = "Department List";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(538, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            pictureBox1.Click += DeleteButton_Click;
            // 
            // EmployeeTab
            // 
            EmployeeTab.AutoSize = true;
            EmployeeTab.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeeTab.ForeColor = Color.DodgerBlue;
            EmployeeTab.Location = new Point(594, 145);
            EmployeeTab.Name = "EmployeeTab";
            EmployeeTab.Size = new Size(86, 21);
            EmployeeTab.TabIndex = 45;
            EmployeeTab.Text = "Employee";
            EmployeeTab.Click += EmployeeTab_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(771, 145);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 47;
            label6.Text = "Departments";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(715, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(899, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Logout.ForeColor = Color.DodgerBlue;
            Logout.Location = new Point(1115, 145);
            Logout.Name = "Logout";
            Logout.Size = new Size(64, 21);
            Logout.TabIndex = 51;
            Logout.Text = "Logout";
            Logout.Click += Logout_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1059, 145);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // DepartList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DepartList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DepartList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DepartList.ColumnHeadersHeight = 25;
            DepartList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DepartList.DefaultCellStyle = dataGridViewCellStyle6;
            DepartList.GridColor = Color.FromArgb(231, 229, 255);
            DepartList.Location = new Point(527, 285);
            DepartList.Name = "DepartList";
            DepartList.RowHeadersVisible = false;
            DepartList.RowHeadersWidth = 51;
            DepartList.RowTemplate.Height = 29;
            DepartList.Size = new Size(743, 372);
            DepartList.TabIndex = 52;
            DepartList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepartList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepartList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepartList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepartList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepartList.ThemeStyle.BackColor = Color.White;
            DepartList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepartList.ThemeStyle.HeaderStyle.BackColor = Color.DodgerBlue;
            DepartList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepartList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepartList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepartList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepartList.ThemeStyle.HeaderStyle.Height = 25;
            DepartList.ThemeStyle.ReadOnly = false;
            DepartList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepartList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepartList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepartList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepartList.ThemeStyle.RowsStyle.Height = 29;
            DepartList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepartList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(217, 518);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(64, 71);
            DeleteButton.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteButton.TabIndex = 54;
            DeleteButton.TabStop = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SalaryForm
            // 
            SalaryForm.AutoSize = true;
            SalaryForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SalaryForm.ForeColor = Color.DodgerBlue;
            SalaryForm.Location = new Point(955, 145);
            SalaryForm.Name = "SalaryForm";
            SalaryForm.Size = new Size(69, 21);
            SalaryForm.TabIndex = 55;
            SalaryForm.Text = "Salaries";
            SalaryForm.Click += SalaryForm_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 753);
            Controls.Add(SalaryForm);
            Controls.Add(DeleteButton);
            Controls.Add(DepartList);
            Controls.Add(Logout);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(EmployeeTab);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepartNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            Load += Departments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepartList).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateButton;
        private Button AddButton;
        private Panel panel2;
        private Label label3;
        private TextBox DepartNameTb;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label EmployeeTab;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label Logout;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2DataGridView DepartList;
        private Button button1;
        private PictureBox DeleteButton;
        private Label SalaryForm;
    }
}