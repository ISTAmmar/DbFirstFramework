using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;
using Sigma.ViewModels;

namespace Sigma.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        private IDashboardService dashboardService { get; set; }

        public DashboardController(IDashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
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