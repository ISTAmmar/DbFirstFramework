namespace Sigma.Models
{
    public class RolePermission
    {
        public long RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public bool IsSelected { get; set; }

        public virtual Permission Permission { get; set; }
    }
}