using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfaces.Services;
using Microsoft.Practices.Unity;

namespace Sigma.Controllers.API
{
    public class DashboardApiController : ApiController
    {
        public IDashboardService dashboardService { get; set; }
        //public DashboardApiController() : base()
        //{
        //}
        //public DashboardApiController(IDashboardService dashboardService)
        //{
        //    this.dashboardService = dashboardService;
        //}

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            dashboardService = UnityWebActivator.Container.Resolve<IDashboardService>();
            var dashboard = dashboardService.GetDashboardResponse();
            return request.CreateResponse(HttpStatusCode.OK, dashboard);
        }
    }
}