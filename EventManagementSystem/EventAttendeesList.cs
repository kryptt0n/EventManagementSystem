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

namespace EventManagementSystem
{
    public partial class EventAttendeesList : Form
    {
        private MySqlConnection connection;
        private string eventId;
        public EventAttendeesList(string eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
            connection = Program.db.GetConnection();
            LoadAttendees();
            LoadRegisteredAttendees();
            LoadEventInfo();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
            txtUserName.Clear();
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
                listBox1.Items.Clear();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox2.Items.Add(reader.GetString(0));
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
                WHERE RoleId = 1003;
                """;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            listBox1.Items.Clear();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }
        private void LoadEventInfo()
        {
            string sql = $"""
                SELECT EventName, Capacity
                FROM Events
                WHERE EventId = {eventId};
                """;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            listBox1.Items.Clear();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        txtEventName.Text = reader.GetString(0);
                        txtRemainSeats.Text = (reader.GetInt32(1) - listBox2.Items.Count).ToString();
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
    }
}
