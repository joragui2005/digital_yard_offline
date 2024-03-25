using System;
using System.Collections.Generic;

namespace TipMexico.DigitalYard.Domain.Entity.EntityFramework
{
    public partial class XxdyInsLine
    {
        public int LineId { get; set; }
        public int HeaderId { get; set; }
        public string ZoneType { get; set; } = null!;
        public string? FrePlacaDeVin { get; set; }
        public string? FreNumeroOcultos { get; set; }
        public string? FreKmAbs { get; set; }
        public string? FreComments { get; set; }
        public string? CiPortllantas { get; set; }
        public string? CiManivela { get; set; }
        public string? CiComments { get; set; }
        public string? TraPlacaCirculacion { get; set; }
        public string? TraPlaca { get; set; }
        public string? TraComments { get; set; }
        public string? IntObservacions { get; set; }
        public string? CdObservacions { get; set; }
        public string? InfEspiga { get; set; }
        public string? InfPatines { get; set; }
        public string? InfEje1 { get; set; }
        public string? InfEje2 { get; set; }
        public string? InfComments { get; set; }
        public string? TolObservacions { get; set; }
        public string? DocPlacaVin { get; set; }
        public string? DocTarjetaDeCirculacion { get; set; }
        public string? DocHologrameDeVerificacion { get; set; }
        public string? DocDictamenDeVerificacion { get; set; }
        public string? DocPedimientoDeImportacion { get; set; }
        public string? DanoDetailsJson { get; set; }
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
        public string? PiObservacions { get; set; }
        public string? DocLuces { get; set; }
        public string? DocMarco { get; set; }
        public string? DocLlantas { get; set; }
        public string? DocRines { get; set; }
        public string? DocSuspension { get; set; }
        public string? DocSistemaDeAire { get; set; }
        public string? DocConexiones { get; set; }
        public string? DocPatines { get; set; }
        public string? DocDefensa { get; set; }
        public string? DocVin { get; set; }
        public string? CiNumeroOcultos { get; set; }
        public string? TraNumeroOcultos { get; set; }
        public string? IntNumeroOcultos { get; set; }
        public string? PiNumeroOcultos { get; set; }
        public string? CdNumeroOcultos { get; set; }
        public string? InfNumeroOcultos { get; set; }
        public string? TolNumeroOcultos { get; set; }
        public string? LlantaDelCliente { get; set; }
        public string? LlantaSinCliente { get; set; }
        public string? InsEco { get; set; }
        public string? InsTipo { get; set; }
        public string? InsDot { get; set; }
        public string? InsMarca { get; set; }
        public string? InsModelo { get; set; }
        public string? InsMedidas { get; set; }
        public string? InsRenovados { get; set; }
        public string? InsCondicion { get; set; }
        public string? Val1321 { get; set; }
        public string? Val1322 { get; set; }
        public string? InsComments { get; set; }
        public string? TraRearType { get; set; }
        public string? TraPlacaDeVin { get; set; }
    }
}
