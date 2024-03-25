using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCatZone
    {
        public int ZoneId { get; set; }
        public string? ItemCode { get; set; }
        public string? ZoneType { get; set; }
        public string? ZoneName { get; set; }
        public string? ZoneArea { get; set; }
        public string? ZoneImage { get; set; }
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
        public string? ZoneSubtype { get; set; }
    }
}
