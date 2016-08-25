using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;

namespace Repository.BaseRepository
{
    public abstract class BaseRepository<TDomainClass> : IBaseRepository<TDomainClass, int>
        where TDomainClass : class
    {
        private readonly IUnityContainer container;
        protected abstract IDbSet<TDomainClass> DbSet { get; }
        public BaseDbContext db;

        //protected BaseRepository()
        //{
        //    db = new BaseDbContext();
        //}
        protected BaseRepository(IUnityContainer container)
        {

            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
            string connectionString = ConfigurationManager.ConnectionStrings["BaseDbContext"].ConnectionString;
            db =
                (BaseDbContext)
                    container.Resolve(typeof(BaseDbContext),
                        new ResolverOverride[] {new ParameterOverride("connectionString", connectionString)});
        }

        public virtual void Add(TDomainClass entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(TDomainClass entity)
        {
            DbSet.AddOrUpdate(entity);
        }

        public virtual void Delete(TDomainClass entity)
        {
            DbSet.Remove(entity);
        }

        public virtual IEnumerable<TDomainClass> GetAll()
        {
            return DbSet;
        }

        /// <summary>
        /// Find Entity by Id
        /// </summary>
        public TDomainClass Find(int id)
        {
            return DbSet.Find(id);
        }
        /// <summary>
        /// Find Entity by Id
        /// </summary>
        public TDomainClass Find(string id)
        {
            return DbSet.Find(id);
        }
        /// <summary>
        /// Find Entity by Id
        /// </summary>
        public TDomainClass Find(long id)
        {
            return DbSet.Find(id);
        }

        public void SaveChanges()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception exp)
            {
                string message = exp.Message;
                throw;
            }
        }
    }
}