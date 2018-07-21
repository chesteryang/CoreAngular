using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }

        public long PhoneNumberTypeId { get; set; }
        public string Name { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
