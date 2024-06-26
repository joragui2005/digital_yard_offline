﻿using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyTeam
    {
        public int TeamId { get; set; }
        public string? TeamName { get; set; }
        public string? TeamType { get; set; }
        public string? TeamDescription { get; set; }
        public int? TeamHead { get; set; }
        public int? BranchId { get; set; }
        public string? EnabledFlag { get; set; }
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
    }
}
