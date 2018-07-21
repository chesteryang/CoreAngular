using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductModelProductDescriptionCulture
    {
        public long ProductModelId { get; set; }
        public long ProductDescriptionId { get; set; }
        public string CultureId { get; set; }
        public string ModifiedDate { get; set; }

        public Culture Culture { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
