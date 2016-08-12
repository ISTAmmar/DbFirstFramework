using System;
using System.Collections.Generic;

namespace Models.DomainModels
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? ArchivedBy { get; set; }
        public DateTime? ArchivedOn { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool HasAllDistribution { get; set; }
        public bool HasAllCategory { get; set; }
        public bool IsArchived { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
