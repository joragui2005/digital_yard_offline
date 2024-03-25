using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysUser
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string EncryptedUserPassword { get; set; } = null!;
        public string? FullName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public int? EmployeeId { get; set; }
        public int? RmaMenuId { get; set; }
        public string EnabledFlag { get; set; } = null!;
        public string AdminFlag { get; set; } = null!;
        public DateTime? InactiveDate { get; set; }
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
        public int? BranchId { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerIds { get; set; }
    }
}
