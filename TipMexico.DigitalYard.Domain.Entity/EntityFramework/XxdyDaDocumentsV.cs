using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaDocumentsV
    {
        public decimal DaDocumentId { get; set; }
        public string RequiredFlag { get; set; } = null!;
        public string OriginalDoc { get; set; } = null!;
        public string SourceTable { get; set; } = null!;
        public string SourceId { get; set; } = null!;
        public decimal? DocumentSetId { get; set; }
        public string? DocumentSetName { get; set; }
        public decimal DocumentId { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentDesc { get; set; }
        public string FileExtn { get; set; } = null!;
        public string? ApproverId { get; set; }
        public string? DispFlag { get; set; }
        public decimal? TotalFiles { get; set; }
        public string? DocStatus { get; set; }
    }
}
