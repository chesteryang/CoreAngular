using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Vendor
    {
        public Vendor()
        {
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

        public long BusinessEntityId { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public long CreditRating { get; set; }
        public string PreferredVendorStatus { get; set; }
        public string ActiveFlag { get; set; }
        public string PurchasingWebServiceUrl { get; set; }
        public string ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public ICollection<ProductVendor> ProductVendor { get; set; }
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
    }
}
