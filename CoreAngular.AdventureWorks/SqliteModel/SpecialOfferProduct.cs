using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }

        public long SpecialOfferId { get; set; }
        public long ProductId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
        public SpecialOffer SpecialOffer { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
    }
}
