using System.Net;

namespace MagicVilla_Web.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public ApiResponse()
        {
            ErrorMessages = new List<string>();
            IsSuccess = true;
        }

        public ApiResponse(HttpStatusCode statusCode, bool isSuccess, object result = null, List<string> errorMessages = null)
        {
            StatusCode = statusCode;
            IsSuccess = isSuccess;
            Result = result;
            ErrorMessages = errorMessages ?? new List<string>();
        }
    }
}
