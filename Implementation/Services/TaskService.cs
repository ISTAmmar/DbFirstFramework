using System.Collections.Generic;
using System.Linq;
using Interfaces.Repositories;
using Interfaces.Services;
using Models.RequestModels;
using Models.ResponseModels;
using Task = Models.DomainModels.Task;

namespace Implementation.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository { get; set; }

        public TaskService(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<Task> GetAll()
        {
            return taskRepository.GetAll().ToList();
        }

        public TaskResponse GetAllTasks(TaskSearchRequest searchRequest)
        {
            return taskRepository.GetAllTasks(searchRequest);
        }
    }
}