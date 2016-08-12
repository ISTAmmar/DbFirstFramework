using System.Collections.Generic;

namespace Models.DomainModels
{
    public class AspNetRole
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
