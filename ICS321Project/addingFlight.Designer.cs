namespace ICS321Project
{
    partial class addingFlight
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
            backButton = new Label();
            addButton = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.AutoSize = true;
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            backButton.ForeColor = Color.SteelBlue;
            backButton.Location = new Point(12, 395);
            backButton.Name = "backButton";
            backButton.Size = new Size(97, 46);
            backButton.TabIndex = 9;
            backButton.Text = "Back";
            backButton.Click += label1_Click;
            backButton.MouseEnter += label1_MouseEnter;
            backButton.MouseLeave += label1_MouseLeave;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.AutoSize = true;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            addButton.ForeColor = Color.SteelBlue;
            addButton.Location = new Point(704, 395);
            addButton.Name = "addButton";
            addButton.Size = new Size(84, 46);
            addButton.TabIndex = 13;
            addButton.Text = "Add";
            addButton.Click += addButton_Click;
            addButton.MouseEnter += label3_MouseEnter;
            addButton.MouseLeave += label3_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(217, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(217, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 27);
            textBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = SystemColors.InactiveBorder;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 28);
            comboBox1.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top;
            textBox5.BackColor = SystemColors.InactiveBorder;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(217, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(349, 27);
            textBox5.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(217, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 20;
            label2.Text = "flight ID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(217, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 21;
            label4.Text = "From";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(217, 147);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 22;
            label5.Text = "To";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(217, 200);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 23;
            label6.Text = "Date";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(217, 253);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 25;
            label8.Text = "Aircraft";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.Location = new Point(217, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // addingFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(addButton);
            Controls.Add(backButton);
            Name = "addingFlight";
            StartPosition = FormStartPosition.Manual;
            Text = "Adding Flight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backButton;
        private Label addButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}