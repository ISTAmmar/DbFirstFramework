using System.Data.Entity;
using DAL.BaseRepository;
using Models.DomainModels;

namespace DAL.Repositories
{
    public class DistributorRepository : BaseRepository<Distributor>
    {
        protected override IDbSet<Distributor> DbSet
        {
            get { return db.Distributors; }
        }
    }
}
