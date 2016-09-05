using System.Data.Entity;
using System.Linq;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class AspNetRoleRepository : BaseRepository<AspNetRole>, IAspNetRoleRepository
    {
        protected override IDbSet<AspNetRole> DbSet
        {
            get { return db.AspNetRoles; }
        }

        public AspNetRoleRepository(IUnityContainer container) : base(container)
        {
        }

        //public AspNetRole Find(int roleId)
        //{
        //    return DbSet.Find(roleId);
        //}

        public bool CheckIfExist(AspNetRole role)
        {
            return DbSet.Any(m => m.Id != role.Id && m.Name == role.Name);
        }
    }
}