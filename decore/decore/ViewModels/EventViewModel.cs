using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using decore.Models;

namespace decore.ViewModels
{
    public class EventViewModel
    {
        public ICollection<Event> Events { get; set; }
        public Event nameId { get; set; }
        public Event name { get; set; }
    }
}