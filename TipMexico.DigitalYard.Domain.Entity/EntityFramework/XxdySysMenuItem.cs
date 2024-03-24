using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysMenuItem
    {
        public decimal MenuItemId { get; set; }
        public decimal MenuId { get; set; }
        public decimal ModuleId { get; set; }
        public decimal? PageId { get; set; }
        public decimal ItemOrder { get; set; }
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
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
