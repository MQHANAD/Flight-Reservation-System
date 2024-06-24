namespace ICS321Project
{
    partial class takePassID
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
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(212, 119);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Passenger ID";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(212, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(583, 129);
            label3.Name = "label3";
            label3.Size = new Size(103, 46);
            label3.TabIndex = 5;
            label3.Text = "Enter";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(333, 395);
            label2.Name = "label2";
            label2.Size = new Size(97, 46);
            label2.TabIndex = 6;
            label2.Text = "Back";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // takePassID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "takePassID";
            StartPosition = FormStartPosition.Manual;
            Text = "takePassID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
    }
}