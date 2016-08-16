using System.Data.Entity;
using System.Linq;
using DAL.BaseRepository;
using Models.DomainModels;

namespace DAL.Repositories
{
    public class AspNetRoleRepository : BaseRepository<AspNetRole>
    {
        protected override IDbSet<AspNetRole> DbSet
        {
            get { return db.AspNetRoles; }
        }

        public AspNetRole Find(int roleId)
        {
            return DbSet.Find(roleId);
        }

        public bool CheckIfExist(AspNetRole role)
        {
            return DbSet.Any(m => m.Id != role.Id && m.Name == role.Name);
        }
    }
}
