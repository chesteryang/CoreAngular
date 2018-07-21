using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class PersonPhone
    {
        public long BusinessEntityId { get; set; }
        public string PhoneNumber { get; set; }
        public long PhoneNumberTypeId { get; set; }
        public string ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
    }
}
