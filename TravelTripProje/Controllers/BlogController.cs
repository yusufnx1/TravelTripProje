using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            BlogYorum by = new BlogYorum();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {
            BlogYorum by = new BlogYorum();

            by.Deger1 = c.Blogs.Where(x => x.BlogID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.BlogId == id).ToList();

            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar b)
        {
            c.Yorumlars.Add(b);
            c.SaveChanges();
            return PartialView();
        }
    }
}