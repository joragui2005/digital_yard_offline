using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtLine
    {
        public decimal LineId { get; set; }
        public decimal HeaderId { get; set; }
        public decimal ZoneId { get; set; }
        public string MaterialId { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal? WorkHours { get; set; }
        public string? MaterialStatus { get; set; }
        public string? LineStatus { get; set; }
        public string DeleteFlag { get; set; } = null!;
        public decimal? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
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
        public string? Comments { get; set; }
        public decimal? PlannedHours { get; set; }
        public decimal? TeamId { get; set; }
        public decimal? ApprovedQuantity { get; set; }
        public string? OnhandStatus { get; set; }
        public string? LockFlag { get; set; }
        public string? FaultType { get; set; }
        public string? ApprvMotive { get; set; }
        public string? ApprvComments { get; set; }
        public string? Category { get; set; }
        public decimal? ApproverId { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }
}
