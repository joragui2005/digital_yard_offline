using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtAttachment
    {
        public decimal FileId { get; set; }
        public string SourceFolder { get; set; } = null!;
        public string SourceTable { get; set; } = null!;
        public decimal HeaderId { get; set; }
        public decimal LineId { get; set; }
        public string? AbsoluteName { get; set; }
        public string? FileName { get; set; }
        public string? FileExt { get; set; }
        public string? FileType { get; set; }
        public string? Comments { get; set; }
        public DateTime? ValidUntil { get; set; }
        public decimal? ApprovedBy { get; set; }
        public string? ApprovalStatus { get; set; }
        public string? RejectReason { get; set; }
        public string? RejectMotive { get; set; }
        public decimal OrgId { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
