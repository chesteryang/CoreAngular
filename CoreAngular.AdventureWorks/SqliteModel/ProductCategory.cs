using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategory = new HashSet<ProductSubcategory>();
        }

        public long ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<ProductSubcategory> ProductSubcategory { get; set; }
    }
}
