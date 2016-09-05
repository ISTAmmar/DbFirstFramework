using System;
using Task = Models.DomainModels.Task;

namespace Sigma.ModelMapper
{
    public static class TaskMapper
    {
        public static Models.Taskk CreateFromServerToClient(this Task source)
        {
            return new Models.Taskk
            {
                TaskId = source.TaskId,
                TaskName = source.TaskName,
                Status = source.Status,
                TaskPriority = source.TaskPriority,
                Progress = source.Progress,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                IsParent = source.IsParent,
                ParentTaskId = source.ParentTaskId,
                ParentTaskName = source.ParentTask != null ? source.ParentTask.TaskName : String.Empty
            };
        }

        public static Task CreateFromClientToServer(this Models.Taskk source)
        {
            return new Task
            {
                TaskId = source.TaskId,
                TaskName = source.TaskName,
                Status = source.Status,
                TaskPriority = source.TaskPriority,
                Progress = source.Progress,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                IsParent = source.IsParent,
                ParentTaskId = source.ParentTaskId
            };
        }
    }
}