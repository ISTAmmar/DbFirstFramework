using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Repository.BaseRepository
{
    public abstract class BaseRepository<TDomainClass> where TDomainClass : class
    {
        public BaseDbContext db;

        protected BaseRepository()
        {
            db = new BaseDbContext();
        }

        protected abstract IDbSet<TDomainClass> DbSet { get; }

        public void Add(TDomainClass entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TDomainClass entity)
        {
            DbSet.AddOrUpdate(entity);
        }

        public void Delete(TDomainClass entity)
        {
            DbSet.Remove(entity);
        }

        public IEnumerable<TDomainClass> GetAll()
        {
            return DbSet;
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