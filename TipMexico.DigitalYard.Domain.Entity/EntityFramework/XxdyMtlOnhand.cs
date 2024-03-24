using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyMtlOnhand
    {
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public string? OrganizationCode { get; set; }
        public string SubinventoryCode { get; set; } = null!;
        public decimal? OnHand { get; set; }
        public decimal InventoryItemId { get; set; }
        public decimal OrganizationId { get; set; }
    }
}
