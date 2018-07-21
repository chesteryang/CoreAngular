using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
        }

        public long SpecialOfferId { get; set; }
        public string Description { get; set; }
        public string DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long MinQty { get; set; }
        public long? MaxQty { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }
    }
}
