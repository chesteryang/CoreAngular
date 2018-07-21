using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ScrapReason
    {
        public ScrapReason()
        {
            WorkOrder = new HashSet<WorkOrder>();
        }

        public long ScrapReasonId { get; set; }
        public string Name { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
