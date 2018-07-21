using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Employee
    {
        public Employee()
        {
            Document = new HashSet<Document>();
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistory = new HashSet<EmployeePayHistory>();
            JobCandidate = new HashSet<JobCandidate>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

        public long BusinessEntityId { get; set; }
        public string NationalIdnumber { get; set; }
        public string LoginId { get; set; }
        public string OrganizationNode { get; set; }
        public string JobTitle { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string HireDate { get; set; }
        public string SalariedFlag { get; set; }
        public long VacationHours { get; set; }
        public long SickLeaveHours { get; set; }
        public string CurrentFlag { get; set; }
        [JsonIgnore]
        public string Rowguid { get; set; }
        [JsonIgnore]
        public string ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public ICollection<Document> Document { get; set; }
        public ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public ICollection<EmployeePayHistory> EmployeePayHistory { get; set; }
        public ICollection<JobCandidate> JobCandidate { get; set; }
        public ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
    }
}
