namespace WinFormsApp1
{
    partial class StaffFrontPage
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
            Button button2;
            Button ShowAllOrders;
            Button ShowAllAcceptedOrders;
            Button button3;
            SideBar = new FlowLayoutPanel();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            pictureBox9 = new PictureBox();
            button2 = new Button();
            ShowAllOrders = new Button();
            ShowAllAcceptedOrders = new Button();
            button3 = new Button();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
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
            button2.Text = "              ";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // ShowAllOrders
            // 
            ShowAllOrders.BackColor = Color.Maroon;
            ShowAllOrders.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ShowAllOrders.ForeColor = Color.White;
            ShowAllOrders.Location = new Point(-16, -13);
            ShowAllOrders.Name = "ShowAllOrders";
            ShowAllOrders.Size = new Size(251, 60);
            ShowAllOrders.TabIndex = 1;
            ShowAllOrders.Text = "              Show All Orders";
            ShowAllOrders.TextAlign = ContentAlignment.MiddleLeft;
            ShowAllOrders.UseVisualStyleBackColor = false;
            ShowAllOrders.Click += ShowAllOrders_Click;
            // 
            // ShowAllAcceptedOrders
            // 
            ShowAllAcceptedOrders.BackColor = Color.Maroon;
            ShowAllAcceptedOrders.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ShowAllAcceptedOrders.ForeColor = Color.White;
            ShowAllAcceptedOrders.Location = new Point(-16, -13);
            ShowAllAcceptedOrders.Name = "ShowAllAcceptedOrders";
            ShowAllAcceptedOrders.Size = new Size(251, 60);
            ShowAllAcceptedOrders.TabIndex = 1;
            ShowAllAcceptedOrders.Text = "       Show Accepted Orders";
            ShowAllAcceptedOrders.UseVisualStyleBackColor = false;
            ShowAllAcceptedOrders.Click += ShowAllAcceptedOrders_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-16, -13);
            button3.Name = "button3";
            button3.Size = new Size(251, 60);
            button3.TabIndex = 1;
            button3.Text = "              Orders History";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SideBar
            // 
            SideBar.Anchor = AnchorStyles.None;
            SideBar.BackColor = Color.Maroon;
            SideBar.Controls.Add(pictureBox8);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel1);
            SideBar.Controls.Add(panel6);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(button1);
            SideBar.FlowDirection = FlowDirection.TopDown;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(228, 653);
            SideBar.MinimumSize = new Size(48, 653);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(48, 653);
            SideBar.TabIndex = 1;
            SideBar.Paint += SideBar_Paint;
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
            panel1.Controls.Add(ShowAllOrders);
            panel1.Location = new Point(3, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 38);
            panel1.TabIndex = 1;
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
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Left;
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(ShowAllAcceptedOrders);
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
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(3, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 38);
            panel3.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Maroon;
            pictureBox3.Image = Properties.Resources.clipart1587307;
            pictureBox3.Location = new Point(4, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(55, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 5;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Cafe2_logo;
            pictureBox9.Location = new Point(341, 176);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(300, 300);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // StaffFrontPage
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
            Name = "StaffFrontPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "3";
            Load += StaffFrontPage_Load;
            SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel SideBar;
        private PictureBox pictureBox8;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel6;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer SideBarTimer;
        private Button button1;
        private PictureBox pictureBox9;
        private Panel panel3;
        private PictureBox pictureBox3;
    }
}