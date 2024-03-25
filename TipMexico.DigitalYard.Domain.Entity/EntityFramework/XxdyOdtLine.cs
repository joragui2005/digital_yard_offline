using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtLine
    {
        public int LineId { get; set; }
        public int HeaderId { get; set; }
        public int ZoneId { get; set; }
        public string MaterialId { get; set; } = null!;
        public int Quantity { get; set; }
        public int? WorkHours { get; set; }
        public string? MaterialStatus { get; set; }
        public string? LineStatus { get; set; }
        public string DeleteFlag { get; set; } = null!;
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
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
        public string? Comments { get; set; }
        public int? PlannedHours { get; set; }
        public int? TeamId { get; set; }
        public int? ApprovedQuantity { get; set; }
        public string? OnhandStatus { get; set; }
        public string? LockFlag { get; set; }
        public string? FaultType { get; set; }
        public string? ApprvMotive { get; set; }
        public string? ApprvComments { get; set; }
        public string? Category { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }
}
