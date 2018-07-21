using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductDocument
    {
        public long ProductId { get; set; }
        public string DocumentNode { get; set; }
        public string ModifiedDate { get; set; }

        public Document DocumentNodeNavigation { get; set; }
        public Product Product { get; set; }
    }
}
