using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyAppAssignedDoc
    {
        public decimal AssignmentId { get; set; }
        public decimal DisplayOrder { get; set; }
        public decimal DocumentSetId { get; set; }
        public decimal DocumentId { get; set; }
        public string RequiredFlag { get; set; } = null!;
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string OriginalDoc { get; set; } = null!;
    }
}
