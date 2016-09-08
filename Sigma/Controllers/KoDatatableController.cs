using System.Web.Mvc;

namespace Sigma.Controllers
{
    public class KoDatatableController : Controller
    {
        // GET: Datatable
        public ActionResult HtmlBinding()
        {
            return View();
        }
        public ActionResult JqueryBinding()
        {
            return View();
        }
    }
}