using MySql.Data.MySqlClient;


namespace ICS321Project
{
    public partial class waitlistForm : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private int id;
        private AdminForm af;
        public waitlistForm(AdminForm f, int id)
        {
            InitializeComponent();

            this.Height = f.Height;
            this.Width = f.Width;
            this.Location = f.Location;
            this.id = id;
            this.af = f;
            loadOnPanel();
            
        }
        private void loadOnPanel()
        {
            listView1.Items.Clear();
            mycon.Open();
            string query2 = "SELECT * FROM flight f left join waitlistedfor w on w.FID = f.FID WHERE PID =" + id;
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();


            while (reader2.Read())
            {
                ListViewItem item = new ListViewItem(reader2["FID"] + "");
                item.SubItems.Add(reader2["SRCCity"] + "");
                item.SubItems.Add(reader2["Destination"] + "");
                item.SubItems.Add(reader2["Date"] + "");
                item.SubItems.Add(reader2["ClassType"] + "");
                listView1.Items.Add(item);

            }
            mycon.Close();
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.ForeColor = SystemColors.ControlDark;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.ForeColor = Color.SteelBlue;
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = SystemColors.ControlDark;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.SteelBlue;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            
            int itemsSelected = listView1.SelectedItems.Count;
            if (itemsSelected == 1)
            {
                
                mycon.Open();
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int num = int.Parse(selectedItem.Text);
                List<string> subitemValues = new List<string>();

                // Iterate over the subitems of the ListViewItem
                foreach (ListViewItem.ListViewSubItem subitem in selectedItem.SubItems)
                {
                    // Store the value of each subitem in the list
                    subitemValues.Add(subitem.Text);
                }
                string query2 = "delete from waitlistedfor where PID = " + id + " and FID =" + num + " and ClassType = " +"'"+subitemValues[4]+"'";
                MySqlCommand command2 = new MySqlCommand(query2, mycon);
                command2.ExecuteNonQuery();
                mycon.Close();
                loadOnPanel();

            }
            else
            {
                MessageBox.Show("Please Select a Ticket");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            af.Height = this.Height;
            af.Width = this.Width;
            af.Location = this.Location;
            this.Hide();
            af.Show();
        }
    }
}
