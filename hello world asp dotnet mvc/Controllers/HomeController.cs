using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hello_world_asp_dotnet_mvc.Models;

namespace hello_world_asp_dotnet_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestsResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                //do zrobienia: wyślij zawartość guestResponse do organizatora przyjęcia
                return View("Thanks", guestResponse);
            }
            else
            {
                //błąd kontroli poprawności, więc ponownie wyświetlamy formularz wprowadzania danych
                return View();
            }
           
        }
    }
}