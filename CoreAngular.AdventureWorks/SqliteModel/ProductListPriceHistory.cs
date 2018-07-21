using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductListPriceHistory
    {
        public long ProductId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ListPrice { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
