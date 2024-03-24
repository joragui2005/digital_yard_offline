using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class AppJob
    {
        public decimal Id { get; set; }
        public string Queue { get; set; } = null!;
        public string Payload { get; set; } = null!;
        public decimal Attempts { get; set; }
        public decimal? ReservedAt { get; set; }
        public decimal AvailableAt { get; set; }
        public decimal CreatedAt { get; set; }
    }
}
