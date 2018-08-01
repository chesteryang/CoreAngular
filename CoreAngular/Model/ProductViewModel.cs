using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#pragma warning disable 1591

namespace CoreAngular.Model
{
    public class ProductViewModel
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string StandardCost { get; set; }
        public string ListPrice { get; set; }
        public string SubCategoryName { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public string LargePhotoFileName { get; set; }
    }
}
