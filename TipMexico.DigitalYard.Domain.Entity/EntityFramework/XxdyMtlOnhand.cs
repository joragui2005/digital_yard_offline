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
        public int? OnHand { get; set; }
        public int InventoryItemId { get; set; }
        public int OrganizationId { get; set; }
    }
}
