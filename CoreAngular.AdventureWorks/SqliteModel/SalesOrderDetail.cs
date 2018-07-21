using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesOrderDetail
    {
        public long SalesOrderId { get; set; }
        public long SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public long OrderQty { get; set; }
        public long ProductId { get; set; }
        public long SpecialOfferId { get; set; }
        public string UnitPrice { get; set; }
        public string UnitPriceDiscount { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public SalesOrderHeader SalesOrder { get; set; }
        public SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
