using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Address
    {
        public Address()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            SalesOrderHeaderBillToAddress = new HashSet<SalesOrderHeader>();
            SalesOrderHeaderShipToAddress = new HashSet<SalesOrderHeader>();
        }

        public long AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public long StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public string SpatialLocation { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public StateProvince StateProvince { get; set; }
        public ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeaderBillToAddress { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeaderShipToAddress { get; set; }
    }
}
