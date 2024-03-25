using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class CusdyDyWoDetailT
    {
        public int? CusdyDyWoLId { get; set; }
        public int? CusdyDyWoHId { get; set; }
        public string? CodigoActividad { get; set; }
        public string? Observaciones { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? DyappLineId { get; set; }
    }
}
