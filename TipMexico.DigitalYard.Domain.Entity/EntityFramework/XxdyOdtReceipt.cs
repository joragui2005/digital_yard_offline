using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtReceipt
    {
        public int RcvHeaderId { get; set; }
        public int OdtHeaderId { get; set; }
        public DateTime? RcvDate { get; set; }
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
        public string? ReceiptStatus { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? DispatchBy { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string? Comments { get; set; }
        public string? SerialNumber { get; set; }
        public int? TeamId { get; set; }
        public int? BranchId { get; set; }
    }
}
