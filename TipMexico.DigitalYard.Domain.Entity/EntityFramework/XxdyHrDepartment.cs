using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyHrDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; } = null!;
        public string? DepartmentName { get; set; }
        public string? DepartmentType { get; set; }
        public DateTime? EndDateActive { get; set; }
        public string? EnabledFlag { get; set; }
        public int? ParentDeptId { get; set; }
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
