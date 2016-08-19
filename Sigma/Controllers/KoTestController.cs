using System.Web.Mvc;
using Sigma.Models;

namespace Sigma.Controllers
{
    public class KoTestController : Controller
    {
        // GET: KoTest
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Save(Person person)
        {
            var message = string.Format("Saved {0} {1}", person.FirstName, person.LastName);
            return Json(new {message});
        }
    }
}