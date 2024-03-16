using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public class Manager : User
    {
        public List<Event> Events {  get; set; }
    }
}
