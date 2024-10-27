using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Models.Entities;

namespace TravelTripProje.Controllers
{
    [Authorize]
    public class YorumController : Controller
    {
        // GET: Yorum
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Yorumlars.ToList();
            return View(value);
        }
        public ActionResult YorumSil(int id)
        {
            var value = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}