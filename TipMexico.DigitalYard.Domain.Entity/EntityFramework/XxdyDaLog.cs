using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaLog
    {
        public decimal LogId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public decimal? DaDocumentId { get; set; }
        public string OriginalDoc { get; set; } = null!;
        public decimal? DepartmentId { get; set; }
        public DateTime? TrxDate { get; set; }
        public string? Comments { get; set; }
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
