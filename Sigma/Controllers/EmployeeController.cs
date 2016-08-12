using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Implementation;
using Microsoft.AspNet.Identity.Owin;
using Models.DomainModels;
using Sigma.Authorize;

namespace Sigma.Controllers
{
    public class EmployeeController : BaseController
    {
        #region Private

        private EmployeeService employeeService { get; set; }

        #endregion

        #region Constructor

        public EmployeeController()
        {
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