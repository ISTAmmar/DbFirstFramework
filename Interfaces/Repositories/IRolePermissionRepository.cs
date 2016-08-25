using System.Collections.Generic;
using Models.DomainModels;

namespace Interfaces.Repositories
{
    public interface IRolePermissionRepository : IBaseRepository<RolePermission, long>
    {
        IEnumerable<RolePermission> GetRolePermissionByRoleId(int roleId);
    }
}
