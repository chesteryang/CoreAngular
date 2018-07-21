using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class BusinessEntityContact
    {
        public long BusinessEntityId { get; set; }
        public long PersonId { get; set; }
        public long ContactTypeId { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public ContactType ContactType { get; set; }
        public Person Person { get; set; }
    }
}
