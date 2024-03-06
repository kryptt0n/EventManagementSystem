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
    public partial class EventAttendees : Form
    {
        public EventAttendees()
        {
            InitializeComponent();
        }

        private void btnAddAttendee_Click(object sender, EventArgs e)
        {
            AddAttendee addAttendee = new AddAttendee();
            addAttendee.Show();

        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
        }
    }
}
