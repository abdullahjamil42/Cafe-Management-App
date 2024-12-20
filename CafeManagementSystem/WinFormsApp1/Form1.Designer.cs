namespace WinFormsApp1
{
    partial class Form1
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
            ContinueAsAdmin = new Button();
            ContinueAsStaff = new Button();
            ContinueAsCostumer = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ContinueAsAdmin
            // 
            ContinueAsAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContinueAsAdmin.BackColor = Color.DarkOrange;
            ContinueAsAdmin.FlatStyle = FlatStyle.Flat;
            ContinueAsAdmin.Location = new Point(314, 185);
            ContinueAsAdmin.Name = "ContinueAsAdmin";
            ContinueAsAdmin.Size = new Size(177, 29);
            ContinueAsAdmin.TabIndex = 0;
            ContinueAsAdmin.Text = "Continue as Admin";
            ContinueAsAdmin.UseVisualStyleBackColor = false;
            ContinueAsAdmin.Click += button1_Click;
            // 
            // ContinueAsStaff
            // 
            ContinueAsStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContinueAsStaff.BackColor = Color.DarkOrange;
            ContinueAsStaff.FlatStyle = FlatStyle.Flat;
            ContinueAsStaff.Location = new Point(314, 289);
            ContinueAsStaff.Name = "ContinueAsStaff";
            ContinueAsStaff.Size = new Size(177, 29);
            ContinueAsStaff.TabIndex = 1;
            ContinueAsStaff.Text = "Continue as Staff";
            ContinueAsStaff.UseVisualStyleBackColor = false;
            ContinueAsStaff.Click += button1_Click_1;
            // 
            // ContinueAsCostumer
            // 
            ContinueAsCostumer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContinueAsCostumer.BackColor = Color.DarkOrange;
            ContinueAsCostumer.FlatStyle = FlatStyle.Flat;
            ContinueAsCostumer.Location = new Point(314, 238);
            ContinueAsCostumer.Name = "ContinueAsCostumer";
            ContinueAsCostumer.Size = new Size(177, 29);
            ContinueAsCostumer.TabIndex = 2;
            ContinueAsCostumer.Text = "Continue as Customer";
            ContinueAsCostumer.UseVisualStyleBackColor = false;
            ContinueAsCostumer.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cover;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(ContinueAsCostumer);
            Controls.Add(ContinueAsStaff);
            Controls.Add(ContinueAsAdmin);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ContinueAsAdmin;
        private Button ContinueAsStaff;
        private Button ContinueAsCostumer;
        private PictureBox pictureBox1;
    }
}
