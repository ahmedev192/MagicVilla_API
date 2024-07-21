using System.Net;

namespace MagicVilla_Web.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public APIResponse()
        {
            ErrorMessages = new List<string>();
            IsSuccess = true;
        }

        public APIResponse(HttpStatusCode statusCode, bool isSuccess, object result = null, List<string> errorMessages = null)
        {
            StatusCode = statusCode;
            IsSuccess = isSuccess;
            Result = result;
            ErrorMessages = errorMessages ?? new List<string>();
        }
    }
}
