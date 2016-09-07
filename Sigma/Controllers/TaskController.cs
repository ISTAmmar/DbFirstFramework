using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;
using Models.RequestModels;
using Models.ResponseModels;
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

        [HttpPost]
        public ActionResult Index(TaskSearchRequest searchRequest)
        {
            TaskResponse response = taskService.GetAllTasks(searchRequest);
            var list = response.Tasks.Select(x => x.CreateFromServerToClient());
            TaskAjaxViewModel listViewModel = new TaskAjaxViewModel
            {
                data = list,
                recordsTotal = response.TotalCount,
                recordsFiltered = response.FilteredCount
            };
            return Json(listViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}