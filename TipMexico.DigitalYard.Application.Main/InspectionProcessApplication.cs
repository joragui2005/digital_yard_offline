using Microsoft.Extensions.Configuration;
using TipMexico.DigitalYard.Application.DTO;
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Domain.Entity;
using TipMexico.DigitalYard.Infrastructure.Interface;
using TipMexico.DigitalYard.Transversal.Common;

namespace TipMexico.DigitalYard.Application.Main
{
    public class InspectionProcessApplication : IInspectionProcessApplication
    {
        public IConfiguration Configuration { get; }
        private readonly IInspectionProcessRepository InspectionProcessRepository;

        public InspectionProcessApplication(IConfiguration configuration, IInspectionProcessRepository inspectionProcessRepository)
        {
            Configuration = configuration;
            InspectionProcessRepository = inspectionProcessRepository;
        }

        public async Task<Response<int>> InspectionProcessStartAsync(InspecctionProcessStartDTO payload)
        {
            try
            {
                var id = await InspectionProcessRepository.InspectionProcessStartAsync(payload.HeaderId, payload.UserId);
                if (id > 0)
                {
                    return ResponseState<int>.OK("Success", id);
                }

                return ResponseState<int>.NotFound("Not found", payload.HeaderId);
            }
            catch (Exception ex)
            {
                return ResponseState<int>.InternalServerError($"Error: {ex.Message} ", payload.HeaderId);
            }
        }
    }
}
