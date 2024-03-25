using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyPrioritiesV
    {
        public int PriorityId { get; set; }
        public int? DeHeaderId { get; set; }
        public int? DeLineId { get; set; }
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
        public int PriorityCode { get; set; }
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
        public int? InsHeaderIdS { get; set; }
        public int? InsHeaderIdT { get; set; }
        public int? OdtHeaderIdS { get; set; }
        public int? OdtHeaderIdT { get; set; }
        public int? OdtTeamIdS { get; set; }
        public int? OdtTeamIdT { get; set; }
        public int? PlannedHours { get; set; }
        public int? Amount { get; set; }
        public string? ReserveStatus { get; set; }
        public string? ReserveCustomer { get; set; }
        public string? ReserveContract { get; set; }
        public string? SalesRep { get; set; }
    }
}
