namespace WinFormsApp1
{
    partial class Inventory
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
            AddInventoryMenuID = new TextBox();
            AddInventoryQuantity = new TextBox();
            AddInventoryName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            InventoryID = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            MenuItemInventory = new ColumnHeader();
            InventoryItem = new ColumnHeader();
            InventoryQuantitiy = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            inventoryDelete = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // AddInventoryMenuID
            // 
            AddInventoryMenuID.Location = new Point(30, 185);
            AddInventoryMenuID.Name = "AddInventoryMenuID";
            AddInventoryMenuID.Size = new Size(195, 27);
            AddInventoryMenuID.TabIndex = 0;
            AddInventoryMenuID.TextChanged += AddInventoryMenuID_TextChanged;
            // 
            // AddInventoryQuantity
            // 
            AddInventoryQuantity.Location = new Point(30, 311);
            AddInventoryQuantity.Name = "AddInventoryQuantity";
            AddInventoryQuantity.Size = new Size(195, 27);
            AddInventoryQuantity.TabIndex = 1;
            // 
            // AddInventoryName
            // 
            AddInventoryName.Location = new Point(30, 251);
            AddInventoryName.Name = "AddInventoryName";
            AddInventoryName.Size = new Size(195, 27);
            AddInventoryName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 162);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter Menu Item ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 228);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter Inventory item name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 288);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 5;
            label3.Text = "Enter Quantity";
            // 
            // listView1
            // 
            listView1.BackColor = Color.DarkOrange;
            listView1.Columns.AddRange(new ColumnHeader[] { InventoryID, columnHeader1, MenuItemInventory, InventoryItem, InventoryQuantitiy });
            listView1.Location = new Point(256, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(698, 389);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // InventoryID
            // 
            InventoryID.Text = "Inventory ID";
            InventoryID.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Menu Item ID";
            columnHeader1.Width = 120;
            // 
            // MenuItemInventory
            // 
            MenuItemInventory.Text = "Menu Item";
            MenuItemInventory.Width = 120;
            // 
            // InventoryItem
            // 
            InventoryItem.Text = "Inventory Item";
            InventoryItem.Width = 120;
            // 
            // InventoryQuantitiy
            // 
            InventoryQuantitiy.Text = "Quantity";
            InventoryQuantitiy.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(139, 344);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(804, 505);
            button2.Name = "button2";
            button2.Size = new Size(150, 32);
            button2.TabIndex = 8;
            button2.Text = "Refresh Inventory";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // inventoryDelete
            // 
            inventoryDelete.Location = new Point(694, 505);
            inventoryDelete.Name = "inventoryDelete";
            inventoryDelete.Size = new Size(94, 32);
            inventoryDelete.TabIndex = 9;
            inventoryDelete.Text = "Delete";
            inventoryDelete.UseVisualStyleBackColor = true;
            inventoryDelete.Click += inventoryDelete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 609);
            button3.Name = "button3";
            button3.Size = new Size(73, 32);
            button3.TabIndex = 10;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            panel1.TabIndex = 16;
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
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(inventoryDelete);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddInventoryName);
            Controls.Add(AddInventoryQuantity);
            Controls.Add(AddInventoryMenuID);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddInventoryMenuID;
        private TextBox AddInventoryQuantity;
        private TextBox AddInventoryName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ColumnHeader InventoryID;
        private ColumnHeader MenuItemInventory;
        private ColumnHeader InventoryItem;
        private ColumnHeader InventoryQuantitiy;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader1;
        private Button inventoryDelete;
        private Button button3;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox13;
    }
}