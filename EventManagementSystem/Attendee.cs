using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public class Attendee : User
    {
        public List<Event> Events {  get; set; }
    }
}
