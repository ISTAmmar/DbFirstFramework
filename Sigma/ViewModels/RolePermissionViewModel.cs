using System.Collections.Generic;
using Sigma.Models;

namespace Sigma.ViewModels
{
    public class RolePermissionViewModel
    {
        public int RoleId { get; set; }
        public IList<AspNetRole> Roles { get; set; }
        public IList<RolePermission> RolePermissions { get; set; }
    }
}