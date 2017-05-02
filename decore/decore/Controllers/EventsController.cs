using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using decore.EventServiceReference;
using decore.ViewModels;
using Newtonsoft.Json;
using Decore.Models;

namespace decore.Controllers
{
    public class EventsController : Controller
    {

        private readonly EventServiceClient _eventWcfClient = new EventServiceClient();


        public ActionResult Index(string title, string description)
        {
       
            ICollection<Event> events = _eventWcfClient.GetEvents();

            var viewModel = new EventViewModel
            {
                Events = events
            };

            return View(viewModel);
        }
    }
}