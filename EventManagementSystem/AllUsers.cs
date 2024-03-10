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
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail form = new UserDetail();
            form.Show();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail form = new EventDetail();
            form.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.Show();
        }

        private void attendeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
