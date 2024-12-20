namespace WinFormsApp1
{
    partial class StaffRegister
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
            StaffCreateAcc = new Button();
            CustomerTermsAndConditions = new CheckBox();
            StaffRegisterEmail = new TextBox();
            label4 = new Label();
            StaffRegisterPass2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StaffRegisterUN = new TextBox();
            StaffRegisterPass = new TextBox();
            SuspendLayout();
            // 
            // StaffCreateAcc
            // 
            StaffCreateAcc.Location = new Point(628, 399);
            StaffCreateAcc.Name = "StaffCreateAcc";
            StaffCreateAcc.Size = new Size(128, 29);
            StaffCreateAcc.TabIndex = 30;
            StaffCreateAcc.Text = "Create Account";
            StaffCreateAcc.UseVisualStyleBackColor = true;
            StaffCreateAcc.Click += StaffCreateAcc_Click;
            // 
            // CustomerTermsAndConditions
            // 
            CustomerTermsAndConditions.AutoSize = true;
            CustomerTermsAndConditions.Font = new Font("Segoe UI", 7F);
            CustomerTermsAndConditions.Location = new Point(325, 287);
            CustomerTermsAndConditions.Name = "CustomerTermsAndConditions";
            CustomerTermsAndConditions.Size = new Size(231, 19);
            CustomerTermsAndConditions.TabIndex = 29;
            CustomerTermsAndConditions.Text = "I agree to all the Terms and Conditions";
            CustomerTermsAndConditions.UseVisualStyleBackColor = true;
            CustomerTermsAndConditions.CheckedChanged += CustomerTermsAndConditions_CheckedChanged;
            // 
            // StaffRegisterEmail
            // 
            StaffRegisterEmail.Location = new Point(385, 141);
            StaffRegisterEmail.Name = "StaffRegisterEmail";
            StaffRegisterEmail.Size = new Size(171, 27);
            StaffRegisterEmail.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 148);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 27;
            label4.Text = "Enter Email";
            // 
            // StaffRegisterPass2
            // 
            StaffRegisterPass2.Location = new Point(385, 235);
            StaffRegisterPass2.Name = "StaffRegisterPass2";
            StaffRegisterPass2.Size = new Size(171, 27);
            StaffRegisterPass2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 242);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 25;
            label3.Text = "Re-enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 194);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 24;
            label2.Text = "Enter Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 101);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 23;
            label1.Text = "Enter Username";
            // 
            // StaffRegisterUN
            // 
            StaffRegisterUN.Location = new Point(385, 94);
            StaffRegisterUN.Name = "StaffRegisterUN";
            StaffRegisterUN.Size = new Size(171, 27);
            StaffRegisterUN.TabIndex = 22;
            // 
            // StaffRegisterPass
            // 
            StaffRegisterPass.Location = new Point(385, 187);
            StaffRegisterPass.Name = "StaffRegisterPass";
            StaffRegisterPass.Size = new Size(171, 27);
            StaffRegisterPass.TabIndex = 21;
            // 
            // StaffRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StaffCreateAcc);
            Controls.Add(CustomerTermsAndConditions);
            Controls.Add(StaffRegisterEmail);
            Controls.Add(label4);
            Controls.Add(StaffRegisterPass2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StaffRegisterUN);
            Controls.Add(StaffRegisterPass);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "StaffRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            Load += StaffRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StaffCreateAcc;
        private CheckBox CustomerTermsAndConditions;
        private TextBox StaffRegisterEmail;
        private Label label4;
        private TextBox StaffRegisterPass2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox StaffRegisterUN;
        private TextBox StaffRegisterPass;
    }
}