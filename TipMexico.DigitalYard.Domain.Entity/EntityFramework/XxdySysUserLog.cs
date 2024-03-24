using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysUserLog
    {
        public decimal LogId { get; set; }
        public decimal UserId { get; set; }
        public string? AppVersion { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
