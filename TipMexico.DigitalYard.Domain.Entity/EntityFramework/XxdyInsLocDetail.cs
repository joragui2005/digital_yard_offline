using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsLocDetail
    {
        public int DetailId { get; set; }
        public int HeaderId { get; set; }
        public int LineId { get; set; }
        public string ZoneType { get; set; } = null!;
        public string DanoType { get; set; } = null!;
        public int DanoOrder { get; set; }
        public int? LineNumber { get; set; }
        public string? Actividad { get; set; }
        public string? Category { get; set; }
        public string? Falla { get; set; }
        public int? Cant { get; set; }
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
        public int? ZoneId { get; set; }
        public int? PlannedHours { get; set; }
        public string? Comments { get; set; }
    }
}
