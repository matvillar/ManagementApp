namespace ManagementApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            Username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Password = new TextBox();
            LoginButton = new Button();
            ResetPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 637);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            // 
            // Username
            // 
            Username.BackColor = SystemColors.Window;
            Username.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(595, 368);
            Username.Name = "Username";
            Username.Size = new Size(295, 38);
            Username.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(595, 335);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(595, 427);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Window;
            Password.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(595, 460);
            Password.Name = "Password";
            Password.Size = new Size(295, 38);
            Password.TabIndex = 9;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DodgerBlue;
            LoginButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(662, 515);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(162, 47);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ResetPass
            // 
            ResetPass.AutoSize = true;
            ResetPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ResetPass.ForeColor = Color.DodgerBlue;
            ResetPass.Location = new Point(679, 565);
            ResetPass.Name = "ResetPass";
            ResetPass.Size = new Size(134, 20);
            ResetPass.TabIndex = 12;
            ResetPass.Text = "Forgot Password?";
            ResetPass.Click += ResetPass_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1135, 637);
            Controls.Add(ResetPass);
            Controls.Add(LoginButton);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox Username;
        private Label label2;
        private Label label3;
        private TextBox Password;
        private Button LoginButton;
        private Label ResetPass;
    }
}