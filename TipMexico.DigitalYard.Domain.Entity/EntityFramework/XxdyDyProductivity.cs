using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyProductivity
    {
        public decimal ProductivityId { get; set; }
        public decimal PeriodId { get; set; }
        public decimal WeekNumber { get; set; }
        public decimal PersonId { get; set; }
        public decimal TeamId { get; set; }
        public decimal BranchId { get; set; }
        public decimal TeamHeadId { get; set; }
        public string? WStartDate { get; set; }
        public string? WEndDate { get; set; }
        public decimal? WByPeriod { get; set; }
        public decimal? DLaborados { get; set; }
        public decimal? DNomina { get; set; }
        public decimal? TExtra { get; set; }
        public decimal? TIndirecto { get; set; }
        public decimal? TOdt { get; set; }
        public decimal? ODays { get; set; }
        public decimal? PdtyPercent { get; set; }
        public string? WeekStatus { get; set; }
        public string? ExtraComment { get; set; }
        public string? IndirectoComment { get; set; }
        public string? DaysComment { get; set; }
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
        public decimal? TIncapacidad { get; set; }
        public decimal? TAusencia { get; set; }
        public string? IncapacidadComment { get; set; }
        public string? AusenciaComment { get; set; }
        public decimal? TVacaciones { get; set; }
        public string? VacacionesComment { get; set; }
    }
}
