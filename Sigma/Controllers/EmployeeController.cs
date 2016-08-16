using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BLL.Implementation;
using Interfaces.Services;
using Models.DomainModels;
using Sigma.Authorize;

namespace Sigma.Controllers
{
    public class EmployeeController : BaseController
    {
        

        #region Private

        private EmployeeService employeeService { get; set; }
        private readonly IEmployeeService iemployeeService;

        #endregion

        #region Constructor

        public EmployeeController(IEmployeeService iemployeeService)
        {
            this.iemployeeService = iemployeeService;
            employeeService = new EmployeeService();
        }

        #endregion

        #region Public

        [SiteAuthorize(PermissionKey = "EmployeeView")]
        public ActionResult Index()
        {
            IList<Employee> result = employeeService.GetAll().ToList();
            return View(result);
        }

        [SiteAuthorize(PermissionKey = "EmployeeAddEdit")]
        public ActionResult Create(long? id)
        {
            return View();
        }

        [SiteAuthorize(PermissionKey = "EmployeeDelete")]
        public ActionResult Delete()
        {
            return View();
        }

        #endregion
    }
}