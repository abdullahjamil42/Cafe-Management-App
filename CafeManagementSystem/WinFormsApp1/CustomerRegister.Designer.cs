namespace WinFormsApp1
{
    partial class CustomerRegister
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
            CustomerTermsAndConditions = new CheckBox();
            CustomerRegisterEmail = new TextBox();
            label4 = new Label();
            CustomerRegisterPass2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomerRegisterUN = new TextBox();
            CustomerRegisterPass = new TextBox();
            CustomerCreateAcc = new Button();
            SuspendLayout();
            // 
            // CustomerTermsAndConditions
            // 
            CustomerTermsAndConditions.AutoSize = true;
            CustomerTermsAndConditions.Font = new Font("Segoe UI", 7F);
            CustomerTermsAndConditions.Location = new Point(346, 293);
            CustomerTermsAndConditions.Name = "CustomerTermsAndConditions";
            CustomerTermsAndConditions.Size = new Size(231, 19);
            CustomerTermsAndConditions.TabIndex = 19;
            CustomerTermsAndConditions.Text = "I agree to all the Terms and Conditions";
            CustomerTermsAndConditions.UseVisualStyleBackColor = true;
            CustomerTermsAndConditions.CheckedChanged += CustomerTermsAndConditions_CheckedChanged;
            // 
            // CustomerRegisterEmail
            // 
            CustomerRegisterEmail.Location = new Point(406, 147);
            CustomerRegisterEmail.Name = "CustomerRegisterEmail";
            CustomerRegisterEmail.Size = new Size(171, 27);
            CustomerRegisterEmail.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 154);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 17;
            label4.Text = "Enter Email";
            // 
            // CustomerRegisterPass2
            // 
            CustomerRegisterPass2.Location = new Point(406, 241);
            CustomerRegisterPass2.Name = "CustomerRegisterPass2";
            CustomerRegisterPass2.Size = new Size(171, 27);
            CustomerRegisterPass2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 248);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 15;
            label3.Text = "Re-enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 200);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 14;
            label2.Text = "Enter Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 107);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 13;
            label1.Text = "Enter Username";
            // 
            // CustomerRegisterUN
            // 
            CustomerRegisterUN.Location = new Point(406, 100);
            CustomerRegisterUN.Name = "CustomerRegisterUN";
            CustomerRegisterUN.Size = new Size(171, 27);
            CustomerRegisterUN.TabIndex = 12;
            CustomerRegisterUN.TextChanged += CustomerRegisterUN_TextChanged;
            // 
            // CustomerRegisterPass
            // 
            CustomerRegisterPass.Location = new Point(406, 193);
            CustomerRegisterPass.Name = "CustomerRegisterPass";
            CustomerRegisterPass.Size = new Size(171, 27);
            CustomerRegisterPass.TabIndex = 11;
            // 
            // CustomerCreateAcc
            // 
            CustomerCreateAcc.Location = new Point(649, 405);
            CustomerCreateAcc.Name = "CustomerCreateAcc";
            CustomerCreateAcc.Size = new Size(128, 29);
            CustomerCreateAcc.TabIndex = 20;
            CustomerCreateAcc.Text = "Create Account";
            CustomerCreateAcc.UseVisualStyleBackColor = true;
            CustomerCreateAcc.Click += CustomerCreateAcc_Click;
            // 
            // CustomerRegister
            // 
            AcceptButton = CustomerCreateAcc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerCreateAcc);
            Controls.Add(CustomerTermsAndConditions);
            Controls.Add(CustomerRegisterEmail);
            Controls.Add(label4);
            Controls.Add(CustomerRegisterPass2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CustomerRegisterUN);
            Controls.Add(CustomerRegisterPass);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "CustomerRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerRegister";
            Load += CustomerRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CustomerTermsAndConditions;
        private TextBox CustomerRegisterEmail;
        private Label label4;
        private TextBox CustomerRegisterPass2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CustomerRegisterUN;
        private TextBox CustomerRegisterPass;
        private Button CustomerCreateAcc;
    }
}