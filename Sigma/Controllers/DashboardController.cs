using System.Linq;
using System.Web.Mvc;
using Implementation.Services;
using Sigma.ViewModels;

namespace Sigma.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        private DashboardService dashboardService { get; set; }

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