using System.Web.Mvc;

namespace Sigma.Controllers
{
    public class UnauthorizedRequestController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "You are not Authorize for this request. Please contact your Administrator.";
            return View();
        }
    }
}