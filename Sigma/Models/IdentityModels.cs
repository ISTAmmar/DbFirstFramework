using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Sigma.Models
{
    public class Users : IdentityUser<int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationUserRole : IdentityUserRole<int>
    {
    }

    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
    }

    public class ApplicationUserClaim : IdentityUserClaim<int>
    {
    }

    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>
    {
    }

    public class ApplicatonUserStore :
        UserStore<Users, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicatonUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }

    public class ApplicationDbContext
        : IdentityDbContext<Users, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!

            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.EmailConfirmed).HasColumnName("IsActive");
            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.PasswordHash).HasColumnName("Password");
            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.PhoneNumberConfirmed).HasColumnName("IsSuperAdmin");
            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.TwoFactorEnabled).HasColumnName("HasAllDistribution");
            modelBuilder.Entity<Users>().ToTable("User").Property(p => p.LockoutEnabled).HasColumnName("HasAllCategory");
            //modelBuilder.Entity<IdentityRole>().ToTable("Role");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
        }
    }
}