using System.Linq;
using System.Web.Mvc;
using BLL.Implementation;
using Sigma.ViewModels;

namespace Sigma.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardService dashboardService { get; set; }

        public DashboardController()
        {
            dashboardService = new DashboardService();
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            var response = dashboardService.GetDashboardResponse();
            DashboardViewModel viewModel = new DashboardViewModel
            {
                Temp = 8,
                Distributors = response.Distributors.ToList()
            };
            return View(viewModel);
        }
    }
}