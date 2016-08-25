using System.Collections.Generic;
using Models.DomainModels;
using Models.ResponseModels;

namespace Interfaces.Services
{
    public interface IRolePermissionService
    {
        IEnumerable<RolePermission> GetAll();
        RolePermissionResponse GetRolePermissionByRoleId(int roleId);
    }
}
