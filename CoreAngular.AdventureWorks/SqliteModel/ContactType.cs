using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class ContactType
    {
        public ContactType()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }

        public long ContactTypeId { get; set; }
        public string Name { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
    }
}
