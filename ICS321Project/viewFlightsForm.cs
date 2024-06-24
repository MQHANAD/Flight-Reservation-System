using ICS321Project.ents;
using MySql.Data.MySqlClient;
using System.Xml.Linq;


namespace ICS321Project
{

    public partial class viewFlightsForm : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        AdminForm form;
        private int passengerID;


        public viewFlightsForm(AdminForm form, Boolean isAdmin, int passengerID)
        {
            this.passengerID = passengerID;
            this.form = form;
            InitializeComponent();
            fillcomboBox();
            if (isAdmin)
            {
                label3.Show();
                label2.Hide();
                label4.Show();
                label5.Show();
                bookLabel.Hide();
            }
            else
            {
                label3.Hide();
                label2.Show();
                label4.Hide();
                label5.Hide();
                bookLabel.Show();
            }
            loadFlightsDB();

            this.Width = form.Width;
            this.Height = form.Height;
            this.Location = form.Location;
        }
        public void fillcomboBox()
        {
            mycon.Open();

            string query2 = "select distinct SRCCity from flight;";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();


            while (reader2.Read())
            {
                comboBox1.Items.Add(reader2["SRCCity"] + "");
            }
            reader2.Close();
            query2 = "select distinct Destination from flight;";
            command2 = new MySqlCommand(query2, mycon);
            reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2["Destination"] + "");
            }
            reader2.Close();

            mycon.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            ticketCollection.setFromModifecationFalse();
            form.Width = this.Width;
            form.Height = this.Height;
            form.Location = this.Location;
            this.Hide();
            form.Show();
        }
        internal void LoadFlightsOnThePanel(List<ents.flight> flights)
        {
            listView1.Items.Clear();

            foreach (ents.flight element in flights)
            {

                if (!string.IsNullOrEmpty(element.Id + ""))
                {
                    ListViewItem item = new ListViewItem(element.Id + "");
                    item.SubItems.Add(element.SrcCity);
                    item.SubItems.Add(element.DestCity);
                    item.SubItems.Add(element.Date.ToShortDateString());
                    listView1.Items.Add(item);
                }

            }

        }
        public void loadFlightsDB()
        {
            List<flight> collection = flightCollection.GetCollection();
            LoadFlightsOnThePanel(collection);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //waitlist button clicked
            if (listView1.SelectedItems.Count == 1)
            {

                flight flight1 = findFlight(listView1);
                bookingForm formB = new bookingForm(this, passengerID, false);
                formB.setFlight(flight1);
                this.Hide();
                formB.Show();

            }
            else
            {
                MessageBox.Show("please select a flight");
            }

        }

        private void bookLabel_MouseEnter(object sender, EventArgs e)
        {
            bookLabel.ForeColor = SystemColors.ControlDark;
        }

        private void bookLabel_MouseLeave(object sender, EventArgs e)
        {
            bookLabel.ForeColor = Color.SteelBlue;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ControlDark;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SteelBlue;
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ControlDark;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.SteelBlue;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlDark;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.SteelBlue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlDark;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SteelBlue;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ControlDark;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.SteelBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            addingFlight addForm = new addingFlight(this);
            addForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            flight fl = findFlight(listView1);
            flightCollection.remove(fl);
            loadFlightsDB();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                this.Hide();
                flight flight1 = findFlight(listView1);
                modifecationForm mform = new modifecationForm(this);
                mform.SetFlight(flight1);
                mform.Show();
            }

        }
        private flight findFlight(ListView l)
        {
            int itemsSelected = l.SelectedItems.Count;
            List<flight> flight1 = flightCollection.GetCollection();
            if (itemsSelected == 1)
            {
                ListViewItem selectedItem = l.SelectedItems[0];
                int num = int.Parse(selectedItem.Text);
                foreach (flight fl in flight1)
                {
                    if (fl.Id == num)
                    {
                        return fl;
                    }
                }

            }
            return null;
        }

        private void bookLabel_Click(object sender, EventArgs e)
        {
            //booking 
            if (listView1.SelectedItems.Count == 1)
            {

                flight flight1 = findFlight(listView1);
                bookingForm formB = new bookingForm(this, passengerID, true);
                formB.setFlight(flight1);
                this.Hide();
                formB.Show();

            }
            else
            {
                MessageBox.Show("please select a flight");
            }

        }

        private void SearchButton_MouseEnter(object sender, EventArgs e)
        {
            SearchButton.ForeColor = SystemColors.ControlDark;
        }

        private void SearchButton_MouseLeave(object sender, EventArgs e)
        {
            SearchButton.ForeColor = Color.SteelBlue;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select The City You are Travling from!");
            }
            else if (comboBox1.SelectedItem != null & comboBox2.SelectedItem == null)
            {
                List<flight> collection = flightCollection.GetCollection2(comboBox1.SelectedItem + "");
                LoadFlightsOnThePanel(collection);
            }
            else
            {
                List<flight> collection = flightCollection.GetCollection1(comboBox1.SelectedItem+"", comboBox2.SelectedItem+"");
                LoadFlightsOnThePanel(collection);
            }
        }


    }

}
