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
            ConfigureVisibleElements();
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
                string qSql = GetSelectRequest();

                if (!string.IsNullOrEmpty(txtEventName.Text))
                {
                    qSql += $"AND LOWER(EventName) LIKE '%{txtEventName.Text.ToLower()}%' ";
                }
                if (!string.IsNullOrEmpty(txtEventCapacity.Text))
                {
                    qSql += $"AND Capacity = {txtEventCapacity.Text} ";
                }
                if (!string.IsNullOrEmpty(txtBoxLocation.Text))
                {
                    qSql += $"AND LOWER(Location) LIKE '%{txtBoxLocation.Text.ToLower()}%' ";
                }
                if (dateTimePickerEvent.Checked)
                {
                    DateTime dateTime = dateTimePickerEvent.Value;
                    string date = dateTime.ToString("yyyy-MM-dd");
                    qSql += $"AND Date = '{date}' ";
                }
                if (CurrentUser.User.Role == Role.Manager)
                {
                    qSql += $"AND ManagerName = '{CurrentUser.User.Username}' ";
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
                string qStr = GetSelectRequest();

                if (CurrentUser.User.Role == Role.Manager)
                {
                    qStr += $"AND ManagerName = '{CurrentUser.User.Username}'";
                }
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                using (MySqlDataReader dataReader = mySqlCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridEvents.DataSource = dataTable;

                    string columnNameToHide = "EventId"; 
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

        private string GetSelectRequest()
        {
            string qStr = """
                    SELECT *
                    FROM Events 
                    WHERE 1 = 1 
                    """;
            if (CurrentUser.User.Role == Role.Attendee)
            {
                qStr += """ AND Valid = 'Y'""";
            }
            if (checkBoxMyEvents.Checked)
            {
                qStr += $"""
                    AND EventId IN (
                        SELECT EventId
                        FROM Register
                        WHERE UserName = '{CurrentUser.User.Username}'
                    ) 
                    """;
            }

            return qStr;
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

        private void ConfigureVisibleElements()
        {
            bool isAttendee = CurrentUser.User.Role == Role.Attendee;
            bool isAdmin = CurrentUser.User.Role == Role.Administrator;
            btnAddEvent.Visible = isAdmin;
            btnEditEvent.Visible = !isAttendee;
            btnDelete.Visible = isAdmin;
            btnEventAttendees.Visible = !isAttendee;
            btnCancelRegister.Visible = isAttendee;
            btnRegister.Visible = isAttendee;
            checkBoxMyEvents.Visible = isAttendee;
            usersToolStripMenuItem.Visible = isAdmin;
            toolStripMenuItem6.Visible = isAdmin;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (dataGridEvents.SelectedRows.Count > 0)
            {
                try
                {

                    DataGridViewRow selectedRow = dataGridEvents.SelectedRows[0];
                    int eventId = (int)selectedRow.Cells["EventId"].Value;
                    int capacity = (int)selectedRow.Cells["Capacity"].Value;
                    if (capacity > 0)
                    {
                        string qStr = $"INSERT INTO Register VALUES ('{CurrentUser.User.Username}', {eventId});" +
                            $"UPDATE Events SET Capacity = {--capacity} WHERE EventId = {eventId}";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();
                        LoadAlldata();
                        MessageBox.Show("You have registered for this event!", "Successful registration", MessageBoxButtons.OK);
                    } else
                    {
                        MessageBox.Show("Not enough capacity for new attendees", "Warning",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"You are already registered", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select an event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int capacity = (int)selectedRow.Cells["Capacity"].Value;
                    string qStr = $"DELETE FROM Register WHERE UserName = '{CurrentUser.User.Username}' AND EventId = {eventId}; " +
                        $"UPDATE Events SET Capacity = {++capacity} WHERE EventId = {eventId}; ";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();
                    LoadAlldata();
                    MessageBox.Show("You have canceled your registration for this event!", "Successful cancellation", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"You are not registered for this event", "Error", MessageBoxButtons.OK);
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

        private void checkBoxMyEvents_CheckedChanged(object sender, EventArgs e)
        {
            LoadAlldata();
        }
    }
}
