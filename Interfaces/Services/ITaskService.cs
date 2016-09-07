using System.Collections.Generic;
using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.Services
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
        TaskResponse GetAllTasks(TaskSearchRequest searchRequest);
    }
}
