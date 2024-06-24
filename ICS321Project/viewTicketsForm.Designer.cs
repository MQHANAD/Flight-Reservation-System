namespace ICS321Project
{
    partial class viewTicketsForm
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
            columnHeader6 = new ColumnHeader();
            BackButton = new Label();
            CancelButton = new Label();
            modifyButton = new Label();
            PayButton = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.AliceBlue;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI", 14F);
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 381);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ticket ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Time";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Class";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Flight ID";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 135;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackButton.AutoSize = true;
            BackButton.Cursor = Cursors.Hand;
            BackButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            BackButton.ForeColor = Color.SteelBlue;
            BackButton.Location = new Point(12, 396);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 46);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.Click += BackButton_Click;
            BackButton.MouseEnter += BackButton_MouseEnter;
            BackButton.MouseLeave += BackButton_MouseLeave;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.AutoSize = true;
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            CancelButton.ForeColor = Color.SteelBlue;
            CancelButton.Location = new Point(660, 396);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(127, 46);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.Click += CancelButton_Click;
            CancelButton.MouseEnter += CancelButton_MouseEnter;
            CancelButton.MouseLeave += CancelButton_MouseLeave;
            // 
            // modifyButton
            // 
            modifyButton.Anchor = AnchorStyles.Bottom;
            modifyButton.AutoSize = true;
            modifyButton.Cursor = Cursors.Hand;
            modifyButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            modifyButton.ForeColor = Color.SteelBlue;
            modifyButton.Location = new Point(210, 396);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(132, 46);
            modifyButton.TabIndex = 5;
            modifyButton.Text = "Modify";
            modifyButton.Click += modifyButton_Click;
            modifyButton.MouseEnter += modifyButton_MouseEnter;
            modifyButton.MouseLeave += modifyButton_MouseLeave;
            // 
            // PayButton
            // 
            PayButton.Anchor = AnchorStyles.Bottom;
            PayButton.AutoSize = true;
            PayButton.Cursor = Cursors.Hand;
            PayButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            PayButton.ForeColor = Color.SteelBlue;
            PayButton.Location = new Point(449, 396);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(79, 46);
            PayButton.TabIndex = 6;
            PayButton.Text = "Pay";
            PayButton.Click += PayButton_Click;
            PayButton.MouseEnter += PayButton_MouseEnter;
            PayButton.MouseLeave += PayButton_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(449, 396);
            label1.Name = "label1";
            label1.Size = new Size(101, 46);
            label1.TabIndex = 7;
            label1.Text = "Book";
            label1.Click += label1_Click;
            // 
            // viewTicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(PayButton);
            Controls.Add(modifyButton);
            Controls.Add(CancelButton);
            Controls.Add(BackButton);
            Controls.Add(listView1);
            Name = "viewTicketsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "viewTicketsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label BackButton;
        private Label CancelButton;
        private Label modifyButton;
        private Label PayButton;
        private Label label1;
    }
}