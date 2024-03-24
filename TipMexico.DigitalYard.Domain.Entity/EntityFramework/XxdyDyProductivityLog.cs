using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyProductivityLog
    {
        public decimal LogId { get; set; }
        public decimal PeriodId { get; set; }
        public decimal? WeekNumber { get; set; }
        public decimal? BranchId { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? MessageContent { get; set; }
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
