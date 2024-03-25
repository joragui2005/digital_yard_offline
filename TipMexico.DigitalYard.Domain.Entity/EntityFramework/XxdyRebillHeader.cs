using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyRebillHeader
    {
        public int InterfaceId { get; set; }
        public int? InsHeaderId { get; set; }
        public string? Patio { get; set; }
        public string? CustomerNumber { get; set; }
        public string? ContractNumber { get; set; }
        public string? LineType { get; set; }
        public string? DoorType { get; set; }
        public string? OrgName { get; set; }
        public string? SerialNumber { get; set; }
        public string? TipoEspiga { get; set; }
        public string? TipoPatines { get; set; }
        public string? Eje1EspesorBalata { get; set; }
        public string? Eje2EspesorBalata { get; set; }
        public string? PlacaVin { get; set; }
        public string? Manivela { get; set; }
        public int? RbHeaderId { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
