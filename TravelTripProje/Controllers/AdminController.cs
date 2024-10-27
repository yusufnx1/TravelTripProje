using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var value = c.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult BlogGuncelle(Blog blogEkle)
        {
            var blg = c.Blogs.Find(blogEkle.BlogID);
            blg.Aciklama = blogEkle.Aciklama;
            blg.Baslik = blogEkle.Baslik;
            blg.Tarih = blogEkle.Tarih;
            blg.BlogImage = blogEkle.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}