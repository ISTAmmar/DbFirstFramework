using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;
using Sigma.ModelMapper;
using Sigma.ViewModels;

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
            TaskViewModel viewModel = new TaskViewModel
            {
                Taskks = taskService.GetAll().Select(x => x.CreateFromServerToClient()).ToList()
            };
            return View(viewModel);
        }
    }
}