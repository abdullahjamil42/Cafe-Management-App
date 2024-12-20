namespace WinFormsApp1
{
    partial class AddToMenu
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
            AddItem = new Button();
            AddItemName = new TextBox();
            AddItemPrice = new TextBox();
            AddItemDescription = new TextBox();
            AddItemName1 = new Label();
            AddItemPrice1 = new Label();
            AddItemDescription1 = new Label();
            AddItemAvailaibility1 = new Label();
            AddItemCatogary1 = new Label();
            AddItemCategory = new ComboBox();
            AddItemAvailability = new ComboBox();
            BrowseImage = new Button();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ImageAddress = new TextBox();
            pictureBox1 = new PictureBox();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddItem
            // 
            AddItem.Location = new Point(581, 463);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(94, 29);
            AddItem.TabIndex = 0;
            AddItem.Text = "Add Item";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // AddItemName
            // 
            AddItemName.Location = new Point(490, 145);
            AddItemName.Name = "AddItemName";
            AddItemName.Size = new Size(185, 27);
            AddItemName.TabIndex = 1;
            // 
            // AddItemPrice
            // 
            AddItemPrice.Location = new Point(490, 200);
            AddItemPrice.Name = "AddItemPrice";
            AddItemPrice.Size = new Size(185, 27);
            AddItemPrice.TabIndex = 2;
            AddItemPrice.TextChanged += AddItemPrice_TextChanged;
            // 
            // AddItemDescription
            // 
            AddItemDescription.Location = new Point(490, 256);
            AddItemDescription.Name = "AddItemDescription";
            AddItemDescription.Size = new Size(185, 27);
            AddItemDescription.TabIndex = 3;
            AddItemDescription.TextChanged += textBox3_TextChanged;
            // 
            // AddItemName1
            // 
            AddItemName1.BackColor = Color.Maroon;
            AddItemName1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddItemName1.ForeColor = Color.WhiteSmoke;
            AddItemName1.Location = new Point(318, 144);
            AddItemName1.Name = "AddItemName1";
            AddItemName1.Size = new Size(116, 25);
            AddItemName1.TabIndex = 6;
            AddItemName1.Text = "Enter Name";
            // 
            // AddItemPrice1
            // 
            AddItemPrice1.AutoSize = true;
            AddItemPrice1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddItemPrice1.ForeColor = Color.WhiteSmoke;
            AddItemPrice1.Location = new Point(318, 199);
            AddItemPrice1.Name = "AddItemPrice1";
            AddItemPrice1.Size = new Size(108, 25);
            AddItemPrice1.TabIndex = 7;
            AddItemPrice1.Text = "Enter Price";
            // 
            // AddItemDescription1
            // 
            AddItemDescription1.AutoSize = true;
            AddItemDescription1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddItemDescription1.ForeColor = Color.WhiteSmoke;
            AddItemDescription1.Location = new Point(318, 255);
            AddItemDescription1.Name = "AddItemDescription1";
            AddItemDescription1.Size = new Size(166, 25);
            AddItemDescription1.TabIndex = 9;
            AddItemDescription1.Text = "Enter Description";
            AddItemDescription1.Click += AddItemDescription1_Click;
            // 
            // AddItemAvailaibility1
            // 
            AddItemAvailaibility1.AutoSize = true;
            AddItemAvailaibility1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddItemAvailaibility1.ForeColor = Color.WhiteSmoke;
            AddItemAvailaibility1.Location = new Point(318, 311);
            AddItemAvailaibility1.Name = "AddItemAvailaibility1";
            AddItemAvailaibility1.Size = new Size(161, 25);
            AddItemAvailaibility1.TabIndex = 10;
            AddItemAvailaibility1.Text = "Enter Availability";
            // 
            // AddItemCatogary1
            // 
            AddItemCatogary1.AutoSize = true;
            AddItemCatogary1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AddItemCatogary1.ForeColor = Color.WhiteSmoke;
            AddItemCatogary1.Location = new Point(318, 366);
            AddItemCatogary1.Name = "AddItemCatogary1";
            AddItemCatogary1.Size = new Size(146, 25);
            AddItemCatogary1.TabIndex = 11;
            AddItemCatogary1.Text = "Enter Category";
            AddItemCatogary1.Click += label6_Click;
            // 
            // AddItemCategory
            // 
            AddItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemCategory.FormattingEnabled = true;
            AddItemCategory.Items.AddRange(new object[] { "Food", "Drinks", "Deserts", "Side" });
            AddItemCategory.Location = new Point(490, 367);
            AddItemCategory.Name = "AddItemCategory";
            AddItemCategory.Size = new Size(185, 28);
            AddItemCategory.TabIndex = 13;
            // 
            // AddItemAvailability
            // 
            AddItemAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemAvailability.FormattingEnabled = true;
            AddItemAvailability.Items.AddRange(new object[] { "True", "False" });
            AddItemAvailability.Location = new Point(490, 312);
            AddItemAvailability.Name = "AddItemAvailability";
            AddItemAvailability.Size = new Size(185, 28);
            AddItemAvailability.TabIndex = 14;
            // 
            // BrowseImage
            // 
            BrowseImage.Location = new Point(610, 418);
            BrowseImage.Name = "BrowseImage";
            BrowseImage.Size = new Size(65, 29);
            BrowseImage.TabIndex = 15;
            BrowseImage.Text = "Browse Image";
            BrowseImage.UseVisualStyleBackColor = true;
            BrowseImage.Click += BrowseImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(318, 418);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 16;
            label1.Text = "Add Image";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImageAddress
            // 
            ImageAddress.Location = new Point(490, 419);
            ImageAddress.Name = "ImageAddress";
            ImageAddress.Size = new Size(121, 27);
            ImageAddress.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cvr;
            pictureBox1.Location = new Point(-91, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1236, 653);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Back
            // 
            Back.Location = new Point(901, 612);
            Back.Name = "Back";
            Back.Size = new Size(69, 29);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // AddToMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(982, 653);
            Controls.Add(Back);
            Controls.Add(ImageAddress);
            Controls.Add(label1);
            Controls.Add(BrowseImage);
            Controls.Add(AddItemAvailability);
            Controls.Add(AddItemCategory);
            Controls.Add(AddItemCatogary1);
            Controls.Add(AddItemAvailaibility1);
            Controls.Add(AddItemDescription1);
            Controls.Add(AddItemPrice1);
            Controls.Add(AddItemName1);
            Controls.Add(AddItemDescription);
            Controls.Add(AddItemPrice);
            Controls.Add(AddItemName);
            Controls.Add(AddItem);
            Controls.Add(pictureBox1);
            Name = "AddToMenu";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateItems";
            Load += UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddItem;
        private TextBox AddItemName;
        private TextBox AddItemPrice;
        private TextBox AddItemDescription;
        private Label AddItemName1;
        private Label AddItemPrice1;
        private Label AddItemDescription1;
        private Label AddItemAvailaibility1;
        private Label AddItemCatogary1;
        private ComboBox AddItemCategory;
        private ComboBox AddItemAvailability;
        private Button BrowseImage;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox ImageAddress;
        private PictureBox pictureBox1;
        private Button Back;
    }
}