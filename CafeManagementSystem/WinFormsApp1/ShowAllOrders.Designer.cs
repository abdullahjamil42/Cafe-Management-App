namespace WinFormsApp1
{
    partial class ShowAllOrders
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
            listView1 = new ListView();
            ID = new ColumnHeader();
            Date = new ColumnHeader();
            Status = new ColumnHeader();
            Amount = new ColumnHeader();
            CustomerName = new ColumnHeader();
            SideNote = new ColumnHeader();
            AcceptOrder = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            ShowOrderDetails = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = Color.DarkOrange;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Date, Status, Amount, CustomerName, SideNote });
            listView1.Location = new Point(12, 91);
            listView1.Margin = new Padding(30, 3, 3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(958, 451);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "            ID";
            ID.Width = 120;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.TextAlign = HorizontalAlignment.Center;
            Date.Width = 120;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.TextAlign = HorizontalAlignment.Center;
            Status.Width = 120;
            // 
            // Amount
            // 
            Amount.Text = "Amount";
            Amount.Width = 120;
            // 
            // CustomerName
            // 
            CustomerName.Text = "Customer Name";
            CustomerName.TextAlign = HorizontalAlignment.Center;
            CustomerName.Width = 120;
            // 
            // SideNote
            // 
            SideNote.Text = "Side Note";
            SideNote.TextAlign = HorizontalAlignment.Center;
            SideNote.Width = 500;
            // 
            // AcceptOrder
            // 
            AcceptOrder.Location = new Point(856, 548);
            AcceptOrder.Name = "AcceptOrder";
            AcceptOrder.Size = new Size(114, 29);
            AcceptOrder.TabIndex = 11;
            AcceptOrder.Text = "Accept Order";
            AcceptOrder.TextAlign = ContentAlignment.MiddleRight;
            AcceptOrder.UseVisualStyleBackColor = true;
            AcceptOrder.Click += AcceptOrder_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 612);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox13);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 85);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(89, 8);
            label7.Name = "label7";
            label7.Size = new Size(267, 61);
            label7.TabIndex = 1;
            label7.Text = "Fast Cafeteria";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.cafe_logo2;
            pictureBox13.Location = new Point(3, -1);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(80, 80);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // ShowOrderDetails
            // 
            ShowOrderDetails.Location = new Point(694, 548);
            ShowOrderDetails.Name = "ShowOrderDetails";
            ShowOrderDetails.Size = new Size(156, 29);
            ShowOrderDetails.TabIndex = 18;
            ShowOrderDetails.Text = "Show Order Details";
            ShowOrderDetails.UseVisualStyleBackColor = true;
            ShowOrderDetails.Click += ShowOrderDetails_Click;
            // 
            // ShowAllOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(ShowOrderDetails);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(AcceptOrder);
            Controls.Add(listView1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "ShowAllOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowAllOrders";
            Load += ShowAllOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Date;
        private ColumnHeader Status;
        private ColumnHeader CustomerName;
        private ColumnHeader SideNote;
        private Button AcceptOrder;
        private Button button1;
        private ColumnHeader Amount;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox13;
        private Button ShowOrderDetails;
    }
}