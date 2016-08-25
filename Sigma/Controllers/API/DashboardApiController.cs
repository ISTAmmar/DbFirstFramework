using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfaces.Services;

namespace Sigma.Controllers.API
{
    public class DashboardApiController : ApiController
    {
        public IDashboardService dashboardService { get; set; }

        public DashboardApiController(IDashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var dashboard = dashboardService.GetDashboardResponse();
            return request.CreateResponse(HttpStatusCode.OK, dashboard.Distributors.ToArray());
        }
    }
}