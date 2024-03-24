using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyAmTheftReportH
    {
        public decimal HistoryId { get; set; }
        public decimal ReportId { get; set; }
        public string? AssetNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public string ReportPlate { get; set; } = null!;
        public string ReportVin { get; set; } = null!;
        public string? DocumentPath1 { get; set; }
        public string? DocumentPath2 { get; set; }
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
