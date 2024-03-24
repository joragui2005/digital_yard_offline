using System.ComponentModel.DataAnnotations;

namespace TipMexico.DigitalYard.Domain.Entity
{
    public class InsHeaders
    {

        // TODO: Mappear las propiedades de la entidad InsHeaders
        public int HEADER_ID { get; set; }
        public int BRANCH_ID { get; set; }
        public string? INSPECTION_FOLIO { get; set; }
        public int ACTUAL_INSPECTOR { get; set; }
        [MaxLength(1)]
        public string? INSPECT_STATUS { get; set; } = "N";
        public DateTime INSPECTION_DATE { get; set; }
        public int LAST_UPDATED_BY { get; set; }
        public DateTime LAST_UPDATE_DATE { get; set; }
        public int CREATED_BY { get; set; }
        public DateTime CREATION_DATE { get; set; }

        // SERIAL_NUMBER, VIN, ENTRY_DATE, TERMINATION_DATE, INS_TYPE, TRX_TYPE, MOVEMENT_TYPE, , , CONTEXT_VALUE, CUSTOM_FIELD1, CUSTOM_FIELD2, CUSTOM_FIELD3, CUSTOM_FIELD4, CUSTOM_FIELD5, DE_HEADER_ID, DE_LINE_ID, , , , COMMENTS, OPERATION_TYPE, NUMERO_OCULTOS, HIDDEN_NUMBER, ITEM_CODE, ZONE_TYPE, REAR_TYPE, PLACA_DE_VIN, PLACA_DE_VIN_ZONE_TYPE, CUSTOMER_NAME, CONTRACT_NUMBER, PLATE_NUMBER
    }
}
