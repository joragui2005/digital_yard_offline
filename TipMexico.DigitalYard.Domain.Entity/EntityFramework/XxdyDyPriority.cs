using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyPriority
    {
        public int PriorityId { get; set; }
        public string TrxType { get; set; } = null!;
        public string LineType { get; set; } = null!;
        public int BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public string PlateNumber { get; set; } = null!;
        public string? ContractNumber { get; set; }
        public string? ContractStatus { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? WorkshopName { get; set; }
        public string? ManufacturerName { get; set; }
        public int? LineBranchId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemFound { get; set; }
        public int PriorityCode { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public int? DeHeaderId { get; set; }
        public int? DeLineId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Comments { get; set; }
        public string? RebillFlag { get; set; }
        public string? OdtFlag { get; set; }
    }
}
