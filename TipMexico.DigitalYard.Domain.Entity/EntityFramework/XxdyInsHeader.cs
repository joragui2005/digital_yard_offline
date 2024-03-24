using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsHeader
    {
        public int HeaderId { get; set; }
        public decimal BranchId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? InspectionFolio { get; set; }
        public DateTime? InspectionDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string InsType { get; set; } = null!;
        public string TrxType { get; set; } = null!;
        public string MovementType { get; set; } = null!;
        public string InspectStatus { get; set; } = null!;
        public decimal? ActualInspector { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? DeHeaderId { get; set; }
        public decimal? DeLineId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Comments { get; set; }
        public string? OperationType { get; set; }
        public string? NumeroOcultos { get; set; }
        public string? HiddenNumber { get; set; }
        public string? ItemCode { get; set; }
        public string? ZoneType { get; set; }
        public string? RearType { get; set; }
        public string PlacaDeVin { get; set; } = null!;
        public string? PlacaDeVinZoneType { get; set; }
        public string? CustomerName { get; set; }
        public string? ContractNumber { get; set; }
        public string? PlateNumber { get; set; }
    }
}
