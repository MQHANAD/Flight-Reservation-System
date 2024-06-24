namespace ICS321Project
{
    partial class ReportsForm
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label8 = new Label();
            SearchButton = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.LightCyan;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Cursor = Cursors.Hand;
            label2.Dock = DockStyle.Left;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 450);
            label2.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.BackColor = Color.LightCyan;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(0, 59);
            label1.Name = "label1";
            label1.Size = new Size(170, 48);
            label1.TabIndex = 11;
            label1.Text = "Current Flights";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.LightCyan;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(0, 107);
            label3.Name = "label3";
            label3.Size = new Size(170, 48);
            label3.TabIndex = 12;
            label3.Text = "Booking %";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.LightCyan;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Cursor = Cursors.Hand;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(0, 155);
            label4.Name = "label4";
            label4.Size = new Size(170, 48);
            label4.TabIndex = 13;
            label4.Text = "Payments";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.BackColor = Color.LightCyan;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(0, 203);
            label5.Name = "label5";
            label5.Size = new Size(170, 48);
            label5.TabIndex = 14;
            label5.Text = "Waitlist";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.BackColor = Color.LightCyan;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Cursor = Cursors.Hand;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(0, 251);
            label6.Name = "label6";
            label6.Size = new Size(170, 48);
            label6.TabIndex = 15;
            label6.Text = "Load Factor";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.BackColor = Color.LightCyan;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Cursor = Cursors.Hand;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(0, 299);
            label7.Name = "label7";
            label7.Size = new Size(170, 48);
            label7.TabIndex = 16;
            label7.Text = "Cancelled tickets";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            label7.MouseEnter += label7_MouseEnter;
            label7.MouseLeave += label7_MouseLeave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(176, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 379);
            panel1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(362, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 18;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(315, 22);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 19;
            label8.Text = "Date";
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.AutoSize = true;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            SearchButton.ForeColor = Color.SteelBlue;
            SearchButton.Location = new Point(619, 6);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(165, 46);
            SearchButton.TabIndex = 21;
            SearchButton.Text = "Generate";
            SearchButton.Click += SearchButton_Click;
            SearchButton.MouseEnter += SearchButton_MouseEnter;
            SearchButton.MouseLeave += SearchButton_MouseLeave;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.BackColor = Color.LightCyan;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Cursor = Cursors.Hand;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(0, 347);
            label9.Name = "label9";
            label9.Size = new Size(170, 48);
            label9.TabIndex = 22;
            label9.Text = "Back";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            label9.MouseEnter += label9_MouseEnter;
            label9.MouseLeave += label9_MouseLeave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(362, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(SearchButton);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ReportsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox textBox1;
        private Label label8;
        private Label SearchButton;
        private Label label9;
        private DateTimePicker dateTimePicker1;
    }
}