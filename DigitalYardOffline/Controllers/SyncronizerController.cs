using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TipMexico.DigitalYard.Application.DTO;
using TipMexico.DigitalYard.Application.Interface;
using TipMexico.DigitalYard.Transversal.Common;

namespace TipMexico.DigitalYard.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyncronizerController : ControllerBase
    {
        private IInspectionProcessApplication InspectionProcessApplication;
        private IConfiguration Configuration { get; }

        public SyncronizerController(IInspectionProcessApplication inspectionProcessApplication, IConfiguration configuration)
        {
            InspectionProcessApplication = inspectionProcessApplication;
            Configuration = configuration;

        }

        [HttpPost, Route("InspectionProcessStart")]

        public async Task<ActionResult<Response<int>>> InspectionProcessStart(InspecctionProcessStartDTO payload)
        {
            var resp = await InspectionProcessApplication.InspectionProcessStartAsync(payload);

            return StatusCode((int)resp.StatusCode, resp);
        }
    }
}
