namespace ICS321Project
{
    partial class AddingPayment
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            label8 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(226, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(226, 141);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Card Number";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(226, 210);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Billing Address";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(226, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(226, 279);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 5;
            label3.Text = "EXP";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._235009158fa8f90d0f5f43c82bd5d5c3;
            pictureBox1.Location = new Point(266, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(226, 302);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(340, 27);
            textBox3.TabIndex = 8;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(266, 395);
            label8.Name = "label8";
            label8.Size = new Size(97, 46);
            label8.TabIndex = 16;
            label8.Text = "Back";
            label8.Click += label8_Click;
            label8.MouseEnter += label8_MouseEnter;
            label8.MouseLeave += label8_MouseLeave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(436, 395);
            label4.Name = "label4";
            label4.Size = new Size(84, 46);
            label4.TabIndex = 17;
            label4.Text = "Add";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // AddingPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AddingPayment";
            StartPosition = FormStartPosition.Manual;
            Text = "AddingPayment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label8;
        private Label label4;
    }
}