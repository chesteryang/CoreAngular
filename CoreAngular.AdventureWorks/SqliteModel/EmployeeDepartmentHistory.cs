using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class EmployeeDepartmentHistory
    {
        public long BusinessEntityId { get; set; }
        public long DepartmentId { get; set; }
        public long ShiftId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ModifiedDate { get; set; }

        public Employee BusinessEntity { get; set; }
        public Department Department { get; set; }
        public Shift Shift { get; set; }
    }
}
