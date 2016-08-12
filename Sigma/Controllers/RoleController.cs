using System;
using System.Linq;
using System.Web.Mvc;
using BLL.Implementation;
using Sigma.ModelMapper;
using Sigma.ViewModels;
using Microsoft.AspNet.Identity;

namespace Sigma.Controllers
{
    public class RoleController : Controller
    {
        #region Private

        private RolePermissionService rolePermissionService { get; set; }

        #endregion

        #region Constructor

        public RoleController()
        {
            rolePermissionService = new RolePermissionService();
        }

        #endregion

        #region Public

        [HttpGet]
        public ActionResult RolePermission()
        {
            var userId = User.Identity.GetUserId();
            RolePermissionViewModel viewModel = new RolePermissionViewModel();
            var response = rolePermissionService.GetRolePermissionByRoleId(0);
            viewModel.Roles = response.AspNetRoles.Select(x => x.CreateFromServerToClient()).ToList();
            viewModel.RolePermissions = response.RolePermissions.Select(x => x.CreateFromServerToClient()).ToList();
            return View(viewModel);
        }


        [HttpPost]
        public ActionResult RolePermission(FormCollection formCollection)
        {
            RolePermissionViewModel viewModel = new RolePermissionViewModel();
            var response = rolePermissionService.GetRolePermissionByRoleId(Convert.ToInt32(formCollection["RoleId"]));
            viewModel.Roles = response.AspNetRoles.Select(x => x.CreateFromServerToClient()).ToList();
            viewModel.RolePermissions = response.RolePermissions.Select(x => x.CreateFromServerToClient()).ToList();
            return View(viewModel);
        }

        #endregion
    }
}