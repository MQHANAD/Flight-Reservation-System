using ICS321Project.ents;
using MySql.Data.MySqlClient;

namespace ICS321Project
{
    public partial class viewTicketsForm : Form
    {
        static MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");

        private AdminForm f;
        private viewFlightsForm viewFlF;
        private int id;
        private static int Tid;
        public viewTicketsForm(AdminForm f, int id, viewFlightsForm viewFlF, Boolean isAdmin)
        {
            InitializeComponent();
            this.Height = f.Height;
            this.Width = f.Width;
            this.Location = f.Location;
            this.f = f;
            this.id = id;
            this.viewFlF = viewFlF;
            loadOnpanel();
            if (isAdmin)
            {
                PayButton.Hide();
                label1.Show();
            }
            else
            {
                PayButton.Show();
                label1.Hide();
            }
            

        }
        public void loadOnpanel()
        {
            listView1.Items.Clear();
            mycon.Open();
            string query2 = "SELECT * FROM Ticket WHERE PID =" + id;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem item = new ListViewItem(reader2["TicketID"] + "");
                item.SubItems.Add(reader2["FlightDate"] + "");
                item.SubItems.Add(reader2["Time"] + "");
                item.SubItems.Add(reader2["ClassType"] + "");
                item.SubItems.Add(reader2["FID"] + "");
                item.SubItems.Add(reader2["Status"] + "");
                listView1.Items.Add(item);

            }
            mycon.Close();


        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            int itemsSelected = listView1.SelectedItems.Count;
            if (itemsSelected == 1)
            {


                mycon.Open();
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Tid = int.Parse(selectedItem.Text);
                List<string> subitemValues = new List<string>();
                foreach (ListViewItem.ListViewSubItem subitem in selectedItem.SubItems)
                {
                    // Store the value of each subitem in the list
                    subitemValues.Add(subitem.Text);
                }
                string fid = subitemValues[4];
                if (subitemValues[5] == "Payed")
                {
                    MessageBox.Show("you Already Payed");
                }
                else if (subitemValues[5] == "Canceld")
                {
                    MessageBox.Show("Ticket is Canceld");
                }
                else
                {
                    string query2 = "select Destination, SRCCity from flight where FID =" + fid;
                    MySqlCommand command2 = new MySqlCommand(query2, mycon);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    string src = "";
                    string des = "";
                    while (reader2.Read())
                    {
                        src = reader2["SRCCity"] + "";
                        des = reader2["Destination"] + "";
                    }

                    viewFlF.Width = this.Width;
                    viewFlF.Height = this.Height;
                    viewFlF.Location = this.Location;
                    this.Hide();
                    List<flight> collection = flightCollection.GetCollection1(src, des);
                    viewFlF.Show();
                    viewFlF.LoadFlightsOnThePanel(collection);
                    ticketCollection.setFromModifecationTrue();
                }

                mycon.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Ticket");
            }
        }
        public static void deleteTicket()
        {
            mycon.Open();
            string query2 = "update Ticket set Status = 'Canceld' WHERE TicketID =" + Tid;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            command2 = new MySqlCommand(query2, mycon);
            command2.ExecuteNonQuery();
            mycon.Close();
        }


        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = SystemColors.ControlDark;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.SteelBlue;
        }

        private void modifyButton_MouseEnter(object sender, EventArgs e)
        {
            modifyButton.ForeColor = SystemColors.ControlDark;
        }

        private void modifyButton_MouseLeave(object sender, EventArgs e)
        {
            modifyButton.ForeColor = Color.SteelBlue;
        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            CancelButton.ForeColor = SystemColors.ControlDark;
        }

        private void CancelButton_MouseLeave(object sender, EventArgs e)
        {
            CancelButton.ForeColor = Color.SteelBlue;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            int itemsSelected = listView1.SelectedItems.Count;

            if (itemsSelected == 1)
            {
                mycon.Open();
                ListViewItem selectedItem = listView1.SelectedItems[0];
                List<string> subitemValues = new List<string>();
                foreach (ListViewItem.ListViewSubItem subitem in selectedItem.SubItems)
                {
                    // Store the value of each subitem in the list
                    subitemValues.Add(subitem.Text);
                }
                if (subitemValues[5] == "Canceld")
                {
                    MessageBox.Show("Ticket is Canceld");
                }
                else
                {
                    int num = int.Parse(selectedItem.Text);
                    string query2 = "update Ticket set Status = 'Canceld' WHERE TicketID =" + num;
                    MySqlCommand command2 = new MySqlCommand(query2, mycon);
                    command2.ExecuteNonQuery();
                    mycon.Close();
                    loadOnpanel();
                }


            }
            else
            {
                MessageBox.Show("Please Select a Ticket");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            f.Height = this.Height;
            f.Width = this.Width;
            f.Location = this.Location;
            this.Hide();
            f.Show();
        }

        private void PayButton_MouseEnter(object sender, EventArgs e)
        {
            PayButton.ForeColor = SystemColors.ControlDark;
        }

        private void PayButton_MouseLeave(object sender, EventArgs e)
        {
            PayButton.ForeColor = Color.SteelBlue;
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            //pay

            int itemsSelected = listView1.SelectedItems.Count;
            if (itemsSelected == 1)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int num = int.Parse(selectedItem.Text);

                List<string> subitemValues = new List<string>();
                foreach (ListViewItem.ListViewSubItem subitem in selectedItem.SubItems)
                {
                    // Store the value of each subitem in the list
                    subitemValues.Add(subitem.Text);
                }
                if (subitemValues[5] == "Canceld")
                {
                    MessageBox.Show("Ticket is Canceld");
                }
                else
                {
                    string query2 = "select * from ticket where TicketID=" + num;
                    string payed = "";

                    mycon.Open();
                    MySqlCommand command2 = new MySqlCommand(query2, mycon);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        payed = reader2["Status"] + "";
                    }
                    if (payed != "Payed")
                    {
                        SelectPaymentMethod Pform = new SelectPaymentMethod(this, id, num);
                        this.Hide();
                        Pform.Show();
                    }
                    else
                    {
                        MessageBox.Show("You Paid The ticket");
                    }
                    mycon.Close();
                }

            }
            else
            {
                MessageBox.Show("Please Select a Ticket");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewFlF.Show();
        }
    }
}
