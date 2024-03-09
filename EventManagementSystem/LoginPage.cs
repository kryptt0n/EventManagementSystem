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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // this part is only for testing layout
           /* if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter user name.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtUserName.Text == "admin")
                {
                    AllEvents allEventsAdmin = new AllEvents();
                    allEventsAdmin.Show();
                    Hide();
                }
                else if(txtUserName.Text == "manager")
                {
                    AllEvents allEventsManager = new AllEvents();
                    allEventsManager.Show();
                    Hide();
                }
                else
                {
                    AllEvents allEventsUser = new AllEvents();
                    allEventsUser.Show();
                    Hide();
                }
            }*/
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            Hide();
        }
    }
}
