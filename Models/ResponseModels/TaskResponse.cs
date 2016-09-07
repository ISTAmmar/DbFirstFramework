using System.Collections.Generic;
using Models.DomainModels;

namespace Models.ResponseModels
{
    public class TaskResponse
    {
        public IEnumerable<Task> Tasks { get; set; }
        public int TotalCount { get; set; }
        public int TotalRecords { get; set; }
        public int FilteredCount { get; set; }
    }
}
