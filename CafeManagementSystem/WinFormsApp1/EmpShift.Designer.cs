namespace WinFormsApp1
{
    partial class EmpShift
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
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listView3
            // 
            listView3.BackColor = Color.DarkOrange;
            listView3.CheckBoxes = true;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7, columnHeader8 });
            listView3.Location = new Point(40, 44);
            listView3.Name = "listView3";
            listView3.Size = new Size(898, 397);
            listView3.TabIndex = 5;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Name";
            columnHeader6.Width = 260;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Email";
            columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Shift";
            columnHeader8.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(12, 612);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(847, 497);
            button2.Name = "button2";
            button2.Size = new Size(85, 29);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 466);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 9;
            label1.Text = "Select New Shift";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Day Shift";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Day Shift", "Night Shift" });
            comboBox1.Location = new Point(789, 463);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 28);
            comboBox1.TabIndex = 10;
            comboBox1.ValueMember = "ss";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(40, 462);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(139, 29);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete Employee";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // EmpShift
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(buttonDelete);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView3);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "EmpShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpShift";
            Load += EmpShift_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private Button buttonDelete;
    }
}