using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class DatabaseLog
    {
        public long DatabaseLogId { get; set; }
        public string PostTime { get; set; }
        public string DatabaseUser { get; set; }
        public string Event { get; set; }
        public string Schema { get; set; }
        public string Object { get; set; }
        public string Tsql { get; set; }
        public string XmlEvent { get; set; }
    }
}
