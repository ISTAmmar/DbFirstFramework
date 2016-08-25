using System.Collections.Generic;

namespace Interfaces.Repositories
{
    public interface IBaseRepository<TDomainClass, TKeyType>
        where TDomainClass : class
    {
        void Add(TDomainClass entity);

        void Update(TDomainClass entity);

        void Delete(TDomainClass entity);

        IEnumerable<TDomainClass> GetAll();

        TDomainClass Find(TKeyType id);

        void SaveChanges();
    }
}
