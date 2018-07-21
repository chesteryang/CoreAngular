using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ProductReview
    {
        public long ProductReviewId { get; set; }
        public long ProductId { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewDate { get; set; }
        public string EmailAddress { get; set; }
        public long Rating { get; set; }
        public string Comments { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
