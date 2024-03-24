using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeActivation
    {
        public decimal ActivationId { get; set; }
        public DateTime? ActivationDate { get; set; }
        public decimal BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public string? TrxType { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContractNumber { get; set; }
        public string? DealType { get; set; }
        public string? MovementType { get; set; }
        public DateTime? ProgramDate { get; set; }
        public string ActivateFlag { get; set; } = null!;
        public string? ProcessStatus { get; set; }
        public string? ProcessMessage { get; set; }
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
        public decimal? DeliveryId { get; set; }
    }
}
