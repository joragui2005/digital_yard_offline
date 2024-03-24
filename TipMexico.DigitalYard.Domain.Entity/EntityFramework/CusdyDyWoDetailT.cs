using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class CusdyDyWoDetailT
    {
        public decimal? CusdyDyWoLId { get; set; }
        public decimal? CusdyDyWoHId { get; set; }
        public string? CodigoActividad { get; set; }
        public string? Observaciones { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? DyappLineId { get; set; }
    }
}
