using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductModelIllustration
    {
        public long ProductModelId { get; set; }
        public long IllustrationId { get; set; }
        public string ModifiedDate { get; set; }

        public Illustration Illustration { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
