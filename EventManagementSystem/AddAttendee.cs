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
    public partial class AddAttendee : Form
    {
        public AddAttendee()
        {
            InitializeComponent();
        }

        private void btnAddAttendee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelAddAttendee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }
    }
}
