using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistory = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            Store = new HashSet<Store>();
        }

        public long BusinessEntityId { get; set; }
        public long? TerritoryId { get; set; }
        public string SalesQuota { get; set; }
        public string Bonus { get; set; }
        public string CommissionPct { get; set; }
        public string SalesYtd { get; set; }
        public string SalesLastYear { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Employee BusinessEntity { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public ICollection<Store> Store { get; set; }
    }
}
