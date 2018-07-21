using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class StateProvince
    {
        public StateProvince()
        {
            Address = new HashSet<Address>();
            SalesTaxRate = new HashSet<SalesTaxRate>();
        }

        public long StateProvinceId { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryRegionCode { get; set; }
        public string IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public long TerritoryId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public CountryRegion CountryRegionCodeNavigation { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<SalesTaxRate> SalesTaxRate { get; set; }
    }
}
