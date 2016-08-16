using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sigma.Authorize
{
    public class SiteAuthorize : AuthorizeAttribute
    {
        public string PermissionKey { get; set; }
        public string[] PermissionKeys { get; set; }

        private bool IsAuthorized()
        {
            object userPermissionSet = HttpContext.Current.Session["UserPermissionSet"];
            IList<string> userPermissionsSet = (IList<string>)userPermissionSet;
            PermissionKeys = PermissionKey.Split(',');
            foreach (var permissionKey in PermissionKeys)
            {
                if (userPermissionsSet != null && userPermissionsSet.Contains(permissionKey))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Perform the authorization
        /// </summary>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }
            if (!string.IsNullOrEmpty(httpContext.Request.QueryString["C_Id"]))
            {
                return true;
            }
            return IsAuthorized();
        }
        /// <summary>
        /// Redirects request to unauthroized request page
        /// </summary>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
            else
            {
                filterContext.Result =
                    new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { area = "", controller = "UnauthorizedRequest", action = "Index" }));
            }
        }
    }
}