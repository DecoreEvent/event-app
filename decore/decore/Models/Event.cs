using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace decore.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventType { get; set; }

        public int nameId { get; set; }
        public string name { get; set; }

    }
}