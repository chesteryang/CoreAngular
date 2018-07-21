using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class PersonCreditCard
    {
        public long BusinessEntityId { get; set; }
        public long CreditCardId { get; set; }
        public string ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
