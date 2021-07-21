using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        //static private List<string> Events = new List<string>();

        private static Dictionary<string, string> Events = new Dictionary<string, string>();


        [HttpGet]
        public IActionResult Index()
        {
            /*Events.Add("CodeForPhoenix");
            Events.Add("CSharp For Dummies");
            Events.Add("Your Brain On C#");*/
            ViewBag.events = Events;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string eventDescription)
        {
            Events.Add(name, eventDescription);

            return Redirect("/events");
        }
    }
}
