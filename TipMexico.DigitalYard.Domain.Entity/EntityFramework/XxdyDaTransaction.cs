using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaTransaction
    {
        public int TrxId { get; set; }
        public string TrxType { get; set; } = null!;
        public DateTime TrxDate { get; set; }
        public int DaDocumentId { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public int TrxDays { get; set; }
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
        public int OrgId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
