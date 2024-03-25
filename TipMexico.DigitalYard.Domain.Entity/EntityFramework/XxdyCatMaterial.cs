using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatMaterial
    {
        public string? ItemCode { get; set; }
        public string? UomCode { get; set; }
        public string? ItemDescription { get; set; }
        public int? Amount { get; set; }
        public string? Workforce { get; set; }
        public string? Miscellaneous { get; set; }
        public int AssemblyItemId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
