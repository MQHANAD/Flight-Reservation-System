namespace ICS321Project
{
    partial class modifecationForm
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
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            modifyButton = new Label();
            backButton = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.Location = new Point(217, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(217, 224);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 38;
            label8.Text = "Aircraft";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(217, 171);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 36;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(217, 118);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 35;
            label5.Text = "To";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(217, 65);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 34;
            label4.Text = "From";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = SystemColors.InactiveBorder;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(217, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(349, 28);
            comboBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(217, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(217, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 29;
            // 
            // modifyButton
            // 
            modifyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            modifyButton.AutoSize = true;
            modifyButton.Cursor = Cursors.Hand;
            modifyButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            modifyButton.ForeColor = Color.SteelBlue;
            modifyButton.Location = new Point(651, 394);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(132, 46);
            modifyButton.TabIndex = 28;
            modifyButton.Text = "Modify";
            modifyButton.Click += modifyButton_Click;
            modifyButton.MouseEnter += modifyButton_MouseEnter;
            modifyButton.MouseLeave += modifyButton_MouseLeave;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.AutoSize = true;
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            backButton.ForeColor = Color.SteelBlue;
            backButton.Location = new Point(7, 394);
            backButton.Name = "backButton";
            backButton.Size = new Size(97, 46);
            backButton.TabIndex = 27;
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            backButton.MouseEnter += backButton_MouseEnter;
            backButton.MouseLeave += backButton_MouseLeave;
            // 
            // modifecationForm
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
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(modifyButton);
            Controls.Add(backButton);
            Name = "modifecationForm";
            StartPosition = FormStartPosition.Manual;
            Text = "modifecationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label modifyButton;
        private Label backButton;
    }
}