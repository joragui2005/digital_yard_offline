using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyDailyV
    {
        public string FolioE1 { get; set; } = null!;
        public decimal FolioE2 { get; set; }
        public decimal FolioE3 { get; set; }
        public string Patio { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaMovimentoE { get; set; }
        public string TipoOperacionE { get; set; } = null!;
        public string Economico { get; set; } = null!;
        public string? Vin { get; set; }
        public string Placa { get; set; } = null!;
        public string? TipoUnidad { get; set; }
        public string? TipoPuerta { get; set; }
        public string? ContratoE { get; set; }
        public string? EstatusContratoE { get; set; }
        public string? NumeroClienteE { get; set; }
        public string? ClienteE { get; set; }
        public string? Fabricante { get; set; }
        public string? Modelo { get; set; }
        public decimal? Prioridad { get; set; }
        public string? ComentarioPrioridad { get; set; }
        public string? EstatusActual { get; set; }
        public string? EstatusInspeccion { get; set; }
        public string? EstatusOt { get; set; }
        public string? EstatusCalidad { get; set; }
        public string? EstatusRt { get; set; }
        public string? FolioS1 { get; set; }
        public decimal? FolioS2 { get; set; }
        public decimal? FolioS3 { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string? TipoOperacionS { get; set; }
        public string? TipoPuertaS { get; set; }
        public string? ContratoS { get; set; }
        public string? EstatusContratoS { get; set; }
        public string? NumeroClienteS { get; set; }
        public string? ClienteS { get; set; }
    }
}
