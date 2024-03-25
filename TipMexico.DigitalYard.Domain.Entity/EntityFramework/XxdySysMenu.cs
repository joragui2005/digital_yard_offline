using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysMenu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; } = null!;
        public string? Description { get; set; }
        public string EnabledFlag { get; set; } = null!;
        public string ExternalFlag { get; set; } = null!;
        public string SecurityLevel { get; set; } = null!;
        public int? DefaultPageId { get; set; }
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
