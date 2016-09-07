using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Interfaces.Repositories;
using Microsoft.Practices.Unity;
using Models.Common;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;
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

        #region Private

        private readonly Dictionary<TaskByColumn, Func<Task, object>> detailClause =

            new Dictionary<TaskByColumn, Func<Task, object>>
            {
                {TaskByColumn.TaskName, c => c.TaskName}
            };

        #endregion

        #region Public

        public TaskRepository(IUnityContainer container)
            : base(container)
        {
        }

        #endregion

        public TaskResponse GetAllTasks(TaskSearchRequest searchRequest)
        {
            int fromRow = (searchRequest.PageNo - 1)*searchRequest.PageSize;
            int toRow = searchRequest.PageSize;

            bool nameSpecified = !string.IsNullOrEmpty(searchRequest.TaskName);

            Expression<Func<Task, bool>> query =
                s =>
                    (nameSpecified && s.TaskName.Contains(searchRequest.TaskName) || !nameSpecified);

            IEnumerable<Task> details = searchRequest.IsAsc
                ? DbSet
                    .Where(query)
                    .OrderBy(detailClause[searchRequest.BillDetailByColumn])
                    .Skip(fromRow)
                    .Take(toRow)
                    .ToList()
                : DbSet
                    .Where(query)
                    .OrderByDescending(detailClause[searchRequest.BillDetailByColumn])
                    .Skip(fromRow)
                    .Take(toRow)
                    .ToList();

            return new TaskResponse
            {
                Tasks = details,
                TotalCount = DbSet.Count(query),
                FilteredCount = DbSet.Count(query)
            };
        }
    }
}