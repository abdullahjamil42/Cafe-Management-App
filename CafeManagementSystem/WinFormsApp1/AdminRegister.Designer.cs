namespace WinFormsApp1
{
    partial class AdminRegister
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
            components = new System.ComponentModel.Container();
            AdminCreateAcc = new Button();
            AdminRegisterPass = new TextBox();
            AdminRegisterUN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AdminRegisterPass2 = new TextBox();
            label4 = new Label();
            AdminRegisterEmail = new TextBox();
            TermsAndConditions = new CheckBox();
            popupWindowBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)popupWindowBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AdminCreateAcc
            // 
            AdminCreateAcc.Location = new Point(654, 409);
            AdminCreateAcc.Name = "AdminCreateAcc";
            AdminCreateAcc.Size = new Size(122, 29);
            AdminCreateAcc.TabIndex = 0;
            AdminCreateAcc.Text = "Create Account";
            AdminCreateAcc.UseVisualStyleBackColor = true;
            AdminCreateAcc.Click += AdminCreateAcc_Click;
            // 
            // AdminRegisterPass
            // 
            AdminRegisterPass.Location = new Point(395, 192);
            AdminRegisterPass.Name = "AdminRegisterPass";
            AdminRegisterPass.Size = new Size(171, 27);
            AdminRegisterPass.TabIndex = 1;
            // 
            // AdminRegisterUN
            // 
            AdminRegisterUN.Location = new Point(395, 99);
            AdminRegisterUN.Name = "AdminRegisterUN";
            AdminRegisterUN.Size = new Size(171, 27);
            AdminRegisterUN.TabIndex = 2;
            AdminRegisterUN.TextChanged += AdminRegisterUN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 106);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 199);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 247);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 5;
            label3.Text = "Re-enter Password";
            // 
            // AdminRegisterPass2
            // 
            AdminRegisterPass2.Location = new Point(395, 240);
            AdminRegisterPass2.Name = "AdminRegisterPass2";
            AdminRegisterPass2.Size = new Size(171, 27);
            AdminRegisterPass2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 153);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Enter Email";
            // 
            // AdminRegisterEmail
            // 
            AdminRegisterEmail.Location = new Point(395, 146);
            AdminRegisterEmail.Name = "AdminRegisterEmail";
            AdminRegisterEmail.Size = new Size(171, 27);
            AdminRegisterEmail.TabIndex = 8;
            // 
            // TermsAndConditions
            // 
            TermsAndConditions.AutoSize = true;
            TermsAndConditions.Font = new Font("Segoe UI", 7F);
            TermsAndConditions.Location = new Point(335, 292);
            TermsAndConditions.Name = "TermsAndConditions";
            TermsAndConditions.Size = new Size(231, 19);
            TermsAndConditions.TabIndex = 9;
            TermsAndConditions.Text = "I agree to all the Terms and Conditions";
            TermsAndConditions.UseVisualStyleBackColor = true;
            TermsAndConditions.CheckedChanged += TermsAndConditions_CheckedChanged;
            // 
            // AdminRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TermsAndConditions);
            Controls.Add(AdminRegisterEmail);
            Controls.Add(label4);
            Controls.Add(AdminRegisterPass2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminRegisterUN);
            Controls.Add(AdminRegisterPass);
            Controls.Add(AdminCreateAcc);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "AdminRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRegister";
            Load += AdminRegister_Load;
            ((System.ComponentModel.ISupportInitialize)popupWindowBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminCreateAcc;
        private TextBox AdminRegisterPass;
        private TextBox AdminRegisterUN;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AdminRegisterPass2;
        private Label label4;
        private TextBox AdminRegisterEmail;
        private CheckBox TermsAndConditions;
        private BindingSource popupWindowBindingSource;
    }
}