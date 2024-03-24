using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtHeader
    {
        public decimal HeaderId { get; set; }
        public decimal BranchId { get; set; }
        public decimal? CustomerId { get; set; }
        public string? ContractNumber { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public string? OdtType { get; set; }
        public string? MovementType { get; set; }
        public decimal PriorityCode { get; set; }
        public string ItemCode { get; set; } = null!;
        public string? OdtFolio { get; set; }
        public DateTime? OdtDate { get; set; }
        public string? OdtStatus { get; set; }
        public string RebillFlag { get; set; } = null!;
        public string? RebillStatus { get; set; }
        public decimal? TeamId { get; set; }
        public decimal? WorkHours { get; set; }
        public string? MaterialStatus { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? InsHeaderId { get; set; }
        public decimal? DeHeaderId { get; set; }
        public decimal? DeLineId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Comments { get; set; }
        public string OdtGroup { get; set; } = null!;
        public decimal? PlannedHours { get; set; }
        public decimal? CurrentReceiptId { get; set; }
        public string? LockFlag { get; set; }
        public decimal? ParentId { get; set; }
        public string? RearType { get; set; }
        public decimal? CusdyDyWoHId { get; set; }
        public string? CustomerName { get; set; }
        public string? PlateNumber { get; set; }
    }
}
