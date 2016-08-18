using System.Collections.Generic;
using System.Linq;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.Repositories;

namespace Implementation.Services
{
    public class RolePermissionService
    {
        #region Private

        private RolePermissionRepository repository { get; set; }
        private AspNetRoleRepository roleRepository { get; set; }

        #endregion

        #region Constructor

        public RolePermissionService()
        {
            repository = new RolePermissionRepository();
            roleRepository = new AspNetRoleRepository();
        }

        #endregion

        #region Public

        public IEnumerable<RolePermission> GetAll()
        {
            return repository.GetAll();
        }

        public RolePermissionResponse GetRolePermissionByRoleId(int roleId)
        {
            RolePermissionResponse response = new RolePermissionResponse
            {
                AspNetRoles = roleRepository.GetAll().ToList()
            };
            AspNetRole firstOrDefault = response.AspNetRoles.FirstOrDefault();
            int userRoleId = roleId;
            if (roleId == 0 && firstOrDefault != null)
            {
                userRoleId = firstOrDefault.Id;
            }
            response.RolePermissions = userRoleId != 0
                ? repository.GetRolePermissionByRoleId(userRoleId)
                : new List<RolePermission>();
            return response;
        }

        #endregion
    }
}