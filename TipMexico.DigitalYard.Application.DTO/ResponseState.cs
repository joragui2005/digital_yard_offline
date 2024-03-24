using TipMexico.DigitalYard.Transversal.Common;

namespace TipMexico.DigitalYard.Application.DTO
{
    public static class ResponseState<T>
    {

        public static Response<T> NotFound(string Message)
        {
            return new Response<T>
            {
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

        public static Response<T> NotFound(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

        public static Response<T> InternalServerError(string Message)
        {
            return new Response<T>
            {
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }

        public static Response<T> InternalServerError(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }

        public static Response<T> BadRequest(string Message)
        {
            return new Response<T>
            {
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

        public static Response<T> BadRequest(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                Success = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

        public static Response<T> OK(string Message)
        {
            return new Response<T>
            {
                Success = true,
                Message = string.IsNullOrEmpty(Message) ? "Success" : Message,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

        public static Response<T> OK(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                Success = true,
                Message = string.IsNullOrEmpty(Message) ? "Success" : Message,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

        public static Response<T> OK(string Message, T inputData, int rowCount = 0)
        {
            return new Response<T>
            {
                Data = inputData,
                Success = true,
                Message = string.IsNullOrEmpty(Message) ? "Success" : Message,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }

        public static Response<T> NoContent(string Message)
        {
            return new Response<T>
            {
                Success = true,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NoContent
            };
        }
    }
}
