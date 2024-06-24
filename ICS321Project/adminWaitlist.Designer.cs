namespace ICS321Project
{
    partial class adminWaitlist
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
            BackButton = new Label();
            discardButton = new Label();
            promoteButton = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackButton.AutoSize = true;
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            BackButton.ForeColor = Color.SteelBlue;
            BackButton.Location = new Point(12, 403);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 46);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.Click += BackButton_Click;
            BackButton.MouseEnter += BackButton_MouseEnter;
            BackButton.MouseLeave += BackButton_MouseLeave;
            // 
            // discardButton
            // 
            discardButton.Anchor = AnchorStyles.Bottom;
            discardButton.AutoSize = true;
            discardButton.Cursor = Cursors.Hand;
            discardButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            discardButton.ForeColor = Color.SteelBlue;
            discardButton.Location = new Point(325, 403);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(142, 46);
            discardButton.TabIndex = 6;
            discardButton.Text = "Discard";
            discardButton.Click += discardButton_Click;
            discardButton.MouseEnter += discardButton_MouseEnter;
            discardButton.MouseLeave += discardButton_MouseLeave;
            // 
            // promoteButton
            // 
            promoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            promoteButton.AutoSize = true;
            promoteButton.Cursor = Cursors.Hand;
            promoteButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            promoteButton.ForeColor = Color.SteelBlue;
            promoteButton.Location = new Point(631, 403);
            promoteButton.Name = "promoteButton";
            promoteButton.Size = new Size(157, 46);
            promoteButton.TabIndex = 7;
            promoteButton.Text = "Promote";
            promoteButton.Click += promoteButton_Click;
            promoteButton.MouseEnter += promoteButton_MouseEnter;
            promoteButton.MouseLeave += promoteButton_MouseLeave;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.AliceBlue;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 8F);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 388);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Flight ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "To";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ClassType";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "passenger ID";
            columnHeader6.Width = 120;
            // 
            // adminWaitlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(promoteButton);
            Controls.Add(discardButton);
            Controls.Add(BackButton);
            Name = "adminWaitlist";
            StartPosition = FormStartPosition.Manual;
            Text = "adminWaitlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BackButton;
        private Label discardButton;
        private Label promoteButton;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}