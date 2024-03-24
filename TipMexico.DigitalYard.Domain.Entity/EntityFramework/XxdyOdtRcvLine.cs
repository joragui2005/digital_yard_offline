using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtRcvLine
    {
        public decimal RcvLineId { get; set; }
        public decimal RcvHeaderId { get; set; }
        public decimal? DistributionId { get; set; }
        public decimal? OrganizationId { get; set; }
        public string? ItemComponent { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public decimal? DeliveredQuantity { get; set; }
        public decimal? ApprovedQuantity { get; set; }
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
        public decimal? RequestedQuantity { get; set; }
    }
}
