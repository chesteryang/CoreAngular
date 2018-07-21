using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            WorkOrderRouting = new HashSet<WorkOrderRouting>();
        }

        public long WorkOrderId { get; set; }
        public long ProductId { get; set; }
        public long OrderQty { get; set; }
        public long ScrappedQty { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DueDate { get; set; }
        public long? ScrapReasonId { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
        public ScrapReason ScrapReason { get; set; }
        public ICollection<WorkOrderRouting> WorkOrderRouting { get; set; }
    }
}
