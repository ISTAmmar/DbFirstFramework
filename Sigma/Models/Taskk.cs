using System;

namespace Sigma.Models
{
    public class Taskk
    {
        public long TaskId { get; set; }
        public string TaskName { get; set; }
        public short Status { get; set; }
        public short TaskPriority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public short Progress { get; set; }
        public bool IsParent { get; set; }
        public long? ParentTaskId { get; set; }
        public string ParentTaskName { get; set; }
    }
}