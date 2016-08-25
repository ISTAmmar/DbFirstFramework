using System.Data.Entity;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        #region Protected

        protected override IDbSet<Task> DbSet
        {
            get { return db.Tasks; }
        }

        #endregion

        #region Public

        public TaskRepository(IUnityContainer container)
            : base(container)
        {
        }

        #endregion
    }
}