using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GUI_Restaurant.Models;

namespace GUI_Restaurant.Controllers
{
    public class GuestController : Controller
    {
        private RestaurantDbContext db = new();

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var guests = db.Guests.ToList();
            return View(guests);
        }

        [HttpGet]
        [Route("create")]
            
    }
}
