using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaTransaction
    {
        public decimal TrxId { get; set; }
        public string TrxType { get; set; } = null!;
        public DateTime TrxDate { get; set; }
        public decimal DaDocumentId { get; set; }
        public decimal DepartmentId { get; set; }
        public decimal EmployeeId { get; set; }
        public decimal TrxDays { get; set; }
        public string NoReturnFlag { get; set; } = null!;
        public string Motive { get; set; } = null!;
        public string? Comments { get; set; }
        public string? ApprovalStatus { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? ApprovalComments { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? ReturnComments { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal OrgId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
