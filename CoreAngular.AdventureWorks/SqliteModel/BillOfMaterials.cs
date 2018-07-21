using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class BillOfMaterials
    {
        public long BillOfMaterialsId { get; set; }
        public long? ProductAssemblyId { get; set; }
        public long ComponentId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string UnitMeasureCode { get; set; }
        public long Bomlevel { get; set; }
        public string PerAssemblyQty { get; set; }
        public string ModifiedDate { get; set; }

        public Product Component { get; set; }
        public Product ProductAssembly { get; set; }
        public UnitMeasure UnitMeasureCodeNavigation { get; set; }
    }
}
