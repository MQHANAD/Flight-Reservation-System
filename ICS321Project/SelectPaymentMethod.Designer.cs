namespace ICS321Project
{
    partial class SelectPaymentMethod
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(384, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(197, 70);
            label1.Name = "label1";
            label1.Size = new Size(388, 37);
            label1.TabIndex = 1;
            label1.Text = "Select Your Payment Method";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(201, 395);
            label2.Name = "label2";
            label2.Size = new Size(97, 46);
            label2.TabIndex = 3;
            label2.Text = "Back";
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
            label3.Location = new Point(506, 395);
            label3.Name = "label3";
            label3.Size = new Size(79, 46);
            label3.TabIndex = 4;
            label3.Text = "Pay";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // SelectPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.ControlText;
            Name = "SelectPaymentMethod";
            StartPosition = FormStartPosition.Manual;
            Text = "SelectPaymentMethod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}