using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BLL.Implementation;
using Models.DomainModels;

namespace Sigma.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeService employeeService { get; set; }

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        // GET: employeeService
        public ActionResult Index()
        {
            IList<Employee> result = employeeService.GetAll().ToList();
            return View(result);
        }
    }
}