using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using decore.Models;
using decore.ViewModels;
using Newtonsoft.Json;

namespace decore.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index(string title, string description)
        {




            var events = new List<Event>
            {
                new Event() { EventId = 1, Title = title, EventType = "Sittning", Adress = "Skolgatan 21", Description = description},
                new Event() { EventId = 1, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { EventId = 2, Title = "Vidar visar upp sig", EventType = "Sittning", Adress = "Hos Vidar 21", Description = "Se Vidar gå loss"},
                new Event() { EventId = 3, Title = "Vidar går och handlar", EventType = "Shopping", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
                new Event() { EventId = 4, Title = "Knark Festen", EventType = "Sittning", Adress = "Skolgatan 21", Description = "Knarka på Så hårt det går"},
            };


            if (title != null)
            {
                var ev = new Event() { EventId = 1, Title = title, EventType = "Sittning", Adress = "Skolgatan 21", Description = description };
            }


            var viewModel = new EventViewModel
            {
                Events = events
            };


            return View(viewModel);
        }
    }
}