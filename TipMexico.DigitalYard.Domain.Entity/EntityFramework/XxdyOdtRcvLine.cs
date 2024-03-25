using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtRcvLine
    {
        public int RcvLineId { get; set; }
        public int RcvHeaderId { get; set; }
        public int? DistributionId { get; set; }
        public int? OrganizationId { get; set; }
        public string? ItemComponent { get; set; }
        public int? ReceivedQuantity { get; set; }
        public int? DeliveredQuantity { get; set; }
        public int? ApprovedQuantity { get; set; }
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
        public int? RequestedQuantity { get; set; }
    }
}
