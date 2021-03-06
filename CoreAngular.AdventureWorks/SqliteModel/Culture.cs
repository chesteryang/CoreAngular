﻿using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Culture
    {
        public Culture()
        {
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }

        public string CultureId { get; set; }
        public string Name { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
    }
}
