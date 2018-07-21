using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }

        public long PurchaseOrderId { get; set; }
        public long RevisionNumber { get; set; }
        public long Status { get; set; }
        public long EmployeeId { get; set; }
        public long VendorId { get; set; }
        public long ShipMethodId { get; set; }
        public string OrderDate { get; set; }
        public string ShipDate { get; set; }
        public string SubTotal { get; set; }
        public string TaxAmt { get; set; }
        public string Freight { get; set; }
        public string TotalDue { get; set; }
        public string ModifiedDate { get; set; }

        public Employee Employee { get; set; }
        public ShipMethod ShipMethod { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
    }
}
