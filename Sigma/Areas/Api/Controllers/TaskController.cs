using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfaces.Services;

namespace Sigma.Areas.Api.Controllers
{
    public class TaskController : ApiController
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var dashboard = taskService.GetAll();
            return request.CreateResponse(HttpStatusCode.OK, dashboard.ToArray());
        }
    }
}
