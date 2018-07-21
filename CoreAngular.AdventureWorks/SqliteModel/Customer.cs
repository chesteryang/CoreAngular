using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Customer
    {
        public Customer()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        public long CustomerId { get; set; }
        public long? PersonId { get; set; }
        public long? StoreId { get; set; }
        public long? TerritoryId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Person Person { get; set; }
        public Store Store { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
