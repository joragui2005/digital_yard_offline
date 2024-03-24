using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyCustomerContractsV
    {
        public decimal? ContractId { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractKnownas { get; set; }
        public decimal? CustomerId { get; set; }
        public string? CustomerNumber { get; set; }
        public string? CustomerName { get; set; }
    }
}
