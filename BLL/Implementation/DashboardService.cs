using System.Linq;
using DAL.Repositories;
using Models.ResponseModels;

namespace BLL.Implementation
{
    public class DashboardService
    {
        public DistributorRepository distributorRepository { get; set; }

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