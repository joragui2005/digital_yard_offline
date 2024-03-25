using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeDelivery
    {
        public int DeliveryId { get; set; }
        public int BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public int? CustomerId { get; set; }
        public string? ContractNumber { get; set; }
        public string? MovementType { get; set; }
        public string QualityFlag { get; set; } = null!;
        public string RiskFlag { get; set; } = null!;
        public string LegalFlag { get; set; } = null!;
        public string HiFlag { get; set; } = null!;
        public string HillFlag { get; set; } = null!;
        public string? DeliveryStatus { get; set; }
        public string? PersonInCharge { get; set; }
        public DateTime? ProgramDate { get; set; }
        public int? LicenseId { get; set; }
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
        public int? HiHeaderId { get; set; }
        public int? HillHeaderId { get; set; }
        public string? CarrierName { get; set; }
        public DateTime? CarrierDate { get; set; }
        public int? ActivationId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? IdSlot { get; set; }
    }
}
