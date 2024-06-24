namespace ICS321Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            signUpButton = new Button();
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Top;
            userNameTextBox.BackColor = SystemColors.InactiveBorder;
            userNameTextBox.Cursor = Cursors.IBeam;
            userNameTextBox.Location = new Point(284, 152);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(254, 27);
            userNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top;
            PasswordTextBox.BackColor = SystemColors.InactiveBorder;
            PasswordTextBox.Cursor = Cursors.IBeam;
            PasswordTextBox.Location = new Point(284, 205);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(254, 27);
            PasswordTextBox.TabIndex = 1;
            // 
            // signUpButton
            // 
            signUpButton.Anchor = AnchorStyles.Top;
            signUpButton.BackColor = Color.LightSkyBlue;
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.Location = new Point(284, 243);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(124, 30);
            signUpButton.TabIndex = 2;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.BackColor = Color.LightSkyBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Location = new Point(414, 243);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(124, 30);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(284, 129);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(284, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources._235009158fa8f90d0f5f43c82bd5d5c3;
            pictureBox1.Location = new Point(284, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(832, 453);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(signUpButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(userNameTextBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox PasswordTextBox;
        private Button signUpButton;
        private Button LoginButton;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
