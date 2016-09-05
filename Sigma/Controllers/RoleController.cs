using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interfaces.Services;
using Sigma.ModelMapper;
using Sigma.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Sigma.Models;
using AspNetRole = Models.DomainModels.AspNetRole;

namespace Sigma.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        #region Private

        private IRolePermissionService rolePermissionService { get; set; }
        private IAspNetRoleService roleService { get; set; }
        private ApplicationUserManager userManager;

        #endregion

        #region Constructor

        public RoleController(IRolePermissionService rolePermissionService, IAspNetRoleService roleService)
        {
            this.rolePermissionService = rolePermissionService;
            this.roleService = roleService;
        }

        public ApplicationUserManager UserManager
        {
            get { return userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            private set { userManager = value; }
        }

        RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(
            new RoleStore<IdentityRole>(new ApplicationDbContext()));

        #endregion

        #region Public

        public ActionResult RolePermission()
        {
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

        public ActionResult PostRolePermission(string roleValue, string selectedList)
        {
            //RolePermissionViewModel viewModel = new RolePermissionViewModel(RolePermissionViewModel viewModel);
            //var response = rolePermissionService.GetRolePermissionByRoleId(Convert.ToInt32(formCollection["RoleId"]));
            //viewModel.Roles = response.AspNetRoles.Select(x => x.CreateFromServerToClient()).ToList();
            //viewModel.RolePermissions = response.RolePermissions.Select(x => x.CreateFromServerToClient()).ToList();
            return RedirectToAction("RolePermission");
        }

        public ActionResult Index()
        {
            RoleViewModel viewModel = new RoleViewModel();
            IEnumerable<AspNetRole> response = roleService.GetAll();
            viewModel.Roles = response.Select(x => x.CreateFromServerToClient()).ToList();
            return View(viewModel);
        }

        public ActionResult Create(int? id)
        {
            RoleViewModel viewModel = new RoleViewModel();
            if (id != null)
            {
                viewModel.Role = roleService.FindById(Convert.ToInt32(id)).CreateFromServerToClient();
            }
            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Create(RoleViewModel model)
        {
            if (model.Role.Id > 0)
            {
                if (roleService.UpdateRole(model.Role.CreateFromClientToServer()))
                {
                    return RedirectToAction("Index", "Role");
                }
                ModelState.AddModelError("", "This role name has already been used.");
            }
            else
            {
                if (roleService.AddRole(model.Role.CreateFromClientToServer()))
                {
                    return RedirectToAction("Index", "Role");
                }
                ModelState.AddModelError("", "This role name has already been used.");
            }
            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                roleService.DeleteRole(Convert.ToInt32(id));
            }
            return RedirectToAction("Index");
        }

        #endregion
    }
}