using System.Collections.Generic;
using Models.DomainModels;

namespace Interfaces.Services
{
    public interface IAspNetRoleService
    {
        IEnumerable<AspNetRole> GetAll();
        AspNetRole FindById(int roleId);
        bool AddRole(AspNetRole role);
        bool UpdateRole(AspNetRole role);
        void DeleteRole(int roleId);

    }
}