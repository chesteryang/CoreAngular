using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        public long ShipMethodId { get; set; }
        public string Name { get; set; }
        public string ShipBase { get; set; }
        public string ShipRate { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
