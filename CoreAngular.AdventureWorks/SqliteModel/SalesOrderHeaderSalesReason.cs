using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesOrderHeaderSalesReason
    {
        public long SalesOrderId { get; set; }
        public long SalesReasonId { get; set; }
        public string ModifiedDate { get; set; }

        public SalesOrderHeader SalesOrder { get; set; }
        public SalesReason SalesReason { get; set; }
    }
}
