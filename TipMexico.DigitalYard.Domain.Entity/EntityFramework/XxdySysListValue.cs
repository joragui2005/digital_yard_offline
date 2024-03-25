using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysListValue
    {
        public int ListValueId { get; set; }
        public int? ListCodeId { get; set; }
        public string ListCode { get; set; } = null!;
        public string ListValue { get; set; } = null!;
        public int ListOrder { get; set; }
        public string Meaning { get; set; } = null!;
        public string? Description { get; set; }
        public string LanguageCode { get; set; } = null!;
        public int? OrgId { get; set; }
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
    }
}
