namespace ICS321Project
{
    partial class viewFlightsForm
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
            label1 = new Label();
            bookLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listView1 = new ListView();
            ID = new ColumnHeader();
            From = new ColumnHeader();
            To = new ColumnHeader();
            Date = new ColumnHeader();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            SearchButton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(26, 395);
            label1.Name = "label1";
            label1.Size = new Size(97, 46);
            label1.TabIndex = 8;
            label1.Text = "Back";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // bookLabel
            // 
            bookLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bookLabel.AutoSize = true;
            bookLabel.Cursor = Cursors.Hand;
            bookLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            bookLabel.ForeColor = Color.SteelBlue;
            bookLabel.Location = new Point(664, 395);
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(101, 46);
            bookLabel.TabIndex = 10;
            bookLabel.Text = "Book";
            bookLabel.Click += bookLabel_Click;
            bookLabel.MouseEnter += bookLabel_MouseEnter;
            bookLabel.MouseLeave += bookLabel_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(330, 395);
            label2.Name = "label2";
            label2.Size = new Size(148, 46);
            label2.TabIndex = 11;
            label2.Text = "Waitlist";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(357, 395);
            label3.Name = "label3";
            label3.Size = new Size(84, 46);
            label3.TabIndex = 12;
            label3.Text = "Add";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(447, 395);
            label4.Name = "label4";
            label4.Size = new Size(147, 46);
            label4.TabIndex = 13;
            label4.Text = "Remove";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(219, 395);
            label5.Name = "label5";
            label5.Size = new Size(132, 46);
            label5.TabIndex = 14;
            label5.Text = "Modify";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.AliceBlue;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, From, To, Date });
            listView1.Font = new Font("Segoe UI", 12F);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 58);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 334);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "Flight ID";
            ID.Width = 200;
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 200;
            // 
            // To
            // 
            To.Text = "To";
            To.Width = 200;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 190;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(382, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 28);
            comboBox2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 23);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 18;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 23);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 19;
            label7.Text = "To";
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.AutoSize = true;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            SearchButton.ForeColor = Color.SteelBlue;
            SearchButton.Location = new Point(639, 7);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(126, 46);
            SearchButton.TabIndex = 20;
            SearchButton.Text = "Search";
            SearchButton.Click += SearchButton_Click;
            SearchButton.MouseEnter += SearchButton_MouseEnter;
            SearchButton.MouseLeave += SearchButton_MouseLeave;
            // 
            // viewFlightsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(bookLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "viewFlightsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "viewFlightsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label bookLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader From;
        private ColumnHeader To;
        private ColumnHeader Date;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Label SearchButton;
    }
}