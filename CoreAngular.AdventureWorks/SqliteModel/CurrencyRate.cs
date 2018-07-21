using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        public long CurrencyRateId { get; set; }
        public string CurrencyRateDate { get; set; }
        public string FromCurrencyCode { get; set; }
        public string ToCurrencyCode { get; set; }
        public string AverageRate { get; set; }
        public string EndOfDayRate { get; set; }
        public string ModifiedDate { get; set; }

        public Currency FromCurrencyCodeNavigation { get; set; }
        public Currency ToCurrencyCodeNavigation { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
