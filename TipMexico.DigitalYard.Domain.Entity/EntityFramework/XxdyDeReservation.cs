using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeReservation
    {
        public int ReserveId { get; set; }
        public DateTime? ReserveDate { get; set; }
        public int BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContractNumber { get; set; }
        public string? DealType { get; set; }
        public string? MovementType { get; set; }
        public DateTime? ProgramDate { get; set; }
        public string RiskFlag { get; set; } = null!;
        public string LegalFlag { get; set; } = null!;
        public string VppFlag { get; set; } = null!;
        public string TdcFlag { get; set; } = null!;
        public string VerifyFlag { get; set; } = null!;
        public string TheftFlag { get; set; } = null!;
        public string? ReserveStatus { get; set; }
        public int? ActCustomerId { get; set; }
        public string? ActCustomerName { get; set; }
        public string? ActContractNumber { get; set; }
        public int CheckInId { get; set; }
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
        public string? SalesRep { get; set; }
        public int? IdSlot { get; set; }
        public int? DeliveryId { get; set; }
    }
}
