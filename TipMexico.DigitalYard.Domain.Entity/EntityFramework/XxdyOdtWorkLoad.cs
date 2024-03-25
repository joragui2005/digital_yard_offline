using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtWorkLoad
    {
        public int WorkloadId { get; set; }
        public int OdtHeaderId { get; set; }
        public DateTime TerminationDate { get; set; }
        public int PeriodId { get; set; }
        public int WeekNumber { get; set; }
        public int TeamId { get; set; }
        public int PersonId { get; set; }
        public int WorkHours { get; set; }
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
        public int? PeriodYear { get; set; }
    }
}
