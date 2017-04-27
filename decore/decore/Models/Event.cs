using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace decore.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string EventType { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string ZipCode { get; set; }
    }
}