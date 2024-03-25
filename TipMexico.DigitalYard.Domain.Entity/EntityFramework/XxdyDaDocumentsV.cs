using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyDaDocumentsV
    {
        public int DaDocumentId { get; set; }
        public string RequiredFlag { get; set; } = null!;
        public string OriginalDoc { get; set; } = null!;
        public string SourceTable { get; set; } = null!;
        public string SourceId { get; set; } = null!;
        public int? DocumentSetId { get; set; }
        public string? DocumentSetName { get; set; }
        public int DocumentId { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentDesc { get; set; }
        public string FileExtn { get; set; } = null!;
        public string? ApproverId { get; set; }
        public string? DispFlag { get; set; }
        public int? TotalFiles { get; set; }
        public string? DocStatus { get; set; }
    }
}
