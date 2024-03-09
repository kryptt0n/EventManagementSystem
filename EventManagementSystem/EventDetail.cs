using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class EventDetail : Form
    {
        public EventDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            UserDetail userDetail = new UserDetail();
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
    }
}
