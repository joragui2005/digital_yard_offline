using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtReceipt
    {
        public decimal RcvHeaderId { get; set; }
        public decimal OdtHeaderId { get; set; }
        public DateTime? RcvDate { get; set; }
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
        public string? ReceiptStatus { get; set; }
        public decimal? ApproverId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public decimal? DispatchBy { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string? Comments { get; set; }
        public string? SerialNumber { get; set; }
        public decimal? TeamId { get; set; }
        public decimal? BranchId { get; set; }
    }
}
