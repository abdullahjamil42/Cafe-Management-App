namespace WinFormsApp1
{
    partial class CustomerFrontPage
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
            Button button3;
            Button ShowAllOrders;
            Button ShowAllAcceptedOrders;
            Button button5;
            Button button6;
            panel1 = new Panel();
            pictureBox14 = new PictureBox();
            label27 = new Label();
            button1 = new Button();
            Search = new TextBox();
            label1 = new Label();
            pictureBox13 = new PictureBox();
            listView1 = new ListView();
            MenuID = new ColumnHeader();
            MenuName = new ColumnHeader();
            MenuPrice = new ColumnHeader();
            Discription = new ColumnHeader();
            Availability = new ColumnHeader();
            Category = new ColumnHeader();
            imageList1 = new ImageList(components);
            AddtoCart = new Button();
            button2 = new Button();
            SideBar = new FlowLayoutPanel();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            pictureBox9 = new PictureBox();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            button3 = new Button();
            ShowAllOrders = new Button();
            ShowAllAcceptedOrders = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-16, -12);
            button3.Name = "button3";
            button3.Size = new Size(251, 60);
            button3.TabIndex = 1;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // ShowAllOrders
            // 
            ShowAllOrders.BackColor = Color.Maroon;
            ShowAllOrders.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ShowAllOrders.ForeColor = Color.White;
            ShowAllOrders.Location = new Point(-14, -9);
            ShowAllOrders.Name = "ShowAllOrders";
            ShowAllOrders.Size = new Size(251, 76);
            ShowAllOrders.TabIndex = 1;
            ShowAllOrders.Text = "              Show Orders History\r\n\r\n";
            ShowAllOrders.TextAlign = ContentAlignment.MiddleLeft;
            ShowAllOrders.UseVisualStyleBackColor = false;
            ShowAllOrders.Click += ShowAllOrders_Click;
            // 
            // ShowAllAcceptedOrders
            // 
            ShowAllAcceptedOrders.BackColor = Color.Maroon;
            ShowAllAcceptedOrders.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            ShowAllAcceptedOrders.ForeColor = Color.White;
            ShowAllAcceptedOrders.Location = new Point(-14, -7);
            ShowAllAcceptedOrders.Name = "ShowAllAcceptedOrders";
            ShowAllAcceptedOrders.Size = new Size(251, 60);
            ShowAllAcceptedOrders.TabIndex = 1;
            ShowAllAcceptedOrders.Text = "              Show Cart";
            ShowAllAcceptedOrders.TextAlign = ContentAlignment.MiddleLeft;
            ShowAllAcceptedOrders.UseVisualStyleBackColor = false;
            ShowAllAcceptedOrders.Click += ShowAllAcceptedOrders_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(-16, -13);
            button5.Name = "button5";
            button5.Size = new Size(251, 60);
            button5.TabIndex = 12;
            button5.Text = "              Give Feedback";
            button5.TextAlign = ContentAlignment.MiddleLeft;
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
            button6.TabIndex = 14;
            button6.Text = "              View Feedbacks";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox14);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox13);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 124);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.cart;
            pictureBox14.Location = new Point(914, 29);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(48, 47);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Orange;
            label27.Location = new Point(591, 75);
            label27.Name = "label27";
            label27.Size = new Size(81, 17);
            label27.TabIndex = 5;
            label27.Text = "Search Food";
            // 
            // button1
            // 
            button1.Location = new Point(819, 41);
            button1.Name = "button1";
            button1.Size = new Size(64, 27);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Search
            // 
            Search.Location = new Point(588, 41);
            Search.Name = "Search";
            Search.Size = new Size(225, 27);
            Search.TabIndex = 2;
            Search.TextChanged += Search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 22);
            label1.Name = "label1";
            label1.Size = new Size(267, 61);
            label1.TabIndex = 1;
            label1.Text = "Fast Cafeteria";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.cafe_logo2;
            pictureBox13.Location = new Point(48, -1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(130, 130);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = Color.DarkOrange;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { MenuID, MenuName, MenuPrice, Discription, Availability, Category });
            listView1.LabelEdit = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(72, 164);
            listView1.Margin = new Padding(30, 3, 3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(890, 422);
            listView1.SmallImageList = imageList1;
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MenuID
            // 
            MenuID.Text = "                           ID";
            MenuID.Width = 160;
            // 
            // MenuName
            // 
            MenuName.Text = "Name";
            MenuName.TextAlign = HorizontalAlignment.Center;
            MenuName.Width = 100;
            // 
            // MenuPrice
            // 
            MenuPrice.Text = "Price";
            MenuPrice.TextAlign = HorizontalAlignment.Center;
            MenuPrice.Width = 100;
            // 
            // Discription
            // 
            Discription.Text = "Discription";
            Discription.TextAlign = HorizontalAlignment.Center;
            Discription.Width = 320;
            // 
            // Availability
            // 
            Availability.Text = "Category";
            Availability.TextAlign = HorizontalAlignment.Center;
            Availability.Width = 100;
            // 
            // Category
            // 
            Category.Text = "Availability";
            Category.TextAlign = HorizontalAlignment.Center;
            Category.Width = 100;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(80, 80);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // AddtoCart
            // 
            AddtoCart.AutoSize = true;
            AddtoCart.BackColor = SystemColors.Control;
            AddtoCart.Font = new Font("Segoe UI", 9F);
            AddtoCart.ForeColor = Color.Black;
            AddtoCart.Location = new Point(853, 592);
            AddtoCart.Name = "AddtoCart";
            AddtoCart.Size = new Size(110, 32);
            AddtoCart.TabIndex = 8;
            AddtoCart.Text = "Add To Cart";
            AddtoCart.UseVisualStyleBackColor = false;
            AddtoCart.Click += button2_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(55, 307);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 9;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // SideBar
            // 
            SideBar.Anchor = AnchorStyles.None;
            SideBar.BackColor = Color.Maroon;
            SideBar.Controls.Add(pictureBox8);
            SideBar.Controls.Add(panel2);
            SideBar.Controls.Add(panel3);
            SideBar.Controls.Add(panel6);
            SideBar.Controls.Add(panel5);
            SideBar.Controls.Add(panel7);
            SideBar.Controls.Add(button2);
            SideBar.FlowDirection = FlowDirection.TopDown;
            SideBar.Location = new Point(0, 0);
            SideBar.MaximumSize = new Size(228, 653);
            SideBar.MinimumSize = new Size(48, 653);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(48, 653);
            SideBar.TabIndex = 7;
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
            pictureBox8.Click += pictureBox8_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button3);
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(ShowAllOrders);
            panel3.Location = new Point(3, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 38);
            panel3.TabIndex = 1;
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
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(ShowAllAcceptedOrders);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(3, 175);
            panel6.Name = "panel6";
            panel6.Size = new Size(199, 38);
            panel6.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Maroon;
            pictureBox4.Image = Properties.Resources.clipart1587307;
            pictureBox4.Location = new Point(4, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Maroon;
            pictureBox6.Image = Properties.Resources.clipart1587307;
            pictureBox6.Location = new Point(6, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left;
            panel5.BackColor = Color.Maroon;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(3, 219);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 38);
            panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Maroon;
            pictureBox5.Image = Properties.Resources.clipart1587307;
            pictureBox5.Location = new Point(4, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left;
            panel7.BackColor = Color.Maroon;
            panel7.Controls.Add(pictureBox9);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 263);
            panel7.Name = "panel7";
            panel7.Size = new Size(199, 38);
            panel7.TabIndex = 5;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Maroon;
            pictureBox9.Image = Properties.Resources.clipart1587307;
            pictureBox9.Location = new Point(4, 7);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 5;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Drinks", "Beverages", "Deserts" });
            comboBox1.Location = new Point(818, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CustomerFrontPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(comboBox1);
            Controls.Add(SideBar);
            Controls.Add(AddtoCart);
            Controls.Add(listView1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "CustomerFrontPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerFrontPage";
            Load += CustomerFrontPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label27;
        private Button button1;
        private TextBox Search;
        private Label label1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private ListView listView1;
        private ColumnHeader MenuName;
        private ColumnHeader MenuPrice;
        private ColumnHeader Discription;
        private ColumnHeader Availability;
        private ColumnHeader Category;
        private ImageList imageList1;
        private Button AddtoCart;
        private ColumnHeader MenuID;
        private Button button2;
        private FlowLayoutPanel SideBar;
        private PictureBox pictureBox8;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel6;
        private System.Windows.Forms.Timer SideBarTimer;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel5;
        private Panel panel7;
        private PictureBox pictureBox9;
        private ComboBox comboBox1;
    }
}