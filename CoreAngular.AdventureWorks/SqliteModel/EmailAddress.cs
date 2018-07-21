using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class EmailAddress
    {
        public long BusinessEntityId { get; set; }
        public long EmailAddressId { get; set; }
        public string EmailAddress1 { get; set; }
        [JsonIgnore]
        public string Rowguid { get; set; }
        [JsonIgnore]
        public string ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
    }
}
