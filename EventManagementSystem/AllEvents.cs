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
    }
}
