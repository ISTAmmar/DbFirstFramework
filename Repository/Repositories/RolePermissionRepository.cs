using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class RolePermissionRepository : BaseRepository<RolePermission>, IRolePermissionRepository
    {
        #region Protected

        protected override IDbSet<RolePermission> DbSet
        {
            get { return db.RolePermissions; }
        }

        #endregion

        #region Public

        public RolePermissionRepository(IUnityContainer container) : base(container)
        {
        }

        public IEnumerable<RolePermission> GetRolePermissionByRoleId(int roleId)
        {
            return DbSet.Where(role => role.RoleId == roleId).ToList();
        }

        #endregion
    }
}