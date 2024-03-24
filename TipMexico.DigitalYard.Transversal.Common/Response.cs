using System.Net;

namespace TipMexico.DigitalYard.Transversal.Common
{
    public class Response<T>
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string? ErrorCode { get; set; }
    }

    public class FailResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.BadRequest;
    }
}
