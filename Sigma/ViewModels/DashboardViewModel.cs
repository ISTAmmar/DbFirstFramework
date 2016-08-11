using System.Collections.Generic;
using Models.DomainModels;

namespace Sigma.ViewModels
{
    public class DashboardViewModel
    {
        public long Temp { get; set; }
        public int DistributorId { get; set; }
        public IList<Distributor> Distributors { get; set; }
    }
}