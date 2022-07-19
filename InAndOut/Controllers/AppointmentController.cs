using Microsoft.AspNetCore.Mvc;
using System;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(todaysDate);
            return View();
        }
    }
}
