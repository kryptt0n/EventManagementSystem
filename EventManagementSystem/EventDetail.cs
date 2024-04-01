using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace EventManagementSystem
{
    public partial class EventDetail : Form
    {
        private MySqlConnection connection;
        ActionType actionType;
        string eventID;
        public EventDetail()
        {
            InitializeComponent();
            connection = Program.db.GetConnection();
            LoadManagers();
        }

        public EventDetail(ActionType action, DataGridViewRow row = null) : this()
        { 
            if (action == ActionType.Add)
            {

            } else if (action == ActionType.Edit)
            {
                if (row != null)
                {
                    string eventName = row.Cells["EventName"].Value.ToString();
                    string date = row.Cells["Date"].Value.ToString();
                    string capacity = row.Cells["Capacity"].Value.ToString();
                    string location = row.Cells["Location"].Value.ToString();
                    string organizer = row.Cells["Organizer"].Value.ToString();
                    string managerName = row.Cells["ManagerName"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    string id = row.Cells["EventId"].Value.ToString();
                    string valid = row.Cells["Valid"].Value.ToString();

                    txtEventName.Text = eventName;
                    dateTimePickerEvent.Value = DateTime.Parse(date);
                    txtEventCapacity.Text = capacity;
                    txtBoxtLocation.Text = location;
                    comboBoxManager.Text = managerName;
                    txtEventOragnizer.Text = organizer;
                    comboBoxValid.Text = valid;
                    richTextBoxEventDesc.Text = description;
                    eventID = id;
                }
            }
            actionType = action;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string eventName = txtEventName.Text;
            string date = dateTimePickerEvent.Value.ToString("yyyy-MM-dd"); 
            string capacity = txtEventCapacity.Text;
            string location = txtBoxtLocation.Text;
            string managerName = comboBoxManager.Text;
            string organizer = txtEventOragnizer.Text;
            string valid = comboBoxValid.Text;
            string description = richTextBoxEventDesc.Text;

            if (actionType == ActionType.Add)
            {
                try
                {
                    string qStr = $"INSERT INTO Events(EventName, Date, Capacity, Location, Organizer, ManagerName, Description, Valid)  VALUES " +
                        $"('{eventName}','{date}',{capacity},'{location}','{organizer}','{managerName}','{description}', '{valid}')";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" New event added successfully!!!", "New Event", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
                
            }
            else if (actionType == ActionType.Edit)
            {
                try
                {
                    string qStr = $"UPDATE Events SET EventName = '{eventName}', Date = '{date}', Capacity = '{capacity}', " +
                        $"Location = '{location}', Organizer = '{organizer}', ManagerName = '{managerName}', Description = '{description}', Valid = '{valid}'" +
                        $" WHERE EventId = '{eventID}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" Event updated!!!", "Edit Event", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(ActionType.Add);
            userDetail.Show();
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

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
            Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            this.Close();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents registForEvents = new AllEvents();
            registForEvents.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void attendeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void registForEventsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void LoadManagers()
        {
            string sql = """
                SELECT UserName
                FROM User
                WHERE RoleId = 1002;
                """;

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            comboBoxManager.Items.Clear();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        comboBoxManager.Items.Add(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
