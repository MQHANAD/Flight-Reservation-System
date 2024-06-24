namespace ICS321Project
{
    partial class Form2
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
            signUpButton = new Button();
            IDTextBox = new TextBox();
            NameTextBox = new TextBox();
            PassTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signUpButton
            // 
            signUpButton.Anchor = AnchorStyles.Top;
            signUpButton.BackColor = Color.LightSkyBlue;
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.Location = new Point(413, 294);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(124, 30);
            signUpButton.TabIndex = 3;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top;
            IDTextBox.BackColor = SystemColors.InactiveBorder;
            IDTextBox.Cursor = Cursors.IBeam;
            IDTextBox.Location = new Point(283, 146);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(254, 27);
            IDTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top;
            NameTextBox.BackColor = SystemColors.InactiveBorder;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Location = new Point(283, 199);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(254, 27);
            NameTextBox.TabIndex = 5;
            // 
            // PassTextBox
            // 
            PassTextBox.Anchor = AnchorStyles.Top;
            PassTextBox.BackColor = SystemColors.InactiveBorder;
            PassTextBox.Cursor = Cursors.IBeam;
            PassTextBox.Location = new Point(283, 252);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.PasswordChar = '*';
            PassTextBox.Size = new Size(254, 27);
            PassTextBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(283, 123);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(283, 176);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(283, 229);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top;
            backButton.BackColor = Color.LightSkyBlue;
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(283, 294);
            backButton.Name = "backButton";
            backButton.Size = new Size(124, 30);
            backButton.TabIndex = 10;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources._235009158fa8f90d0f5f43c82bd5d5c3;
            pictureBox1.Location = new Point(283, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(832, 453);
            Controls.Add(pictureBox1);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PassTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(signUpButton);
            Name = "Form2";
            StartPosition = FormStartPosition.Manual;
            Text = "Sigh up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signUpButton;
        private TextBox IDTextBox;
        private TextBox NameTextBox;
        private TextBox PassTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backButton;
        private PictureBox pictureBox1;
    }
}