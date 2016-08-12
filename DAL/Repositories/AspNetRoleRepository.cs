using System.Data.Entity;
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
    }
}
