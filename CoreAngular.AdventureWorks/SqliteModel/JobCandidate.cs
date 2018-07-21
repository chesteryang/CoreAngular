using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class JobCandidate
    {
        public long JobCandidateId { get; set; }
        public long? BusinessEntityId { get; set; }
        public string Resume { get; set; }
        public string ModifiedDate { get; set; }

        public Employee BusinessEntity { get; set; }
    }
}
