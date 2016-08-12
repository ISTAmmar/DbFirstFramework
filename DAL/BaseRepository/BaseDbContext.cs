using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Models.DomainModels;

namespace DAL.BaseRepository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext()
            : base("name=BaseDbContext")
        {
            Database.SetInitializer<BaseDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
    }
}
