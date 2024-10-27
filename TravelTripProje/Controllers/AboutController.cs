using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var değeler = c.Hakkimizdas.ToList();
            return View(değeler);
        }
    }
}