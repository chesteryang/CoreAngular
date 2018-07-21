using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Department
    {
        public Department()
        {
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
        }

        public long DepartmentId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
    }
}
