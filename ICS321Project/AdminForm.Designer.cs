namespace ICS321Project
{
    partial class AdminForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            generateReportButton = new Label();
            waitButton = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._6915987;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(64, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(319, 132);
            label2.Name = "label2";
            label2.Size = new Size(128, 46);
            label2.TabIndex = 2;
            label2.Text = "Flights";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(285, 242);
            label3.Name = "label3";
            label3.Size = new Size(198, 46);
            label3.TabIndex = 3;
            label3.Text = "My Tickets ";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(318, 297);
            label7.Name = "label7";
            label7.Size = new Size(130, 46);
            label7.TabIndex = 7;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            label7.MouseEnter += label7_MouseEnter;
            label7.MouseLeave += label7_MouseLeave;
            // 
            // generateReportButton
            // 
            generateReportButton.Anchor = AnchorStyles.Top;
            generateReportButton.AutoSize = true;
            generateReportButton.Cursor = Cursors.Hand;
            generateReportButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            generateReportButton.ForeColor = Color.SteelBlue;
            generateReportButton.Location = new Point(242, 242);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.Size = new Size(296, 46);
            generateReportButton.TabIndex = 8;
            generateReportButton.Text = "Generate Reports";
            generateReportButton.Click += generateReportButton_Click;
            generateReportButton.MouseEnter += generateReportButton_MouseEnter;
            generateReportButton.MouseLeave += generateReportButton_MouseLeave;
            // 
            // waitButton
            // 
            waitButton.Anchor = AnchorStyles.Top;
            waitButton.AutoSize = true;
            waitButton.Cursor = Cursors.Hand;
            waitButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            waitButton.ForeColor = Color.SteelBlue;
            waitButton.Location = new Point(308, 187);
            waitButton.Name = "waitButton";
            waitButton.Size = new Size(148, 46);
            waitButton.TabIndex = 9;
            waitButton.Text = "Waitlist";
            waitButton.Click += waitButton_Click;
            waitButton.MouseEnter += waitButton_MouseEnter;
            waitButton.MouseLeave += waitButton_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources._235009158fa8f90d0f5f43c82bd5d5c3;
            pictureBox2.Location = new Point(493, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources._235009158fa8f90d0f5f43c82bd5d5c3;
            pictureBox3.Location = new Point(25, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(254, 114);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(320, 86);
            label5.Name = "label5";
            label5.Size = new Size(132, 46);
            label5.TabIndex = 12;
            label5.Text = "Tickets";
            label5.Click += label5_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(waitButton);
            Controls.Add(generateReportButton);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label generateReportButton;
        private Label waitButton;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
    }
}