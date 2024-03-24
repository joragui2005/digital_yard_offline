using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysLegalEntity
    {
        public decimal EntityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string? ShortName { get; set; }
        public string? Code { get; set; }
        public string? TaxIdentifier { get; set; }
        public string ActiveFlag { get; set; } = null!;
        public string? WebAddress { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? StreetNumber { get; set; }
        public string? DoorNumber { get; set; }
        public string? Colony { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
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
