using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class CusdyCatUnidadTipo
    {
        public decimal UnidadTipoId { get; set; }
        public string? UnidadTipoCod { get; set; }
        public string? UnidadTipoDsc { get; set; }
        public decimal UnidadTipoOrgId { get; set; }
    }
}
