namespace WinFormsApp1
{
    partial class StaffLogin1
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
            CustomerRegister = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            StaffLoginPass = new TextBox();
            StaffLoginName = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // CustomerRegister
            // 
            CustomerRegister.AutoSize = true;
            CustomerRegister.LinkColor = Color.Navy;
            CustomerRegister.Location = new Point(563, 361);
            CustomerRegister.Name = "CustomerRegister";
            CustomerRegister.Size = new Size(186, 20);
            CustomerRegister.TabIndex = 26;
            CustomerRegister.TabStop = true;
            CustomerRegister.Text = "New here? Click to register";
            CustomerRegister.LinkClicked += CustomerRegister_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 7F);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(480, 262);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password? Click Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(454, 174);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 24;
            label2.Text = "Enter Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(454, 91);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 23;
            label1.Text = "Enter Email ";
            label1.Click += label1_Click;
            // 
            // StaffLoginPass
            // 
            StaffLoginPass.BorderStyle = BorderStyle.FixedSingle;
            StaffLoginPass.Location = new Point(454, 197);
            StaffLoginPass.Name = "StaffLoginPass";
            StaffLoginPass.Size = new Size(283, 27);
            StaffLoginPass.TabIndex = 22;
            StaffLoginPass.UseSystemPasswordChar = true;
            // 
            // StaffLoginName
            // 
            StaffLoginName.BorderStyle = BorderStyle.FixedSingle;
            StaffLoginName.Location = new Point(454, 117);
            StaffLoginName.Name = "StaffLoginName";
            StaffLoginName.Size = new Size(283, 27);
            StaffLoginName.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(643, 254);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 415);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StaffLogin1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_24_at_23_58_49_4db2c651;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(CustomerRegister);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StaffLoginPass);
            Controls.Add(StaffLoginName);
            Controls.Add(textBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "StaffLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffLogin1";
            Load += StaffLogin1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel CustomerRegister;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private TextBox StaffLoginPass;
        private TextBox StaffLoginName;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}