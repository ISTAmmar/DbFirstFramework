using System.Collections.Generic;
using System.Linq;
using Interfaces.Repositories;
using Interfaces.Services;
using Models.DomainModels;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class RolePermissionService : IRolePermissionService
    {
        #region Private

        private IRolePermissionRepository repository { get; set; }
        private IAspNetRoleRepository roleRepository { get; set; }

        #endregion

        #region Constructor

        public RolePermissionService(IRolePermissionRepository repository, IAspNetRoleRepository roleRepository)
        {
            this.repository = repository;
            this.roleRepository = roleRepository;
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