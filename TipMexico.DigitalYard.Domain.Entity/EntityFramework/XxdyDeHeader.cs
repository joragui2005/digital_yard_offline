using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeHeader
    {
        public decimal HeaderId { get; set; }
        public decimal BranchId { get; set; }
        public string TrxType { get; set; } = null!;
        public string HeaderStatus { get; set; } = null!;
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
        public string? Comments { get; set; }
        public DateTime? TrxDate { get; set; }
        public string? LicenseNo { get; set; }
        public string? LicenseHolder { get; set; }
    }
}
