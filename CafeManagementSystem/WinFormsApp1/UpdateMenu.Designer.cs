namespace WinFormsApp1
{
    partial class UpdateMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMenu));
            listView1 = new ListView();
            MenuName = new ColumnHeader();
            MenuPrice = new ColumnHeader();
            Discription = new ColumnHeader();
            Availability = new ColumnHeader();
            Category = new ColumnHeader();
            imageList1 = new ImageList(components);
            UpdatedItemAvailability = new TextBox();
            UpdatedItemCategory = new TextBox();
            UpdatedItemDescription = new TextBox();
            UpdatedItemPrice = new TextBox();
            UpdatedItemName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            backbutton = new Button();
            updatebutton = new Button();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox13 = new PictureBox();
            DeleteSelected = new Button();
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
            listView1.Columns.AddRange(new ColumnHeader[] { MenuName, MenuPrice, Discription, Availability, Category });
            listView1.Location = new Point(39, 106);
            listView1.Margin = new Padding(30, 3, 3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(900, 401);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // MenuName
            // 
            MenuName.Text = "                        Name";
            MenuName.Width = 200;
            // 
            // MenuPrice
            // 
            MenuPrice.Text = "Price";
            MenuPrice.Width = 150;
            // 
            // Discription
            // 
            Discription.DisplayIndex = 4;
            Discription.Text = "Discription";
            Discription.Width = 150;
            // 
            // Availability
            // 
            Availability.DisplayIndex = 2;
            Availability.Text = "Availability";
            Availability.Width = 150;
            // 
            // Category
            // 
            Category.DisplayIndex = 3;
            Category.Text = "Category";
            Category.Width = 150;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "biryani.jpg");
            // 
            // UpdatedItemAvailability
            // 
            UpdatedItemAvailability.Location = new Point(569, 551);
            UpdatedItemAvailability.Name = "UpdatedItemAvailability";
            UpdatedItemAvailability.Size = new Size(125, 27);
            UpdatedItemAvailability.TabIndex = 1;
            // 
            // UpdatedItemCategory
            // 
            UpdatedItemCategory.Location = new Point(721, 551);
            UpdatedItemCategory.Name = "UpdatedItemCategory";
            UpdatedItemCategory.Size = new Size(125, 27);
            UpdatedItemCategory.TabIndex = 2;
            // 
            // UpdatedItemDescription
            // 
            UpdatedItemDescription.Location = new Point(417, 551);
            UpdatedItemDescription.Name = "UpdatedItemDescription";
            UpdatedItemDescription.Size = new Size(125, 27);
            UpdatedItemDescription.TabIndex = 3;
            // 
            // UpdatedItemPrice
            // 
            UpdatedItemPrice.Location = new Point(265, 551);
            UpdatedItemPrice.Name = "UpdatedItemPrice";
            UpdatedItemPrice.Size = new Size(125, 27);
            UpdatedItemPrice.TabIndex = 4;
            // 
            // UpdatedItemName
            // 
            UpdatedItemName.Location = new Point(119, 551);
            UpdatedItemName.Name = "UpdatedItemName";
            UpdatedItemName.Size = new Size(125, 27);
            UpdatedItemName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 522);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "New Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(265, 522);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "New Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(417, 522);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 8;
            label3.Text = "New Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(569, 522);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Availablity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(721, 522);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 10;
            label5.Text = "New Category";
            // 
            // backbutton
            // 
            backbutton.Location = new Point(12, 614);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(94, 29);
            backbutton.TabIndex = 11;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(876, 614);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(94, 29);
            updatebutton.TabIndex = 14;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            updatebutton.Click += updatebutton_Click;
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
            panel1.TabIndex = 15;
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
            // DeleteSelected
            // 
            DeleteSelected.Location = new Point(730, 614);
            DeleteSelected.Name = "DeleteSelected";
            DeleteSelected.Size = new Size(140, 29);
            DeleteSelected.TabIndex = 16;
            DeleteSelected.Text = "Delete Selected";
            DeleteSelected.UseVisualStyleBackColor = true;
            DeleteSelected.Click += DeleteSelected_Click;
            // 
            // UpdateMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(DeleteSelected);
            Controls.Add(panel1);
            Controls.Add(updatebutton);
            Controls.Add(backbutton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpdatedItemName);
            Controls.Add(UpdatedItemPrice);
            Controls.Add(UpdatedItemDescription);
            Controls.Add(UpdatedItemCategory);
            Controls.Add(UpdatedItemAvailability);
            Controls.Add(listView1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "UpdateMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader MenuName;
        private ColumnHeader MenuPrice;
        private ColumnHeader Availability;
        private ColumnHeader Category;
        private ColumnHeader Discription;
        private ImageList imageList1;
        private TextBox UpdatedItemAvailability;
        private TextBox UpdatedItemCategory;
        private TextBox UpdatedItemDescription;
        private TextBox UpdatedItemPrice;
        private TextBox UpdatedItemName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button backbutton;
        private Button updatebutton;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox13;
        private Button DeleteSelected;
    }
}