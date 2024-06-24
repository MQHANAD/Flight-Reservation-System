namespace ICS321Project
{
    partial class bookingForm
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
            firstClassButton = new Label();
            busClasButton = new Label();
            EconomyButton = new Label();
            label1 = new Label();
            backButton = new Label();
            bookButton = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            waitlistButton = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // firstClassButton
            // 
            firstClassButton.Anchor = AnchorStyles.Left;
            firstClassButton.AutoSize = true;
            firstClassButton.Cursor = Cursors.Hand;
            firstClassButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            firstClassButton.ForeColor = Color.SteelBlue;
            firstClassButton.Location = new Point(12, 184);
            firstClassButton.Name = "firstClassButton";
            firstClassButton.Size = new Size(183, 46);
            firstClassButton.TabIndex = 15;
            firstClassButton.Text = "First Class";
            firstClassButton.Click += firstClassButton_Click;
            firstClassButton.MouseEnter += firstClassButton_MouseEnter;
            firstClassButton.MouseLeave += firstClassButton_MouseLeave;
            // 
            // busClasButton
            // 
            busClasButton.Anchor = AnchorStyles.Left;
            busClasButton.AutoSize = true;
            busClasButton.Cursor = Cursors.Hand;
            busClasButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            busClasButton.ForeColor = Color.SteelBlue;
            busClasButton.Location = new Point(12, 255);
            busClasButton.Name = "busClasButton";
            busClasButton.Size = new Size(248, 46);
            busClasButton.TabIndex = 14;
            busClasButton.Text = "Business Class";
            busClasButton.Click += busClasButton_Click;
            busClasButton.MouseEnter += busClasButton_MouseEnter;
            busClasButton.MouseLeave += busClasButton_MouseLeave;
            // 
            // EconomyButton
            // 
            EconomyButton.Anchor = AnchorStyles.Left;
            EconomyButton.AutoSize = true;
            EconomyButton.Cursor = Cursors.Hand;
            EconomyButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            EconomyButton.ForeColor = Color.SteelBlue;
            EconomyButton.Location = new Point(12, 112);
            EconomyButton.Name = "EconomyButton";
            EconomyButton.Size = new Size(255, 46);
            EconomyButton.TabIndex = 16;
            EconomyButton.Text = "Economy Class";
            EconomyButton.Click += label4_Click;
            EconomyButton.MouseEnter += EconomyButton_MouseEnter;
            EconomyButton.MouseLeave += EconomyButton_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(495, 57);
            label1.TabIndex = 17;
            label1.Text = "Please Select Your Class";
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
            backButton.TabIndex = 18;
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            backButton.MouseEnter += backButton_MouseEnter;
            backButton.MouseLeave += backButton_MouseLeave;
            // 
            // bookButton
            // 
            bookButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bookButton.AutoSize = true;
            bookButton.Cursor = Cursors.Hand;
            bookButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            bookButton.ForeColor = Color.SteelBlue;
            bookButton.Location = new Point(691, 395);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(101, 46);
            bookButton.TabIndex = 19;
            bookButton.Text = "Book";
            bookButton.Click += bookButton_Click;
            bookButton.MouseEnter += bookButton_MouseEnter;
            bookButton.MouseLeave += bookButton_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(349, 112);
            label2.Name = "label2";
            label2.Size = new Size(109, 46);
            label2.TabIndex = 20;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(349, 184);
            label3.Name = "label3";
            label3.Size = new Size(109, 46);
            label3.TabIndex = 21;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(349, 255);
            label4.Name = "label4";
            label4.Size = new Size(109, 46);
            label4.TabIndex = 22;
            label4.Text = "label4";
            // 
            // waitlistButton
            // 
            waitlistButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            waitlistButton.AutoSize = true;
            waitlistButton.Cursor = Cursors.Hand;
            waitlistButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            waitlistButton.ForeColor = Color.SteelBlue;
            waitlistButton.Location = new Point(524, 395);
            waitlistButton.Name = "waitlistButton";
            waitlistButton.Size = new Size(268, 46);
            waitlistButton.TabIndex = 23;
            waitlistButton.Text = "Sign to Waitlist";
            waitlistButton.Click += waitlistButton_Click;
            waitlistButton.MouseEnter += waitlistButton_MouseEnter;
            waitlistButton.MouseLeave += waitlistButton_MouseLeave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(556, 112);
            label5.Name = "label5";
            label5.Size = new Size(109, 46);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(556, 184);
            label6.Name = "label6";
            label6.Size = new Size(109, 46);
            label6.TabIndex = 25;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(556, 255);
            label7.Name = "label7";
            label7.Size = new Size(109, 46);
            label7.TabIndex = 26;
            label7.Text = "label7";
            // 
            // bookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(waitlistButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bookButton);
            Controls.Add(backButton);
            Controls.Add(label1);
            Controls.Add(firstClassButton);
            Controls.Add(busClasButton);
            Controls.Add(EconomyButton);
            Name = "bookingForm";
            StartPosition = FormStartPosition.Manual;
            Text = "bookingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstClassButton;
        private Label busClasButton;
        private Label EconomyButton;
        private Label label1;
        private Label backButton;
        private Label bookButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label waitlistButton;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}