using ICS321Project.ents;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS321Project
{
    public partial class adminWaitlist : Form
    {
        MySqlConnection mycon = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=airlinereservation ;UID=root ;PASSWORD= Aqwsderfg123");
        private AdminForm af;
        public adminWaitlist(AdminForm af)
        {
            InitializeComponent();
            loadOnPanel();
            this.af = af;
            this.Height = af.Height;
            this.Width = af.Width;
            this.Location = af.Location;
        }
        private void loadOnPanel()
        {
            listView1.Items.Clear();
            mycon.Open();
            string query2 = "SELECT * FROM flight f left join waitlistedfor w on w.FID = f.FID where w.PID IS NOT NULL";
            MySqlCommand command2 = new MySqlCommand(query2, mycon);
            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                ListViewItem item = new ListViewItem(reader2["FID"] + "");
                item.SubItems.Add(reader2["SRCCity"] + "");
                item.SubItems.Add(reader2["Destination"] + "");
                item.SubItems.Add(reader2["Date"] + "");
                item.SubItems.Add(reader2["ClassType"] + "");
                item.SubItems.Add(reader2["PID"] + "");
                listView1.Items.Add(item);

            }
            mycon.Close();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            af.Height = this.Height;
            af.Width = this.Width;
            af.Location = this.Location;
            this.Hide();
            af.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.ForeColor = SystemColors.ControlDark;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.ForeColor = Color.SteelBlue;
        }

        private void discardButton_MouseEnter(object sender, EventArgs e)
        {
            discardButton.ForeColor = SystemColors.ControlDark;

        }

        private void discardButton_MouseLeave(object sender, EventArgs e)
        {
            discardButton.ForeColor = Color.SteelBlue;
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            discard();
        }
        private void discard()
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
                string query2 = "delete from waitlistedfor where PID = " + subitemValues[5] + " and FID = " + num + " and ClassType = " + "'" + subitemValues[4] + "'";
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

        private void promoteButton_MouseEnter(object sender, EventArgs e)
        {
            promoteButton.ForeColor = SystemColors.ControlDark;
        }

        private void promoteButton_MouseLeave(object sender, EventArgs e)
        {
            promoteButton.ForeColor = Color.SteelBlue;
        }

        private void promoteButton_Click(object sender, EventArgs e)
        {
            

            int itemsSelected = listView1.SelectedItems.Count;
            if (itemsSelected == 1)
            {
               
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int num = int.Parse(selectedItem.Text);
                List<string> subitemValues = new List<string>();

                // Iterate over the subitems of the ListViewItem
                foreach (ListViewItem.ListViewSubItem subitem in selectedItem.SubItems)
                {
                    // Store the value of each subitem in the list
                    subitemValues.Add(subitem.Text);
                }
                ticketCollection t = new ticketCollection(num);
                if (subitemValues[4]== "Economy Class")
                {
                    t.bookEco(Convert.ToInt32(subitemValues[5]));
                }
                else if (subitemValues[4] == "Business Class")
                {
                    t.bookBus(Convert.ToInt32(subitemValues[5]));
                }
                else if (subitemValues[4] == "First Class")
                {
                    t.bookfir(Convert.ToInt32(subitemValues[5]));
                }
                discard();

            }
            else
            {
                MessageBox.Show("Please Select a Ticket");
            }
        }
    }
}
