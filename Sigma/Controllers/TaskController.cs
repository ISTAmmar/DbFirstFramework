using System.Web.Mvc;
using Interfaces.Services;

namespace Sigma.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService taskService;

        public TaskController(ITaskService taskService)
        {
            this.taskService = taskService;
        }
        // GET: Task
        public ActionResult Index()
        {
            var dashboard = taskService.GetAll();
            return View();
        }
    }
}