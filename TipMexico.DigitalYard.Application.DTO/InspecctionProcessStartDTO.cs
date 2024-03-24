using System.ComponentModel.DataAnnotations;

namespace TipMexico.DigitalYard.Application.DTO
{
    public class InspecctionProcessStartDTO
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio"), Range(1, int.MaxValue)]
        public int HeaderId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio"), Range(1, int.MaxValue)]
        public int UserId { get; set; }
    }
}
