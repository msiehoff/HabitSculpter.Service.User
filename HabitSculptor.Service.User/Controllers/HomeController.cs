using System.Web.Mvc;

namespace HabitSculptor.Service.Users.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
