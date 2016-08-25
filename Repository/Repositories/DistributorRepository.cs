using System.Data.Entity;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class DistributorRepository : BaseRepository<Distributor>, IDistributorRepository
    {
        protected override IDbSet<Distributor> DbSet
        {
            get { return db.Distributors; }
        }

        public DistributorRepository(IUnityContainer container) : base(container)
        {
        }
    }
}
