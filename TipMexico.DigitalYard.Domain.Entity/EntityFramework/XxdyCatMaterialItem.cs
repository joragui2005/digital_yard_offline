using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatMaterialItem
    {
        public int? AssemblyItemId { get; set; }
        public int? OrganizationId { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        public int? ItemSequence { get; set; }
        public string? ItemComponent { get; set; }
        public int? OperationSeqNum { get; set; }
        public string? ItemDescription { get; set; }
        public string? PrimaryUomCode { get; set; }
        public int? ComponentQuantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
