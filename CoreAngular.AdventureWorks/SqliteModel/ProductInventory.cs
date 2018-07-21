using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductInventory
    {
        public long ProductId { get; set; }
        public long LocationId { get; set; }
        public string Shelf { get; set; }
        public long Bin { get; set; }
        public long Quantity { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Location Location { get; set; }
        public Product Product { get; set; }
    }
}
