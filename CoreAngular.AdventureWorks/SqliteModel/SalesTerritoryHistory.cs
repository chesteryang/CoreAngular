using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesTerritoryHistory
    {
        public long BusinessEntityId { get; set; }
        public long TerritoryId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public SalesPerson BusinessEntity { get; set; }
        public SalesTerritory Territory { get; set; }
    }
}
