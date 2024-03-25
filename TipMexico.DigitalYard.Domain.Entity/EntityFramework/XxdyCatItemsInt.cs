using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatItemsInt
    {
        public string? SerialNumber { get; set; }
        public string? Vin { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? ManufacturerName { get; set; }
        public string? ModelYear { get; set; }
        public string? LicensePlate { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractStatus { get; set; }
        public string? CategoryName { get; set; }
        public string? OrganizationName { get; set; }
        public string? DoorType { get; set; }
        public string? SerialStatus { get; set; }
        public string? ParentSerial { get; set; }
        public int? CustomerId { get; set; }
        public int? ContractId { get; set; }
        public int? ContractOrgId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
