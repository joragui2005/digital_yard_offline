using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatLicense
    {
        public decimal LicenseId { get; set; }
        public string? LicenseNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? LicImagePath { get; set; }
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
        public string ExternalOperator { get; set; } = null!;
    }
}
