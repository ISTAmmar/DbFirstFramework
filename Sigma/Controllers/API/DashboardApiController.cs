using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Implementation;

namespace Sigma.Controllers.API
{
    public class DashboardApiController : ApiController
    {
        public DashboardService dashboardService { get; set; }

        public DashboardApiController()
        {
            dashboardService = new DashboardService();
        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var dashboard = dashboardService.GetDashboardResponse();
            return request.CreateResponse(HttpStatusCode.OK, dashboard.Distributors.ToArray());
        }
    }
}