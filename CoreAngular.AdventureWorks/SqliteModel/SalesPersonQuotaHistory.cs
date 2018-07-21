using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesPersonQuotaHistory
    {
        public long BusinessEntityId { get; set; }
        public string QuotaDate { get; set; }
        public string SalesQuota { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public SalesPerson BusinessEntity { get; set; }
    }
}
