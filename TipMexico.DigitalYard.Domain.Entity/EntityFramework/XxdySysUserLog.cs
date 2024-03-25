using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdySysUserLog
    {
        public int LogId { get; set; }
        public int UserId { get; set; }
        public string? AppVersion { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
