using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Document
    {
        public Document()
        {
            ProductDocument = new HashSet<ProductDocument>();
        }

        public string DocumentNode { get; set; }
        public string Title { get; set; }
        public long Owner { get; set; }
        public string FolderFlag { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Revision { get; set; }
        public long ChangeNumber { get; set; }
        public long Status { get; set; }
        public string DocumentSummary { get; set; }
        public string Document1 { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Employee OwnerNavigation { get; set; }
        public ICollection<ProductDocument> ProductDocument { get; set; }
    }
}
