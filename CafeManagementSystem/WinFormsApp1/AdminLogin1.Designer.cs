namespace WinFormsApp1
{
    partial class AdminLogin1
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
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            AdminPassword = new TextBox();
            textBox1 = new TextBox();
            AdminUserName = new TextBox();
            AdminRegister = new LinkLabel();
            button2 = new Button();
            AdminLogin = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 7F);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(486, 265);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password? Click Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(460, 177);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 16;
            label2.Text = "Enter Password";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(460, 94);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 15;
            label1.Text = "Enter Email";
            // 
            // AdminPassword
            // 
            AdminPassword.BorderStyle = BorderStyle.FixedSingle;
            AdminPassword.Location = new Point(460, 200);
            AdminPassword.Name = "AdminPassword";
            AdminPassword.Size = new Size(283, 27);
            AdminPassword.TabIndex = 14;
            AdminPassword.UseSystemPasswordChar = true;
            AdminPassword.TextChanged += AdminPassword_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 13;
            // 
            // AdminUserName
            // 
            AdminUserName.BorderStyle = BorderStyle.FixedSingle;
            AdminUserName.Location = new Point(460, 120);
            AdminUserName.Name = "AdminUserName";
            AdminUserName.Size = new Size(283, 27);
            AdminUserName.TabIndex = 13;
            AdminUserName.TextChanged += textBox3_TextChanged;
            // 
            // AdminRegister
            // 
            AdminRegister.AutoSize = true;
            AdminRegister.LinkColor = Color.Navy;
            AdminRegister.Location = new Point(569, 364);
            AdminRegister.Name = "AdminRegister";
            AdminRegister.Size = new Size(186, 20);
            AdminRegister.TabIndex = 18;
            AdminRegister.TabStop = true;
            AdminRegister.Text = "New here? Click to register";
            AdminRegister.LinkClicked += AdminRegister_LinkClicked;
            // 
            // button2
            // 
            button2.Location = new Point(12, 410);
            button2.Name = "button2";
            button2.Size = new Size(94, 28);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminLogin
            // 
            AdminLogin.Location = new Point(664, 233);
            AdminLogin.Name = "AdminLogin";
            AdminLogin.Size = new Size(79, 29);
            AdminLogin.TabIndex = 20;
            AdminLogin.Text = "Login";
            AdminLogin.UseVisualStyleBackColor = true;
            AdminLogin.Click += AdminLogin_Click;
            // 
            // AdminLogin1
            // 
            AcceptButton = AdminLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_24_at_23_58_49_4db2c651;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminLogin);
            Controls.Add(button2);
            Controls.Add(AdminRegister);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminPassword);
            Controls.Add(AdminUserName);
            Controls.Add(textBox1);
            Name = "AdminLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AdminLogin1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private TextBox AdminPassword;
        private TextBox textBox1;
        private TextBox AdminUserName;
        private LinkLabel AdminRegister;
        private Button button2;
        private Button AdminLogin;
    }
}