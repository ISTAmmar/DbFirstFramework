using System.Collections.Generic;
using Models.RequestModels;

namespace Sigma.ViewModels
{
    public class TaskAjaxViewModel
    {
        public TaskAjaxViewModel()
        {
            data = new List<Models.Taskk>();
        }

        // ReSharper disable once InconsistentNaming
        public IEnumerable<Models.Taskk> data { get; set; }
        public TaskSearchRequest SearchRequest { get; set; }

        /// <summary>
        /// Total Records in DB
        /// </summary>
        public int recordsTotal;

        /// <summary>
        /// Total Records Filtered
        /// </summary>
        public int recordsFiltered;
    }
}