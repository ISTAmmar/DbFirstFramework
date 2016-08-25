using System.Collections.Generic;
using Models.DomainModels;

namespace Interfaces.Services
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
    }
}
