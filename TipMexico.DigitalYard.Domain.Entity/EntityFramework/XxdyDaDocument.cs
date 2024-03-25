using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaDocument
    {
        public int DaDocumentId { get; set; }
        public string SourceTable { get; set; } = null!;
        public string SourceId { get; set; } = null!;
        public int? DocumentSetId { get; set; }
        public int DocumentId { get; set; }
        public string RequiredFlag { get; set; } = null!;
        public string FileExtn { get; set; } = null!;
        public string? Comments { get; set; }
        public int OrgId { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string OriginalDoc { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public DateTime? TrxDate { get; set; }
    }
}
