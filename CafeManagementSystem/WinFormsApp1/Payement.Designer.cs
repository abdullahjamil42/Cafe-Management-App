namespace WinFormsApp1
{
    partial class Payement
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
            ConfirmOrder = new Button();
            listView1 = new ListView();
            MenuID = new ColumnHeader();
            MenuName = new ColumnHeader();
            MenuPrice = new ColumnHeader();
            Availability = new ColumnHeader();
            Discription = new ColumnHeader();
            button1 = new Button();
            PayementOptions = new CheckedListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // ConfirmOrder
            // 
            ConfirmOrder.Location = new Point(847, 612);
            ConfirmOrder.Name = "ConfirmOrder";
            ConfirmOrder.Size = new Size(118, 29);
            ConfirmOrder.TabIndex = 1;
            ConfirmOrder.Text = "Confirm Order";
            ConfirmOrder.UseVisualStyleBackColor = true;
            ConfirmOrder.Click += ConfirmOrder_Click;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = Color.DarkOrange;
            listView1.Columns.AddRange(new ColumnHeader[] { MenuID, MenuName, MenuPrice, Availability, Discription });
            listView1.Location = new Point(19, 23);
            listView1.Margin = new Padding(30, 3, 3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(745, 458);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MenuID
            // 
            MenuID.DisplayIndex = 1;
            MenuID.Text = "              Name";
            MenuID.Width = 170;
            // 
            // MenuName
            // 
            MenuName.DisplayIndex = 0;
            MenuName.Text = "    ID";
            // 
            // MenuPrice
            // 
            MenuPrice.Text = "Unit Price";
            MenuPrice.TextAlign = HorizontalAlignment.Center;
            MenuPrice.Width = 170;
            // 
            // Availability
            // 
            Availability.Text = "Quantity";
            Availability.TextAlign = HorizontalAlignment.Center;
            Availability.Width = 170;
            // 
            // Discription
            // 
            Discription.Text = "Total Price";
            Discription.TextAlign = HorizontalAlignment.Center;
            Discription.Width = 170;
            // 
            // button1
            // 
            button1.Location = new Point(19, 612);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PayementOptions
            // 
            PayementOptions.FormattingEnabled = true;
            PayementOptions.Items.AddRange(new object[] { "Jazzcash", "Easypaisa", "Bank transaction", "Cash Payement" });
            PayementOptions.Location = new Point(820, 220);
            PayementOptions.Name = "PayementOptions";
            PayementOptions.Size = new Size(150, 92);
            PayementOptions.TabIndex = 11;
            PayementOptions.SelectedIndexChanged += PayementOptions_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(797, 315);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 12;
            label1.Text = "Select Payement method";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(784, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 143);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(849, 169);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 14;
            label2.Text = "Add Order Note";
            // 
            // Payement
            // 
            AcceptButton = ConfirmOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(PayementOptions);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(ConfirmOrder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "Payement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "a";
            Load += Payement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmOrder;
        private ListView listView1;
        private ColumnHeader MenuID;
        private ColumnHeader MenuName;
        private ColumnHeader MenuPrice;
        private ColumnHeader Discription;
        private ColumnHeader Availability;
        private Button button1;
        private CheckedListBox PayementOptions;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}