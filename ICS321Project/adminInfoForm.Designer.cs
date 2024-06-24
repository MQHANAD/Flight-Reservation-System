namespace ICS321Project
{
    partial class adminInfoForm
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
            nameLable = new Label();
            passwordLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            roleLabel = new Label();
            label8 = new Label();
            LoginButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Font = new Font("Segoe UI", 20F);
            nameLable.Location = new Point(12, 48);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(109, 46);
            nameLable.TabIndex = 0;
            nameLable.Text = "label1";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20F);
            passwordLabel.Location = new Point(12, 92);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(176, 46);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(170, 101);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 2;
            label1.Text = "**********";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(297, 46);
            label2.TabIndex = 6;
            label2.Text = "Payment methods:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(148, 46);
            label3.TabIndex = 8;
            label3.Text = "Fines: 0$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(18, 230);
            label4.Name = "label4";
            label4.Size = new Size(0, 46);
            label4.TabIndex = 9;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 20F);
            roleLabel.Location = new Point(12, 230);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(92, 46);
            roleLabel.TabIndex = 10;
            roleLabel.Text = "Role:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(352, 395);
            label8.Name = "label8";
            label8.Size = new Size(97, 46);
            label8.TabIndex = 15;
            label8.Text = "Back";
            label8.Click += label8_Click;
            label8.MouseEnter += label8_MouseEnter;
            label8.MouseLeave += label8_MouseLeave;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LoginButton.BackColor = Color.LightSkyBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Location = new Point(600, 59);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(170, 30);
            LoginButton.TabIndex = 16;
            LoginButton.Text = "Edit Name";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.LightSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(600, 101);
            button1.Name = "button1";
            button1.Size = new Size(170, 30);
            button1.TabIndex = 17;
            button1.Text = "Edit Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.LightSkyBlue;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(600, 150);
            button2.Name = "button2";
            button2.Size = new Size(170, 30);
            button2.TabIndex = 18;
            button2.Text = "Add Payment Method";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.LightSkyBlue;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(600, 199);
            button3.Name = "button3";
            button3.Size = new Size(170, 30);
            button3.TabIndex = 19;
            button3.Text = "Pay All Fines";
            button3.UseVisualStyleBackColor = false;
            // 
            // adminInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LoginButton);
            Controls.Add(label8);
            Controls.Add(roleLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordLabel);
            Controls.Add(nameLable);
            Name = "adminInfoForm";
            StartPosition = FormStartPosition.Manual;
            Text = "adminInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLable;
        private Label passwordLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label roleLabel;
        private Label label8;
        private Button LoginButton;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}