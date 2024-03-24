using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class CusdyDyWoHeaderT
    {
        public decimal? CusdyDyWoHId { get; set; }
        public string? WoType { get; set; }
        public string? NumUnidad { get; set; }
        public string? Patio { get; set; }
        public decimal? WipEntityId { get; set; }
        public string? Status { get; set; }
        public string? Detail { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? CreatedBy { get; set; }
        public decimal? LastUpdateLogin { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? DyappHeaderId { get; set; }
        public string? WoNumber { get; set; }
        public DateTime? OtDate { get; set; }
        public string? UnitGeneric { get; set; }
        public string? ItemTypeGeneric { get; set; }
    }
}
