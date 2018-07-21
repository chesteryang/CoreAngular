using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class CountryRegionCurrency
    {
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ModifiedDate { get; set; }

        public CountryRegion CountryRegionCodeNavigation { get; set; }
        public Currency CurrencyCodeNavigation { get; set; }
    }
}
