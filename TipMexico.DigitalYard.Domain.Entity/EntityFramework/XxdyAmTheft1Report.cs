using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyAmTheft1Report
    {
        public decimal ReportId { get; set; }
        public string? Vin { get; set; }
        public string? ValidadorDelVin { get; set; }
        public string? Fabricante { get; set; }
        public string? Submarca { get; set; }
        public string? Clase { get; set; }
        public string? Modelo { get; set; }
        public string? EstatusOcra { get; set; }
        public string? LugarDeRoboOcra { get; set; }
        public DateTime? FechaDeActOcra { get; set; }
        public DateTime? FechaDeRoboOcra { get; set; }
        public DateTime? FechaDeAverOcra { get; set; }
        public string? LugarRecuOcra { get; set; }
        public DateTime? FechaRecuOcra { get; set; }
        public string? EstatusPgj { get; set; }
        public string? LugarDeRoboPgj { get; set; }
        public DateTime? FechaDeActPgj { get; set; }
        public DateTime? FechaDeRoboPgj { get; set; }
        public DateTime? FechaDeAverPgj { get; set; }
        public string? LugarRecuPgj { get; set; }
        public DateTime? FechaRecuPgj { get; set; }
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
