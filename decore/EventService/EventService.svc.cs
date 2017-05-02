using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Decore.Models;

namespace EventService
{
    public class EventService : IEventService
    {
        public ICollection<Event> GetEvents()
        {
            var events = new List<Event>
            {
                new Event() { EventId = 1, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { EventId = 2, Title = "Vidar visar upp sig", EventType = "Sittning", Adress = "Hos Vidar 21", Description = "Se Vidar gå loss"},
                new Event() { EventId = 3, Title = "Vidar går och handlar", EventType = "Shopping", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { EventId = 4, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
            };

            return events;
        }

        public Event GetEventById(int eventId)
        {
            throw new NotImplementedException();
        }

        public void PostEvent(Event eventObject)
        {
            throw new NotImplementedException();
        }
    }
}
