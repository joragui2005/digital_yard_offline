using TipMexico.DigitalYard.Application.DTO;
using TipMexico.DigitalYard.Transversal.Common;

namespace TipMexico.DigitalYard.Application.Interface
{
    public interface IInspectionProcessApplication
    {
        Task<Response<int>> InspectionProcessStartAsync(InspecctionProcessStartDTO payload);
    }
}
