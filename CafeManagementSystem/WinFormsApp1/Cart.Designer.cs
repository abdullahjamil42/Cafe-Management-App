namespace WinFormsApp1
{
    partial class Cart
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
            button1 = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            QUANTITY = new ColumnHeader();
            NAME = new ColumnHeader();
            PRICE = new ColumnHeader();
            DESCRIPTION = new ColumnHeader();
            TOTALPRICE = new ColumnHeader();
            imageList1 = new ImageList(components);
            button2 = new Button();
            DeleteFromCart = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox13 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(15, 609);
            button1.Name = "button1";
            button1.Size = new Size(79, 32);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Anchor = AnchorStyles.Top;
            listView1.BackColor = Color.DarkOrange;
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, QUANTITY, NAME, PRICE, DESCRIPTION, TOTALPRICE });
            listView1.Location = new Point(15, 97);
            listView1.Margin = new Padding(30, 3, 3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(946, 422);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // ID
            // 
            ID.Text = "                                     ID";
            ID.Width = 220;
            // 
            // QUANTITY
            // 
            QUANTITY.Text = "Quantity";
            QUANTITY.TextAlign = HorizontalAlignment.Center;
            QUANTITY.Width = 120;
            // 
            // NAME
            // 
            NAME.Text = "Name";
            NAME.TextAlign = HorizontalAlignment.Center;
            NAME.Width = 120;
            // 
            // PRICE
            // 
            PRICE.Text = "Price";
            PRICE.TextAlign = HorizontalAlignment.Center;
            PRICE.Width = 120;
            // 
            // DESCRIPTION
            // 
            DESCRIPTION.Text = "Description";
            DESCRIPTION.TextAlign = HorizontalAlignment.Center;
            DESCRIPTION.Width = 120;
            // 
            // TOTALPRICE
            // 
            TOTALPRICE.Text = "Total Price";
            TOTALPRICE.TextAlign = HorizontalAlignment.Center;
            TOTALPRICE.Width = 120;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(80, 80);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(797, 535);
            button2.Name = "button2";
            button2.Size = new Size(164, 32);
            button2.TabIndex = 11;
            button2.Text = "Proceed To payement";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DeleteFromCart
            // 
            DeleteFromCart.BackColor = SystemColors.Control;
            DeleteFromCart.Location = new Point(100, 609);
            DeleteFromCart.Name = "DeleteFromCart";
            DeleteFromCart.Size = new Size(129, 32);
            DeleteFromCart.TabIndex = 12;
            DeleteFromCart.Text = "Delete Selected";
            DeleteFromCart.UseVisualStyleBackColor = false;
            DeleteFromCart.Click += DeleteFromCart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox13);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 91);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 8);
            label2.Name = "label2";
            label2.Size = new Size(267, 61);
            label2.TabIndex = 1;
            label2.Text = "Fast Cafeteria";
            label2.Click += label2_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.cafe_logo2;
            pictureBox13.Location = new Point(3, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(80, 80);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 0;
            pictureBox13.TabStop = false;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(panel1);
            Controls.Add(DeleteFromCart);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "Cart";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += Cart_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader QUANTITY;
        private ColumnHeader NAME;
        private ColumnHeader PRICE;
        private ColumnHeader DESCRIPTION;
        private ColumnHeader TOTALPRICE;
        private Button button2;
        private ImageList imageList1;
        private Button DeleteFromCart;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox13;
    }
}