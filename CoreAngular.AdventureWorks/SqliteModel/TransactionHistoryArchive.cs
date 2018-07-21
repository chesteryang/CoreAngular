using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class TransactionHistoryArchive
    {
        public long TransactionId { get; set; }
        public long ProductId { get; set; }
        public long ReferenceOrderId { get; set; }
        public long ReferenceOrderLineId { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public long Quantity { get; set; }
        public string ActualCost { get; set; }
        public string ModifiedDate { get; set; }
    }
}
