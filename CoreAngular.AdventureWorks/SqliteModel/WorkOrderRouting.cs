using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class WorkOrderRouting
    {
        public long WorkOrderId { get; set; }
        public long ProductId { get; set; }
        public long OperationSequence { get; set; }
        public long LocationId { get; set; }
        public string ScheduledStartDate { get; set; }
        public string ScheduledEndDate { get; set; }
        public string ActualStartDate { get; set; }
        public string ActualEndDate { get; set; }
        public string ActualResourceHrs { get; set; }
        public string PlannedCost { get; set; }
        public string ActualCost { get; set; }
        public string ModifiedDate { get; set; }

        public Location Location { get; set; }
        public WorkOrder WorkOrder { get; set; }
    }
}
