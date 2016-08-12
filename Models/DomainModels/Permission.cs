using System.Collections.Generic;

namespace Models.DomainModels
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionDescription { get; set; }
        public string PermissionKey { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
