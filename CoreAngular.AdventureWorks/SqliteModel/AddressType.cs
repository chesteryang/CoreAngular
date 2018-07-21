using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class AddressType
    {
        public AddressType()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
        }

        public long AddressTypeId { get; set; }
        public string Name { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
    }
}
