namespace ICS321Project
{
    partial class waitlistForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            BackButton = new Label();
            RemoveButton = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.AliceBlue;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Font = new Font("Segoe UI", 14F);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 388);
            listView1.TabIndex = 0;
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
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ClassType";
            columnHeader5.Width = 200;
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
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.Click += BackButton_Click;
            BackButton.MouseEnter += BackButton_MouseEnter;
            BackButton.MouseLeave += BackButton_MouseLeave;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.Cursor = Cursors.Hand;
            RemoveButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            RemoveButton.ForeColor = Color.SteelBlue;
            RemoveButton.Location = new Point(641, 403);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(147, 46);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "Remove";
            RemoveButton.Click += RemoveButton_Click;
            RemoveButton.MouseEnter += RemoveButton_MouseEnter;
            RemoveButton.MouseLeave += RemoveButton_MouseLeave;
            // 
            // waitlistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveButton);
            Controls.Add(BackButton);
            Controls.Add(listView1);
            Name = "waitlistForm";
            StartPosition = FormStartPosition.Manual;
            Text = "waitlistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label BackButton;
        private Label RemoveButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}