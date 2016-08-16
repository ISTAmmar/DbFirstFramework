using System.Data.Entity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class DistributorRepository : BaseRepository<Distributor>
    {
        protected override IDbSet<Distributor> DbSet
        {
            get { return db.Distributors; }
        }
    }
}
