using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            Product = new HashSet<Product>();
        }

        public long ProductSubcategoryId { get; set; }
        public long ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ProductCategory ProductCategory { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
