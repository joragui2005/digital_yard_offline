using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class AppJob
    {
        public int Id { get; set; }
        public string Queue { get; set; } = null!;
        public string Payload { get; set; } = null!;
        public int Attempts { get; set; }
        public int? ReservedAt { get; set; }
        public int AvailableAt { get; set; }
        public int CreatedAt { get; set; }
    }
}
