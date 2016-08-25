using System.Data.Entity;
using System.Linq;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        protected override IDbSet<Employee> DbSet
        {
            get { return db.Employees; }
        }

        #region Public

        public EmployeeRepository(IUnityContainer container) : base(container)
        {
        }

        public Employee GetEmployeeByName(string employeeName)
        {
            return DbSet.FirstOrDefault(x => x.EmployeeName == employeeName);
        }

        #endregion
    }
}