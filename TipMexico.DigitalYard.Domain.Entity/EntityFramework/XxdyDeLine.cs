using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeLine
    {
        public decimal LineId { get; set; }
        public decimal HeaderId { get; set; }
        public decimal LineNumber { get; set; }
        public string LineType { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string PlateNumber { get; set; } = null!;
        public string? ContractNumber { get; set; }
        public string? ContractStatus { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? ItemCode { get; set; }
        public string? DoorType { get; set; }
        public string? VerifyStatus { get; set; }
        public string LineStatus { get; set; } = null!;
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
        public decimal? LineBranchId { get; set; }
        public string? WorkshopName { get; set; }
        public string? ManufacturerName { get; set; }
        public string? Vin { get; set; }
        public string? ItemFound { get; set; }
        public decimal? ConfirmBy { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public decimal? CancelBy { get; set; }
        public DateTime? CancelDate { get; set; }
        public string? Comments { get; set; }
        public string? AssetNumber { get; set; }
        public decimal? DeliveryId { get; set; }
    }
}
