using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyAmVerification
    {
        public decimal VerifyId { get; set; }
        public string? AssetNumber { get; set; }
        public string? AssetType { get; set; }
        public decimal? BranchId { get; set; }
        public string? PlateNumber { get; set; }
        public string? Vin { get; set; }
        public string? ModelYear { get; set; }
        public string? PlateGroup { get; set; }
        public string? VerifyEntityOld { get; set; }
        public DateTime? VerifyDateOld { get; set; }
        public string? VerifyFolioOld { get; set; }
        public string? HaveDictamenOld { get; set; }
        public string? ClientNameOld { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string? VerifyEntityNew { get; set; }
        public DateTime? VerifyDateNew { get; set; }
        public string? VerifyFolioNew { get; set; }
        public string? HaveDictamenNew { get; set; }
        public string? ClientNameNew { get; set; }
        public string? Comments { get; set; }
        public string? AssetStatus { get; set; }
        public string? FolioTc { get; set; }
        public string? BrandName { get; set; }
        public string? TowingCapacity { get; set; }
        public string? AssetClass { get; set; }
        public string? DocumentPath { get; set; }
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
