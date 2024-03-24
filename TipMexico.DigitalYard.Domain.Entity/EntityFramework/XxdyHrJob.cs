using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyHrJob
    {
        public decimal JobId { get; set; }
        public string JobCode { get; set; } = null!;
        public string JobName { get; set; } = null!;
        public DateTime? EndDateActive { get; set; }
        public string? EnabledFlag { get; set; }
        public decimal? ParentId { get; set; }
        public decimal? BranchId { get; set; }
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
