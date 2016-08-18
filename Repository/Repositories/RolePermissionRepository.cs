using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class RolePermissionRepository : BaseRepository<RolePermission>
    {
        #region Protected

        protected override IDbSet<RolePermission> DbSet
        {
            get { return db.RolePermissions; }
        }

        #endregion

        #region Public

        public IEnumerable<RolePermission> GetRolePermissionByRoleId(int roleId)
        {
            return DbSet.Where(role => role.RoleId == roleId).ToList();
        }

        #endregion

    }
}