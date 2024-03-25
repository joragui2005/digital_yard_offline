using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDyProductivity
    {
        public int ProductivityId { get; set; }
        public int PeriodId { get; set; }
        public int WeekNumber { get; set; }
        public int PersonId { get; set; }
        public int TeamId { get; set; }
        public int BranchId { get; set; }
        public int TeamHeadId { get; set; }
        public string? WStartDate { get; set; }
        public string? WEndDate { get; set; }
        public int? WByPeriod { get; set; }
        public int? DLaborados { get; set; }
        public int? DNomina { get; set; }
        public int? TExtra { get; set; }
        public int? TIndirecto { get; set; }
        public int? TOdt { get; set; }
        public int? ODays { get; set; }
        public int? PdtyPercent { get; set; }
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
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? TIncapacidad { get; set; }
        public int? TAusencia { get; set; }
        public string? IncapacidadComment { get; set; }
        public string? AusenciaComment { get; set; }
        public int? TVacaciones { get; set; }
        public string? VacacionesComment { get; set; }
    }
}
