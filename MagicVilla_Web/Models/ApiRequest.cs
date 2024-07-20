using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Models
{
    public class ApiRequest
    {
        public APIType ApiType { get; set; } = APIType.GET; 
        public string ApiUrl { get; set; }
        public object Data { get; set; }

        public ApiRequest(APIType apiType, string apiUrl, object? data = null)
        {
            ApiType = apiType;
            ApiUrl = apiUrl;
            Data = data;
        }

        public ApiRequest()
        {
                
        }
    }
}
