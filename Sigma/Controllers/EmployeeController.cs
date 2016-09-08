using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Interfaces.Services;
using Models.DomainModels;
using Sigma.Authorize;

namespace Sigma.Controllers
{
    public class EmployeeController : BaseController
    {
        #region Private

        private readonly IEmployeeService employeeService;

        #endregion

        #region Constructor

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        #endregion

        #region Public

        [CustomAuthorize(PermissionKey = "EmployeeView")]
        public ActionResult Index()
        {
            IList<Employee> result = employeeService.GetAll().ToList();
            return View(result);
        }

        [CustomAuthorize(PermissionKey = "EmployeeAddEdit")]
        public ActionResult Create(long? id)
        {
            return View();
        }

        [CustomAuthorize(PermissionKey = "EmployeeDelete")]
        public ActionResult Delete()
        {
            return View();
        }

        #endregion
    }
}