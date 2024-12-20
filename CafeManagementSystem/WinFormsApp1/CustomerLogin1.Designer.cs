namespace WinFormsApp1
{
    partial class CustomerLogin1
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
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            CustomerUserName = new TextBox();
            button1 = new Button();
            CustomerLogin = new Button();
            CustomerPassword = new TextBox();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Navy;
            linkLabel2.Location = new Point(561, 374);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(186, 20);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "New here? Click to register";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI", 7F);
            linkLabel3.LinkColor = Color.Navy;
            linkLabel3.Location = new Point(478, 275);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(157, 15);
            linkLabel3.TabIndex = 25;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forgot Password? Click Here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(452, 187);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 24;
            label3.Text = "Enter Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(452, 104);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 23;
            label4.Text = "Enter Email";
            // 
            // CustomerUserName
            // 
            CustomerUserName.Location = new Point(452, 130);
            CustomerUserName.Name = "CustomerUserName";
            CustomerUserName.Size = new Size(283, 27);
            CustomerUserName.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(12, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 27;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerLogin
            // 
            CustomerLogin.Location = new Point(655, 248);
            CustomerLogin.Name = "CustomerLogin";
            CustomerLogin.Size = new Size(80, 29);
            CustomerLogin.TabIndex = 28;
            CustomerLogin.Text = "Login";
            CustomerLogin.UseVisualStyleBackColor = true;
            CustomerLogin.Click += CustomerLogin_Click;
            // 
            // CustomerPassword
            // 
            CustomerPassword.BorderStyle = BorderStyle.FixedSingle;
            CustomerPassword.Location = new Point(452, 213);
            CustomerPassword.Name = "CustomerPassword";
            CustomerPassword.Size = new Size(283, 27);
            CustomerPassword.TabIndex = 29;
            CustomerPassword.UseSystemPasswordChar = true;
            // 
            // CustomerLogin1
            // 
            AcceptButton = CustomerLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_24_at_23_58_49_4db2c651;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerPassword);
            Controls.Add(CustomerLogin);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(CustomerUserName);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "CustomerLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B";
            Load += CostumerLogin1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label3;
        private Label label4;
        private TextBox CustomerUserName;
        private Button button1;
        private Button CustomerLogin;
        private TextBox CustomerPassword;
    }
}