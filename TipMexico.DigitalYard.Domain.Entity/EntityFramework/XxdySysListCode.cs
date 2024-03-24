using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysListCode
    {
        public decimal ListCodeId { get; set; }
        public string ListCode { get; set; } = null!;
        public string Meaning { get; set; } = null!;
        public string LanguageCode { get; set; } = null!;
        public string SecurityLevel { get; set; } = null!;
        public decimal? OrgId { get; set; }
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
    }
}
