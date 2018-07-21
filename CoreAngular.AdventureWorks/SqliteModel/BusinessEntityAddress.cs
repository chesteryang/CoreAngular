using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class BusinessEntityAddress
    {
        public long BusinessEntityId { get; set; }
        public long AddressId { get; set; }
        public long AddressTypeId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Address Address { get; set; }
        public AddressType AddressType { get; set; }
        public BusinessEntity BusinessEntity { get; set; }
    }
}
