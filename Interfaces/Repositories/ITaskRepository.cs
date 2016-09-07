using Models.DomainModels;
using Models.RequestModels;
using Models.ResponseModels;

namespace Interfaces.Repositories
{
    public interface ITaskRepository : IBaseRepository<Task, long>
    {
        TaskResponse GetAllTasks(TaskSearchRequest searchRequest);
    }
}
