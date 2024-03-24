using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsLog
    {
        public decimal LogId { get; set; }
        public decimal InspectionId { get; set; }
        public decimal InspectorId { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
