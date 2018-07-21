using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
        }

        public long BusinessEntityId { get; set; }
        public string Name { get; set; }
        public long? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
