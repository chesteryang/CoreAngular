using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class EmployeePayHistory
    {
        public long BusinessEntityId { get; set; }
        public string RateChangeDate { get; set; }
        public string Rate { get; set; }
        public long PayFrequency { get; set; }
        public string ModifiedDate { get; set; }

        public Employee BusinessEntity { get; set; }
    }
}
