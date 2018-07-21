using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductVendor
    {
        public long ProductId { get; set; }
        public long BusinessEntityId { get; set; }
        public long AverageLeadTime { get; set; }
        public string StandardPrice { get; set; }
        public string LastReceiptCost { get; set; }
        public string LastReceiptDate { get; set; }
        public long MinOrderQty { get; set; }
        public long MaxOrderQty { get; set; }
        public long? OnOrderQty { get; set; }
        public string UnitMeasureCode { get; set; }
        public string ModifiedDate { get; set; }

        public Vendor BusinessEntity { get; set; }
        public Product Product { get; set; }
        public UnitMeasure UnitMeasureCodeNavigation { get; set; }
    }
}
