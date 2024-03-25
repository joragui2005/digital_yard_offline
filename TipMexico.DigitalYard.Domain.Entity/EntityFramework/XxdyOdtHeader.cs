using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtHeader
    {
        public int HeaderId { get; set; }
        public int BranchId { get; set; }
        public int? CustomerId { get; set; }
        public string? ContractNumber { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public string? OdtType { get; set; }
        public string? MovementType { get; set; }
        public int PriorityCode { get; set; }
        public string ItemCode { get; set; } = null!;
        public string? OdtFolio { get; set; }
        public DateTime? OdtDate { get; set; }
        public string? OdtStatus { get; set; }
        public string RebillFlag { get; set; } = null!;
        public string? RebillStatus { get; set; }
        public int? TeamId { get; set; }
        public int? WorkHours { get; set; }
        public string? MaterialStatus { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public int? InsHeaderId { get; set; }
        public int? DeHeaderId { get; set; }
        public int? DeLineId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Comments { get; set; }
        public string OdtGroup { get; set; } = null!;
        public int? PlannedHours { get; set; }
        public int? CurrentReceiptId { get; set; }
        public string? LockFlag { get; set; }
        public int? ParentId { get; set; }
        public string? RearType { get; set; }
        public int? CusdyDyWoHId { get; set; }
        public string? CustomerName { get; set; }
        public string? PlateNumber { get; set; }
    }
}
