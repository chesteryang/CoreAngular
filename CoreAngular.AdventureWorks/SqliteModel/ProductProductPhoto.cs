using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductProductPhoto
    {
        public long ProductId { get; set; }
        public long ProductPhotoId { get; set; }
        public string Primary { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
        public ProductPhoto ProductPhoto { get; set; }
    }
}
