using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Illustration
    {
        public Illustration()
        {
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
        }

        public long IllustrationId { get; set; }
        public string Diagram { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
    }
}
