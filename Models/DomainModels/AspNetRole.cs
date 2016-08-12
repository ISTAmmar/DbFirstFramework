using System.Collections.Generic;

namespace Models.DomainModels
{
    public class AspNetRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
