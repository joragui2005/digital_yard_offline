using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyHrEmployee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeNumber { get; set; }
        public string? EmployeeType { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get; set; } = null!;
        public string? Gender { get; set; }
        public string? TaxIdentifier { get; set; }
        public string? NationalIdentifier { get; set; }
        public string EnabledFlag { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte[]? ImageFile { get; set; }
        public int DepartmentId { get; set; }
        public int JobId { get; set; }
        public string? MobilePhone { get; set; }
        public string? HomePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? Email { get; set; }
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
