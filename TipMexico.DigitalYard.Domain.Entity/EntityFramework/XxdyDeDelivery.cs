using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeDelivery
    {
        public decimal DeliveryId { get; set; }
        public decimal BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public decimal? CustomerId { get; set; }
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
        public decimal? LicenseId { get; set; }
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
        public decimal? HiHeaderId { get; set; }
        public decimal? HillHeaderId { get; set; }
        public string? CarrierName { get; set; }
        public DateTime? CarrierDate { get; set; }
        public decimal? ActivationId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal? IdSlot { get; set; }
    }
}
