namespace WinFormsApp1
{
    partial class Reports
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
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            NoOfOrders = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label3 = new Label();
            listView3 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label4 = new Label();
            listView4 = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label5 = new Label();
            listView5 = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label6 = new Label();
            listView6 = new ListView();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            label7 = new Label();
            listView7 = new ListView();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            label8 = new Label();
            listView8 = new ListView();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader39 = new ColumnHeader();
            listView9 = new ListView();
            columnHeader36 = new ColumnHeader();
            columnHeader37 = new ColumnHeader();
            columnHeader38 = new ColumnHeader();
            label9 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.Columns.AddRange(new ColumnHeader[] { Name, Email, NoOfOrders });
            listView1.Location = new Point(59, 34);
            listView1.Name = "listView1";
            listView1.Size = new Size(851, 86);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 200;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 300;
            // 
            // NoOfOrders
            // 
            NoOfOrders.Text = "No. of Orders";
            NoOfOrders.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "All Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "All Orders";
            label2.Click += label2_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Location = new Point(59, 143);
            listView2.Name = "listView2";
            listView2.Size = new Size(851, 85);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Amount";
            columnHeader4.Width = 155;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Customer Name";
            columnHeader5.Width = 155;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 228);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "All Workers";
            label3.Click += label3_Click;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8 });
            listView3.Location = new Point(59, 251);
            listView3.Name = "listView3";
            listView3.Size = new Size(851, 97);
            listView3.TabIndex = 4;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Name";
            columnHeader6.Width = 260;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            columnHeader7.Width = 260;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Shift";
            columnHeader8.Width = 260;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 349);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Inventory";
            label4.Click += label4_Click;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14 });
            listView4.Location = new Point(59, 372);
            listView4.Name = "listView4";
            listView4.Size = new Size(851, 92);
            listView4.TabIndex = 6;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            listView4.SelectedIndexChanged += listView4_SelectedIndexChanged;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Item Name";
            columnHeader12.Width = 250;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Quantity";
            columnHeader13.Width = 250;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Menu Item Name";
            columnHeader14.Width = 250;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 466);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Menu";
            // 
            // listView5
            // 
            listView5.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader9, columnHeader10, columnHeader11, columnHeader15, columnHeader16 });
            listView5.Location = new Point(59, 489);
            listView5.Name = "listView5";
            listView5.Size = new Size(851, 101);
            listView5.TabIndex = 8;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            listView5.SelectedIndexChanged += listView5_SelectedIndexChanged;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "ID";
            columnHeader17.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Name";
            columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Price";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Desription";
            columnHeader11.Width = 300;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Availablility";
            columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Category";
            columnHeader16.Width = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 592);
            label6.Name = "label6";
            label6.Size = new Size(237, 20);
            label6.TabIndex = 11;
            label6.Text = "Customer With more than 5 orders";
            // 
            // listView6
            // 
            listView6.Columns.AddRange(new ColumnHeader[] { columnHeader21, columnHeader22, columnHeader23 });
            listView6.Location = new Point(59, 615);
            listView6.Name = "listView6";
            listView6.Size = new Size(851, 91);
            listView6.TabIndex = 10;
            listView6.UseCompatibleStateImageBehavior = false;
            listView6.View = View.Details;
            listView6.SelectedIndexChanged += listView6_SelectedIndexChanged;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "ID";
            columnHeader21.Width = 200;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Name";
            columnHeader22.Width = 200;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Total Orders";
            columnHeader23.Width = 200;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 707);
            label7.Name = "label7";
            label7.Size = new Size(276, 20);
            label7.TabIndex = 13;
            label7.Text = "Customer With orders more than 1000 rs";
            // 
            // listView7
            // 
            listView7.Columns.AddRange(new ColumnHeader[] { columnHeader24, columnHeader25, columnHeader26 });
            listView7.Location = new Point(59, 730);
            listView7.Name = "listView7";
            listView7.Size = new Size(851, 90);
            listView7.TabIndex = 12;
            listView7.UseCompatibleStateImageBehavior = false;
            listView7.View = View.Details;
            listView7.SelectedIndexChanged += listView7_SelectedIndexChanged;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "ID";
            columnHeader24.Width = 200;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Name";
            columnHeader25.Width = 200;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Total Amount";
            columnHeader26.Width = 200;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 821);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 15;
            label8.Text = "Most Active worker";
            // 
            // listView8
            // 
            listView8.Columns.AddRange(new ColumnHeader[] { columnHeader30, columnHeader31, columnHeader39 });
            listView8.Location = new Point(59, 844);
            listView8.Name = "listView8";
            listView8.Size = new Size(851, 90);
            listView8.TabIndex = 14;
            listView8.UseCompatibleStateImageBehavior = false;
            listView8.View = View.Details;
            listView8.SelectedIndexChanged += listView8_SelectedIndexChanged;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "ID";
            columnHeader30.Width = 200;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Total Orders";
            columnHeader31.Width = 200;
            // 
            // columnHeader39
            // 
            columnHeader39.Text = "Average Amount Earned";
            columnHeader39.Width = 200;
            // 
            // listView9
            // 
            listView9.Columns.AddRange(new ColumnHeader[] { columnHeader36, columnHeader37, columnHeader38 });
            listView9.Location = new Point(59, 960);
            listView9.Name = "listView9";
            listView9.Size = new Size(851, 90);
            listView9.TabIndex = 16;
            listView9.UseCompatibleStateImageBehavior = false;
            listView9.View = View.Details;
            listView9.SelectedIndexChanged += listView9_SelectedIndexChanged;
            // 
            // columnHeader36
            // 
            columnHeader36.Text = "ID";
            columnHeader36.Width = 250;
            // 
            // columnHeader37
            // 
            columnHeader37.Text = "Name";
            columnHeader37.Width = 250;
            // 
            // columnHeader38
            // 
            columnHeader38.Text = "Orders";
            columnHeader38.Width = 250;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 937);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 17;
            label9.Text = "Best Selling items";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(label9);
            Controls.Add(listView9);
            Controls.Add(label8);
            Controls.Add(listView8);
            Controls.Add(label7);
            Controls.Add(listView7);
            Controls.Add(label6);
            Controls.Add(listView6);
            Controls.Add(label5);
            Controls.Add(listView5);
            Controls.Add(label4);
            Controls.Add(listView4);
            Controls.Add(label3);
            Controls.Add(listView3);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(label1);
            Controls.Add(listView1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            //Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private ListView listView2;
        private Label label3;
        private ListView listView3;
        private Label label4;
        private ListView listView4;
        private Label label5;
        private ListView listView5;
        private ColumnHeader Name;
        private ColumnHeader NoOfOrders;
        private ColumnHeader Email;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private Label label6;
        private ListView listView6;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private Label label7;
        private ListView listView7;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private Label label8;
        private ListView listView8;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ListView listView9;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader37;
        private ColumnHeader columnHeader38;
        private Label label9;
        private ColumnHeader columnHeader39;
    }
}