using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using decore.Models;
using decore.ViewModels;

namespace decore.Controllers
{
    public class EventController : Controller
    {
      
        public ActionResult Index()
        {
            var events = new List<Event>
            {
                new Event() { EventId = 1, EventType = "Sittning"},
                new Event() { EventId = 2, EventType = "Mat hos patrik"},
                new Event() { EventId = 3, EventType = "Fest"},
                new Event() { EventId = 4, EventType = "Lan"},
            };
         
               var viewModel = new EventViewModel
            {
                Events = events
            };

            return View(viewModel);
        }

        // GET: Event
        [HttpPost]
        public ActionResult CreateEvent()
        {
            return RedirectToAction("Index");
        }

    }
}