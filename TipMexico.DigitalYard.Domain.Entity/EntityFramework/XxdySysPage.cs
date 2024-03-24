using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysPage
    {
        public decimal PageId { get; set; }
        public decimal ModuleId { get; set; }
        public decimal PageOrder { get; set; }
        public string PageCode { get; set; } = null!;
        public string PageName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string? ParamText { get; set; }
        public string SecurityLevel { get; set; } = null!;
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
        public string IsHeader { get; set; } = null!;
    }
}
