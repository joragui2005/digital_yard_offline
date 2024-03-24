using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class AppFailedJob
    {
        public decimal Id { get; set; }
        public string Connection { get; set; } = null!;
        public string Queue { get; set; } = null!;
        public string Payload { get; set; } = null!;
        public string Exception { get; set; } = null!;
        public DateTime FailedAt { get; set; }
    }
}
