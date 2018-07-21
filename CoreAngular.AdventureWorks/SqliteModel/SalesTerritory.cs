using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            Customer = new HashSet<Customer>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPerson = new HashSet<SalesPerson>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            StateProvince = new HashSet<StateProvince>();
        }

        public long TerritoryId { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public string SalesYtd { get; set; }
        public string SalesLastYear { get; set; }
        public string CostYtd { get; set; }
        public string CostLastYear { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public CountryRegion CountryRegionCodeNavigation { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public ICollection<SalesPerson> SalesPerson { get; set; }
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public ICollection<StateProvince> StateProvince { get; set; }
    }
}
