using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesTaxRate
    {
        public long SalesTaxRateId { get; set; }
        public long StateProvinceId { get; set; }
        public long TaxType { get; set; }
        public string TaxRate { get; set; }
        public string Name { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public StateProvince StateProvince { get; set; }
    }
}
