using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }

        public long ProductPhotoId { get; set; }
        public string ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public string LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }
    }
}
