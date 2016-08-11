﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Models.DomainModels;

namespace Sigma.Models
{
    // You can add profile data for the user by adding more properties to your User class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser
    {
        public long? EmployeeId { get; set; }
        public string Email { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder); // This needs to go before the other rules!

        //    modelBuilder.Entity<User>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");
        //    //modelBuilder.Entity<IdentityRole>().ToTable("Role");
        //    //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
        //    //modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
        //    //modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
        //}
    }
}