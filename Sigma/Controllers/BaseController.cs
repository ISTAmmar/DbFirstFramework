using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Implementation.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Sigma.Models;

namespace Sigma.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationUserManager _userManager;
        private RolePermissionService permissionService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            SetUserPermissionSet();
        }

        private void SetUserPermissionSet()
        {
            Users userResult = UserManager.FindById(Convert.ToInt32(User.Identity.GetUserId()));
            if (userResult != null && userResult.Roles.Any())
            {
                List<ApplicationUserRole> roles = userResult.Roles.ToList();
                permissionService = new RolePermissionService();
                var userPermission = permissionService.GetRolePermissionByRoleId(roles[0].RoleId);
                string[] userPermissions = userPermission.RolePermissions.Select(user => user.Permission.PermissionKey).ToArray();
                Session["UserPermissionSet"] = userPermissions;
            }
        }

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            private set { _userManager = value; }
        }
    }
}