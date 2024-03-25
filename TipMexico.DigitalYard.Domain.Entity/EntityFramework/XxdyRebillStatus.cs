using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyRebillStatus
    {
        public int DetailId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? ItemCode { get; set; }
        public string? Vin { get; set; }
        public string? PlateNumber { get; set; }
        public string? ModelYear { get; set; }
        public string? ManufacturerName { get; set; }
        public string? CustomerName { get; set; }
        public string BranchName { get; set; } = null!;
        public DateTime? ReturnDate { get; set; }
        public int RebillGroupId { get; set; }
        public int? Amount { get; set; }
        public string? DoorType { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public string? DeleteFlag { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
