using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyAvailability
    {
        public int LineId { get; set; }
        public int RowNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? AssetNumber { get; set; }
        public string? ItemCode { get; set; }
        public string? BranchName { get; set; }
        public string? YardName { get; set; }
        public string? DoorType { get; set; }
        public string? PlateNumber { get; set; }
        public string? Vin { get; set; }
        public string? ModelName { get; set; }
        public string? BrandName { get; set; }
        public string? CirculationCard { get; set; }
        public string? FlowStatus { get; set; }
        public string? Vpp { get; set; }
        public string? VerificationStatus { get; set; }
        public string? VerifyPeriod { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? CustomerEntry { get; set; }
        public string? ProgramStatus { get; set; }
        public string? DocStatus { get; set; }
        public string? ReservedTo { get; set; }
        public string? SalesRep { get; set; }
        public string? DealStatus { get; set; }
        public string? DealType { get; set; }
        public string? ContractName { get; set; }
        public string? LegacyRef { get; set; }
        public string? OperationType { get; set; }
        public string? FleetDetail { get; set; }
        public string? RebillStatus { get; set; }
        public string? FeetDesc { get; set; }
        public string? PlateStatus { get; set; }
        public string? ActivationDate { get; set; }
        public string? ActivationMonth { get; set; }
        public string? Comments { get; set; }
        public string? RentActDate { get; set; }
        public string? RentRate { get; set; }
        public string? MttoAmount { get; set; }
        public string? VppRate { get; set; }
        public string? RateType { get; set; }
        public string? CurrencyCode { get; set; }
        public string? PayTerm { get; set; }
        public string? TermType { get; set; }
        public string? QuoteNumber { get; set; }
        public string? FullAmount { get; set; }
        public string? AmountDesc { get; set; }
        public string? BaseAmount { get; set; }
        public string? StaffStatus { get; set; }
        public string? StaffStatusQ { get; set; }
        public string? PrevDeal { get; set; }
        public string? PrevAssetStatus { get; set; }
        public string? NetBookValue { get; set; }
        public string? RebillAmount { get; set; }
        public string? DamageAmount { get; set; }
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
    }
}
