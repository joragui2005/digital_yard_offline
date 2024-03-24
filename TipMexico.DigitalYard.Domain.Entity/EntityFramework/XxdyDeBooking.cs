using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeBooking
    {
        public decimal BookingId { get; set; }
        public string? AssetNumber { get; set; }
        public decimal CheckInId { get; set; }
        public DateTime CheckInDate { get; set; }
        public decimal? PriorityId { get; set; }
        public decimal? InsHeaderId { get; set; }
        public decimal? IntHeaderId { get; set; }
        public decimal? OtsHeaderId { get; set; }
        public decimal? OttHeaderId { get; set; }
        public decimal? QasHeaderId { get; set; }
        public decimal? QatHeaderId { get; set; }
        public decimal? RtsHeaderId { get; set; }
        public decimal? RttHeaderId { get; set; }
        public decimal? ReserveId { get; set; }
        public decimal? DeliveryId { get; set; }
        public decimal? CheckOutId { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public string? BookStatus { get; set; }
        public DateTime? StatusDate { get; set; }
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
        public decimal? TCheckOutId { get; set; }
        public DateTime? TCheckOutDate { get; set; }
        public decimal? CurrentBranchId { get; set; }
    }
}
