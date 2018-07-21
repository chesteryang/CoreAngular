using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Password
    {
        public long BusinessEntityId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
    }
}
