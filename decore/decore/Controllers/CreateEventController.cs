using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using decore.Models;
using decore.ViewModels;

namespace decore.Controllers
{
    public class CreateEventController : Controller
    {
      
        public ActionResult Index()
        {
            var eventsTypes = new List<Event>
            {
                new Event() { EventId = 1, EventType = "Sittning"},
                new Event() { EventId = 2, EventType = "Mat hos patrik"},
                new Event() { EventId = 3, EventType = "Fest"},
                new Event() { EventId = 4, EventType = "Lan"},
            };        
               var viewModel = new EventViewModel
            {
                Events = eventsTypes
            };
            return View(viewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateEvent(EventViewModel viewModel)
        {



            return RedirectToAction(
                "Index", 
                "Events", 
                new
                {
                    Title = viewModel.Title,
                    Description = viewModel.Description
                });
        }


     





    }
}