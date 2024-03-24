using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyDeliveredFlotum
    {
        public decimal LineId { get; set; }
        public string? LineStatus { get; set; }
        public string? EcoPadre { get; set; }
        public string? EcoSistema { get; set; }
        public string? Tipo { get; set; }
        public string? Yard { get; set; }
        public string? Puerta { get; set; }
        public string? Placa { get; set; }
        public string? Serie { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public string? EstatusPatio { get; set; }
        public string? Flota { get; set; }
        public string? VerificationDetail { get; set; }
        public string? Period { get; set; }
        public string? Quality { get; set; }
        public DateTime? ArriveDate { get; set; }
        public string? Customer { get; set; }
        public string? EstatusUnidadPatio { get; set; }
        public string? AssetStatus { get; set; }
        public string? AssetReturnStatus { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? DeliveryTo { get; set; }
        public DateTime? FechaVerificacion { get; set; }
        public DateTime? Calidad { get; set; }
        public string? Comentario { get; set; }
        public string? EcoAnterior { get; set; }
        public string? ContextValue { get; set; }
        public string? CustomField1 { get; set; }
        public string? CustomField2 { get; set; }
        public string? CustomField3 { get; set; }
        public string? CustomField4 { get; set; }
        public string? CustomField5 { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
