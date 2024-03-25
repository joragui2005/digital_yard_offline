using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysMenuItem
    {
        public int MenuItemId { get; set; }
        public int MenuId { get; set; }
        public int ModuleId { get; set; }
        public int? PageId { get; set; }
        public int ItemOrder { get; set; }
        public string EnabledFlag { get; set; } = null!;
        public string InsertAllowed { get; set; } = null!;
        public string UpdateAllowed { get; set; } = null!;
        public string DeleteAllowed { get; set; } = null!;
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
