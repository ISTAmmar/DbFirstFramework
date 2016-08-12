using Models.DomainModels;

namespace Sigma.ModelMapper
{
    public static class RolePermissionMapper
    {
        public static Models.RolePermission CreateFromServerToClient(this RolePermission source)
        {
            return new Models.RolePermission
            {
                RolePermissionId = source.RolePermissionId,
                RoleId = source.RoleId,
                PermissionId = source.PermissionId,

                Permission = source.Permission.CreateFromServerToClient()
            };
        }
    }
}