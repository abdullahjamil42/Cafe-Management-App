namespace WinFormsApp1
{
    partial class GiveFeedback
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
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            SubmitFeedback = new Button();
            RatingComboBox = new ComboBox();
            Feedback = new TextBox();
            SuspendLayout();
            // 
            // listView2
            // 
            listView2.BackColor = Color.DarkOrange;
            listView2.CheckBoxes = true;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView2.Location = new Point(68, 57);
            listView2.Name = "listView2";
            listView2.Size = new Size(851, 314);
            listView2.TabIndex = 5;
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
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(14, 604);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SubmitFeedback
            // 
            SubmitFeedback.ForeColor = Color.Black;
            SubmitFeedback.Location = new Point(828, 569);
            SubmitFeedback.Name = "SubmitFeedback";
            SubmitFeedback.Size = new Size(91, 34);
            SubmitFeedback.TabIndex = 7;
            SubmitFeedback.Text = "Submit";
            SubmitFeedback.UseVisualStyleBackColor = true;
            SubmitFeedback.Click += SubmitFeedback_Click;
            // 
            // RatingComboBox
            // 
            RatingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RatingComboBox.FormattingEnabled = true;
            RatingComboBox.Items.AddRange(new object[] { "*", "* *", "* * *", "* * * *", "* * * * *" });
            RatingComboBox.Location = new Point(671, 535);
            RatingComboBox.Name = "RatingComboBox";
            RatingComboBox.Size = new Size(248, 28);
            RatingComboBox.TabIndex = 8;
            // 
            // Feedback
            // 
            Feedback.Location = new Point(671, 389);
            Feedback.Multiline = true;
            Feedback.Name = "Feedback";
            Feedback.Size = new Size(248, 140);
            Feedback.TabIndex = 9;
            // 
            // GiveFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(982, 653);
            Controls.Add(Feedback);
            Controls.Add(RatingComboBox);
            Controls.Add(SubmitFeedback);
            Controls.Add(listView2);
            Controls.Add(button1);
            ForeColor = SystemColors.Control;
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "GiveFeedback";
            Text = "GiveFeedback";
            Load += GiveFeedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private Button SubmitFeedback;
        private ComboBox RatingComboBox;
        private TextBox Feedback;
    }
}