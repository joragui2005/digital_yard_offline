using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtDistribution
    {
        public int DistributionId { get; set; }
        public int LineId { get; set; }
        public int HeaderId { get; set; }
        public int? AssemblyItemId { get; set; }
        public int? OrganizationId { get; set; }
        public int? ItemSequence { get; set; }
        public string? ItemComponent { get; set; }
        public int? OperationSeqNum { get; set; }
        public string? ItemDescription { get; set; }
        public string? PrimaryUomCode { get; set; }
        public int? ComponentQuantity { get; set; }
        public int? OnHandQuantity { get; set; }
        public int? RequestedQuantity { get; set; }
        public int? DeliveredQuantity { get; set; }
        public string? Comments { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? SwapQuantity { get; set; }
        public int? ParentId { get; set; }
    }
}
