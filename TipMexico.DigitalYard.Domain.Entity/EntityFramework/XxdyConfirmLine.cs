using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyConfirmLine
    {
        public int DeLineId { get; set; }
        public string? ParentSerial { get; set; }
        public string? SerialNumber { get; set; }
        public string? ProcessFlag { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string? ApiStatus { get; set; }
        public string? ApiMensage { get; set; }
        public string? ApiErrorLoc { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
