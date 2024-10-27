using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Blogs.ToList();
            return View(value);
        }
        public PartialViewResult Partial1()
        {
            var değerler = c.Blogs.OrderByDescending(u => u.BlogID).Take(3).ToList();
            return PartialView(değerler);
        }
        public PartialViewResult Partial2()
        {
            var value = c.Blogs.ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = c.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial4()
        {
            var value = c.Blogs.OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return PartialView(value);
        }
    }
}