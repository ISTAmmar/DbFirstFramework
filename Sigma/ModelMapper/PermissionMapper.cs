using Models.DomainModels;

namespace Sigma.ModelMapper
{
    public static class PermissionMapper
    {
        public static Models.Permission CreateFromServerToClient(this Permission source)
        {
            return new Models.Permission
            {
                PermissionId = source.PermissionId,
                PermissionDescription = source.PermissionDescription,
                PermissionKey = source.PermissionKey
            };
        }
    }
}