using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyRebillLine
    {
        public decimal InterfaceId { get; set; }
        public decimal InterfaceLineId { get; set; }
        public decimal? InsHeaderId { get; set; }
        public decimal? InsDetailId { get; set; }
        public string? Patio { get; set; }
        public string? CustomerNumber { get; set; }
        public string? ContractNumber { get; set; }
        public string? LineType { get; set; }
        public string? DoorType { get; set; }
        public string? OrgName { get; set; }
        public string? SerialNumber { get; set; }
        public string? InsType { get; set; }
        public string? ZoneType { get; set; }
        public string? ItemCode { get; set; }
        public string? Falla { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? RbHeaderId { get; set; }
        public decimal? RbLineId { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public string? Status { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
