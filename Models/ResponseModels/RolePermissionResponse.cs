using System.Collections.Generic;
using Models.DomainModels;

namespace Models.ResponseModels
{
    public class RolePermissionResponse
    {
        public IEnumerable<AspNetRole> AspNetRoles { get; set; }
        public IEnumerable<RolePermission> RolePermissions { get; set; }
    }
}
