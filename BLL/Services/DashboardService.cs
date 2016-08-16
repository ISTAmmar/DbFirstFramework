using System.Linq;
using Models.ResponseModels;
using Repository.Repositories;

namespace Implementation.Services
{
    public class DashboardService
    {
        private DistributorRepository distributorRepository { get; set; }

        public DashboardService()
        {
            distributorRepository = new DistributorRepository();
        }

        public DashboardResponse GetDashboardResponse()
        {
            DashboardResponse response = new DashboardResponse
            {
                Distributors = distributorRepository.GetAll().ToList()
            };
            return response;
        }
    }
}