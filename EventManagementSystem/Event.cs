using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public class Event
    {
        // private attributes
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public int EventCapacity { get; set; }
        public string EventLocation { get; set; }
        public string ManagerUserName { get; set; }
        public string EvnetDescription { get; set; }
        public char EventValid { get; set; }

        public List<Attendee> attendeeList { get; set; }


    }
}
