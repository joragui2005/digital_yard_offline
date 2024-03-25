using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysItem
    {
        public int InventoryItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? Description { get; set; }
        public string? PrimaryUomCode { get; set; }
        public string? ItemType { get; set; }
    }
}
