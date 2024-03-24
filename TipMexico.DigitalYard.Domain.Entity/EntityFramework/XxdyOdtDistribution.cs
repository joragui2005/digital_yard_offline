using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtDistribution
    {
        public decimal DistributionId { get; set; }
        public decimal LineId { get; set; }
        public decimal HeaderId { get; set; }
        public decimal? AssemblyItemId { get; set; }
        public decimal? OrganizationId { get; set; }
        public decimal? ItemSequence { get; set; }
        public string? ItemComponent { get; set; }
        public decimal? OperationSeqNum { get; set; }
        public string? ItemDescription { get; set; }
        public string? PrimaryUomCode { get; set; }
        public decimal? ComponentQuantity { get; set; }
        public decimal? OnHandQuantity { get; set; }
        public decimal? RequestedQuantity { get; set; }
        public decimal? DeliveredQuantity { get; set; }
        public string? Comments { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? SwapQuantity { get; set; }
        public decimal? ParentId { get; set; }
    }
}
