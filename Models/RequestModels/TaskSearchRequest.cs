using Models.Common;

namespace Models.RequestModels
{
    public class TaskSearchRequest : GetPagedListRequest
    {
        // filters
        public string TaskName { get; set; }

        public TaskByColumn BillDetailByColumn
        {
            get
            {
                return (TaskByColumn)SortBy;
            }
            set
            {
                SortBy = (short)value;
            }
        }
    }
}
