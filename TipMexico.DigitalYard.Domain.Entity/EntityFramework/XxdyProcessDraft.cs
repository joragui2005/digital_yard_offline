using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyProcessDraft
    {
        public decimal InterfaceId { get; set; }
        public decimal? DeLineId { get; set; }
        public decimal? DeliveryId { get; set; }
        public decimal? ActivationId { get; set; }
        public string? SerialNumber { get; set; }
        public string? ContractNumber { get; set; }
        public string? ProcessFlag { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? ApiStatus { get; set; }
        public string? ApiMensage { get; set; }
        public string? ApiErrorLoc { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ProgramDate { get; set; }
    }
}
