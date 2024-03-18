using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class Event
    {
        // private attributes
        private int EventId { get; set; }
        private string EventName { get; set; }
        private string EventDate { get; set; }
        private int EventCapacity { get; set; }
        private string EventLocation { get; set; }
        private string ManagerUserName { get; set; }
        private string EvnetDescription { get; set; }
        private char EventValid { get; set; }

        private List<Attendee> attendeeList { get; set; }


    }
}
