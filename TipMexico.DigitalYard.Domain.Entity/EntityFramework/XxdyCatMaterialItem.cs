using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatMaterialItem
    {
        public decimal? AssemblyItemId { get; set; }
        public decimal? OrganizationId { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
        public decimal? ItemSequence { get; set; }
        public string? ItemComponent { get; set; }
        public decimal? OperationSeqNum { get; set; }
        public string? ItemDescription { get; set; }
        public string? PrimaryUomCode { get; set; }
        public decimal? ComponentQuantity { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
