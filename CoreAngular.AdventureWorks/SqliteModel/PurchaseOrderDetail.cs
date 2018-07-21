using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class PurchaseOrderDetail
    {
        public long PurchaseOrderId { get; set; }
        public long PurchaseOrderDetailId { get; set; }
        public string DueDate { get; set; }
        public long OrderQty { get; set; }
        public long ProductId { get; set; }
        public string UnitPrice { get; set; }
        public string ReceivedQty { get; set; }
        public string RejectedQty { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
        public PurchaseOrderHeader PurchaseOrder { get; set; }
    }
}
