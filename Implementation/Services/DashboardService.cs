using System.Linq;
using Interfaces.Repositories;
using Interfaces.Services;
using Models.ResponseModels;

namespace Implementation.Services
{
    public class DashboardService : IDashboardService
    {
        private IDistributorRepository distributorRepository { get; set; }

        public DashboardService(IDistributorRepository distributorRepository)
        {
            this.distributorRepository = distributorRepository;
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