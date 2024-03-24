using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatItemSubstitute
    {
        public decimal SubstituteId { get; set; }
        public decimal OriginalItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public decimal SubstituteItemId { get; set; }
        public string? ItemSubstitute { get; set; }
        public string? SubstituteDesc { get; set; }
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
