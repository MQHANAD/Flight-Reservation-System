using MySql.Data.MySqlClient;


namespace ICS321Project
{
    public partial class AdminForm : Form
    {
        private Form1 form;
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private ents.Admin adm;
        private ents.passenger pss;
        Boolean isAdmin;
        viewFlightsForm vf;
        public AdminForm(int id, Form1 form, Boolean isAdmin)
        {


            this.isAdmin = isAdmin;
            string query2;
            InitializeComponent();
            mycon.Open();
            if (isAdmin)
            {
                query2 = "SELECT AdminID,Password,Name FROM admin WHERE AdminID = " + id;
                label3.Hide();
                label5.Show();
                generateReportButton.Show();

            }
            else
            {
                query2 = "SELECT PID,Password,Name FROM passenger WHERE PID = " + id;
                label3.Show();
                label5.Hide();
                generateReportButton.Hide();
            }

            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            this.form = form;

            this.Width = form.Width;
            this.Height = form.Height;
            this.Location = form.Location;
            while (reader2.Read())
            {
                this.Text = "Welcome Back " + reader2["Name"] + "!";
                if (isAdmin)
                {
                    adm = new ents.Admin((int)reader2["AdminID"], (string)reader2["Name"], (string)reader2["Password"]);
                }
                else
                {
                    pss = new ents.passenger((int)reader2["PID"], (string)reader2["Name"], (string)reader2["Password"]);
                }

            }
            if (isAdmin)
            {
                label1.Text = adm.Name;
            }
            else
            {
                label1.Text = pss.Name;
            }

            reader2.Close();
            mycon.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminInfoForm form;
            if (isAdmin)
            {
                form = new adminInfoForm(adm.Name, adm.Role, this, adm.Id, false);
            }
            else
            {
                form = new adminInfoForm(pss.Name, pss.Role, this, pss.Id, true);
            }
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (isAdmin)
            {
                vf = new viewFlightsForm(this, isAdmin, adm.Id);
                vf.Show();
            }
            else
            {
                vf = new viewFlightsForm(this, isAdmin, pss.Id);
                vf.Show();
            }


        }
        private void label3_Click(object sender, EventArgs e)
        {
            //my tickets
            if (isAdmin)
            {
                vf = new viewFlightsForm(this, isAdmin, adm.Id);
            }
            else
            {
                vf = new viewFlightsForm(this, isAdmin, pss.Id);
            }
            viewTicketsForm f = new viewTicketsForm(this, pss.Id, vf, false);
            this.Hide();
            f.Show();

        }
        private void label7_Click(object sender, EventArgs e)
        {
            form.Width = this.Width;
            form.Height = this.Height;
            form.Location = this.Location;
            this.Close();
            form.Show();
        }








        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlDark;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SteelBlue;
        }


        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = SystemColors.ControlDark;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.SteelBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlDark;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SteelBlue;
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            ReportsForm Rform = new ReportsForm(this);
            this.Hide();
            Rform.Show();
        }

        private void waitButton_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                adminWaitlist wf = new adminWaitlist(this);
                this.Hide();
                wf.Show();
            }
            else
            {
                waitlistForm wform = new waitlistForm(this, pss.Id);
                this.Hide();
                wform.Show();
            }
        }

        private void waitButton_MouseEnter(object sender, EventArgs e)
        {
            waitButton.ForeColor = SystemColors.ControlDark;
        }

        private void waitButton_MouseLeave(object sender, EventArgs e)
        {
            waitButton.ForeColor = Color.SteelBlue;
        }

        private void generateReportButton_MouseEnter(object sender, EventArgs e)
        {
            generateReportButton.ForeColor = SystemColors.ControlDark;
        }

        private void generateReportButton_MouseLeave(object sender, EventArgs e)
        {
            generateReportButton.ForeColor = Color.SteelBlue;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ControlDark;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor= Color.SteelBlue;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            takePassID tpi = new takePassID(this);
            this.Hide();
            tpi.Show();
        }
    }
}
