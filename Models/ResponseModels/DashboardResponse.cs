using System.Collections.Generic;
using Models.DomainModels;

namespace Models.ResponseModels
{
    public class DashboardResponse
    {
        public IEnumerable<Distributor> Distributors { get; set; }
    }
}
