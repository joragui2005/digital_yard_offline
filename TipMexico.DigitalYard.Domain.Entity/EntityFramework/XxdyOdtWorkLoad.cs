using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyOdtWorkLoad
    {
        public decimal WorkloadId { get; set; }
        public decimal OdtHeaderId { get; set; }
        public DateTime TerminationDate { get; set; }
        public decimal PeriodId { get; set; }
        public decimal WeekNumber { get; set; }
        public decimal TeamId { get; set; }
        public decimal PersonId { get; set; }
        public decimal WorkHours { get; set; }
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
        public decimal? PeriodYear { get; set; }
    }
}
