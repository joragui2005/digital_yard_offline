using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDeBooking
    {
        public int BookingId { get; set; }
        public string? AssetNumber { get; set; }
        public int CheckInId { get; set; }
        public DateTime CheckInDate { get; set; }
        public int? PriorityId { get; set; }
        public int? InsHeaderId { get; set; }
        public int? IntHeaderId { get; set; }
        public int? OtsHeaderId { get; set; }
        public int? OttHeaderId { get; set; }
        public int? QasHeaderId { get; set; }
        public int? QatHeaderId { get; set; }
        public int? RtsHeaderId { get; set; }
        public int? RttHeaderId { get; set; }
        public int? ReserveId { get; set; }
        public int? DeliveryId { get; set; }
        public int? CheckOutId { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public string? BookStatus { get; set; }
        public DateTime? StatusDate { get; set; }
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
        public int? TCheckOutId { get; set; }
        public DateTime? TCheckOutDate { get; set; }
        public int? CurrentBranchId { get; set; }
    }
}
