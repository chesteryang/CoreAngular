using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ShoppingCartItem
    {
        public long ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public long Quantity { get; set; }
        public long ProductId { get; set; }
        public string DateCreated { get; set; }
        public string ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}
