using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class EventAttendeesList : Form
    {
        private MySqlConnection connection;
        private string eventId;
        private List<string> registeredUsers;
        private List<string> unregisteredUsers;
        public EventAttendeesList(string eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
            connection = Program.db.GetConnection();
            LoadRegisteredAttendees();
            LoadAttendees();
            LoadEventInfo();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Hide();
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            if (listBoxUnregistered.SelectedItem != null)
            {
                int remainSeats = Convert.ToInt32(txtRemainSeats.Text);
                if (remainSeats > 0)
                {
                    txtRemainSeats.Text = (remainSeats - 1).ToString();
                    string userName = listBoxUnregistered.SelectedItem.ToString();
                    listBoxUnregistered.Items.Remove(userName);
                    listBoxRegistered.Items.Add(userName);
                }
                else
                {
                    MessageBox.Show("Not enough capacity for new attendees", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Please select an unregistered user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RemoveAllAttendees();
            AddRegisteredAttendees();
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            Hide();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(ActionType.Add);
            userDetail.Show();
        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEventName.Clear();
        }

        private void btnCancelSearchUser_Click(object sender, EventArgs e)
        {
            txtUnregistered.Clear();
        }

        private void LoadRegisteredAttendees()
        {
            try
            {
                string sql = $"""
                    SELECT UserName
                    FROM Register
                    WHERE EventId = {eventId};
                    """;

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                listBoxRegistered.Items.Clear();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxRegistered.Items.Add(reader.GetString(0));
                        registeredUsers.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }

        private void LoadAttendees()
        {
            string sql = """
                SELECT UserName
                FROM User
                WHERE RoleId = 1003 
                """;

            string alreadyRegistered = GetAttendeesUserNames();
            sql += alreadyRegistered;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            listBoxUnregistered.Items.Clear();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        listBoxUnregistered.Items.Add(reader.GetString(0));
                        unregisteredUsers.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private string GetAttendeesUserNames()
        {
            string result = "";

            if (listBoxRegistered.Items.Count > 0)
            {
                result += "AND UserName NOT IN (";
                foreach (string user in listBoxRegistered.Items)
                {
                    result += $"'{user}', ";
                }
            }
            result = result.Remove(result.Length - 2);
            result += ")";
            return result;
        }
        private void LoadEventInfo()
        {
            string sql = $"""
                SELECT EventName, Capacity
                FROM Events
                WHERE EventId = {eventId};
                """;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        txtEventName.Text = reader.GetString(0);
                        txtRemainSeats.Text = (reader.GetInt32(1) - listBoxRegistered.Items.Count).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void EventAttendeesList_Load(object sender, EventArgs e)
        {

        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            if (listBoxRegistered.SelectedItem != null)
            {
                int remainSeats = Convert.ToInt32(txtRemainSeats.Text);
                txtRemainSeats.Text = (remainSeats + 1).ToString();
                string userName = listBoxRegistered.SelectedItem.ToString();
                listBoxRegistered.Items.Remove(userName);
                listBoxUnregistered.Items.Add(userName);
            }
            else
            {
                MessageBox.Show("Please select an registered user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveAllAttendees()
        {
            try
            {
                string sql = $"DELETE FROM Register WHERE EventId = {eventId}";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }

        }

        private void AddRegisteredAttendees()
        {
            try
            {
                string sql = "";
                foreach (string userName in registeredUsers)
                {
                    sql += $"INSERT INTO Register VALUES ('{userName}', {eventId});";
                }
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnSearchRegistered_Click(object sender, EventArgs e)
        {
            // Display from registered list
        }

        private void btnSearchUnregistered_Click(object sender, EventArgs e)
        {
            // Display from unregistered list
        }
    }
}
