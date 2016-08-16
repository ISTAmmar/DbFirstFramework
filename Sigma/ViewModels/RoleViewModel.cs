using System.Collections.Generic;
using Sigma.Models;

namespace Sigma.ViewModels
{
    public class RoleViewModel
    {
        public RoleViewModel()
        {
            Role = new AspNetRole();
            Roles = new List<AspNetRole>();
        }
        
        public AspNetRole Role { get; set; }
        public IList<AspNetRole> Roles { get; set; }
    }
}