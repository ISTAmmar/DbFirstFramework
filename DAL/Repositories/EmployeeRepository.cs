using System.Data.Entity;
using System.Linq;
using DAL.BaseRepository;
using Models.DomainModels;

namespace DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        protected override IDbSet<Employee> DbSet
        {
            get { return db.Employees; }
        }

        #region Public

        public Employee GetEmployeeByName(string employeeName)
        {
            return DbSet.FirstOrDefault(x => x.EmployeeName == employeeName);
        }

        #endregion
    }
}