using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsLog
    {
        public int LogId { get; set; }
        public int InspectionId { get; set; }
        public int InspectorId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
