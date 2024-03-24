using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyPrioritiesV
    {
        public decimal PriorityId { get; set; }
        public decimal? DeHeaderId { get; set; }
        public decimal? DeLineId { get; set; }
        public string TrxType { get; set; } = null!;
        public string LineType { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string? Vin { get; set; }
        public string PlateNumber { get; set; } = null!;
        public string? ContractNumber { get; set; }
        public string? ContractStatus { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? ItemCode { get; set; }
        public decimal PriorityCode { get; set; }
        public string? CustomField1 { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? WorkshopName { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ModelYear { get; set; }
        public string? ItemManufacturerName { get; set; }
        public string BranchName { get; set; } = null!;
        public string? Comments { get; set; }
        public string? RebillFlag { get; set; }
        public string? OdtFlag { get; set; }
        public string? InsStatusS { get; set; }
        public string? InsStatusT { get; set; }
        public string? OdtStatusS { get; set; }
        public string? OdtStatusT { get; set; }
        public decimal? InsHeaderIdS { get; set; }
        public decimal? InsHeaderIdT { get; set; }
        public decimal? OdtHeaderIdS { get; set; }
        public decimal? OdtHeaderIdT { get; set; }
        public decimal? OdtTeamIdS { get; set; }
        public decimal? OdtTeamIdT { get; set; }
        public decimal? PlannedHours { get; set; }
        public decimal? Amount { get; set; }
        public string? ReserveStatus { get; set; }
        public string? ReserveCustomer { get; set; }
        public string? ReserveContract { get; set; }
        public string? SalesRep { get; set; }
    }
}
