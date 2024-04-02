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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventManagementSystem
{
    public partial class AllEvents : Form
    {
        MySqlConnection connection = Program.db.GetConnection();
        public AllEvents()
        {
            InitializeComponent();
            LoadAlldata();
            DisplayButtons();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail(ActionType.Add);
            eventDetail.Show();
            Hide();
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                EventDetail eventDetail = new EventDetail(ActionType.Edit, dataGridEvents.SelectedRows[0]);
                eventDetail.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEventAttendees_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridEvents.SelectedRows[0];
                string eventId = selectedRow.Cells["EventId"].Value.ToString();
                EventAttendeesList list = new EventAttendeesList(eventId);
                list.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail form = new EventDetail(ActionType.Add);
            form.Show();
            Hide();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers form = new AllUsers();
            form.Show();
            Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail form = new UserDetail(ActionType.Add);
            form.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents regist = new AllEvents();
            regist.Show();
            Hide();
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            try
            {
                string qSql = """
                        SELECT *
                        FROM Events
                        WHERE Valid = 'Y' 
                        """;
                if (!string.IsNullOrEmpty(txtEventName.Text))
                {
                    qSql += $"AND EventName = '{txtEventName.Text}' ";
                }
                if (!string.IsNullOrEmpty(txtEventCapacity.Text))
                {
                    qSql += $"AND Capacity = {txtEventCapacity.Text} ";
                }
                if (!string.IsNullOrEmpty(txtBoxLocation.Text))
                {
                    qSql += $"AND Location = '{txtBoxLocation.Text}' ";
                }
                if (dateTimePickerEvent.Checked)
                {
                    DateTime dateTime = dateTimePickerEvent.Value;
                    string date = dateTime.ToString("yyyy-MM-dd");
                    qSql += $"AND Date = '{date}' ";
                }
                MySqlCommand mySqlCommand = new MySqlCommand(qSql, connection);
                using (MySqlDataReader dataReader = mySqlCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridEvents.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelSearchEvent_Click(object sender, EventArgs e)
        {
            txtEventName.Text = string.Empty;
            txtEventCapacity.Text = string.Empty;
            txtBoxLocation.Text = string.Empty;
            dateTimePickerEvent.Value = DateTime.Today;
            LoadAlldata();
        }

        public void LoadAlldata()
        {
            try
            {
                string qStr = """
                    SELECT *
                    FROM Events
                    WHERE Valid = 'Y'
                    """;

                MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                using (MySqlDataReader dataReader = mySqlCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridEvents.DataSource = dataTable;

                    string columnNameToHide = "EventId"; // Change this to the name of the column you want to hide
                    if (dataGridEvents.Columns.Contains("EventId"))
                    {
                        dataGridEvents.Columns[columnNameToHide].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                try
                {

                    DataGridViewRow selectedRow = dataGridEvents.SelectedRows[0];
                    string eventId = selectedRow.Cells["EventId"].Value.ToString();
                    string qStr = $"DELETE FROM Events WHERE EventId = '{eventId}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show(" Event Deleted successfully!!!", "Delete Event", MessageBoxButtons.OK);


                    LoadAlldata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($" Error in Database Operation : {ex.Message}", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayButtons()
        {
            bool isAttendee = CurrentUser.User.Role == Role.Attendee;
            btnAddEvent.Visible = !isAttendee;
            btnEditEvent.Visible = !isAttendee;
            btnDelete.Visible = !isAttendee;
            btnEventAttendees.Visible = !isAttendee;
            btnCancelRegister.Visible = isAttendee;
            btnRegister.Visible = isAttendee;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                try
                {

                    DataGridViewRow selectedRow = dataGridEvents.SelectedRows[0];
                    int eventId = (int)selectedRow.Cells["EventId"].Value;
                    string qStr = $"INSERT INTO Register VALUES ('{CurrentUser.User.Username}', {eventId})";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("You have registered for this event!", "Successful registration", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"You are already registered", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                try
                {

                    DataGridViewRow selectedRow = dataGridEvents.SelectedRows[0];
                    int eventId = (int)selectedRow.Cells["EventId"].Value;
                    string qStr = $"DELETE FROM Register WHERE UserName = '{CurrentUser.User.Username}' AND EventId = {eventId}";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("You have canceled your registration for this event!", "Successful cancellation", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"You are not registered", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllEvents_Load(object sender, EventArgs e)
        {

        }

        private void dataGridEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
