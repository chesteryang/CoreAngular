using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Location
    {
        public Location()
        {
            ProductInventory = new HashSet<ProductInventory>();
            WorkOrderRouting = new HashSet<WorkOrderRouting>();
        }

        public long LocationId { get; set; }
        public string Name { get; set; }
        public string CostRate { get; set; }
        public string Availability { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<ProductInventory> ProductInventory { get; set; }
        public ICollection<WorkOrderRouting> WorkOrderRouting { get; set; }
    }
}
