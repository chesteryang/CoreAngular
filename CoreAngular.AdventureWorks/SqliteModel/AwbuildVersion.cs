using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class AwbuildVersion
    {
        public long SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; }
        public string VersionDate { get; set; }
        public string ModifiedDate { get; set; }
    }
}
