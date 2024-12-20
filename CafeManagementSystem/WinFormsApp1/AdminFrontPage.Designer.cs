namespace WinFormsApp1
{
    partial class AdminFrontPage
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
            Button UpdateMenuItems;
            Button button2;
            Button button4;
            Button button5;
            Button button6;
            Button ManageInventory;
            SideBarTimer = new System.Windows.Forms.Timer(components);
            SideBar = new FlowLayoutPanel();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            panel7 = new Panel();
            pictureBox7 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            pictureBox9 = new PictureBox();
            UpdateMenuItems = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ManageInventory = new Button();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // UpdateMenuItems
            // 
            UpdateMenuItems.BackColor = Color.Maroon;
            UpdateMenuItems.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            UpdateMenuItems.ForeColor = Color.White;
            UpdateMenuItems.Location = new Point(-16, -13);
            UpdateMenuItems.Name = "UpdateMenuItems";
            UpdateMenuItems.Size = new Size(251, 60);
            UpdateMenuItems.TabIndex = 1;
            UpdateMenuItems.Text = "              Add Items";
            UpdateMenuItems.TextAlign = ContentAlignment.MiddleLeft;
            UpdateMenuItems.UseVisualStyleBackColor = false;
            UpdateMenuItems.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-16, -12);
            button2.Name = "button2";
            button2.Size = new Size(251, 60);
            button2.TabIndex = 1;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(-16, -13);
            button4.Name = "button4";
            button4.Size = new Size(251, 60);
            button4.TabIndex = 1;
            button4.Text = "    View Employee Shifts";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(-14, -13);
            button5.Name = "button5";
            button5.Size = new Size(251, 60);
            button5.TabIndex = 1;
            button5.Text = "     Generate Sales Report";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Maroon;
            button6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-16, -13);
            button6.Name = "button6";
            button6.Size = new Size(251, 60);
            button6.TabIndex = 1;
            button6.Text = "Update Menu        ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ManageInventory
            // 
            ManageInventory.BackColor = Color.Maroon;
            ManageInventory.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ManageInventory.ForeColor = Color.White;
            ManageInventory.Location = new Point(-18, -13);
            ManageInventory.Name = "ManageInventory";
            ManageInventory.Size = new Size(251, 60);
            ManageInventory.TabIndex = 1;
            ManageInventory.Text = "  Manage Inventory";
            ManageInventory.UseVisualStyleBackColor = false;
            ManageInventory.Click += ManageInventory_Click;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 5;
            SideBarTimer.Tick += SideBar_Tick;
            // 
            // SideBar
            // 
            SideBar.Anchor = AnchorStyles.None;
            SideBar.BackColor = Color.Maroon;
            SideBar.Controls.Add(pictureBox8);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(panel6);
            SideBar.Controls.Add(panel7);
            SideBar.Controls.Add(panel5);
            SideBar.Controls.Add(panel4);
            SideBar.Controls.Add(button1);
            SideBar.FlowDirection = FlowDirection.TopDown;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(228, 653);
            SideBar.MinimumSize = new Size(48, 653);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(48, 653);
            SideBar.TabIndex = 0;
            SideBar.Paint += flowLayoutPanel1_Paint_1;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.None;
            pictureBox8.Image = Properties.Resources.Cafe2_logo;
            pictureBox8.Location = new Point(63, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(78, 78);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 38);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.Image = Properties.Resources.clipart1587307;
            pictureBox2.Location = new Point(4, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(UpdateMenuItems);
            panel1.Location = new Point(3, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 38);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Image = Properties.Resources.clipart1587307;
            pictureBox1.Location = new Point(4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left;
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(button6);
            panel6.Location = new Point(3, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(199, 38);
            panel6.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Maroon;
            pictureBox6.Image = Properties.Resources.clipart1587307;
            pictureBox6.Location = new Point(4, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left;
            panel7.BackColor = Color.Maroon;
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(ManageInventory);
            panel7.Location = new Point(3, 219);
            panel7.Name = "panel7";
            panel7.Size = new Size(199, 38);
            panel7.TabIndex = 3;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Maroon;
            pictureBox7.Image = Properties.Resources.clipart1587307;
            pictureBox7.Location = new Point(4, 7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left;
            panel5.BackColor = Color.Maroon;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(3, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 38);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Maroon;
            pictureBox5.Image = Properties.Resources.clipart1587307;
            pictureBox5.Location = new Point(4, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(3, 307);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 38);
            panel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Maroon;
            pictureBox4.Image = Properties.Resources.clipart1587307;
            pictureBox4.Location = new Point(4, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.Menu;
            button1.Location = new Point(108, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Cafe2_logo;
            pictureBox9.Location = new Point(346, 163);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(300, 300);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // AdminFrontPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(pictureBox9);
            Controls.Add(SideBar);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "AdminFrontPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFrontPage";
            Load += AdminFrontPage_Load;
            SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer SideBarTimer;
        private FlowLayoutPanel SideBar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button UpdateMenuItems;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Panel panel7;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Button button1;
    }
}