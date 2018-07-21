using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        public long BusinessEntityId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Person Person { get; set; }
        public Store Store { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
