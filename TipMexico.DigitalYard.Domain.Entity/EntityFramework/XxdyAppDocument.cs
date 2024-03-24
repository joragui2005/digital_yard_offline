using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyAppDocument
    {
        public decimal DocumentId { get; set; }
        public string DocumentCode { get; set; } = null!;
        public string DocumentName { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string? Description { get; set; }
        public string FileExtn { get; set; } = null!;
        public string EnabledFlag { get; set; } = null!;
        public decimal? AttachmentId { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public string? ApproverId { get; set; }
        public string? ViewDeptId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal NoOfCopies { get; set; }
        public string? OriginalDoc { get; set; }
    }
}
