﻿using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsLocation
    {
        public decimal LocationId { get; set; }
        public decimal HeaderId { get; set; }
        public decimal LineId { get; set; }
        public string ZoneType { get; set; } = null!;
        public string DanoType { get; set; } = null!;
        public decimal DanoOrder { get; set; }
        public decimal? TotalImages { get; set; }
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
