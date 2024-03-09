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
    public partial class AllEvents : Form
    {
        public AllEvents()
        {
            InitializeComponent();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
        }

        private void btnEventAttendees_Click(object sender, EventArgs e)
        {
            EventAttendees eventAttendees = new EventAttendees();
            eventAttendees.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail form = new EventDetail();
            form.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers form = new AllUsers();
            form.Show();
            Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail form = new UserDetail();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            this.Close();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents regist = new AllEvents();
            regist.Show();
            this.Close();
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
